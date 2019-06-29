USE [practice_cosmetics_shop]
GO

CREATE TABLE [dbo].[Post](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[Post] [nchar](15) NOT NULL,
	[Salary] [money] NULL,
	[Nalog] [int] NULL,
	[Clean Salary]  AS ([Salary]-([Salary]*[Nalog])/(100)),
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


