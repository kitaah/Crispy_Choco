USE [master]
GO
/****** Object:  Database [db_crispy_choco]    Script Date: 29/01/2023 22:35:46 ******/
CREATE DATABASE [db_crispy_choco]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_crispy_choco', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\db_crispy_choco.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_crispy_choco_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\db_crispy_choco_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_crispy_choco] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_crispy_choco].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_crispy_choco] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_crispy_choco] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_crispy_choco] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_crispy_choco] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_crispy_choco] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_crispy_choco] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_crispy_choco] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_crispy_choco] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_crispy_choco] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_crispy_choco] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_crispy_choco] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_crispy_choco] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_crispy_choco] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_crispy_choco] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_crispy_choco] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_crispy_choco] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_crispy_choco] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_crispy_choco] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_crispy_choco] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_crispy_choco] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_crispy_choco] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_crispy_choco] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_crispy_choco] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_crispy_choco] SET  MULTI_USER 
GO
ALTER DATABASE [db_crispy_choco] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_crispy_choco] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_crispy_choco] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_crispy_choco] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_crispy_choco] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_crispy_choco] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_crispy_choco] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_crispy_choco] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_crispy_choco]
GO
/****** Object:  Table [dbo].[tbAdmin]    Script Date: 29/01/2023 22:35:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbAdmin](
	[adminId] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](60) NOT NULL,
	[creationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tbAdmin] PRIMARY KEY CLUSTERED 
(
	[adminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbDepartment]    Script Date: 29/01/2023 22:35:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDepartment](
	[departmentId] [int] IDENTITY(1,1) NOT NULL,
	[departmentName] [varchar](50) NOT NULL,
	[creationDate] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbDepartment] PRIMARY KEY CLUSTERED 
(
	[departmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEmployee]    Script Date: 29/01/2023 22:35:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEmployee](
	[employeeId] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[landlinePhoneNumber] [varchar](50) NOT NULL,
	[mobilePhoneNumber] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[departmentId] [int] NOT NULL,
	[department] [varchar](50) NOT NULL,
	[siteId] [int] NOT NULL,
	[site] [varchar](50) NOT NULL,
	[creationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tbEmployee] PRIMARY KEY CLUSTERED 
(
	[employeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbSite]    Script Date: 29/01/2023 22:35:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSite](
	[siteId] [int] IDENTITY(1,1) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[creationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tbSite] PRIMARY KEY CLUSTERED 
(
	[siteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbAdmin] ADD  CONSTRAINT [DF_tbAdmin_creationDate]  DEFAULT (getdate()) FOR [creationDate]
GO
ALTER TABLE [dbo].[tbDepartment] ADD  CONSTRAINT [DF_tbDepartment_creationDate]  DEFAULT (getdate()) FOR [creationDate]
GO
ALTER TABLE [dbo].[tbEmployee] ADD  CONSTRAINT [DF_tbEmployee_creationDate]  DEFAULT (getdate()) FOR [creationDate]
GO
ALTER TABLE [dbo].[tbSite] ADD  CONSTRAINT [DF_tbSite_creationDate]  DEFAULT (getdate()) FOR [creationDate]
GO
ALTER TABLE [dbo].[tbEmployee]  WITH CHECK ADD  CONSTRAINT [FK_tbEmployee_tbDepartment] FOREIGN KEY([departmentId])
REFERENCES [dbo].[tbDepartment] ([departmentId])
GO
ALTER TABLE [dbo].[tbEmployee] CHECK CONSTRAINT [FK_tbEmployee_tbDepartment]
GO
ALTER TABLE [dbo].[tbEmployee]  WITH CHECK ADD  CONSTRAINT [FK_tbEmployee_tbSite] FOREIGN KEY([siteId])
REFERENCES [dbo].[tbSite] ([siteId])
GO
ALTER TABLE [dbo].[tbEmployee] CHECK CONSTRAINT [FK_tbEmployee_tbSite]
GO
USE [master]
GO
ALTER DATABASE [db_crispy_choco] SET  READ_WRITE 
GO
