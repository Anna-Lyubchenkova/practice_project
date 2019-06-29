USE [practice_cosmetics_shop]
GO

Create View [dbo].[Clients_Orders_all]
	As
		Select OrderID, ClientID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
				JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
					Where ClientOrder.Status = ANY (Select Status FROM ClientOrder);

GO


