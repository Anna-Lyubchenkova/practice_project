USE [practice_cosmetics_shop]
GO

CREATE Procedure [dbo].[Reserved_Items] 
	As
		/*Запрос на вывод товаров, которые в данный момент в резерве*/
		Select Item_Name, Items.Reserved FROM Items
			Where Reserved > 0;

