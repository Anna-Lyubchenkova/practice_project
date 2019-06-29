USE [practice_cosmetics_shop]
GO

CREATE TABLE [dbo].[Staff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](25) NOT NULL,
	[Surname] [varchar](20) NOT NULL,
	[Age] [int] NOT NULL,
	[Position] [int] NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Post] FOREIGN KEY([Position])
REFERENCES [dbo].[Post] ([PostId])
GO

ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Post]
GO


