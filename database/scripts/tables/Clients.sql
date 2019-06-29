USE [practice_cosmetics_shop]
GO

CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Surname] [varchar](25) NOT NULL,
	[Phone] [varchar](10) NULL,
	[E-mail] [varchar](25) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Clients] ADD  CONSTRAINT [DF_Clients_Phone]  DEFAULT ('-') FOR [Phone]
GO

ALTER TABLE [dbo].[Clients] ADD  CONSTRAINT [DF_Clients_E-mail]  DEFAULT ('-') FOR [E-mail]
GO


