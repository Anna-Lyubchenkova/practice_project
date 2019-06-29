USE [practice_cosmetics_shop]
GO

CREATE TABLE [dbo].[ClientOrder](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[Client] [int] NOT NULL,
	[Order Date] [date] NOT NULL,
	[SellerID] [int] NOT NULL,
	[Status] [varchar](5) NULL,
 CONSTRAINT [PK_ClientOrder] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ClientOrder] ADD  CONSTRAINT [DF_ClientOrder_Status]  DEFAULT (N'New') FOR [Status]
GO

ALTER TABLE [dbo].[ClientOrder]  WITH CHECK ADD  CONSTRAINT [FK_ClientOrder_Clients] FOREIGN KEY([Client])
REFERENCES [dbo].[Clients] ([ClientID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClientOrder] CHECK CONSTRAINT [FK_ClientOrder_Clients]
GO

ALTER TABLE [dbo].[ClientOrder]  WITH CHECK ADD  CONSTRAINT [FK_ClientOrder_Staff] FOREIGN KEY([SellerID])
REFERENCES [dbo].[Staff] ([StaffID])
GO

ALTER TABLE [dbo].[ClientOrder] CHECK CONSTRAINT [FK_ClientOrder_Staff]
GO


