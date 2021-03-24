USE [YurtKayit]
GO

/****** Object:  Table [dbo].[Personeller]    Script Date: 24.03.2021 11:43:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Personeller](
	[Personelid] [tinyint] IDENTITY(1,1) NOT NULL,
	[PersonelAdSoyad] [varchar](50) NULL,
	[PersonelDepartman] [varchar](30) NULL
) ON [PRIMARY]
GO

