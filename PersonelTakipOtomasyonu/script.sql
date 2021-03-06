USE [master]
GO
/****** Object:  Database [Monster]    Script Date: 8.2.2022 16:15:51 ******/
CREATE DATABASE [Monster]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Monster', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Monster.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Monster_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Monster_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Monster] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Monster].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Monster] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Monster] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Monster] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Monster] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Monster] SET ARITHABORT OFF 
GO
ALTER DATABASE [Monster] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Monster] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Monster] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Monster] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Monster] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Monster] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Monster] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Monster] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Monster] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Monster] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Monster] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Monster] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Monster] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Monster] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Monster] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Monster] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Monster] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Monster] SET RECOVERY FULL 
GO
ALTER DATABASE [Monster] SET  MULTI_USER 
GO
ALTER DATABASE [Monster] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Monster] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Monster] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Monster] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Monster] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Monster] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Monster', N'ON'
GO
ALTER DATABASE [Monster] SET QUERY_STORE = OFF
GO
USE [Monster]
GO
/****** Object:  Table [dbo].[Departmanlar]    Script Date: 8.2.2022 16:15:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departmanlar](
	[DepartmanID] [int] IDENTITY(1,1) NOT NULL,
	[Departman] [varchar](100) NOT NULL,
	[Aciklama] [varchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 8.2.2022 16:15:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](150) NOT NULL,
	[Sifre] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 8.2.2022 16:15:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](100) NOT NULL,
	[Soyadi] [varchar](100) NOT NULL,
	[Telefon] [varchar](50) NOT NULL,
	[Adres] [varchar](500) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[DepartmanID] [int] NOT NULL,
	[Durumu] [varchar](50) NULL,
	[Maasi] [decimal](18, 2) NOT NULL,
	[GirisTarihi] [date] NOT NULL,
	[CikisTarihi] [date] NULL,
	[Aciklama] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Primler]    Script Date: 8.2.2022 16:15:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Primler](
	[PrimID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[PersonelID] [int] NOT NULL,
	[Donem] [varchar](50) NOT NULL,
	[PrimTutari] [decimal](18, 2) NOT NULL,
	[OdenmeDurumu] [varchar](50) NULL,
	[Aciklama] [varchar](100) NULL,
	[Tarih] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[PrimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YapilanZamlar]    Script Date: 8.2.2022 16:15:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YapilanZamlar](
	[ZamID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[Donem] [varchar](50) NOT NULL,
	[Personeller] [varchar](750) NOT NULL,
	[Yuzde] [decimal](18, 2) NULL,
	[Fiyat] [decimal](18, 2) NULL,
	[Aciklama] [varchar](500) NULL,
	[Tarih] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ZamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Departmanlar] ON 

INSERT [dbo].[Departmanlar] ([DepartmanID], [Departman], [Aciklama]) VALUES (10, N'Yönetim', N'Yönetim ekibi')
INSERT [dbo].[Departmanlar] ([DepartmanID], [Departman], [Aciklama]) VALUES (11, N'İnsan Kaynakları', N'İnsan kaynakları ekibi')
INSERT [dbo].[Departmanlar] ([DepartmanID], [Departman], [Aciklama]) VALUES (12, N'Satış Temsilciliği', N'Satış sorumluları')
SET IDENTITY_INSERT [dbo].[Departmanlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanicilar] ON 

INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciAdi], [Sifre]) VALUES (1, N'admin', N'123')
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciAdi], [Sifre]) VALUES (2, N'muhasebeci', N'123')
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciAdi], [Sifre]) VALUES (3, N'personel', N'123')
SET IDENTITY_INSERT [dbo].[Kullanicilar] OFF
GO
SET IDENTITY_INSERT [dbo].[Personeller] ON 

INSERT [dbo].[Personeller] ([PersonelID], [Adi], [Soyadi], [Telefon], [Adres], [Email], [DepartmanID], [Durumu], [Maasi], [GirisTarihi], [CikisTarihi], [Aciklama]) VALUES (1, N'Ali', N'Sönmez', N'123123123', N'İzmir', N'alisonmez@gmail.com', 10, N'Aktif', CAST(30500.00 AS Decimal(18, 2)), CAST(N'2022-02-07' AS Date), NULL, N'Sonradan açıklama yapılacak.')
INSERT [dbo].[Personeller] ([PersonelID], [Adi], [Soyadi], [Telefon], [Adres], [Email], [DepartmanID], [Durumu], [Maasi], [GirisTarihi], [CikisTarihi], [Aciklama]) VALUES (2, N'Ayşe', N'Gül', N'1231232131', N'İzmir', N'aysegul@gmail.com', 11, N'Aktif', CAST(22000.00 AS Decimal(18, 2)), CAST(N'2022-02-07' AS Date), NULL, N'Sonra yaparım')
INSERT [dbo].[Personeller] ([PersonelID], [Adi], [Soyadi], [Telefon], [Adres], [Email], [DepartmanID], [Durumu], [Maasi], [GirisTarihi], [CikisTarihi], [Aciklama]) VALUES (4, N'Batuhan', N'Yörük', N'23413431231', N'İzmir', N'batuhanyoruk@gmail.com', 10, N'Aktif', CAST(44550.00 AS Decimal(18, 2)), CAST(N'2022-02-07' AS Date), NULL, N'Ceo')
INSERT [dbo].[Personeller] ([PersonelID], [Adi], [Soyadi], [Telefon], [Adres], [Email], [DepartmanID], [Durumu], [Maasi], [GirisTarihi], [CikisTarihi], [Aciklama]) VALUES (5, N'Yunus', N'Kara', N'3452342123', N'İstanbul', N'ykara@gmail.com', 12, N'Aktif', CAST(10500.00 AS Decimal(18, 2)), CAST(N'2022-02-07' AS Date), NULL, N'Satış sorumlusu.')
INSERT [dbo].[Personeller] ([PersonelID], [Adi], [Soyadi], [Telefon], [Adres], [Email], [DepartmanID], [Durumu], [Maasi], [GirisTarihi], [CikisTarihi], [Aciklama]) VALUES (7, N'Atatata', N'tatata', N'1231312', N'ayaya', N'aafa@gmail.com', 12, N'Aktif', CAST(5000.00 AS Decimal(18, 2)), CAST(N'2022-02-08' AS Date), NULL, N'123123')
SET IDENTITY_INSERT [dbo].[Personeller] OFF
GO
SET IDENTITY_INSERT [dbo].[Primler] ON 

INSERT [dbo].[Primler] ([PrimID], [KullaniciID], [PersonelID], [Donem], [PrimTutari], [OdenmeDurumu], [Aciklama], [Tarih]) VALUES (1, 1, 4, N'2/2022', CAST(150.00 AS Decimal(18, 2)), N'Ödendi', N'Batuhana 150tl Prim verildi.', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[Primler] ([PrimID], [KullaniciID], [PersonelID], [Donem], [PrimTutari], [OdenmeDurumu], [Aciklama], [Tarih]) VALUES (2, 2, 1, N'1/2022', CAST(200.00 AS Decimal(18, 2)), N'Ödendi', N'Tüm Personellere Yıl başı için 200tl Prim verildi.', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[Primler] ([PrimID], [KullaniciID], [PersonelID], [Donem], [PrimTutari], [OdenmeDurumu], [Aciklama], [Tarih]) VALUES (3, 2, 2, N'9/2019', CAST(200.00 AS Decimal(18, 2)), N'Ödendi', N'Tüm Personellere Yıl başı için 200tl Prim verildi.', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[Primler] ([PrimID], [KullaniciID], [PersonelID], [Donem], [PrimTutari], [OdenmeDurumu], [Aciklama], [Tarih]) VALUES (4, 2, 4, N'1/2022', CAST(200.00 AS Decimal(18, 2)), N'Ödendi', N'Tüm Personellere Yıl başı için 200tl Prim verildi.', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[Primler] ([PrimID], [KullaniciID], [PersonelID], [Donem], [PrimTutari], [OdenmeDurumu], [Aciklama], [Tarih]) VALUES (5, 2, 5, N'1/2022', CAST(200.00 AS Decimal(18, 2)), N'Ödendi', N'Tüm Personellere Yıl başı için 200tl Prim verildi.', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[Primler] ([PrimID], [KullaniciID], [PersonelID], [Donem], [PrimTutari], [OdenmeDurumu], [Aciklama], [Tarih]) VALUES (6, 1, 1, N'2/2020', CAST(300.00 AS Decimal(18, 2)), N'Ödendi', N'Ali için 400 tl prim borcu.', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[Primler] ([PrimID], [KullaniciID], [PersonelID], [Donem], [PrimTutari], [OdenmeDurumu], [Aciklama], [Tarih]) VALUES (7, 1, 1, N'1/2022', CAST(0.00 AS Decimal(18, 2)), N'Ödendi', N'Proje kontrolünde prim verildi.', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[Primler] ([PrimID], [KullaniciID], [PersonelID], [Donem], [PrimTutari], [OdenmeDurumu], [Aciklama], [Tarih]) VALUES (8, 1, 5, N'1/2021', CAST(0.00 AS Decimal(18, 2)), N'Ödendi', N'Proje denemesinde yapıldı.', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[Primler] ([PrimID], [KullaniciID], [PersonelID], [Donem], [PrimTutari], [OdenmeDurumu], [Aciklama], [Tarih]) VALUES (9, 1, 1, N'3/2021', CAST(222.00 AS Decimal(18, 2)), N'Ödendi', N'AAA', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[Primler] ([PrimID], [KullaniciID], [PersonelID], [Donem], [PrimTutari], [OdenmeDurumu], [Aciklama], [Tarih]) VALUES (10, 1, 4, N'3/2017', CAST(250.00 AS Decimal(18, 2)), N'Ödendi', N'250TL prim verildi.', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[Primler] ([PrimID], [KullaniciID], [PersonelID], [Donem], [PrimTutari], [OdenmeDurumu], [Aciklama], [Tarih]) VALUES (11, 1, 2, N'1/2021', CAST(1500.00 AS Decimal(18, 2)), N'Ödenmedi', N'Rapor için Prim Güncellendi.', CAST(N'2022-02-08' AS Date))
SET IDENTITY_INSERT [dbo].[Primler] OFF
GO
SET IDENTITY_INSERT [dbo].[YapilanZamlar] ON 

INSERT [dbo].[YapilanZamlar] ([ZamID], [KullaniciID], [Donem], [Personeller], [Yuzde], [Fiyat], [Aciklama], [Tarih]) VALUES (6, 1, N'3/2021', N'Tüm Personeller', CAST(10.00 AS Decimal(18, 2)), NULL, N'Herse 10 zam', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[YapilanZamlar] ([ZamID], [KullaniciID], [Donem], [Personeller], [Yuzde], [Fiyat], [Aciklama], [Tarih]) VALUES (7, 1, N'5/2022', N'Tüm Personeller', NULL, CAST(500.00 AS Decimal(18, 2)), N'aaa', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[YapilanZamlar] ([ZamID], [KullaniciID], [Donem], [Personeller], [Yuzde], [Fiyat], [Aciklama], [Tarih]) VALUES (8, 1, N'5/2022', N'2.Ayşe Gül', NULL, CAST(200.00 AS Decimal(18, 2)), N'aaa', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[YapilanZamlar] ([ZamID], [KullaniciID], [Donem], [Personeller], [Yuzde], [Fiyat], [Aciklama], [Tarih]) VALUES (9, 2, N'1/22', N'4.Batuhan Yörük', CAST(10.00 AS Decimal(18, 2)), NULL, N'aaaa', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[YapilanZamlar] ([ZamID], [KullaniciID], [Donem], [Personeller], [Yuzde], [Fiyat], [Aciklama], [Tarih]) VALUES (10, 1, N'1/2022', N'2.Ayşe Gül', CAST(10.00 AS Decimal(18, 2)), NULL, N'yüzde 10 zam ayşegüle.', CAST(N'2022-02-08' AS Date))
SET IDENTITY_INSERT [dbo].[YapilanZamlar] OFF
GO
ALTER TABLE [dbo].[Personeller] ADD  DEFAULT ('Aktif') FOR [Durumu]
GO
ALTER TABLE [dbo].[Primler] ADD  DEFAULT ('Ödenmedi') FOR [OdenmeDurumu]
GO
USE [master]
GO
ALTER DATABASE [Monster] SET  READ_WRITE 
GO
