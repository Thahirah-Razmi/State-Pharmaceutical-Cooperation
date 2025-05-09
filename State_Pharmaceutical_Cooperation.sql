USE [master]
GO
/****** Object:  Database [State_Pharmaceutical_Cooperation]    Script Date: 18-Feb-25 1:38:16 AM ******/
CREATE DATABASE [State_Pharmaceutical_Cooperation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'State_Pharmaceutical_Cooperation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\State_Pharmaceutical_Cooperation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'State_Pharmaceutical_Cooperation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\State_Pharmaceutical_Cooperation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [State_Pharmaceutical_Cooperation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET ARITHABORT OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET  MULTI_USER 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET QUERY_STORE = ON
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [State_Pharmaceutical_Cooperation]
GO
/****** Object:  Table [dbo].[DrugTable]    Script Date: 18-Feb-25 1:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DrugTable](
	[DrugID] [nchar](10) NOT NULL,
	[DrugName] [nvarchar](50) NULL,
	[SupplierID] [nchar](10) NULL,
	[Description] [nchar](1000) NULL,
	[Price] [nchar](10) NULL,
	[Stock] [nchar](10) NULL,
 CONSTRAINT [PK_DrugTable] PRIMARY KEY CLUSTERED 
(
	[DrugID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderTable]    Script Date: 18-Feb-25 1:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderTable](
	[OrderID] [nchar](10) NOT NULL,
	[DrugID] [nchar](10) NULL,
	[Quantity] [nchar](10) NULL,
 CONSTRAINT [PK_OrderTable] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierTable]    Script Date: 18-Feb-25 1:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierTable](
	[SupplierID] [nchar](10) NOT NULL,
	[SupplierName] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [varchar](50) NULL,
	[ContactNumber] [nchar](10) NULL,
 CONSTRAINT [PK_SupplierTable] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 18-Feb-25 1:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTable](
	[UserID] [nchar](100) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Usertype] [varchar](50) NULL,
 CONSTRAINT [PK_UserTable] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DrugTable]  WITH CHECK ADD  CONSTRAINT [FK_DrugTable_SupplierTable] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[SupplierTable] ([SupplierID])
GO
ALTER TABLE [dbo].[DrugTable] CHECK CONSTRAINT [FK_DrugTable_SupplierTable]
GO
ALTER TABLE [dbo].[OrderTable]  WITH CHECK ADD  CONSTRAINT [FK_OrderTable_DrugTable] FOREIGN KEY([DrugID])
REFERENCES [dbo].[DrugTable] ([DrugID])
GO
ALTER TABLE [dbo].[OrderTable] CHECK CONSTRAINT [FK_OrderTable_DrugTable]
GO
ALTER TABLE [dbo].[UserTable]  WITH CHECK ADD  CONSTRAINT [CK_UserTable_Usertype] CHECK  (([Usertype]='Supplier' OR [Usertype]='Pharmacy' OR [Usertype]='ManufacturingPlant' OR [Usertype]='WarehouseStaff'))
GO
ALTER TABLE [dbo].[UserTable] CHECK CONSTRAINT [CK_UserTable_Usertype]
GO
USE [master]
GO
ALTER DATABASE [State_Pharmaceutical_Cooperation] SET  READ_WRITE 
GO
