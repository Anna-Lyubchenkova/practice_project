USE [practice_cosmetics_shop]
GO

CREATE VIEW [dbo].[Active_clients]
AS
SELECT        dbo.Clients.Name, dbo.Clients.Surname, COUNT(dbo.ClientOrder.OrderID) AS 'Orders'
FROM            dbo.Clients INNER JOIN
                         dbo.ClientOrder ON dbo.Clients.ClientID = dbo.ClientOrder.Client
GROUP BY dbo.Clients.Name, dbo.Clients.Surname
GO
