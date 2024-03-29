USE [practice_cosmetics_shop]
GO

CREATE Procedure [dbo].[View_Orders] (@client as int, @mode as int = 0)
	As
		/*Запрос на вывод заказов по данному клиенту,комбинации по фильтру в кач. переменной
			Входное данное - номер клиента*/
	If (@mode = 0) /*вывести все заказы*/
		Select OrderID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
				JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
					Where Client = @client AND ClientOrder.Status = ANY (Select Status FROM ClientOrder);
	IF (@mode = 1) /*только созданные заказы*/
		Select OrderID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
			JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
				Where Client = @client AND ClientOrder.Status = 'New'
	IF (@mode = 2) /*только заказы в резерве.При том полностью reserved и частично reserved заказы - WAIT*/
		Select OrderID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder,Clients, Staff
				Where Clients.ClientID = ClientOrder.Client AND
					ClientOrder.SellerID = Staff.StaffID AND Client = @client AND
					ClientOrder.Status = 'Wait'
	IF (@mode = 4) /*только завершенные заказы*/
		Select OrderID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder,Clients, Staff
				Where Clients.ClientID = ClientOrder.Client AND
					ClientOrder.SellerID = Staff.StaffID AND Client = @client AND
					ClientOrder.Status = 'Sold'
	IF (@mode = 3) /*резерв и только созданные заказы */ 
		Select OrderID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
			JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
				Where Client = @client
		EXCEPT 
		Select OrderID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder,Clients, Staff
				Where Clients.ClientID = ClientOrder.Client AND
				ClientOrder.SellerID = Staff.StaffID AND
				ClientOrder.Status IN ('Sold');

