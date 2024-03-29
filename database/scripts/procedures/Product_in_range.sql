USE [practice_cosmetics_shop]
GO

CREATE Procedure [dbo].[Product_in_Range] (@a_range as int, @b_range as int)
	AS
		/*запрос о выдаче списка товаров, лежащих в диапазоне цен, можно добавить товары 
		только по акции через параметр. Входное данное - границы диапазона.*/
	Select Item_Name, Cost , Num_inShop as 'Available'
		FROM Items 
				Where CONVERT(int,Cost) Between @a_range And @b_range
					Order By Cost,Item_Name;