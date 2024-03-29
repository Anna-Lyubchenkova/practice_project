USE [practice_cosmetics_shop]
GO

CREATE Procedure [dbo].[Seller_upd_order] (@order_num as int)
	AS
		UPDATE ClientOrder SET Status = 'Wait'
			Where ClientOrder.OrderID = @order_num
		UPDATE Ordered_Items SET Reserved = Reserved + Amount
			Where Amount > Num_inShop AND Status = 'New' AND OrderID = @order_num
		UPDATE Ordered_Items SET Status = 'Wait'
			Where Amount > Num_inShop AND Status IN ('New','Wait') AND OrderID = @order_num
		UPDATE Ordered_Items Set Status = 'PreR'
			Where Amount <= Num_inShop AND Status IN ('New','Wait') AND OrderID = @order_num
		UPDATE Ordered_Items SET Num_inShop = Num_inShop - Amount
			Where Status = 'PreR' AND OrderID = @order_num
		UPDATE Ordered_Items SET Status = 'Ready'
			Where Status = 'PreR' AND OrderID = @order_num