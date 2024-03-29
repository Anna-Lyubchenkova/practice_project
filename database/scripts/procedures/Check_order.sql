USE [practice_cosmetics_shop]
GO

CREATE Procedure [dbo].[Check_Order] (@orderid as int, @sort as varchar(10))
	AS
		/*Запрос на вывод товаров в заказе по номеру заказа. Входное данное - номер заказа*/
		if (@sort = 'Item_Name')
		Select Item_Name, Amount, 
			Items.Cost * Amount as 'Summa', ItemListToOrder.Status
				FROM ClientOrder Join ItemListToOrder on ClientOrder.OrderID = ItemListToOrder.OrderID 
				JOIN Items ON Items.Article = ItemListToOrder.ItemID
						Where ClientOrder.OrderID = @orderid
						Order By Item_Name;
		if (@sort = 'Summa')
			Select Item_Name, Amount, 
			Items.Cost * Amount as 'Summa', ItemListToOrder.Status
				FROM ClientOrder Join ItemListToOrder on ClientOrder.OrderID = ItemListToOrder.OrderID 
				JOIN Items ON Items.Article = ItemListToOrder.ItemID
						Where ClientOrder.OrderID = @orderid
						Order By 'Summa';
		if (@sort = 'Status')
			Select Item_Name, Amount, 
			Items.Cost * Amount as 'Summa', ItemListToOrder.Status
				FROM ClientOrder Join ItemListToOrder on ClientOrder.OrderID = ItemListToOrder.OrderID 
				JOIN Items ON Items.Article = ItemListToOrder.ItemID 
						Where ClientOrder.OrderID = @orderid
						Order By ItemListToOrder.Status;