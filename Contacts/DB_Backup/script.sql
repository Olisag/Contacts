USE [master]
GO
/****** Object:  Database [leadifytest]    Script Date: 15/02/2017 15:39:54 ******/
CREATE DATABASE [leadifytest]
GO
ALTER DATABASE [leadifytest] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [leadifytest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [leadifytest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [leadifytest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [leadifytest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [leadifytest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [leadifytest] SET ARITHABORT OFF 
GO
ALTER DATABASE [leadifytest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [leadifytest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [leadifytest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [leadifytest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [leadifytest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [leadifytest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [leadifytest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [leadifytest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [leadifytest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [leadifytest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [leadifytest] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [leadifytest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [leadifytest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [leadifytest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [leadifytest] SET  MULTI_USER 
GO
ALTER DATABASE [leadifytest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [leadifytest] SET QUERY_STORE = ON
GO
ALTER DATABASE [leadifytest] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO)
GO
USE [leadifytest]
GO
/****** Object:  Table [dbo].[contact]    Script Date: 15/02/2017 15:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contact](
	[contactid] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [varchar](100) NOT NULL,
	[lastname] [varchar](100) NOT NULL,
	[cellphone] [varchar](100) NOT NULL,
	[email] [varchar](100) NULL,
 CONSTRAINT [PK_contact] PRIMARY KEY CLUSTERED 
(
	[contactid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET IDENTITY_INSERT [dbo].[contact] ON 

INSERT [dbo].[contact] ([contactid], [firstname], [lastname], [cellphone], [email]) VALUES (1, N'test', N'testuser', N'0718505963', N'oli@test.com')
SET IDENTITY_INSERT [dbo].[contact] OFF
USE [master]
GO
ALTER DATABASE [leadifytest] SET  READ_WRITE 
GO
