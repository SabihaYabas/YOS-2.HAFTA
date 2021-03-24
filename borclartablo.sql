USE [YurtKayit]
GO

/****** Object:  Table [dbo].[Borclar]    Script Date: 24.03.2021 11:42:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Borclar](
	[Ogrid] [int] NULL,
	[OgrAd] [varchar](20) NULL,
	[OgrSoyad] [varchar](20) NULL,
	[OgrKalanBorc] [smallint] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Borclar] ADD  CONSTRAINT [DF_Borclar_OgrKalanBorc]  DEFAULT ((3000)) FOR [OgrKalanBorc]
GO

