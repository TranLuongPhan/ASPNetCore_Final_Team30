USE [master]
GO

ALTER DATABASE [DbCKteam30] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbCKteam30].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbCKteam30] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbCKteam30] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbCKteam30] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbCKteam30] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbCKteam30] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbCKteam30] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DbCKteam30] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DbCKteam30] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbCKteam30] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbCKteam30] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbCKteam30] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbCKteam30] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbCKteam30] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbCKteam30] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbCKteam30] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbCKteam30] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbCKteam30] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbCKteam30] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbCKteam30] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbCKteam30] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbCKteam30] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbCKteam30] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DbCKteam30] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbCKteam30] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbCKteam30] SET  MULTI_USER 
GO
ALTER DATABASE [DbCKteam30] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbCKteam30] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbCKteam30] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbCKteam30] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DbCKteam30]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BinhLuans]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BinhLuans](
	[BinhLuanID] [int] IDENTITY(1,1) NOT NULL,
	[HangHoaID] [int] NOT NULL,
	[NoiDung] [nvarchar](max) NULL,
	[NguoiDungID] [int] NOT NULL,
	[NgayBl] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_BinhLuans] PRIMARY KEY CLUSTERED 
(
	[BinhLuanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chiTietHds]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chiTietHds](
	[ChiTietHdID] [int] IDENTITY(1,1) NOT NULL,
	[HoaDonID] [int] NOT NULL,
	[HangHoaID] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiamGia] [float] NOT NULL,
 CONSTRAINT [PK_chiTietHds] PRIMARY KEY CLUSTERED 
(
	[ChiTietHdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GioiTinhs]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioiTinhs](
	[GioiTinhID] [int] IDENTITY(1,1) NOT NULL,
	[TenGT] [nvarchar](max) NULL,
 CONSTRAINT [PK_GioiTinhs] PRIMARY KEY CLUSTERED 
(
	[GioiTinhID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoas]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoas](
	[HanghoaID] [int] IDENTITY(1,1) NOT NULL,
	[TenHh] [nvarchar](max) NULL,
	[MaLoaiID] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[Hinh] [nvarchar](max) NULL,
	[NhaCungCapID] [int] NOT NULL,
	[NgayNhap] [datetime2](7) NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[GiamGia] [float] NOT NULL,
	[LuotMua] [int] NULL,
 CONSTRAINT [PK_HangHoas] PRIMARY KEY CLUSTERED 
(
	[HanghoaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hoaDons]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoaDons](
	[HoaDonID] [int] IDENTITY(1,1) NOT NULL,
	[NguoiDungID] [int] NOT NULL,
	[NgayDat] [datetime2](7) NOT NULL,
	[NgayNhan] [datetime2](7) NOT NULL,
	[HoTen] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[ThanhToanID] [int] NOT NULL,
	[VanChuyenID] [int] NOT NULL,
	[PhiVanChuyen] [float] NOT NULL,
	[TrangThaiID] [int] NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_hoaDons] PRIMARY KEY CLUSTERED 
(
	[HoaDonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiNgDungs]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNgDungs](
	[LoaiNgDungID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiNgDungs] PRIMARY KEY CLUSTERED 
(
	[LoaiNgDungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Loais]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loais](
	[LoaiID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](max) NULL,
 CONSTRAINT [PK_Loais] PRIMARY KEY CLUSTERED 
(
	[LoaiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDungs]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDungs](
	[NguoiDungID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](max) NULL,
	[GioiTinhID] [int] NOT NULL,
	[NgaySinh] [datetime2](7) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Hinh] [nvarchar](max) NULL,
	[LoaiNgDungID] [int] NOT NULL,
	[TenDangNhap] [nvarchar](max) NULL,
	[MatKhau] [nvarchar](max) NULL,
 CONSTRAINT [PK_NguoiDungs] PRIMARY KEY CLUSTERED 
(
	[NguoiDungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCaps]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCaps](
	[NhaCungCapID] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaCc] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhaCungCaps] PRIMARY KEY CLUSTERED 
(
	[NhaCungCapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThanhToans]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhToans](
	[ThanhToanID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
 CONSTRAINT [PK_ThanhToans] PRIMARY KEY CLUSTERED 
(
	[ThanhToanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrangThais]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThais](
	[TrangThaiID] [int] IDENTITY(1,1) NOT NULL,
	[TenTrangThai] [nvarchar](max) NULL,
 CONSTRAINT [PK_TrangThais] PRIMARY KEY CLUSTERED 
(
	[TrangThaiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VanChuyens]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VanChuyens](
	[VanChuyenID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
 CONSTRAINT [PK_VanChuyens] PRIMARY KEY CLUSTERED 
(
	[VanChuyenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yeutthichs]    Script Date: 12/19/2018 11:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yeutthichs](
	[YeuThichID] [int] IDENTITY(1,1) NOT NULL,
	[NguoiDungID] [int] NOT NULL,
	[HangHoaID] [int] NOT NULL,
	[NgayChon] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Yeutthichs] PRIMARY KEY CLUSTERED 
(
	[YeuThichID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20181206153641_InitialCreate', N'2.1.4-rtm-31024')
SET IDENTITY_INSERT [dbo].[chiTietHds] ON 

INSERT [dbo].[chiTietHds] ([ChiTietHdID], [HoaDonID], [HangHoaID], [DonGia], [SoLuong], [GiamGia]) VALUES (1, 2, 8, 5000, 3, 0)
SET IDENTITY_INSERT [dbo].[chiTietHds] OFF
SET IDENTITY_INSERT [dbo].[GioiTinhs] ON 

INSERT [dbo].[GioiTinhs] ([GioiTinhID], [TenGT]) VALUES (1, N'Nam')
INSERT [dbo].[GioiTinhs] ([GioiTinhID], [TenGT]) VALUES (2, N'Nữ')
INSERT [dbo].[GioiTinhs] ([GioiTinhID], [TenGT]) VALUES (3, N'GtThứ 3')
SET IDENTITY_INSERT [dbo].[GioiTinhs] OFF
SET IDENTITY_INSERT [dbo].[HangHoas] ON 

INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (8, N'Tủ lạnh Sanyo 165 lít', 1, 5000, N't1.jpg', 1, CAST(0x0700EACB257EF33D0B AS DateTime2), N'Hệ thống đèn UV LED bảo quản thực phẩm tốt hơn nhờ khả năng diệt khuẩn cao', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (9, N'Tủ lạnh Panasonic Inverter 255 lít ', 1, 9500, N't2.jpg', 2, CAST(0x07003C44A075133E0B AS DateTime2), N'Công nghệ kháng khuẩn Ag Clean loại bỏ mùi hôi và vi khuẩn gây hại cho thực phẩm.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (10, N'Tủ lạnh LG Inverter 209 lít', 1, 6200, N't3.jpg', 3, CAST(0x0700EACB257E313E0B AS DateTime2), N'Hệ thống khí lạnh đa chiều giúp làm lạnh thực phẩm.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (11, N'Tủ lạnh LG Inverter 393 lít', 1, 14300, N't4.jpg', 3, CAST(0x070046DB308F323E0B AS DateTime2), N'Công nghệ làm lạnh từ cửa tủ DoorCooling.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (12, N'Tủ lạnh Samsung Inverter 538 lít ', 1, 19000, N't5.jpg', 5, CAST(0x070046DB308F323E0B AS DateTime2), N'Tiện lợi với thiết kế lấy nước bên ngoài', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (13, N'Tủ lạnh Samsung Inverter 208 lít', 1, 6300, N't6.jpg', 5, CAST(0x070066A69B2A323E0B AS DateTime2), N'Giải pháp giữ lạnh vô cùng hoàn hảo khi mất điện với tấm CoolPack', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (14, N'Tủ lạnh Panasonic Inverter 152 lít', 1, 5800, N't7.jpg', 2, CAST(0x0700B4856B78F33D0B AS DateTime2), N'Kháng khuẩn, khử mùi tối ưu với tinh thể bạc Ag+.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (15, N'Tủ lạnh Hitachi Inverter 584 lít', 1, 48000, N't8.jpg', 6, CAST(0x0700B81E1622133E0B AS DateTime2), N'Món ăn vặt ưa thích, thích hợp tiêu dùng hoặc làm quà tặng.Được sản xuất từ ở Việt Nam. Hương vị tự nhiên, độ ngọt vừa phải.An toàn vệ sinh, không chất bảo quản', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (16, N'Tủ lạnh Toshiba Inverter 600 lít', 1, 18000, N't9.jpg', 4, CAST(0x07009853AB86323E0B AS DateTime2), N'Sử dụng công nghệ Inverter tiết kiệm đến 40% điện năng tiêu thụ.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (17, N'
Tủ lạnh Hitachi Inverter 587 lít', 1, 39000, N't10.jpg', 6, CAST(0x07003C44A075D63D0B AS DateTime2), N'Cảm biến nhiệt ECO.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (18, N'Smart Tivi Panasonic 32 inch', 3, 7000, N'tv1.jpg', 3, CAST(0x0700EACB257E133E0B AS DateTime2), N'Công nghệ HDR cho hình ảnh chân thực, rõ nét.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (19, N'Smart Tivi Panasonic 4K 49 inch', 3, 15000, N'tv2.jpg', 3, CAST(0x0700EACB257E913E0B AS DateTime2), N'Độ phân giải 4K gấp 4 lần Full HD cho hình ảnh cực kỳ sắc nét.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (20, N'Smart Tivi Samsung 49 inch', 3, 11000, N'tv3.jpg', 5, CAST(0x0700E0349564B13E0B AS DateTime2), N'Công nghệ Wide Color Enhancer nâng cấp độ sâu hình ảnh, cho hình ảnh có chiều sâu ấn tượng.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (21, N'Smart Tivi Samsung 4K 50 inch', 3, 16000, N'tv4.jpg', 5, CAST(0x07009853AB86323E0B AS DateTime2), N'Công nghệ Dynamic Crystal Color giúp bạn đắm chìm vào thế giới hình ảnh trong trẻo, tự nhiên.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (22, N'Smart Tivi Samsung 4K 55 inch', 3, 22000, N'tv5.jpg', 5, CAST(0x07009853AB86323E0B AS DateTime2), N'Công nghệ UHD Dimming tăng cường độ tương phản, cho hình ảnh chân thực đến từng chi tiết.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (23, N'Smart Tivi LG 49 inch', 3, 9000, N'tv6.jpg', 3, CAST(0x07009853AB86133E0B AS DateTime2), N'Hệ điều hành Web OS thân thiện, dễ sử dụng, nhiều ứng dụng ', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (24, N'Smart Tivi LG 4K 55 inch', 3, 22000, N'tv7.jpg', 3, CAST(0x070046DB308FF33D0B AS DateTime2), N'Công nghệ Active HDR và HDR Effect cho hình ảnh chân thật từng chi tiết.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (25, N'Smart Tivi LG 4K 65 inch', 3, 37000, N'tv8.jpg', 3, CAST(0x0700EACB257EF33D0B AS DateTime2), N'Công nghệ âm thanh DTS Virtual:X mang đến âm thanh vòm sống động mạnh mẽ.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (26, N'Smart Tivi Toshiba 4K 55 inch', 3, 14000, N'tv9.jpg', 4, CAST(0x0700EACB257E133E0B AS DateTime2), N'Công nghệ hình ảnh:Công nghệ Color Re-master PRO, Công nghệ Super Contrast Booster, Chức năng Contrast Booster, Picture Optimizer', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (27, N'Smart Tivi Samsung 55 inch', 3, 14000, N'tv10.jpg', 5, CAST(0x0700EACB257E133E0B AS DateTime2), N'Công nghệ PurColor giúp tái hiện những khung hình rực rỡ, sinh động.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (28, N'Nồi cơm điện Sanyo 1 lít', 4, 20000, N'ncd1.jpg', 1, CAST(0x07009853AB86133E0B AS DateTime2), N'Một mâm nhiệt lớn, phẳng, nấu cơm chín nhanh, đều.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (29, N'Nồi cơm điện tử Toshiba 1.8 lít', 4, 2600, N'ncd2.jpg', 4, CAST(0x0700EACB257E133E0B AS DateTime2), N'Lòng nồi bằng hợp kim nhôm tráng chống dính Diamond Titanium bền bỉ.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (30, N'Nồi cơm điện Toshiba

Nồi cơm điện cao tần Toshiba 1 lít', 4, 5100, N'ncd3.jpg', 4, CAST(0x0700EACB257E1E400B AS DateTime2), N'Nồi cơm điện cao tần dung tích 1 lít nhỏ gọn cho gia đình 2 – 4 người.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (31, N'Nồi cơm điện cao tần Toshiba 1.8 lít', 4, 5500, N'ncd4.jpg', 4, CAST(0x0700EACB257E323E0B AS DateTime2), N'Công suất nồi cơm điện lớn tới 1200 W cùng công nghệ cao tần cho cơm chín thơm ngon.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (32, N'Nồi cơm điện tử Hitachi 1.8 lít', 4, 2800, N'ncd5.jpg', 6, CAST(0x0700EACB257E323E0B AS DateTime2), N'Thiết kế màu sắc nhã nhặn, bảng điều khiển điện tử dễ sử dụng.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (33, N'Nồi cơm điện tử Hitachi 1.8 lít', 4, 3800, N'ncd6.jpg', 6, CAST(0x07008672B88A323E0B AS DateTime2), N'Phù Hợp Cho Nhiều Giống Mèo Ở Độ Tuổi Khác Nhau. Thơm Ngon Và Giàu Dinh Dưỡng! Khuyến mãi thường xuyên. Miễn phí vận chuyển. Đổi trả hàng 30 ngày. Hội tụ thương hiệu uy tín', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (34, N'Nồi cơm điện tử Hitachi 1.8 lít', 4, 8000, N'ncd7.jpg', 6, CAST(0x070052908786133E0B AS DateTime2), N'Lòng nồi hợp kim nhôm phủ chống dính an toàn, dày bền, tiện làm sạch.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (35, N'Nồi cơm điện tử Sharp 1.5 lít', 4, 570, N'ncd8.jpg', 7, CAST(0x0700EACB257E323E0B AS DateTime2), N'Có 1 mâm nhiệt, công suất 530 W, nấu cơm chín nhanh, ngon, ít tốn điện.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (36, N'

Nồi cơm điện tử Sharp 2.2 lít', 4, 1630, N'ncd9.jpg', 7, CAST(0x07003C44A075B13E0B AS DateTime2), N'Lòng nồi cơm điện Sharp bằng hợp kim nhôm chống dính bền, tiện vệ sinh.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (37, N'Nồi cơm điện tử Sharp 1.8 lít', 4, 2040, N'ncd10.jpg', 7, CAST(0x0700EACB257E7BBE0B AS DateTime2), N'Nồi cơm điện nắp gài có 2 mâm nhiệt hiện đại cho cơm chín đều, thơm ngon.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (38, N'Máy giặt Samsung Inverter 8 kg', 5, 8000, N'mg1.jpg', 5, CAST(0x0700EACB257E7BBE0B AS DateTime2), N'Công nghệ Eco Bubble hạn chế cặn bột giặt bám vào quần áo.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (39, N'Máy giặt Samsung

Máy giặt Samsung AddWash Inverter 8 kg', 5, 10000, N'mg2.jpg', 5, CAST(0x07001EAE5682803F0B AS DateTime2), N'Cửa phụ Add Door thêm đồ khi giặt, không lo sót quần áo.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (40, N'Máy giặt Samsung Add Wash Inverter 17 kg', 5, 29000, N'mg3.jpg', 5, CAST(0x0700EACB257E133E0B AS DateTime2), N'Công nghệ Stream Cycles sử dụng hơi nước nhiệt độ cao loại bỏ vi khuẩn, tác nhân gây dị ứng.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (41, N'Máy giặt Hitachi 9.5 Kg ', 5, 7000, N'mg4.jpg', 6, CAST(0x0700EACB257E133E0B AS DateTime2), N'Công nghệ Beat Wave Wash giặt mạnh mẽ, nhanh chóng làm sạch quần áo.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (42, N'Máy giặt sấy Hitachi 10.5 kg', 5, 8000, N'mg5.jpg', 6, CAST(0x0700EACB257E323E0B AS DateTime2), N'Sấy khô bằng nhiệt tái sinh – Heat Recycle.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (43, N'Máy giặt Hitachi 13 kg ', 5, 10000, N'mg6.jpg', 6, CAST(0x0700EACB257E133E0B AS DateTime2), N'Động cơ Smart Drive Inverter thông minh và tiết kiệm điện.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (44, N'Máy giặt LG Inverter 9 Kg', 5, 6000, N'mg7.jpg', 3, CAST(0x07000A979019323E0B AS DateTime2), N'Mực ống Hải Nam được đánh bắt từ những con mực ống Phan Thiết có kích thước nhỏ vừa ăn và dễ dàng chế biến thành nhiều món ăn ngon. Mực ống nguyên con được làm sạch và bảo quản đông lạnh không chỉ tiện dụng cho người nội trợ mà chất lượng mực vẫn giữ được độ tươi và ngọt thịt tự nhiên của mực ống.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (45, N'Máy giặt sấy LG Inverter 9kg', 5, 18000, N'mg8.jpg', 3, CAST(0x0700EACB257E133E0B AS DateTime2), N'Sản phẩm không chất kháng sinh, không chất tạo màu, không chất tăng trưởng. Thơm ngon và hấp dẫn. Sản phẩm được đóng khay nhỏ gọn, tiện lợi khi sử dụng và bảo quản.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (46, N'Máy giặt LG Inverter 9 kg', 5, 12000, N'mg9.jpg', 3, CAST(0x0700EACB257E133E0B AS DateTime2), N'Công nghệ giặt TurboWash - 3 tiết kiệm: tiết kiệm điện, tiết kiệm nước, tiết kiệm thời gian.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (47, N'Máy giặt LG Inverter 12 kg', 5, 13500, N'mg10.jpg', 3, CAST(0x0700EACB257E133E0B AS DateTime2), N'Sản phẩm không chất kháng sinh, không chất tạo màu, không chất tăng trưởng. Thơm ngon và hấp dẫn. Sản phẩm được đóng khay nhỏ gọn, tiện lợi khi sử dụng và bảo quản.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (49, N'Bàn ủi hơi nước Panasonic', 6, 8200, N'bu1.jpg', 2, CAST(0x0700EACB257E133E0B AS DateTime2), N'Mặt đế bàn ủi phủ lớp chống dính Titanium trượt êm ái trên mọi chất liệu vải.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (50, N'Bàn ủi hơi nước Panasonic', 6, 10000, N'bu2.jpg', 2, CAST(0x0700EACB257E133E0B AS DateTime2), N'Công suất 2150 W tạo độ nóng nhanh, ủi thẳng nếp nhăn.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (51, N'
Bàn ủi hơi nước Philips', 6, 13000, N'bu3.jpg', 8, CAST(0x0700EACB257E133E0B AS DateTime2), N'Chế độ chống nhỏ giọt, chống đóng cặn - tự làm sạch giúp quần áo luôn sạch sẽ, bàn ủi bền hơn.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (52, N'

Bàn ủi hơi nước Philips', 6, 28000, N'bu4.jpg', 8, CAST(0x0700EACB257E133E0B AS DateTime2), N'Đa chức năng: Ủi hơi nước, phun tia, phun hơi tăng cường.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (53, N'Bàn ủi hơi nước Philips', 6, 37000, N'bu5.jpg', 8, CAST(0x0700EACB257E133E0B AS DateTime2), N'Mặt đế phủ SteamGlide Advanced chống dính cao cấp lướt nhẹ, êm, bảo vệ mặt vải.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (54, N'Bếp từ Electrolux', 7, 1900, N'bt1.jpg', 9, CAST(0x0700EACB257E133E0B AS DateTime2), N'Mặt bếp điện bằng kính chịu nhiệt, chịu lực chịu nhiệt tốt.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (55, N'Bếp từ Electrolux', 7, 2000, N'bt2.jpg', 9, CAST(0x0700EACB257E133E0B AS DateTime2), N'Mặt bếp bằng kính Ceramic chịu nhiệt không bị biến dạng ở nhiệt độ cao.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (56, N'Bếp từ đôi Electrolux', 7, 20000, N'bt3.jpg', 9, CAST(0x0700EACB257E133E0B AS DateTime2), N'Tính năng kết hợp 4 vùng nấu tiện lợi, tổng công suất 7400 W.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (57, N'Bếp từ Philip', 7, 1200, N'bt4.jpg', 8, CAST(0x0700EACB257E133E0B AS DateTime2), N'Mặt bếp điện được làm từ kính chịu nhiệt sang trọng.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (58, N'Bếp từ Philip', 7, 1400, N'bt5.jpg', 8, CAST(0x0700EACB257E133E0B AS DateTime2), N'Mặt bếp điện bằng kính chịu nhiệt sáng bóng, tiện cho việc vệ sinh.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (63, N'Balo Katan', 9, 500, N'balo1.jpg', 10, CAST(0x0700EACB257E133E0B AS DateTime2), N'Phần lưng được may chắc chắn và êm ái', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (64, N'Balo DRed', 9, 600, N'balo2.jpg', 10, CAST(0x0700EACB257E133E0B AS DateTime2), N'Ngăn dắt viết, điện thoại, ngăn đựng laptop riêng biệt với lớp mút PE chống sốc, ngăn lưới đựng adapter, 2 túi hông đựng bình nước ...', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (65, N'Balo Red/Grey', 9, 700, N'balo3.jpg', 10, CAST(0x0700EACB257E133E0B AS DateTime2), N'Phần lưng có lớp lưới Air Mesh thoát hơi nh', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (66, N'Balo Little America', 9, 2300, N'balo4.jpg', 11, CAST(0x0700EACB257E133E0B AS DateTime2), N'Đóng dây đeo từ nam châm với kẹp kim loại', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (67, N'Balo Mammoth', 9, 2500, N'balo5.jpg', 11, CAST(0x0700EACB257E133E0B AS DateTime2), N'Lớp phủ chống nước 1.500mm', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (68, N'Balo Retreat', 9, 1800, N'balo6.jpg', 11, CAST(0x0700EACB257E133E0B AS DateTime2), N'Sắp xếp hợp lý của phong cách leo núi cổ điển, với đóng cửa dây rút và nắp trên cùng chi tiết dây đeo.', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (69, N'Balo Superbreak', 9, 1000, N'balo7.jpg', 12, CAST(0x0700EACB257E133E0B AS DateTime2), N'Túi tiện ích phía trước có tổ chức', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (70, N'Balo Hatchet', 9, 2000, N'balo8.jpg', 12, CAST(0x0700EACB257E133E0B AS DateTime2), N'Túi lưới có khóa kéo bên trong', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (71, N'Balo Cool Student', 9, 1500, N'balo9.jpg', 12, CAST(0x0700EACB257E133E0B AS DateTime2), N'Đáy và da tổng hợp cao cấp', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (72, N'Balo Baughman', 9, 2000, N'balo10.jpg', 12, CAST(0x0700EACB257E133E0B AS DateTime2), N'Một ngăn chính lớn', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (73, N'Nón Rampart ', 8, 2500, N'n1.jpg', 13, CAST(0x0700EACB257E133E0B AS DateTime2), N'Có dây đeo bằng da màu trắng với ruy băng dệt hoa văn phía tây nam và một chiếc ghim nhỏ', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (74, N'Nón Cowpuncher ', 8, 2800, N'n2.jpg', 13, CAST(0x0700EACB257E133E0B AS DateTime2), N'Có một dải grosgrain và ràng buộc vành, được tạo điểm nhấn bằng concho ngôi sao lớn bằng đồng cổ, và một chiếc ghim nhỏ bằng bạc', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (75, N'Nón Groves', 8, 1200, N'n3.jpg', 13, CAST(0x0700EACB257E133E0B AS DateTime2), N'Lấy cảm hứng từ các thiết kế kẻ sọc ngoài trời và được xây dựng trong vải pha len', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (76, N'Nón Dean', 8, 2500, N'n4.jpg', 14, CAST(0x0700EACB257E133E0B AS DateTime2), N'Mỗi chiếc mũ được nhuộm riêng để không có hai chiếc nào giống nhau và được hoàn thành với một chiếc băng đô bằng da. Chụp vành rộng lên hoặc xuống để phù hợp với phong cách cá nhân', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (77, N'Nón Beret Christina', 8, 1400, N'n5.jpg', 14, CAST(0x0700EACB257E133E0B AS DateTime2), N'Thiết yếu được cập nhật mới cho mùa giải với việc bổ sung vàn', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (78, N'Nón Yankees', 8, 1000, N'n6.jpg', 15, CAST(0x0700EACB257E133E0B AS DateTime2), N'Logo Yankees ở mặt trước', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (79, N'Nón CoD', 8, 1100, N'n7.jpg', 15, CAST(0x0700EACB257E133E0B AS DateTime2), N'Kết hợp độc đáo giữa kim loại và thêu thể hiện CoD ', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (80, N'Giày Classic Cortez', 10, 2500, N'g1.jpg', 16, CAST(0x0700EACB257E133E0B AS DateTime2), N'Cao su đế ngoài với rãnh xương cá để dừng và đi lực kéo', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (81, N'Giày Juvenate Sneaker', 10, 3000, N'g2.jpg', 16, CAST(0x0700EACB257E133E0B AS DateTime2), N'Đóng mở hoàn toàn trên và gót chân để đóng gói dễ dàng', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (82, N'Giày Air Zoom Pegasus', 10, 1400, N'g3.jpg', 16, CAST(0x0700EACB257E133E0B AS DateTime2), N'Phản xạ tốt ở gót chân', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (83, N'Giày Barricade', 10, 2000, N'g4.jpg', 17, CAST(0x0700EACB257E133E0B AS DateTime2), N'Phía trên được thiết kế với các khu vực hỗ trợ và kéo dài', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (84, N'Giày Alphabounce', 10, 2000, N'g5.jpg', 17, CAST(0x0700EACB257E133E0B AS DateTime2), N'Cung cấp sự thoải mái tràn đầy năng lượng cho tất cả các môn thể thao, cả ngày', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (85, N'Giày Flashtrek', 10, 3000, N'g6.jpg', 18, CAST(0x0700EACB257E133E0B AS DateTime2), N'Lấy cảm hứng từ thế giới đi bộ đường dài và được thiết kế với đế có hình dạng quá khổ', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (86, N'Giày Black leather', 10, 3000, N'g7.jpg', 18, CAST(0x0700EACB257E133E0B AS DateTime2), N'Giày này đi kèm với hai bộ dây buộc; một màu đỏ và một màu trắng', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (87, N'Áo Dragon tartan', 11, 2000, N'a1.jpg', 18, CAST(0x0700EACB257E133E0B AS DateTime2), N'Thêu hoa và rồng ', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (88, N'Áo Oversize cotton', 11, 2000, N'a2.jpg', 18, CAST(0x0700EACB257E133E0B AS DateTime2), N'Túi vá phía trước', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (89, N'Áo Panther', 11, 2000, N'a3.jpg', 18, CAST(0x0700EACB257E133E0B AS DateTime2), N'100% lụa', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (90, N'Áo Interlocking', 11, 2000, N'a4.jpg', 18, CAST(0x0700EACB257E133E0B AS DateTime2), N'Có hiệu ứng nhăn', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (91, N'Áo Mouth', 11, 2000, N'a5.jpg', 18, CAST(0x0700EACB257E133E0B AS DateTime2), N'100% lụa', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (92, N'Quần Wool canvas ', 12, 1800, N'q1.jpg', 18, CAST(0x0700EACB257E133E0B AS DateTime2), N'Có móc và khóa kéo', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (93, N'Quần Gabardine', 12, 1800, N'q2.jpg', 18, CAST(0x0700EACB257E133E0B AS DateTime2), N'Có túi nắp phía sau', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (94, N'Quần NY Yankees', 12, 1800, N'q3.jpg', 18, CAST(0x0700EACB257E133E0B AS DateTime2), N'Màu xanh và đỏ xuống chân', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (95, N'Quần Nylon shorts', 12, 1500, N'q4.jpg', 18, CAST(0x0700EACB257E133E0B AS DateTime2), N'Túi xiên trước', 0, 1)
INSERT [dbo].[HangHoas] ([HanghoaID], [TenHh], [MaLoaiID], [DonGia], [Hinh], [NhaCungCapID], [NgayNhap], [MoTa], [GiamGia], [LuotMua]) VALUES (96, N'Quần Flora', 12, 1500, N'q5.jpg', 18, CAST(0x0700EACB257E133E0B AS DateTime2), N'Thắt lưng thun có khóa tự buộc', 0, 1)
SET IDENTITY_INSERT [dbo].[HangHoas] OFF
SET IDENTITY_INSERT [dbo].[hoaDons] ON 

INSERT [dbo].[hoaDons] ([HoaDonID], [NguoiDungID], [NgayDat], [NgayNhan], [HoTen], [DiaChi], [ThanhToanID], [VanChuyenID], [PhiVanChuyen], [TrangThaiID], [GhiChu]) VALUES (2, 1, CAST(0x07EC20557EC0163F0B AS DateTime2), CAST(0x07EC20557EC0163F0B AS DateTime2), N'0', NULL, 1, 1, 0, 1, NULL)
SET IDENTITY_INSERT [dbo].[hoaDons] OFF
SET IDENTITY_INSERT [dbo].[LoaiNgDungs] ON 

INSERT [dbo].[LoaiNgDungs] ([LoaiNgDungID], [TenLoai]) VALUES (1, N'Admin')
INSERT [dbo].[LoaiNgDungs] ([LoaiNgDungID], [TenLoai]) VALUES (2, N'Anonymous')
INSERT [dbo].[LoaiNgDungs] ([LoaiNgDungID], [TenLoai]) VALUES (3, N'Khách Hàng')
SET IDENTITY_INSERT [dbo].[LoaiNgDungs] OFF
SET IDENTITY_INSERT [dbo].[Loais] ON 

INSERT [dbo].[Loais] ([LoaiID], [TenLoai]) VALUES (1, N'Tủ lạnh')
INSERT [dbo].[Loais] ([LoaiID], [TenLoai]) VALUES (3, N'Tivi')
INSERT [dbo].[Loais] ([LoaiID], [TenLoai]) VALUES (4, N'Nồi cơm điện')
INSERT [dbo].[Loais] ([LoaiID], [TenLoai]) VALUES (5, N'Máy giặt')
INSERT [dbo].[Loais] ([LoaiID], [TenLoai]) VALUES (6, N'Bàn ủi')
INSERT [dbo].[Loais] ([LoaiID], [TenLoai]) VALUES (7, N'Bếp từ')
INSERT [dbo].[Loais] ([LoaiID], [TenLoai]) VALUES (8, N'Nón')
INSERT [dbo].[Loais] ([LoaiID], [TenLoai]) VALUES (9, N'Balo')
INSERT [dbo].[Loais] ([LoaiID], [TenLoai]) VALUES (10, N'Giày')
INSERT [dbo].[Loais] ([LoaiID], [TenLoai]) VALUES (11, N'Áo')
INSERT [dbo].[Loais] ([LoaiID], [TenLoai]) VALUES (12, N'Quần')
SET IDENTITY_INSERT [dbo].[Loais] OFF
SET IDENTITY_INSERT [dbo].[NguoiDungs] ON 

INSERT [dbo].[NguoiDungs] ([NguoiDungID], [HoTen], [GioiTinhID], [NgaySinh], [DiaChi], [SDT], [Email], [Hinh], [LoaiNgDungID], [TenDangNhap], [MatKhau]) VALUES (1, N'Đặng minh cường', 1, CAST(0x07007AD4BC5D9A1C0B AS DateTime2), N'3/4/3 truong tho, Q .thu duc,tphcm', N'0166 460 1255', N'ykdn.128ve980@gmail.com', N'', 1, N'cuongdeptrai', N'thanhcong123')
SET IDENTITY_INSERT [dbo].[NguoiDungs] OFF
SET IDENTITY_INSERT [dbo].[NhaCungCaps] ON 

INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (1, N'Sanyo', N'Nhật Bản', N'090909099', N'sanyo@gmail.com', N'Công ty điện tử')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (2, N'Panasonic', N'Nhật Bản', N'0980990988', N'panasonic@gmail.com', N' Công ty điện tử ')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (3, N'LG', N'Hàn Quốc', N'09876899', N'lg@gmail.com', N' Công ty điện tử ')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (4, N'Toshiba', N'Nhật Bản', N'09889999', N'toshiba@gmail.com', N' Công ty điện tử ')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (5, N'Samsung', N'Hàn Quốc', N'0989900999', N'samsung@gmail.com', N' Công ty điện tử ')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (6, N'Hitachi', N'Nhật Bản', N'0989900999', N'hitachi@gmail.com', N' Công ty điện tử ')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (7, N'Sharp', N'Hàn Quốc', N'0989120999', N'sharp@gmail.com', N' Công ty điện tử ')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (8, N'Philips', N'Hà Lan', N'0942120999', N'philips@gmail.com', N' Công ty điện tử ')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (9, N'Electrolux', N'Thụy Sĩ', N'0942120677', N'electrolux@gmail', N' Công ty điện tử ')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (10, N'Simplecarry', N'Mỹ', N'09231235663', N'simplecarry@gmail.com', N'Hãng Balo')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (11, N'Herschel', N'Canada', N'09372194583', N'herschel@gmail.com', N'Hãng Balo')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (12, N'Jansport', N'Mỹ', N'01293487734', N'jansport@gmail.com', N'Hãng Balo')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (13, N'Bailey', N'Mỹ', N'09847294871', N'bailey@gmail.com', N'Hãng nón')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (14, N'Goorin', N'Mỹ', N'09847294821', N'goorin@gmail.com', N'Hãng nón')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (15, N'NewEra', N'Mỹ', N'03447294871', N'newera@gmail.com', N'Hãng nón')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (16, N'Nike', N'Mỹ', N'03437294871', N'nike@gmail.com', N'Hãng giày')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (17, N'Adidas', N'Đức', N'03247294871', N'adidas@gmail.com', N'Hãng giày')
INSERT [dbo].[NhaCungCaps] ([NhaCungCapID], [TenNhaCc], [DiaChi], [SDT], [Email], [MoTa]) VALUES (18, N'Gucci', N'Ý', N'09247294871', N'gucci@gmail.com', N'Hãng thời trang')
SET IDENTITY_INSERT [dbo].[NhaCungCaps] OFF
SET IDENTITY_INSERT [dbo].[ThanhToans] ON 

INSERT [dbo].[ThanhToans] ([ThanhToanID], [Ten]) VALUES (1, N'Khi Nhận Hàng')
INSERT [dbo].[ThanhToans] ([ThanhToanID], [Ten]) VALUES (2, N'Tại cửa hàng')
SET IDENTITY_INSERT [dbo].[ThanhToans] OFF
SET IDENTITY_INSERT [dbo].[TrangThais] ON 

INSERT [dbo].[TrangThais] ([TrangThaiID], [TenTrangThai]) VALUES (1, N'Đang Chon')
INSERT [dbo].[TrangThais] ([TrangThaiID], [TenTrangThai]) VALUES (2, N'Đã Xong')
INSERT [dbo].[TrangThais] ([TrangThaiID], [TenTrangThai]) VALUES (3, N'Chờ thanh toán')
INSERT [dbo].[TrangThais] ([TrangThaiID], [TenTrangThai]) VALUES (4, N'Đã thanh toán')
INSERT [dbo].[TrangThais] ([TrangThaiID], [TenTrangThai]) VALUES (5, N'Chưa thanh toán')
SET IDENTITY_INSERT [dbo].[TrangThais] OFF
SET IDENTITY_INSERT [dbo].[VanChuyens] ON 

INSERT [dbo].[VanChuyens] ([VanChuyenID], [Ten]) VALUES (1, N'Nhanh')
INSERT [dbo].[VanChuyens] ([VanChuyenID], [Ten]) VALUES (2, N'Theo thứ tự')
INSERT [dbo].[VanChuyens] ([VanChuyenID], [Ten]) VALUES (3, N'Chậm')
SET IDENTITY_INSERT [dbo].[VanChuyens] OFF
/****** Object:  Index [IX_BinhLuans_HangHoaID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_BinhLuans_HangHoaID] ON [dbo].[BinhLuans]
(
	[HangHoaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BinhLuans_NguoiDungID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_BinhLuans_NguoiDungID] ON [dbo].[BinhLuans]
(
	[NguoiDungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_chiTietHds_HangHoaID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_chiTietHds_HangHoaID] ON [dbo].[chiTietHds]
(
	[HangHoaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_chiTietHds_HoaDonID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_chiTietHds_HoaDonID] ON [dbo].[chiTietHds]
(
	[HoaDonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HangHoas_MaLoaiID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_HangHoas_MaLoaiID] ON [dbo].[HangHoas]
(
	[MaLoaiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HangHoas_NhaCungCapID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_HangHoas_NhaCungCapID] ON [dbo].[HangHoas]
(
	[NhaCungCapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_hoaDons_NguoiDungID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_hoaDons_NguoiDungID] ON [dbo].[hoaDons]
(
	[NguoiDungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_hoaDons_ThanhToanID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_hoaDons_ThanhToanID] ON [dbo].[hoaDons]
(
	[ThanhToanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_hoaDons_TrangThaiID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_hoaDons_TrangThaiID] ON [dbo].[hoaDons]
(
	[TrangThaiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_hoaDons_VanChuyenID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_hoaDons_VanChuyenID] ON [dbo].[hoaDons]
(
	[VanChuyenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NguoiDungs_GioiTinhID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_NguoiDungs_GioiTinhID] ON [dbo].[NguoiDungs]
(
	[GioiTinhID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NguoiDungs_LoaiNgDungID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_NguoiDungs_LoaiNgDungID] ON [dbo].[NguoiDungs]
(
	[LoaiNgDungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Yeutthichs_HangHoaID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_Yeutthichs_HangHoaID] ON [dbo].[Yeutthichs]
(
	[HangHoaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Yeutthichs_NguoiDungID]    Script Date: 12/19/2018 11:05:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_Yeutthichs_NguoiDungID] ON [dbo].[Yeutthichs]
(
	[NguoiDungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BinhLuans]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuans_HangHoas_HangHoaID] FOREIGN KEY([HangHoaID])
REFERENCES [dbo].[HangHoas] ([HanghoaID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BinhLuans] CHECK CONSTRAINT [FK_BinhLuans_HangHoas_HangHoaID]
GO
ALTER TABLE [dbo].[BinhLuans]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuans_NguoiDungs_NguoiDungID] FOREIGN KEY([NguoiDungID])
REFERENCES [dbo].[NguoiDungs] ([NguoiDungID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BinhLuans] CHECK CONSTRAINT [FK_BinhLuans_NguoiDungs_NguoiDungID]
GO
ALTER TABLE [dbo].[chiTietHds]  WITH CHECK ADD  CONSTRAINT [FK_chiTietHds_HangHoas_HangHoaID] FOREIGN KEY([HangHoaID])
REFERENCES [dbo].[HangHoas] ([HanghoaID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[chiTietHds] CHECK CONSTRAINT [FK_chiTietHds_HangHoas_HangHoaID]
GO
ALTER TABLE [dbo].[chiTietHds]  WITH CHECK ADD  CONSTRAINT [FK_chiTietHds_hoaDons_HoaDonID] FOREIGN KEY([HoaDonID])
REFERENCES [dbo].[hoaDons] ([HoaDonID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[chiTietHds] CHECK CONSTRAINT [FK_chiTietHds_hoaDons_HoaDonID]
GO
ALTER TABLE [dbo].[HangHoas]  WITH CHECK ADD  CONSTRAINT [FK_HangHoas_Loais_MaLoaiID] FOREIGN KEY([MaLoaiID])
REFERENCES [dbo].[Loais] ([LoaiID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HangHoas] CHECK CONSTRAINT [FK_HangHoas_Loais_MaLoaiID]
GO
ALTER TABLE [dbo].[HangHoas]  WITH CHECK ADD  CONSTRAINT [FK_HangHoas_NhaCungCaps_NhaCungCapID] FOREIGN KEY([NhaCungCapID])
REFERENCES [dbo].[NhaCungCaps] ([NhaCungCapID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HangHoas] CHECK CONSTRAINT [FK_HangHoas_NhaCungCaps_NhaCungCapID]
GO
ALTER TABLE [dbo].[hoaDons]  WITH CHECK ADD  CONSTRAINT [FK_hoaDons_NguoiDungs_NguoiDungID] FOREIGN KEY([NguoiDungID])
REFERENCES [dbo].[NguoiDungs] ([NguoiDungID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[hoaDons] CHECK CONSTRAINT [FK_hoaDons_NguoiDungs_NguoiDungID]
GO
ALTER TABLE [dbo].[hoaDons]  WITH CHECK ADD  CONSTRAINT [FK_hoaDons_ThanhToans_ThanhToanID] FOREIGN KEY([ThanhToanID])
REFERENCES [dbo].[ThanhToans] ([ThanhToanID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[hoaDons] CHECK CONSTRAINT [FK_hoaDons_ThanhToans_ThanhToanID]
GO
ALTER TABLE [dbo].[hoaDons]  WITH CHECK ADD  CONSTRAINT [FK_hoaDons_TrangThais_TrangThaiID] FOREIGN KEY([TrangThaiID])
REFERENCES [dbo].[TrangThais] ([TrangThaiID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[hoaDons] CHECK CONSTRAINT [FK_hoaDons_TrangThais_TrangThaiID]
GO
ALTER TABLE [dbo].[hoaDons]  WITH CHECK ADD  CONSTRAINT [FK_hoaDons_VanChuyens_VanChuyenID] FOREIGN KEY([VanChuyenID])
REFERENCES [dbo].[VanChuyens] ([VanChuyenID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[hoaDons] CHECK CONSTRAINT [FK_hoaDons_VanChuyens_VanChuyenID]
GO
ALTER TABLE [dbo].[NguoiDungs]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDungs_GioiTinhs_GioiTinhID] FOREIGN KEY([GioiTinhID])
REFERENCES [dbo].[GioiTinhs] ([GioiTinhID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NguoiDungs] CHECK CONSTRAINT [FK_NguoiDungs_GioiTinhs_GioiTinhID]
GO
ALTER TABLE [dbo].[NguoiDungs]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDungs_LoaiNgDungs_LoaiNgDungID] FOREIGN KEY([LoaiNgDungID])
REFERENCES [dbo].[LoaiNgDungs] ([LoaiNgDungID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NguoiDungs] CHECK CONSTRAINT [FK_NguoiDungs_LoaiNgDungs_LoaiNgDungID]
GO
ALTER TABLE [dbo].[Yeutthichs]  WITH CHECK ADD  CONSTRAINT [FK_Yeutthichs_HangHoas_HangHoaID] FOREIGN KEY([HangHoaID])
REFERENCES [dbo].[HangHoas] ([HanghoaID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Yeutthichs] CHECK CONSTRAINT [FK_Yeutthichs_HangHoas_HangHoaID]
GO
ALTER TABLE [dbo].[Yeutthichs]  WITH CHECK ADD  CONSTRAINT [FK_Yeutthichs_NguoiDungs_NguoiDungID] FOREIGN KEY([NguoiDungID])
REFERENCES [dbo].[NguoiDungs] ([NguoiDungID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Yeutthichs] CHECK CONSTRAINT [FK_Yeutthichs_NguoiDungs_NguoiDungID]
GO
USE [master]
GO
ALTER DATABASE [DbCKteam30] SET  READ_WRITE 
GO
