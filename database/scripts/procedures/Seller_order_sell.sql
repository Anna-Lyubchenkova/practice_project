USE [practice_cosmetics_shop]
GO

CREATE Procedure [dbo].[Seller_sold_order] (@order_num as int)
	AS
		UPDATE Ordered_Items SET Status = 'Sold'
			Where Ordered_Items.OrderID = @order_num
		UPDATE ClientOrder SET Status = 'Sold'
			Where ClientOrder.OrderID = @order_num