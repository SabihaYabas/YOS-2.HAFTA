USE [YurtKayit]
GO

/****** Object:  Table [dbo].[Giderler]    Script Date: 24.03.2021 11:42:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Giderler](
	[Odemeid] [smallint] IDENTITY(1,1) NOT NULL,
	[Elektrik] [int] NULL,
	[Su] [int] NULL,
	[Doğalgaz] [int] NULL,
	[internet] [int] NULL,
	[Gıda] [int] NULL,
	[Personel] [int] NULL,
	[Diğer] [int] NULL
) ON [PRIMARY]
GO

