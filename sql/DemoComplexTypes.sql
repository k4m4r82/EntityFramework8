USE [DemoComplexTypes]
GO
/****** Object:  Table [dbo].[Siswa]    Script Date: 06/08/2014 10:31:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Siswa](
	[Nis] [varchar](10) NOT NULL,
	[Nama] [varchar](30) NULL,
	[Jalan] [varchar](100) NULL,
	[Kota] [varchar](50) NULL,
	[Provinsi] [varchar](50) NULL,
	[KodePos] [varchar](5) NULL,
 CONSTRAINT [PK_Siswa] PRIMARY KEY CLUSTERED 
(
	[Nis] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pegawai]    Script Date: 06/08/2014 10:31:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pegawai](
	[Nik] [varchar](20) NOT NULL,
	[Nama] [varchar](30) NULL,
	[Jalan] [varchar](100) NULL,
	[Kota] [varchar](50) NULL,
	[Provinsi] [varchar](50) NULL,
	[KodePos] [varchar](5) NULL,
 CONSTRAINT [PK_Pegawai] PRIMARY KEY CLUSTERED 
(
	[Nik] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Guru]    Script Date: 06/08/2014 10:31:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Guru](
	[Nik] [varchar](20) NOT NULL,
	[Nama] [varchar](30) NULL,
	[JumlahJamMengajar] [int] NULL,
	[Jalan] [varchar](100) NULL,
	[Kota] [varchar](50) NULL,
	[Provinsi] [varchar](50) NULL,
	[KodePos] [varchar](5) NULL,
 CONSTRAINT [PK_Guru] PRIMARY KEY CLUSTERED 
(
	[Nik] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
