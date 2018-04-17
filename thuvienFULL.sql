USE [master]
GO
/****** Object:  Database [quan ly thu vien]    Script Date: 4/17/2018 11:01:46 PM ******/
CREATE DATABASE [quan ly thu vien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'quan ly thu vien', FILENAME = N'E:\SQLServerMS\MSSQL13.SQLEXPRESS\MSSQL\DATA\quan ly thu vien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'quan ly thu vien_log', FILENAME = N'E:\SQLServerMS\MSSQL13.SQLEXPRESS\MSSQL\DATA\quan ly thu vien_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [quan ly thu vien] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quan ly thu vien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quan ly thu vien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [quan ly thu vien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [quan ly thu vien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [quan ly thu vien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [quan ly thu vien] SET ARITHABORT OFF 
GO
ALTER DATABASE [quan ly thu vien] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [quan ly thu vien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [quan ly thu vien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [quan ly thu vien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [quan ly thu vien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [quan ly thu vien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [quan ly thu vien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [quan ly thu vien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [quan ly thu vien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [quan ly thu vien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [quan ly thu vien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [quan ly thu vien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [quan ly thu vien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [quan ly thu vien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [quan ly thu vien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [quan ly thu vien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [quan ly thu vien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [quan ly thu vien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [quan ly thu vien] SET  MULTI_USER 
GO
ALTER DATABASE [quan ly thu vien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [quan ly thu vien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [quan ly thu vien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [quan ly thu vien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [quan ly thu vien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [quan ly thu vien] SET QUERY_STORE = OFF
GO
USE [quan ly thu vien]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [quan ly thu vien]
GO
/****** Object:  UserDefinedTableType [dbo].[ListSachMuon]    Script Date: 4/17/2018 11:01:47 PM ******/
CREATE TYPE [dbo].[ListSachMuon] AS TABLE(
	[TTMuonTra_ID] [varchar](20) NULL,
	[SachID] [varchar](20) NULL
)
GO
/****** Object:  Table [dbo].[Account]    Script Date: 4/17/2018 11:01:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](100) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DauSach]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DauSach](
	[DauSach_ID] [varchar](20) NOT NULL,
	[Sach_ten] [nvarchar](40) NULL,
	[TacGia_ID] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DauSach_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[DocGia_ID] [varchar](20) NOT NULL,
	[DocGia_ten] [nvarchar](40) NULL,
	[DocGia_ngaysinh] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[DocGia_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[Sach_ID] [varchar](20) NOT NULL,
	[DauSach_ID] [varchar](20) NOT NULL,
	[TrangThaiMuon] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sach_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SachMuon]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SachMuon](
	[TTMuonTra_ID] [varchar](20) NOT NULL,
	[Sach_ID] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[TacGia_ID] [varchar](20) NOT NULL,
	[TacGia_ten] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[TacGia_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTMuonTra]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTMuonTra](
	[TTMuonTra_ID] [varchar](20) NOT NULL,
	[DocGia_ID] [varchar](20) NOT NULL,
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[TTMuonTra_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([id], [DisplayName], [UserName], [PassWord], [Type]) VALUES (1, N'Admin', N'Admin', N'1', 1)
INSERT [dbo].[Account] ([id], [DisplayName], [UserName], [PassWord], [Type]) VALUES (2, N'user1', N'user1', N'1', 0)
SET IDENTITY_INSERT [dbo].[Account] OFF
INSERT [dbo].[DauSach] ([DauSach_ID], [Sach_ten], [TacGia_ID]) VALUES (N'0000', N'Linh Vũ Thiên Hạ', N'00001')
INSERT [dbo].[DauSach] ([DauSach_ID], [Sach_ten], [TacGia_ID]) VALUES (N'0001', N'Đấu Phá Thương Khung', N'00002')
INSERT [dbo].[DocGia] ([DocGia_ID], [DocGia_ten], [DocGia_ngaysinh]) VALUES (N'1', N'Đặng Đức Trung', CAST(N'2018-04-15' AS Date))
INSERT [dbo].[DocGia] ([DocGia_ID], [DocGia_ten], [DocGia_ngaysinh]) VALUES (N'2', N'Phạm Hồng Sơn', CAST(N'2018-04-18' AS Date))
INSERT [dbo].[DocGia] ([DocGia_ID], [DocGia_ten], [DocGia_ngaysinh]) VALUES (N'3', N'Tiến CHung', CAST(N'2018-04-15' AS Date))
INSERT [dbo].[Sach] ([Sach_ID], [DauSach_ID], [TrangThaiMuon]) VALUES (N'00000000', N'0000', 0)
INSERT [dbo].[Sach] ([Sach_ID], [DauSach_ID], [TrangThaiMuon]) VALUES (N'00000001', N'0000', 0)
INSERT [dbo].[Sach] ([Sach_ID], [DauSach_ID], [TrangThaiMuon]) VALUES (N'00000002', N'0000', 0)
INSERT [dbo].[Sach] ([Sach_ID], [DauSach_ID], [TrangThaiMuon]) VALUES (N'00000003', N'0000', 0)
INSERT [dbo].[Sach] ([Sach_ID], [DauSach_ID], [TrangThaiMuon]) VALUES (N'00000004', N'0000', 0)
INSERT [dbo].[Sach] ([Sach_ID], [DauSach_ID], [TrangThaiMuon]) VALUES (N'00000005', N'0000', 0)
INSERT [dbo].[Sach] ([Sach_ID], [DauSach_ID], [TrangThaiMuon]) VALUES (N'00000006', N'0000', 0)
INSERT [dbo].[Sach] ([Sach_ID], [DauSach_ID], [TrangThaiMuon]) VALUES (N'00000007', N'0000', 0)
INSERT [dbo].[Sach] ([Sach_ID], [DauSach_ID], [TrangThaiMuon]) VALUES (N'00010000', N'0001', 0)
INSERT [dbo].[Sach] ([Sach_ID], [DauSach_ID], [TrangThaiMuon]) VALUES (N'00010001', N'0001', 0)
INSERT [dbo].[Sach] ([Sach_ID], [DauSach_ID], [TrangThaiMuon]) VALUES (N'00010002', N'0001', 0)
INSERT [dbo].[Sach] ([Sach_ID], [DauSach_ID], [TrangThaiMuon]) VALUES (N'00010003', N'0001', 0)
INSERT [dbo].[TacGia] ([TacGia_ID], [TacGia_ten]) VALUES (N'00001', N'Test')
INSERT [dbo].[TacGia] ([TacGia_ID], [TacGia_ten]) VALUES (N'00002', N'Thiên Tằm Thổ Đậu')
INSERT [dbo].[TacGia] ([TacGia_ID], [TacGia_ten]) VALUES (N'00003', N'Thiên Trà Đạm Phạn')
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD FOREIGN KEY([TacGia_ID])
REFERENCES [dbo].[TacGia] ([TacGia_ID])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([DauSach_ID])
REFERENCES [dbo].[DauSach] ([DauSach_ID])
GO
ALTER TABLE [dbo].[SachMuon]  WITH CHECK ADD FOREIGN KEY([Sach_ID])
REFERENCES [dbo].[Sach] ([Sach_ID])
GO
ALTER TABLE [dbo].[SachMuon]  WITH CHECK ADD FOREIGN KEY([TTMuonTra_ID])
REFERENCES [dbo].[TTMuonTra] ([TTMuonTra_ID])
GO
ALTER TABLE [dbo].[TTMuonTra]  WITH CHECK ADD FOREIGN KEY([DocGia_ID])
REFERENCES [dbo].[DocGia] ([DocGia_ID])
GO
/****** Object:  StoredProcedure [dbo].[GetAccountByUserName]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAccountByUserName]
@username NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName=@username
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllBook]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllBook]
as
begin	
	select B.DauSach_ID,B.Sach_ten,A.SL,TacGia.TacGia_ten 
	from DauSach as B
	inner join (select DauSach_ID,count(Sach_ID) as SL from Sach where TrangThaiMuon='False' group by DauSach_ID)as A on B.DauSach_ID = A.DauSach_ID
	inner join TacGia on B.TacGia_ID = TacGia.TacGia_ID
end
GO
/****** Object:  StoredProcedure [dbo].[getAllDocGia]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getAllDocGia]
as
begin
	select * from DocGia
end
GO
/****** Object:  StoredProcedure [dbo].[pro_Login]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_Login]
@username NVARCHAR(100), @password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName=@username AND PassWord=@password
END

GO
/****** Object:  StoredProcedure [dbo].[SuaTTSach]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaTTSach](@DauSach_ID varchar(20), @Sach_ten nvarchar(40),@TacGia_ten nvarchar)
as
begin
	declare @TacGia_ID varchar(20) = (select TacGia_ID from TacGia where TacGia_ten = @TacGia_ten)
	if @TacGia_ID=''
		set @TacGia_ID = (select top 1 TacGia_ID from TacGia order by TacGia_ID desc)
		declare @id_number int = convert(int,@TacGia_ID) + 1
		set @TacGia_ID = convert(varchar,@id_number);
		while len(@TacGia_ID) < 20
		begin
			set @TacGia_ID = '0'+@TacGia_ID
		end
		insert into TacGia(TacGia_ID,TacGia_ten) values (@TacGia_ID,@TacGia_ten)
	update DauSach set Sach_ten=@Sach_ten,TacGia_ID=@TacGia_ID where DauSach_ID = @DauSach_ID 
end
GO
/****** Object:  StoredProcedure [dbo].[TaoIDMuonSach]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[TaoIDMuonSach](@DocGia_ID varchar(20), @ListSach as ListSachMuon readonly)
as
begin
	declare @id varchar(20),@luot int
	set @luot = (select LuotMuonSach from DocGia where DocGia_ID=@DocGia_ID)
	set @id = @DocGia_ID
	set @id += CONVERT(varchar,@luot);
	insert into TTMuonTra (TTMuonTra_ID, DocGia_ID, NgayMuon)
	values (@id,@DocGia_ID,GETDATE())

	insert into SachMuon(TTMuonTra_ID,Sach_ID)
		select * from @ListSach
end
GO
/****** Object:  StoredProcedure [dbo].[ThemDocGia]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemDocGia](@ID varchar(20),@ten nvarchar(20),@birth date)
as
begin
insert into DocGia(DocGia_ID,DocGia_ten,DocGia_ngaysinh)
values (@ID,@ten,@birth)
end

drop proc if exists SuaDocGia
GO
/****** Object:  StoredProcedure [dbo].[themSach]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[themSach](@DauSach_ID varchar(20),@Sach_ten nvarchar(40),@SoBanSao int,@TacGia_ID varchar(20))
as
begin
	insert into DauSach(DauSach_ID,Sach_ten,TacGia_ID)
	values(@DauSach_ID,@Sach_ten,@TacGia_ID)
	
	declare @i int 
	set @i = (select count(Sach_ID) from Sach where @DauSach_ID = DauSach_ID)
	declare @i_string varchar(4);
	declare @cpy_string varchar(8);

	while @i < @SoBanSao
	begin
		set @i_string = convert(varchar(4),@i)
		if @i<10
			set @cpy_string = @DauSach_ID + '000' + @i_string
		else if @i>=10 and @i<100
			set @cpy_string = @DauSach_ID + '00' + @i_string
		else if @i>=100 and @i<1000
			set @cpy_string = @DauSach_ID + '0' + @i_string
		else if @i>=1000 and @i<=9999
			set @cpy_string = @DauSach_ID + '' + @i_string
		insert into Sach(DauSach_ID,Sach_ID)
		values(@DauSach_ID,@cpy_string)
		set @i = @i+1;
	end
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemSach]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TimKiemSach](@string nvarchar(40))
as
begin
	select B.DauSach_ID,B.Sach_ten,A.SL,TacGia.TacGia_ten 
	from DauSach as B
	inner join (select DauSach_ID,count(Sach_ID) as SL from Sach where TrangThaiMuon='False' group by DauSach_ID)as A on B.DauSach_ID = A.DauSach_ID
	inner join TacGia on B.TacGia_ID = TacGia.TacGia_ID
	where B.Sach_ten like N'%' + @string + N'%' OR TacGia_ten like N'%' + @string + N'%'
end
GO
/****** Object:  StoredProcedure [dbo].[XoaDocGia]    Script Date: 4/17/2018 11:01:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaDocGia](@ID varchar(20)=null,@ten nvarchar(20)=null,@birth date=null)
as
begin
delete from DocGia where @ID=DocGia_ID
end

drop proc if exists TimDocGia
GO
USE [master]
GO
ALTER DATABASE [quan ly thu vien] SET  READ_WRITE 
GO
