USE [master]
GO
/****** Object:  Database [drusus]    Script Date: 11/14/2020 11:05:39 AM ******/
CREATE DATABASE [drusus]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'drusus', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\drusus.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'drusus_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\drusus_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [drusus] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [drusus].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [drusus] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [drusus] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [drusus] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [drusus] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [drusus] SET ARITHABORT OFF 
GO
ALTER DATABASE [drusus] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [drusus] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [drusus] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [drusus] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [drusus] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [drusus] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [drusus] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [drusus] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [drusus] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [drusus] SET  DISABLE_BROKER 
GO
ALTER DATABASE [drusus] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [drusus] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [drusus] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [drusus] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [drusus] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [drusus] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [drusus] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [drusus] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [drusus] SET  MULTI_USER 
GO
ALTER DATABASE [drusus] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [drusus] SET DB_CHAINING OFF 
GO
ALTER DATABASE [drusus] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [drusus] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [drusus] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [drusus] SET QUERY_STORE = OFF
GO
USE [drusus]
GO
/****** Object:  User [NT AUTHORITY\SYSTEM]    Script Date: 11/14/2020 11:05:39 AM ******/
CREATE USER [NT AUTHORITY\SYSTEM] FOR LOGIN [NT AUTHORITY\SYSTEM] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [DESKTOP-QD4VSHE\andre]    Script Date: 11/14/2020 11:05:39 AM ******/
CREATE USER [DESKTOP-QD4VSHE\andre] FOR LOGIN [DESKTOP-QD4VSHE\andre] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [NT AUTHORITY\SYSTEM]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 11/14/2020 11:05:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[cuil] [int] NULL,
	[direccion] [varchar](max) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cobro]    Script Date: 11/14/2020 11:05:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cobro](
	[idCliente] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[descripcion] [varchar](50) NULL,
	[monto] [int] NULL,
	[idCobro] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Cobro_1] PRIMARY KEY CLUSTERED 
(
	[idCobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gasto]    Script Date: 11/14/2020 11:05:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gasto](
	[fecha] [datetime] NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [int] NULL,
	[idGasto] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Gasto] PRIMARY KEY CLUSTERED 
(
	[idGasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 11/14/2020 11:05:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[idCliente] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[descripcion] [varchar](50) NULL,
	[monto] [int] NULL,
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([idCliente], [nombre], [apellido], [cuil], [direccion]) VALUES (1, N'juancito', N'perez', 12345678, N'calle falsa 123|')
INSERT [dbo].[Cliente] ([idCliente], [nombre], [apellido], [cuil], [direccion]) VALUES (2, N'martita|', N'gomez', 876543, N'calle 4523')
INSERT [dbo].[Cliente] ([idCliente], [nombre], [apellido], [cuil], [direccion]) VALUES (3, N'pepito', N'juarz', 765432, N'pje jujulito 233')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Cobro] ON 

INSERT [dbo].[Cobro] ([idCliente], [fecha], [descripcion], [monto], [idCobro]) VALUES (1, CAST(N'2000-11-11T00:00:00.000' AS DateTime), N'eee', 600, 1)
INSERT [dbo].[Cobro] ([idCliente], [fecha], [descripcion], [monto], [idCobro]) VALUES (2, CAST(N'2020-07-25T12:40:40.610' AS DateTime), N'iiiii', 500, 6)
INSERT [dbo].[Cobro] ([idCliente], [fecha], [descripcion], [monto], [idCobro]) VALUES (1, CAST(N'2020-07-25T12:41:14.120' AS DateTime), N'ffff', 600, 7)
INSERT [dbo].[Cobro] ([idCliente], [fecha], [descripcion], [monto], [idCobro]) VALUES (3, CAST(N'2020-07-25T12:43:01.163' AS DateTime), N'uu', 888, 9)
INSERT [dbo].[Cobro] ([idCliente], [fecha], [descripcion], [monto], [idCobro]) VALUES (1, CAST(N'2020-08-25T12:43:01.163' AS DateTime), N'fff', 200, 1008)
INSERT [dbo].[Cobro] ([idCliente], [fecha], [descripcion], [monto], [idCobro]) VALUES (1, CAST(N'2020-08-14T12:43:01.163' AS DateTime), N'ff', 100, 1009)
SET IDENTITY_INSERT [dbo].[Cobro] OFF
GO
SET IDENTITY_INSERT [dbo].[Gasto] ON 

INSERT [dbo].[Gasto] ([fecha], [descripcion], [costo], [idGasto]) VALUES (CAST(N'2001-11-11T00:00:00.000' AS DateTime), N'aaaa', 6666, 1)
INSERT [dbo].[Gasto] ([fecha], [descripcion], [costo], [idGasto]) VALUES (CAST(N'2020-07-25T17:37:00.137' AS DateTime), N'bbb', 9999, 2)
INSERT [dbo].[Gasto] ([fecha], [descripcion], [costo], [idGasto]) VALUES (CAST(N'2020-07-25T17:37:09.017' AS DateTime), N'ccc', 8888, 3)
SET IDENTITY_INSERT [dbo].[Gasto] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([idCliente], [fecha], [descripcion], [monto], [idVenta]) VALUES (1, CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'aaa', 1000, 1)
INSERT [dbo].[Venta] ([idCliente], [fecha], [descripcion], [monto], [idVenta]) VALUES (2, CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'eee', 777, 2)
INSERT [dbo].[Venta] ([idCliente], [fecha], [descripcion], [monto], [idVenta]) VALUES (1, CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'HHH', 1000, 3)
INSERT [dbo].[Venta] ([idCliente], [fecha], [descripcion], [monto], [idVenta]) VALUES (3, CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'hhh', 333, 4)
INSERT [dbo].[Venta] ([idCliente], [fecha], [descripcion], [monto], [idVenta]) VALUES (1, CAST(N'2020-08-25T00:00:00.000' AS DateTime), N'j', 100, 1002)
INSERT [dbo].[Venta] ([idCliente], [fecha], [descripcion], [monto], [idVenta]) VALUES (1, CAST(N'2020-08-13T00:00:00.000' AS DateTime), N'e', 300, 1003)
INSERT [dbo].[Venta] ([idCliente], [fecha], [descripcion], [monto], [idVenta]) VALUES (1, CAST(N'2020-09-01T00:00:00.000' AS DateTime), N'ii', 99, 1008)
INSERT [dbo].[Venta] ([idCliente], [fecha], [descripcion], [monto], [idVenta]) VALUES (2, CAST(N'2020-09-01T00:00:00.000' AS DateTime), N'yy', 77, 1009)
INSERT [dbo].[Venta] ([idCliente], [fecha], [descripcion], [monto], [idVenta]) VALUES (1, CAST(N'2020-09-05T00:00:00.000' AS DateTime), N'99', 999, 1010)
INSERT [dbo].[Venta] ([idCliente], [fecha], [descripcion], [monto], [idVenta]) VALUES (1, CAST(N'2020-09-05T00:00:00.000' AS DateTime), N'uuu', 99, 1012)
INSERT [dbo].[Venta] ([idCliente], [fecha], [descripcion], [monto], [idVenta]) VALUES (1, CAST(N'2020-09-15T00:00:00.000' AS DateTime), N'nnnn Subasta drusus', 999, 1013)
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
/****** Object:  Index [IX_Venta]    Script Date: 11/14/2020 11:05:39 AM ******/
CREATE NONCLUSTERED INDEX [IX_Venta] ON [dbo].[Venta]
(
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cobro] ADD  CONSTRAINT [DF_Cobro_fecha]  DEFAULT (getdate()) FOR [fecha]
GO
ALTER TABLE [dbo].[Gasto] ADD  CONSTRAINT [DF_Gasto_fecha]  DEFAULT (getdate()) FOR [fecha]
GO
ALTER TABLE [dbo].[Venta] ADD  CONSTRAINT [DF_Venta_fecha]  DEFAULT (getdate()) FOR [fecha]
GO
ALTER TABLE [dbo].[Cobro]  WITH CHECK ADD  CONSTRAINT [FK_Cobro_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Cobro] CHECK CONSTRAINT [FK_Cobro_Cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
USE [master]
GO
ALTER DATABASE [drusus] SET  READ_WRITE 
GO
