USE [master]
GO
/****** Object:  Database [HotelDatabase]    Script Date: 2019-05-28 22:58:53 ******/
CREATE DATABASE [HotelDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HotelDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\HotelDatabase.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HotelDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\HotelDatabase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HotelDatabase] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HotelDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HotelDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HotelDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HotelDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HotelDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HotelDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [HotelDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HotelDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HotelDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HotelDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HotelDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HotelDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HotelDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HotelDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HotelDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HotelDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HotelDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HotelDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HotelDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HotelDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HotelDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HotelDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HotelDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HotelDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HotelDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [HotelDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HotelDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HotelDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HotelDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HotelDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
USE [HotelDatabase]
GO
/****** Object:  Table [dbo].[BaiViet]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BaiViet](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenBaiViet] [nvarchar](500) NOT NULL,
	[NoiDung] [nvarchar](1000) NOT NULL,
	[NoiDungChiTiet] [nvarchar](max) NOT NULL,
	[NgayTao] [date] NOT NULL,
	[HinhAnh] [varchar](200) NOT NULL,
 CONSTRAINT [PK_BaiViet] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DatPhong]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DatPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SoPhong] [int] NOT NULL,
	[NgayVao] [date] NOT NULL,
	[NgayRa] [date] NOT NULL,
	[TenKhachHang] [nvarchar](200) NOT NULL,
	[CMND] [varchar](9) NOT NULL,
	[idNV] [int] NOT NULL,
	[TinhTrang] [bit] NOT NULL,
 CONSTRAINT [PK_DatPhong_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SoPhong] [int] NOT NULL,
	[NgayVao] [date] NOT NULL,
	[NgayRa] [date] NOT NULL,
	[TienPhong] [money] NOT NULL,
	[TienDichVu] [money] NOT NULL,
	[PhuThu] [money] NOT NULL,
	[TongTien] [money] NOT NULL,
	[TinhTrang] [int] NOT NULL,
	[GhiChu] [nvarchar](500) NOT NULL,
	[idNv] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[SoPhong] ASC,
	[NgayVao] ASC,
	[NgayRa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[CMND] [varchar](11) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](100) NOT NULL,
	[SDT] [varchar](11) NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
	[imgKhachHang] [nvarchar](max) NULL,
 CONSTRAINT [PK_KhachHang_1] PRIMARY KEY CLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiDichVu]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDichVu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [nvarchar](200) NOT NULL,
	[DonViTinh] [nvarchar](100) NOT NULL,
	[Gia] [money] NOT NULL,
	[imgDichVu] [nvarchar](500) NULL,
 CONSTRAINT [PK_LoaiDichVu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](200) NOT NULL,
	[GiaPhong] [money] NOT NULL,
	[imgLoaiPhong] [nvarchar](500) NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](100) NOT NULL,
	[UserName] [varchar](200) NOT NULL,
	[Password] [varchar](200) NOT NULL,
	[CMND] [varchar](12) NOT NULL,
	[idLoaiNV] [int] NOT NULL,
	[SDT] [varchar](11) NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_NhanVien_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuDatPhongKhachSan]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuDatPhongKhachSan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SoPhong] [int] NOT NULL,
	[NgayVao] [date] NOT NULL,
	[NgayRa] [date] NOT NULL,
	[TinhTrang] [int] NOT NULL,
	[idKhachHang] [varchar](11) NOT NULL,
 CONSTRAINT [PK_PhieuDatPhongKhachPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuDichVu]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDichVu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[idDatPhong] [int] NOT NULL,
	[NgayDat] [date] NOT NULL,
	[idDichVu] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [money] NOT NULL,
	[TinhTrang] [int] NOT NULL,
	[idNv] [int] NOT NULL,
 CONSTRAINT [PK_PhieuDichVu_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phong]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[SoPhong] [int] NOT NULL,
	[idLoaiPhong] [int] NOT NULL,
	[Tang] [int] NOT NULL,
	[imgPhong] [nvarchar](500) NOT NULL,
	[TinhTrang] [bit] NOT NULL,
	[MoTaPhong] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Phong_1] PRIMARY KEY CLUSTERED 
(
	[SoPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[BaiViet] ON 

INSERT [dbo].[BaiViet] ([id], [TenBaiViet], [NoiDung], [NoiDungChiTiet], [NgayTao], [HinhAnh]) VALUES (4, N'Phòng ở ', N'Khách sạn G-Hotel với nhiều phòng có sức chứa khác nhau, đáp ứng từng yêu cầu của quý khách hàng.', N'xxx', CAST(N'2019-01-01' AS Date), N'Post1.jpg')
INSERT [dbo].[BaiViet] ([id], [TenBaiViet], [NoiDung], [NoiDungChiTiet], [NgayTao], [HinhAnh]) VALUES (5, N'Phòng ở ', N'Khách sạn G-Hotel với nhiều phòng có sức chứa khác nhau, đáp ứng từng yêu cầu của quý khách hàng.', N'xxx', CAST(N'2019-01-02' AS Date), N'Post1.jpg')
INSERT [dbo].[BaiViet] ([id], [TenBaiViet], [NoiDung], [NoiDungChiTiet], [NgayTao], [HinhAnh]) VALUES (6, N'Phòng ở ', N'Khách sạn G-Hotel với nhiều phòng có sức chứa khác nhau, đáp ứng từng yêu cầu của quý khách hàng.', N'xxx', CAST(N'2019-01-03' AS Date), N'Post1.jpg')
INSERT [dbo].[BaiViet] ([id], [TenBaiViet], [NoiDung], [NoiDungChiTiet], [NgayTao], [HinhAnh]) VALUES (7, N'Phòng ở ', N'Khách sạn G-Hotel với nhiều phòng có sức chứa khác nhau, đáp ứng từng yêu cầu của quý khách hàng.', N'xxx', CAST(N'2019-01-01' AS Date), N'Post1.jpg')
INSERT [dbo].[BaiViet] ([id], [TenBaiViet], [NoiDung], [NoiDungChiTiet], [NgayTao], [HinhAnh]) VALUES (8, N'Phòng ở ', N'Khách sạn G-Hotel với nhiều phòng có sức chứa khác nhau, đáp ứng từng yêu cầu của quý khách hàng.', N'xxx', CAST(N'2019-01-01' AS Date), N'Post1.jpg')
INSERT [dbo].[BaiViet] ([id], [TenBaiViet], [NoiDung], [NoiDungChiTiet], [NgayTao], [HinhAnh]) VALUES (9, N'Phòng ở ', N'Khách sạn G-Hotel với nhiều phòng có sức chứa khác nhau, đáp ứng từng yêu cầu của quý khách hàng.', N'xxx', CAST(N'2019-01-01' AS Date), N'Post1.jpg')
INSERT [dbo].[BaiViet] ([id], [TenBaiViet], [NoiDung], [NoiDungChiTiet], [NgayTao], [HinhAnh]) VALUES (10, N'Phòng ở ', N'Khách sạn G-Hotel với nhiều phòng có sức chứa khác nhau, đáp ứng từng yêu cầu của quý khách hàng.', N'xxx', CAST(N'2019-01-01' AS Date), N'Post1.jpg')
SET IDENTITY_INSERT [dbo].[BaiViet] OFF
INSERT [dbo].[KhachHang] ([CMND], [UserName], [PassWord], [SDT], [Address], [imgKhachHang]) VALUES (N'123456', N'admin', N'admin', N'123456', N'xxx', N'xxxxx')
SET IDENTITY_INSERT [dbo].[LoaiDichVu] ON 

INSERT [dbo].[LoaiDichVu] ([ID], [TenDichVu], [DonViTinh], [Gia], [imgDichVu]) VALUES (1, N'Nuoc uong ', N'chia ', 200000.0000, N'bia333.png')
SET IDENTITY_INSERT [dbo].[LoaiDichVu] OFF
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON 

INSERT [dbo].[LoaiPhong] ([ID], [TenLoaiPhong], [GiaPhong], [imgLoaiPhong]) VALUES (1, N'Phòng Đơn', 100000.0000, N'LoaiPhong1.jpg')
INSERT [dbo].[LoaiPhong] ([ID], [TenLoaiPhong], [GiaPhong], [imgLoaiPhong]) VALUES (2, N'Phong Đôi ', 200000.0000, N'LoaiPhong1.jpg')
INSERT [dbo].[LoaiPhong] ([ID], [TenLoaiPhong], [GiaPhong], [imgLoaiPhong]) VALUES (3, N'Phòng Vip', 350000.0000, N'LoaiPhong1.jpg')
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [TenNhanVien], [UserName], [Password], [CMND], [idLoaiNV], [SDT], [Address]) VALUES (1, N'Minh', N'Minh', N'123', N'12345', 1, N'11111', N'xxxx')
INSERT [dbo].[NhanVien] ([ID], [TenNhanVien], [UserName], [Password], [CMND], [idLoaiNV], [SDT], [Address]) VALUES (2, N'Admin', N'admin', N'admin', N'12345', 0, N'123', N'xxx')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[PhieuDatPhongKhachSan] ON 

INSERT [dbo].[PhieuDatPhongKhachSan] ([ID], [SoPhong], [NgayVao], [NgayRa], [TinhTrang], [idKhachHang]) VALUES (2, 1, CAST(N'2019-05-26' AS Date), CAST(N'2019-05-26' AS Date), 1, N'123456')
INSERT [dbo].[PhieuDatPhongKhachSan] ([ID], [SoPhong], [NgayVao], [NgayRa], [TinhTrang], [idKhachHang]) VALUES (3, 1, CAST(N'2019-05-26' AS Date), CAST(N'2019-05-26' AS Date), 1, N'123456     ')
INSERT [dbo].[PhieuDatPhongKhachSan] ([ID], [SoPhong], [NgayVao], [NgayRa], [TinhTrang], [idKhachHang]) VALUES (4, 12, CAST(N'2019-05-26' AS Date), CAST(N'2019-05-26' AS Date), 1, N'123456     ')
INSERT [dbo].[PhieuDatPhongKhachSan] ([ID], [SoPhong], [NgayVao], [NgayRa], [TinhTrang], [idKhachHang]) VALUES (21, 12, CAST(N'2019-05-26' AS Date), CAST(N'2019-05-27' AS Date), 0, N'123456     ')
SET IDENTITY_INSERT [dbo].[PhieuDatPhongKhachSan] OFF
INSERT [dbo].[Phong] ([SoPhong], [idLoaiPhong], [Tang], [imgPhong], [TinhTrang], [MoTaPhong]) VALUES (1, 1, 1, N'xxxx', 0, N'xxxx')
INSERT [dbo].[Phong] ([SoPhong], [idLoaiPhong], [Tang], [imgPhong], [TinhTrang], [MoTaPhong]) VALUES (12, 1, 1, N'xxx', 0, N'xxxx')
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_NhanVien] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_NhanVien]
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_Phong] FOREIGN KEY([SoPhong])
REFERENCES [dbo].[Phong] ([SoPhong])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_Phong]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([idNv])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Phong] FOREIGN KEY([SoPhong])
REFERENCES [dbo].[Phong] ([SoPhong])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Phong]
GO
ALTER TABLE [dbo].[PhieuDatPhongKhachSan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatPhongKhachSan_KhachHang] FOREIGN KEY([idKhachHang])
REFERENCES [dbo].[KhachHang] ([CMND])
GO
ALTER TABLE [dbo].[PhieuDatPhongKhachSan] CHECK CONSTRAINT [FK_PhieuDatPhongKhachSan_KhachHang]
GO
ALTER TABLE [dbo].[PhieuDatPhongKhachSan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatPhongKhachSan_Phong] FOREIGN KEY([SoPhong])
REFERENCES [dbo].[Phong] ([SoPhong])
GO
ALTER TABLE [dbo].[PhieuDatPhongKhachSan] CHECK CONSTRAINT [FK_PhieuDatPhongKhachSan_Phong]
GO
ALTER TABLE [dbo].[PhieuDichVu]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDichVu_DatPhong] FOREIGN KEY([idDatPhong])
REFERENCES [dbo].[DatPhong] ([ID])
GO
ALTER TABLE [dbo].[PhieuDichVu] CHECK CONSTRAINT [FK_PhieuDichVu_DatPhong]
GO
ALTER TABLE [dbo].[PhieuDichVu]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDichVu_LoaiDichVu] FOREIGN KEY([idDichVu])
REFERENCES [dbo].[LoaiDichVu] ([ID])
GO
ALTER TABLE [dbo].[PhieuDichVu] CHECK CONSTRAINT [FK_PhieuDichVu_LoaiDichVu]
GO
ALTER TABLE [dbo].[PhieuDichVu]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDichVu_NhanVien] FOREIGN KEY([idNv])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[PhieuDichVu] CHECK CONSTRAINT [FK_PhieuDichVu_NhanVien]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_LoaiPhong] FOREIGN KEY([idLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([ID])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_LoaiPhong]
GO
/****** Object:  StoredProcedure [dbo].[ADD_LIST_ROOM]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADD_LIST_ROOM](
 @TenLoaiPhong character(200),
 @GiaPhong int,
 @imgLoaiPhong character(20) 
)
AS
BEGIN
  insert into LoaiPhong(TenLoaiPhong,GiaPhong,imgLoaiPhong) values(@TenLoaiPhong,@GiaPhong,@imgLoaiPhong)
END
GO
/****** Object:  StoredProcedure [dbo].[ADD_LIST_SERVICE]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Add list service
CREATE PROC [dbo].[ADD_LIST_SERVICE](
 @TenDichVu character(200),
 @DonViTinh character(20),
 @Gia int,
 @imgDichVu character(20) 
)
AS
BEGIN
  insert into LoaiDichVu(TenDichVu,DonViTinh,Gia,imgDichVu) values(@TenDichVu,@DonViTinh,@Gia,@imgDichVu)
END

GO
/****** Object:  StoredProcedure [dbo].[DELETE_BOOKING_TICKET]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_BOOKING_TICKET] (
@ID int
) AS BEGIN
	DELETE FROM PhieuDatPhongKhachSan WHERE ID  = @ID 
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_ITEM_ROOM]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_ITEM_ROOM](
	@ID int
)
AS
BEGIN
  delete LoaiPhong where ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_ITEM_SERVICE]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Delete item service
CREATE PROC [dbo].[DELETE_ITEM_SERVICE](
 @ID int 
)
AS
BEGIN
  delete from LoaiDichVu where ID=@ID
END

GO
/****** Object:  StoredProcedure [dbo].[GET_INFO_FROM_ROOM_NO]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GET_INFO_FROM_ROOM_NO]
 @RoomNo int
AS
BEGIN
   select p.SoPhong,p.Tang,p.imgPhong,p.TinhTrang,p.MoTaPhong,l.TenLoaiPhong,l.GiaPhong
   from Phong p
   left join LoaiPhong l on p.idLoaiPhong=l.ID  
   where p.SoPhong=@RoomNo
END
GO
/****** Object:  StoredProcedure [dbo].[GET_LIST_BOOKING_TICKET]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GET_LIST_BOOKING_TICKET]
AS BEGIN
	SELECT p.ID, p.SoPhong, p.NgayVao, p.NgayRa, p.TinhTrang, kh.CMND
	FROM PhieuDatPhongKhachSan p, KhachHang kh
	WHERE p.idKhachHang = kh.CMND
	ORDER BY p.NgayVao desc
END 
GO
/****** Object:  StoredProcedure [dbo].[GET_LIST_ORDER_FROM_IDENTITYCARD]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- get list order from identity card
CREATE PROC [dbo].[GET_LIST_ORDER_FROM_IDENTITYCARD]
   @CMND character(20)
AS
BEGIN
   select k.CMND,k.UserName,k.SDT,k.Address,k.imgKhachHang,p.SoPhong,p.NgayVao,p.NgayRa,p.TinhTrang,p.idKhachHang 
   from KhachHang k, PhieuDatPhongKhachSan p
   where @CMND like p.idKhachHang
   order by p.SoPhong
END
GO
/****** Object:  StoredProcedure [dbo].[GET_LIST_POSTS]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GET_LIST_POSTS]
AS
BEGIN
  select top 6 id,TenBaiViet,NoiDung,NoiDungChiTiet,NgayTao,HinhAnh 
  from BaiViet
  order by NgayTao desc 
END
GO
/****** Object:  StoredProcedure [dbo].[GET_LIST_ROOM]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GET_LIST_ROOM]
AS BEGIN
	SELECT *
	FROM LoaiPhong  
END
GO
/****** Object:  StoredProcedure [dbo].[GET_SERVICE_ALL]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GET_SERVICE_ALL]
AS BEGIN
	SELECT ID, TenDichVu, DonViTinh, Gia, imgDichVu
	FROM LoaiDichVu  
END 
GO
/****** Object:  StoredProcedure [dbo].[GETROOM_ALL]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GETROOM_ALL]
AS BEGIN
	SELECT p.SoPhong,p.idLoaiPhong,Tang, p.imgPhong, p.TinhTrang, p.MoTaPhong, lp.TenLoaiPhong, lp.GiaPhong
	FROM Phong p, LoaiPhong lp
	WHERE P.idLoaiPhong = lp.ID
END	
GO
/****** Object:  StoredProcedure [dbo].[INSERT_BOOKING_STICKET]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERT_BOOKING_STICKET]
 @SoPhong int,
 @NgayVao character(50),
 @NgayRa character(50),
 @TinhTrang int,
 @idKhachHang character(20)
AS
BEGIN
	insert into PhieuDatPhongKhachSan(SoPhong,NgayVao,NgayRa,TinhTrang,idKhachHang)
	values(@SoPhong,@NgayVao,@NgayRa,0,@idKhachHang)
END
GO
/****** Object:  StoredProcedure [dbo].[SET_BOOKING_ROOM]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SET_BOOKING_ROOM]
 @SoPhong int,
 @NgayVao character(50),
 @NgayRa character(50),
 @TenKhachHang character(50),
 @CMND character(50),
 @idNV character(50),
 @tinhtrang int
AS
BEGIN
	insert into DatPhong(SoPhong,NgayVao,NgayRa,TenKhachHang,CMND,idNV, TinhTrang)
	values(@SoPhong,@NgayVao,@NgayRa,@TenKhachHang,@CMND,@idNV, @tinhtrang)
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_BOOKING_ROOM]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATE_BOOKING_ROOM]
 @ID int,
 @SoPhong int,
 @NgayVao character(50),
 @NgayRa character(50),
 @TenKhachHang character(50),
 @CMND character(50),
 @idNV character(50), 
 @tinhtrang	int	
AS
BEGIN
	update DatPhong 
	set SoPhong=@SoPhong,
		NgayVao=@NgayVao,
		NgayRa=@NgayRa,
		TenKhachHang=@TenKhachHang,
		CMND=@CMND,
		idNV=@idNV,
		TinhTrang = @tinhtrang
	where ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_ITEM_ROOM]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATE_ITEM_ROOM](
	 @ID int,
	 @TenLoaiPhong character(200),
	 @GiaPhong int,
	 @imgLoaiPhong character(20) 
)
AS
BEGIN
  update LoaiPhong set TenLoaiPhong=@TenLoaiPhong,GiaPhong=@GiaPhong,imgLoaiPhong=@imgLoaiPhong where ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_ITEM_SERVICE]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--update item service
CREATE PROC [dbo].[UPDATE_ITEM_SERVICE](
	 @ID int,
	 @TenDichVu character(200),
	 @DonViTinh character(20),
	 @Gia int,
	 @imgDichVu character(20) 
)
AS
BEGIN
  update LoaiDichVu set TenDichVu=@TenDichVu,DonViTinh=@DonViTinh,Gia=@Gia,imgDichVu=@imgDichVu where ID=@ID
END

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_STATUS_BOOKING_STICKET]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATE_STATUS_BOOKING_STICKET]
 @ID int,
 @TinhTrang int
AS
BEGIN
	update PhieuDatPhongKhachSan set TinhTrang = 1 WHERE ID = @ID 
END 
GO
/****** Object:  StoredProcedure [dbo].[USER_LOGIN]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Login 
CREATE PROC [dbo].[USER_LOGIN]
  @UserName character(50),
  @Password character(50)
AS
BEGIN
  select TenNhanVien,UserName,CMND,idLoaiNV,SDT,Address 
  from NhanVien where UserName=@UserName and Password=@Password
END
GO
/****** Object:  StoredProcedure [dbo].[USER_REGISTER]    Script Date: 2019-05-28 22:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USER_REGISTER]
  @TenNhanVien character(200),
  @UserName character(50),
  @Password character(20),
  @CMND character(20),
  @idLoaiNV int,
  @SDT character(20),
  @Address character(15)
AS
BEGIN
   insert into NhanVien(TenNhanVien,UserName,Password,CMND,idLoaiNV,SDT,Address) 
   values(@TenNhanVien,@UserName,@Password,@CMND,@idLoaiNV,@SDT,@Address)
END
GO
USE [master]
GO
ALTER DATABASE [HotelDatabase] SET  READ_WRITE 
GO
