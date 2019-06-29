USE [practice_cosmetics_shop]
GO

CREATE VIEW [dbo].[Product_List]
AS
SELECT        Article, Item_Name, Cost AS [cost, RUB], Num_inShop
FROM            dbo.Items
GO



