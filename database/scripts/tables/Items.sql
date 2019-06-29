USE [practice_cosmetics_shop]
GO

CREATE TABLE [dbo].[Items](
	[Article] [int] IDENTITY(1,1) NOT NULL,
	[Item_Name] [nchar](20) NOT NULL,
	[Cost] [money] NOT NULL,
	[Num_inShop] [int] NOT NULL,
	[Reserved] [int] NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Article] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Items] ADD  CONSTRAINT [DF_Items_Num_inShop]  DEFAULT ((0)) FOR [Num_inShop]
GO

ALTER TABLE [dbo].[Items] ADD  CONSTRAINT [DF_Items_Reserved]  DEFAULT ((0)) FOR [Reserved]
GO

ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [inShop] CHECK  (([Num_inShop]>=(0)))
GO

ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [inShop]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Не может быть <0 в магазине' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'CONSTRAINT',@level2name=N'inShop'
GO


