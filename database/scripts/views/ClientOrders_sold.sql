USE [practice_cosmetics_shop]
GO

Create View [dbo].[Clients_Orders_sold]
	As
		Select OrderID, ClientID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
				JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
					Where ClientOrder.Status = 'Sold';
GO


