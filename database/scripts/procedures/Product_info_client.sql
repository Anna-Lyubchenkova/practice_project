USE [practice_cosmetics_shop]
GO

CREATE Procedure [dbo].[Product_Info_Client] (@product_n as nchar(20))
	As
		/*запрос на информацию о товаре от покупателя. Входное данное - наименование*/
	Select Item_Name, Cost as 'cost, RUB',Num_inShop 
		FROM Items 
			Where Item_name=@product_n;

