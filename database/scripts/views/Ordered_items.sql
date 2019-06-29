USE [practice_cosmetics_shop]
GO

Create View [dbo].[Ordered_Items]
	As
		Select OrderID, ItemID, Amount, Num_inShop, Reserved, ItemListToOrder.Status
			From Items JOIN ItemListToOrder ON Items.Article = ItemListToOrder.ItemID
GO


