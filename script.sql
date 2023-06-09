USE [master]
GO
/****** Object:  Database [QLKH]    Script Date: 16/6/2023 12:55:23 am ******/
CREATE DATABASE [QLKH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLKH.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLKH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLKH_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLKH] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKH] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKH] SET  MULTI_USER 
GO
ALTER DATABASE [QLKH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLKH]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 16/6/2023 12:55:23 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [int] IDENTITY(1,1) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChungTu]    Script Date: 16/6/2023 12:55:23 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChungTu](
	[ChungTu] [uniqueidentifier] NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
	[TrangThai] [bit] NULL,
	[Created_Date] [datetime] NULL,
	[Created_By] [int] NULL,
	[Deleted_Date] [datetime] NULL,
	[Deleted_By] [int] NULL,
	[Update_date] [datetime] NULL,
	[Update_by] [int] NULL,
	[NgayXuat] [datetime] NULL,
	[DVX] [int] NULL,
	[NCC] [int] NULL,
	[NgayNhap] [datetime] NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[ChungTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonVi]    Script Date: 16/6/2023 12:55:23 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonVi](
	[MaDV] [int] IDENTITY(1,1) NOT NULL,
	[TenDV] [nvarchar](100) NULL,
	[SDTDV] [nchar](10) NULL,
	[DCDV] [nvarchar](100) NULL,
 CONSTRAINT [PK_DonVi] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 16/6/2023 12:55:23 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[MaDVT] [int] IDENTITY(1,1) NOT NULL,
	[TenDVT] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[MaDVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 16/6/2023 12:55:23 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[Barcode] [nvarchar](13) NOT NULL,
	[TenHH] [nvarchar](50) NULL,
	[DonViTinh] [int] NULL,
	[TenTat] [nvarchar](50) NULL,
	[Created_Date] [datetime] NULL,
	[Disabled] [bit] NULL,
	[Created_By] [int] NULL,
	[XuatXu] [nvarchar](100) NULL,
 CONSTRAINT [PK_hanghoa] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HHTrongKho]    Script Date: 16/6/2023 12:55:23 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HHTrongKho](
	[MaHH] [nvarchar](13) NULL,
	[SL] [int] NULL,
	[ChungTu] [uniqueidentifier] NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GiaMua] [float] NULL,
	[GiaBan] [float] NULL,
	[MaKH] [int] NULL,
	[SLBan] [int] NULL,
 CONSTRAINT [PK_HHTrongKho] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HHXK]    Script Date: 16/6/2023 12:55:23 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HHXK](
	[ChungTu] [uniqueidentifier] NULL,
	[idhhtk] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[GiaBan] [float] NULL,
	[SLban] [int] NULL,
 CONSTRAINT [PK_HHXK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 16/6/2023 12:55:23 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](100) NULL,
	[DiaChiKH] [nvarchar](100) NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 16/6/2023 12:55:23 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](100) NULL,
	[SDTNCC] [char](10) NULL,
	[EmailNCC] [nchar](100) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 16/6/2023 12:55:23 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [char](100) NULL,
	[PassWord] [char](100) NULL,
	[FullName] [nvarchar](100) NULL,
	[ChucVu] [int] NULL,
	[MaKH] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (1, N'Quản lý')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (2, N'Nhân viên')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (3, N'admin')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
GO
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'e70f5b54-4f54-421a-b0d4-034bcdf4228d', N'123', NULL, CAST(N'2023-06-15T16:19:02.973' AS DateTime), 1, NULL, NULL, NULL, NULL, CAST(N'2023-06-15T00:00:00.000' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'b8c851dc-5edc-4fbd-92c3-03e790dbd52b', NULL, NULL, CAST(N'2023-06-14T01:52:47.103' AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'0e5fd03f-abae-4948-9cd4-0b79351fa891', N'123', NULL, CAST(N'2023-06-14T01:20:27.553' AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'fdc51197-1869-49a1-90b8-0e5ceb270208', N'1234', NULL, CAST(N'2023-06-15T22:50:16.077' AS DateTime), 1, NULL, NULL, NULL, NULL, CAST(N'2023-06-15T00:00:00.000' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'876eef85-aef5-467d-bc43-170d614b47e7', NULL, NULL, CAST(N'2023-06-14T02:43:20.060' AS DateTime), 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'87d3955c-8b1b-48b9-b08a-3207acb071dd', NULL, NULL, CAST(N'2023-06-14T01:33:16.560' AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'0221a2c2-3f49-4607-b229-338bb7ce630f', N'1', NULL, CAST(N'2023-06-15T17:40:12.427' AS DateTime), 1, NULL, NULL, NULL, NULL, CAST(N'2023-06-15T00:00:00.000' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'2c5fcbe4-792c-4ead-8d4c-42e99b3d7bba', NULL, NULL, CAST(N'2023-06-14T02:43:19.370' AS DateTime), 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'8eef3124-5afa-44a7-a6a5-481f867e3862', N'123', NULL, CAST(N'2023-06-15T16:49:03.910' AS DateTime), 1, NULL, NULL, NULL, NULL, CAST(N'2023-06-15T00:00:00.000' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'814cf8c4-c3aa-4c26-ba63-67582b9adfc9', N'123', NULL, CAST(N'2023-06-15T16:18:12.787' AS DateTime), 1, NULL, NULL, NULL, NULL, CAST(N'2023-06-15T00:00:00.000' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'aedba8b0-8e57-4c40-842e-70f47fca691f', N'123', NULL, CAST(N'2023-06-15T17:46:09.013' AS DateTime), 1, NULL, NULL, NULL, NULL, CAST(N'2023-06-15T00:00:00.000' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'70b259b1-ebab-4117-97e7-849db540d80d', N'123', NULL, CAST(N'2023-06-15T14:00:57.923' AS DateTime), 2, NULL, NULL, NULL, NULL, NULL, NULL, 1, CAST(N'2023-06-15T00:00:00.000' AS DateTime))
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'9376d9e9-bdd6-42f4-a965-84db98391bd8', NULL, NULL, CAST(N'2023-06-15T23:21:02.270' AS DateTime), 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'9bb76284-efdb-46be-878b-8db6a66a217a', N'chán', NULL, CAST(N'2023-06-15T17:41:18.187' AS DateTime), 1, NULL, NULL, NULL, NULL, CAST(N'2023-06-15T00:00:00.000' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'58f2359f-11f9-4bcc-848b-93e5e79840ee', NULL, NULL, CAST(N'2023-06-15T15:54:35.420' AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'cb3950e3-cadc-4bc2-a539-ad949657235a', NULL, NULL, CAST(N'2023-06-15T23:55:20.620' AS DateTime), 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'd71cc549-9dec-45eb-be49-adac6aba7853', NULL, NULL, CAST(N'2023-06-14T02:24:56.260' AS DateTime), 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'ee770b49-9a96-4494-9615-b901503a33ce', NULL, NULL, CAST(N'2023-06-15T23:19:53.787' AS DateTime), 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'd563d471-1b79-4332-8d60-c4e1c201e7dc', N'123', NULL, CAST(N'2023-06-15T23:55:26.247' AS DateTime), 3, NULL, NULL, NULL, NULL, NULL, NULL, 1, CAST(N'2023-06-15T00:00:00.000' AS DateTime))
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'c9066bfc-ed5c-4d2b-85c2-c85ff483f0b1', N'13', NULL, CAST(N'2023-06-14T02:08:36.220' AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, 1, CAST(N'2023-06-14T00:00:00.000' AS DateTime))
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'7ac9a10e-2554-4304-a72e-e1ca03f03a10', NULL, NULL, CAST(N'2023-06-14T02:24:55.420' AS DateTime), 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'8113bbdb-1d5d-4e7e-b049-e340e03b3ff9', N'123', NULL, CAST(N'2023-06-14T02:04:34.347' AS DateTime), 1, NULL, NULL, NULL, NULL, CAST(N'2023-06-14T00:00:00.000' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'b24d361f-16de-4c7b-ba4f-e34a847afe2b', NULL, NULL, CAST(N'2023-06-14T01:32:47.980' AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'794499e5-53a0-4788-a516-e6cdde3b1729', NULL, NULL, CAST(N'2023-06-15T23:56:24.800' AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ChungTu] ([ChungTu], [GhiChu], [TrangThai], [Created_Date], [Created_By], [Deleted_Date], [Deleted_By], [Update_date], [Update_by], [NgayXuat], [DVX], [NCC], [NgayNhap]) VALUES (N'9214e0f1-9488-4ccd-a732-ed42a2c766a6', NULL, NULL, CAST(N'2023-06-15T17:38:15.083' AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[DonVi] ON 

INSERT [dbo].[DonVi] ([MaDV], [TenDV], [SDTDV], [DCDV]) VALUES (1, N'Nhà hàng', N'1234567890', N'123')
INSERT [dbo].[DonVi] ([MaDV], [TenDV], [SDTDV], [DCDV]) VALUES (2, N'quan an gia dinh', N'1234567890', N'1234')
INSERT [dbo].[DonVi] ([MaDV], [TenDV], [SDTDV], [DCDV]) VALUES (3, N'don vi 3', N'123123123 ', N'123')
SET IDENTITY_INSERT [dbo].[DonVi] OFF
GO
SET IDENTITY_INSERT [dbo].[DonViTinh] ON 

INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT]) VALUES (1, N'Qủa')
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT]) VALUES (2, N'Cái')
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT]) VALUES (3, N'trai')
SET IDENTITY_INSERT [dbo].[DonViTinh] OFF
GO
INSERT [dbo].[HangHoa] ([Barcode], [TenHH], [DonViTinh], [TenTat], [Created_Date], [Disabled], [Created_By], [XuatXu]) VALUES (N'1', N'Trứng gà (Lớn)', 1, N'11', NULL, NULL, NULL, NULL)
INSERT [dbo].[HangHoa] ([Barcode], [TenHH], [DonViTinh], [TenTat], [Created_Date], [Disabled], [Created_By], [XuatXu]) VALUES (N'1234512345123', N'Trứng gà', 1, N'TG', NULL, NULL, NULL, NULL)
INSERT [dbo].[HangHoa] ([Barcode], [TenHH], [DonViTinh], [TenTat], [Created_Date], [Disabled], [Created_By], [XuatXu]) VALUES (N'13', N'Trứng gà (so)', 1, N'13', NULL, NULL, NULL, NULL)
INSERT [dbo].[HangHoa] ([Barcode], [TenHH], [DonViTinh], [TenTat], [Created_Date], [Disabled], [Created_By], [XuatXu]) VALUES (N'14', N'Trứng gà (đại)', 1, N'14', NULL, NULL, NULL, NULL)
INSERT [dbo].[HangHoa] ([Barcode], [TenHH], [DonViTinh], [TenTat], [Created_Date], [Disabled], [Created_By], [XuatXu]) VALUES (N'15', N'Trứng gà (trung)', 1, N'15', NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[HHTrongKho] ON 

INSERT [dbo].[HHTrongKho] ([MaHH], [SL], [ChungTu], [Id], [GiaMua], [GiaBan], [MaKH], [SLBan]) VALUES (N'13', 0, N'0e5fd03f-abae-4948-9cd4-0b79351fa891', 126, 10, NULL, 2, NULL)
INSERT [dbo].[HHTrongKho] ([MaHH], [SL], [ChungTu], [Id], [GiaMua], [GiaBan], [MaKH], [SLBan]) VALUES (N'13', 0, N'0e5fd03f-abae-4948-9cd4-0b79351fa891', 127, 10, NULL, 2, NULL)
INSERT [dbo].[HHTrongKho] ([MaHH], [SL], [ChungTu], [Id], [GiaMua], [GiaBan], [MaKH], [SLBan]) VALUES (N'13', 0, N'0e5fd03f-abae-4948-9cd4-0b79351fa891', 128, 10, NULL, 2, NULL)
INSERT [dbo].[HHTrongKho] ([MaHH], [SL], [ChungTu], [Id], [GiaMua], [GiaBan], [MaKH], [SLBan]) VALUES (N'15', 0, N'c9066bfc-ed5c-4d2b-85c2-c85ff483f0b1', 129, 10, NULL, 2, NULL)
INSERT [dbo].[HHTrongKho] ([MaHH], [SL], [ChungTu], [Id], [GiaMua], [GiaBan], [MaKH], [SLBan]) VALUES (N'1', 111, N'70b259b1-ebab-4117-97e7-849db540d80d', 130, 10, NULL, 3, NULL)
INSERT [dbo].[HHTrongKho] ([MaHH], [SL], [ChungTu], [Id], [GiaMua], [GiaBan], [MaKH], [SLBan]) VALUES (N'1', 8, N'ee770b49-9a96-4494-9615-b901503a33ce', 131, 2210, NULL, 2, NULL)
INSERT [dbo].[HHTrongKho] ([MaHH], [SL], [ChungTu], [Id], [GiaMua], [GiaBan], [MaKH], [SLBan]) VALUES (N'13', 31, N'ee770b49-9a96-4494-9615-b901503a33ce', 132, 2210, NULL, 2, NULL)
INSERT [dbo].[HHTrongKho] ([MaHH], [SL], [ChungTu], [Id], [GiaMua], [GiaBan], [MaKH], [SLBan]) VALUES (N'14', 1, N'd563d471-1b79-4332-8d60-c4e1c201e7dc', 133, 10, NULL, 2, NULL)
INSERT [dbo].[HHTrongKho] ([MaHH], [SL], [ChungTu], [Id], [GiaMua], [GiaBan], [MaKH], [SLBan]) VALUES (N'15', 1, N'd563d471-1b79-4332-8d60-c4e1c201e7dc', 134, 10, NULL, 2, NULL)
SET IDENTITY_INSERT [dbo].[HHTrongKho] OFF
GO
SET IDENTITY_INSERT [dbo].[HHXK] ON 

INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'b8c851dc-5edc-4fbd-92c3-03e790dbd52b', 126, 81, 1, 1)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'8113bbdb-1d5d-4e7e-b049-e340e03b3ff9', 127, 82, 1, 1)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'814cf8c4-c3aa-4c26-ba63-67582b9adfc9', 129, 83, 1, 1)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'814cf8c4-c3aa-4c26-ba63-67582b9adfc9', 129, 84, 1, 1)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'e70f5b54-4f54-421a-b0d4-034bcdf4228d', 130, 85, 1, 1)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'8eef3124-5afa-44a7-a6a5-481f867e3862', 129, 86, 11111, 1)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'8eef3124-5afa-44a7-a6a5-481f867e3862', 130, 87, 111, 1)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'0221a2c2-3f49-4607-b229-338bb7ce630f', 128, 88, 1, 1)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'9bb76284-efdb-46be-878b-8db6a66a217a', 130, 89, 1, 1)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'aedba8b0-8e57-4c40-842e-70f47fca691f', 130, 90, 1, 1)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'aedba8b0-8e57-4c40-842e-70f47fca691f', 130, 91, 1, 1)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'fdc51197-1869-49a1-90b8-0e5ceb270208', 129, 92, 1, 2)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'fdc51197-1869-49a1-90b8-0e5ceb270208', 130, 93, 1, 3)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'fdc51197-1869-49a1-90b8-0e5ceb270208', 129, 94, 1, 4)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'9376d9e9-bdd6-42f4-a965-84db98391bd8', 129, 95, 1, 2)
INSERT [dbo].[HHXK] ([ChungTu], [idhhtk], [id], [GiaBan], [SLban]) VALUES (N'9376d9e9-bdd6-42f4-a965-84db98391bd8', 131, 96, 2, 3)
SET IDENTITY_INSERT [dbo].[HHXK] OFF
GO
SET IDENTITY_INSERT [dbo].[Kho] ON 

INSERT [dbo].[Kho] ([MaKH], [TenKH], [DiaChiKH]) VALUES (2, N'Kho hàng số 1', N'Tiền Giang')
INSERT [dbo].[Kho] ([MaKH], [TenKH], [DiaChiKH]) VALUES (3, N'kho hàng số 2', N'tt')
INSERT [dbo].[Kho] ([MaKH], [TenKH], [DiaChiKH]) VALUES (4, N'kho hàng số 3', N'my tho')
SET IDENTITY_INSERT [dbo].[Kho] OFF
GO
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDTNCC], [EmailNCC]) VALUES (1, N'Nhà cung cấp số 1', N'0123456789', N'123@gmail.com                                                                                       ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDTNCC], [EmailNCC]) VALUES (2, N'Nhà cc 2', N'1234567890', N'1234@.com                                                                                           ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDTNCC], [EmailNCC]) VALUES (3, N'cong ty a', N'123       ', N'123                                                                                                 ')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [UserName], [PassWord], [FullName], [ChucVu], [MaKH]) VALUES (1, N'thuc                                                                                                ', N'123                                                                                                 ', N'Nguyễn Thức', 1, 2)
INSERT [dbo].[User] ([Id], [UserName], [PassWord], [FullName], [ChucVu], [MaKH]) VALUES (2, N'thuc2                                                                                               ', N'1232                                                                                                ', N'Nguyễn Đông Thức 2', 2, 3)
INSERT [dbo].[User] ([Id], [UserName], [PassWord], [FullName], [ChucVu], [MaKH]) VALUES (3, N'thuc3                                                                                               ', N'1233                                                                                                ', N'thuc', 3, 2)
INSERT [dbo].[User] ([Id], [UserName], [PassWord], [FullName], [ChucVu], [MaKH]) VALUES (4, N'thuc4                                                                                               ', N'1234                                                                                                ', N'Thức', 1, 3)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[ChungTu]  WITH CHECK ADD  CONSTRAINT [FK_ChungTu_DonVi] FOREIGN KEY([DVX])
REFERENCES [dbo].[DonVi] ([MaDV])
GO
ALTER TABLE [dbo].[ChungTu] CHECK CONSTRAINT [FK_ChungTu_DonVi]
GO
ALTER TABLE [dbo].[ChungTu]  WITH CHECK ADD  CONSTRAINT [FK_ChungTu_NhaCungCap] FOREIGN KEY([NCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[ChungTu] CHECK CONSTRAINT [FK_ChungTu_NhaCungCap]
GO
ALTER TABLE [dbo].[ChungTu]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_User] FOREIGN KEY([Created_By])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[ChungTu] CHECK CONSTRAINT [FK_hoadon_User]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_hanghoa_DonViTinh] FOREIGN KEY([DonViTinh])
REFERENCES [dbo].[DonViTinh] ([MaDVT])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_hanghoa_DonViTinh]
GO
ALTER TABLE [dbo].[HHTrongKho]  WITH CHECK ADD  CONSTRAINT [FK_HHTrongKho_ChungTu] FOREIGN KEY([ChungTu])
REFERENCES [dbo].[ChungTu] ([ChungTu])
GO
ALTER TABLE [dbo].[HHTrongKho] CHECK CONSTRAINT [FK_HHTrongKho_ChungTu]
GO
ALTER TABLE [dbo].[HHTrongKho]  WITH CHECK ADD  CONSTRAINT [FK_HHTrongKho_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([Barcode])
GO
ALTER TABLE [dbo].[HHTrongKho] CHECK CONSTRAINT [FK_HHTrongKho_HangHoa]
GO
ALTER TABLE [dbo].[HHTrongKho]  WITH CHECK ADD  CONSTRAINT [FK_HHTrongKho_Kho] FOREIGN KEY([MaKH])
REFERENCES [dbo].[Kho] ([MaKH])
GO
ALTER TABLE [dbo].[HHTrongKho] CHECK CONSTRAINT [FK_HHTrongKho_Kho]
GO
ALTER TABLE [dbo].[HHXK]  WITH CHECK ADD  CONSTRAINT [FK_HHXK_ChungTu] FOREIGN KEY([ChungTu])
REFERENCES [dbo].[ChungTu] ([ChungTu])
GO
ALTER TABLE [dbo].[HHXK] CHECK CONSTRAINT [FK_HHXK_ChungTu]
GO
ALTER TABLE [dbo].[HHXK]  WITH CHECK ADD  CONSTRAINT [FK_HHXK_HHTrongKho] FOREIGN KEY([idhhtk])
REFERENCES [dbo].[HHTrongKho] ([Id])
GO
ALTER TABLE [dbo].[HHXK] CHECK CONSTRAINT [FK_HHXK_HHTrongKho]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_ChucVu] FOREIGN KEY([ChucVu])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_ChucVu]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Kho] FOREIGN KEY([MaKH])
REFERENCES [dbo].[Kho] ([MaKH])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Kho]
GO
USE [master]
GO
ALTER DATABASE [QLKH] SET  READ_WRITE 
GO
