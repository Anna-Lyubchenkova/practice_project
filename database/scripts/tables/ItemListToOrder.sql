USE [practice_cosmetics_shop]
GO

CREATE TABLE [dbo].[ItemListToOrder](
	[ItemID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
	[Status] [varchar](5) NULL,
 CONSTRAINT [PK_ItemListToOrder] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ItemListToOrder] ADD  CONSTRAINT [DF_ItemListToOrder_Status]  DEFAULT (N'New') FOR [Status]
GO

ALTER TABLE [dbo].[ItemListToOrder]  WITH CHECK ADD  CONSTRAINT [FK_ItemListToOrder_ClientOrder] FOREIGN KEY([OrderID])
REFERENCES [dbo].[ClientOrder] ([OrderID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ItemListToOrder] CHECK CONSTRAINT [FK_ItemListToOrder_ClientOrder]
GO

ALTER TABLE [dbo].[ItemListToOrder]  WITH CHECK ADD  CONSTRAINT [FK_ItemListToOrder_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([Article])
GO

ALTER TABLE [dbo].[ItemListToOrder] CHECK CONSTRAINT [FK_ItemListToOrder_Items]
GO


