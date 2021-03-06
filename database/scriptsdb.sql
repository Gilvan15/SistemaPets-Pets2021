USE [master]
GO

/****** Object:  Database [dbpetsepets]    Script Date: 03/07/2021 12:38:29 ******/
CREATE DATABASE [dbpetsepets]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbpetsepets_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\dbpetsepets.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbpetsepets_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\dbpetsepets.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbpetsepets].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [dbpetsepets] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [dbpetsepets] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [dbpetsepets] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [dbpetsepets] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [dbpetsepets] SET ARITHABORT OFF 
GO

ALTER DATABASE [dbpetsepets] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [dbpetsepets] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [dbpetsepets] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [dbpetsepets] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [dbpetsepets] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [dbpetsepets] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [dbpetsepets] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [dbpetsepets] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [dbpetsepets] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [dbpetsepets] SET  DISABLE_BROKER 
GO

ALTER DATABASE [dbpetsepets] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [dbpetsepets] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [dbpetsepets] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [dbpetsepets] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [dbpetsepets] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [dbpetsepets] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [dbpetsepets] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [dbpetsepets] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [dbpetsepets] SET  MULTI_USER 
GO

ALTER DATABASE [dbpetsepets] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [dbpetsepets] SET DB_CHAINING OFF 
GO

ALTER DATABASE [dbpetsepets] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [dbpetsepets] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [dbpetsepets] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [dbpetsepets] SET QUERY_STORE = OFF
GO

ALTER DATABASE [dbpetsepets] SET  READ_WRITE 
GO

