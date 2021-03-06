USE [master]
GO
/****** Object:  Database [AccountPayable]    Script Date: 10/6/2018 9:59:33 AM ******/
CREATE DATABASE [AccountPayable]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AccountPayable', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\AccountPayable.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AccountPayable_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\AccountPayable_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AccountPayable] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AccountPayable].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AccountPayable] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AccountPayable] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AccountPayable] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AccountPayable] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AccountPayable] SET ARITHABORT OFF 
GO
ALTER DATABASE [AccountPayable] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AccountPayable] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AccountPayable] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AccountPayable] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AccountPayable] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AccountPayable] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AccountPayable] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AccountPayable] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AccountPayable] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AccountPayable] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AccountPayable] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AccountPayable] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AccountPayable] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AccountPayable] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AccountPayable] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AccountPayable] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AccountPayable] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AccountPayable] SET RECOVERY FULL 
GO
ALTER DATABASE [AccountPayable] SET  MULTI_USER 
GO
ALTER DATABASE [AccountPayable] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AccountPayable] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AccountPayable] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AccountPayable] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AccountPayable] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AccountPayable', N'ON'
GO
ALTER DATABASE [AccountPayable] SET QUERY_STORE = OFF
GO
USE [AccountPayable]
GO
/****** Object:  Table [dbo].[company]    Script Date: 10/6/2018 9:59:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[company](
	[NUM_CompanyID] [int] NOT NULL,
	[CHR_CompanyName] [varchar](50) NULL,
	[CHR_Address] [varchar](50) NULL,
	[CHR_Salary] [money] NULL,
	[CHR_Email] [varchar](50) NULL,
	[CHR_Phone] [varchar](50) NULL,
	

 CONSTRAINT [PK_company] PRIMARY KEY CLUSTERED 
(
	[NUM_CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[invoice]    Script Date: 10/6/2018 9:59:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[invoice](
	[CHR_InvoiceID] [varchar](50) NOT NULL,
	[CHR_Info] [varchar](50) NULL,
	[DT_Date] [date] NULL,
	[DT_DueDate] [date] NULL,
	[MON_Total] [money] NULL,
	[CHR_Status] [varchar](50) NULL,
 CONSTRAINT [PK_invoice] PRIMARY KEY CLUSTERED 
(
	[CHR_InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 10/6/2018 9:59:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[CHR_Username] [varchar](50) NOT NULL,
	[NUM_Password] [int] NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[CHR_Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 10/6/2018 9:59:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchaseOrder](
	[NUM_PurchaseOrderID] [int] NOT NULL,
	[CHR_Note] [varchar](50) NULL,
	[CHR_Terms] [varchar](50) NULL,
	[MON_Tax] [money] NULL,
	[DT_DateCreated] [date] NULL,
	[CHR_DeliveryAddress] [varchar](50) NULL,
	[DT_DeliveryDate] [date] NULL,
 CONSTRAINT [PK_purchaseOrder] PRIMARY KEY CLUSTERED 
(
	[NUM_PurchaseOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 10/6/2018 9:59:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[NUM_UserID] [int] NOT NULL,
	[CHR_Name] [varchar](50) NULL,
	[CHR_Surname] [varchar](50) NULL,
	[CHR_Email] [varchar](50) NULL,
	[CHR_Phone] [int] NULL,
	[CHR_City] [varchar](50) NULL,
	[CHR_Country] [varchar](50) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[NUM_UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendor]    Script Date: 10/6/2018 9:59:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendor](
	[NUM_VendorID] [int] NOT NULL,
	[BLB_VendorImage] [image] NULL,
	[CHR_Name] [varchar](50) NULL,
	[CHR_Surname] [varchar](50) NULL,
	[CHR_Email] [varchar](50) NULL,
	[CHR_Address] [varchar](50) NULL,
	[NUM_Phone] [varchar](50) NULL,
	[NUM_TaxIdentificationNumber] [varchar](50) NULL,
	[CHR_PaymentMethod] [varchar](50) NULL,
	[CHR_Commodity] [varchar](50) NULL,
	[CHR_PaymentTerms] [varchar](50) NULL,
 CONSTRAINT [PK_vendor] PRIMARY KEY CLUSTERED 
(
	[NUM_VendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[login] ([CHR_Username], [NUM_Password]) VALUES (N'sda', 123)
USE [master]
GO
ALTER DATABASE [AccountPayable] SET  READ_WRITE 
GO
