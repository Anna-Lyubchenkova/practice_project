USE [practice_cosmetics_shop]
GO

CREATE Procedure [dbo].[Product_Info] (@product_n as int)
	As
		/*запрос на получение информации по товару от продавца. наименование - входное данное*/
		Select Item_Name, Cost as 'cost, RUB', Num_inShop, Reserved 
			FROM Items
				Where Article=@product_n;