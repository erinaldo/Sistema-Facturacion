USE [master]
GO
/****** Object:  Database [dbSFacturacion]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'dbSFacturacion')
BEGIN
CREATE DATABASE [dbSFacturacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbSFacturacion', FILENAME = N'E:\Instalados\SQL Server 2016\MSSQL13.MSSQLSERVER\MSSQL\DATA\dbSFacturacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbSFacturacion_log', FILENAME = N'E:\Instalados\SQL Server 2016\MSSQL13.MSSQLSERVER\MSSQL\DATA\dbSFacturacion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 COLLATE Modern_Spanish_CI_AS
END

GO
ALTER DATABASE [dbSFacturacion] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbSFacturacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbSFacturacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbSFacturacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbSFacturacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbSFacturacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbSFacturacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbSFacturacion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbSFacturacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbSFacturacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbSFacturacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbSFacturacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbSFacturacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbSFacturacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbSFacturacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbSFacturacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbSFacturacion] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbSFacturacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbSFacturacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbSFacturacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbSFacturacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbSFacturacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbSFacturacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbSFacturacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbSFacturacion] SET RECOVERY FULL 
GO
ALTER DATABASE [dbSFacturacion] SET  MULTI_USER 
GO
ALTER DATABASE [dbSFacturacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbSFacturacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbSFacturacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbSFacturacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbSFacturacion] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbSFacturacion', N'ON'
GO
ALTER DATABASE [dbSFacturacion] SET QUERY_STORE = OFF
GO
USE [dbSFacturacion]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
/****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\Winmgmt')
CREATE LOGIN [NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[Español]
GO
/****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLWriter')
CREATE LOGIN [NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[Español]
GO
/****** Object:  Login [NT SERVICE\SQLTELEMETRY]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLTELEMETRY')
CREATE LOGIN [NT SERVICE\SQLTELEMETRY] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[Español]
GO
/****** Object:  Login [NT SERVICE\SQLSERVERAGENT]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLSERVERAGENT')
CREATE LOGIN [NT SERVICE\SQLSERVERAGENT] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[Español]
GO
/****** Object:  Login [NT Service\MSSQLSERVER]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT Service\MSSQLSERVER')
CREATE LOGIN [NT Service\MSSQLSERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[Español]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT AUTHORITY\SYSTEM')
CREATE LOGIN [NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[Español]
GO
/****** Object:  Login [LDBM\david]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'LDBM\david')
CREATE LOGIN [LDBM\david] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[Español]
GO
/****** Object:  Login [IIS APPPOOL\MgcTaskManager]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'IIS APPPOOL\MgcTaskManager')
CREATE LOGIN [IIS APPPOOL\MgcTaskManager] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[Español]
GO
/****** Object:  Login [IIS APPPOOL\LDBMAgenda]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'IIS APPPOOL\LDBMAgenda')
CREATE LOGIN [IIS APPPOOL\LDBMAgenda] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[Español]
GO
/****** Object:  Login [IIS APPPOOL\dnndev.me]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'IIS APPPOOL\dnndev.me')
CREATE LOGIN [IIS APPPOOL\dnndev.me] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[Español]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyTsqlExecutionLogin##')
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'SkiUQflgmWmVTIbXeQVdLyVivMoN8MQ29c8xKkSEPhA=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 12/11/2018 3:17:40 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyEventProcessingLogin##')
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'lXP2oC/dUWj22q4kccqzXaFFOEsT0/NRcOoiogR6suM=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
ALTER AUTHORIZATION ON DATABASE::[dbSFacturacion] TO [LDBM\david]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\Winmgmt]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLWriter]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLSERVERAGENT]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT Service\MSSQLSERVER]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [LDBM\david]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [IIS APPPOOL\MgcTaskManager]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [IIS APPPOOL\LDBMAgenda]
GO
USE [dbSFacturacion]
GO
GRANT VIEW ANY COLUMN ENCRYPTION KEY DEFINITION TO [public] AS [dbo]
GO
GRANT VIEW ANY COLUMN MASTER KEY DEFINITION TO [public] AS [dbo]
GO
/****** Object:  Table [dbo].[tblCategoria]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblCategoria]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblCategoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
 CONSTRAINT [PK_tblCategoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblCategoria] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblCliente]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblCliente]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblCliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Apellido] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Dni] [int] NULL,
	[Direccion] [varchar](500) COLLATE Modern_Spanish_CI_AS NULL,
	[Telefono] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_tblCliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblCliente] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblDetalleVenta]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDetalleVenta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblDetalleVenta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VentaId] [int] NOT NULL,
	[ProductoId] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tblDetalleVenta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[tblDetalleVenta] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblProducto]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblProducto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblProducto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[Nombre] [varchar](200) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Descripcion] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Stock] [decimal](18, 2) NOT NULL,
	[PrecioCompra] [decimal](18, 2) NOT NULL,
	[PrecioVenta] [decimal](18, 2) NOT NULL,
	[FechaVencimiento] [date] NOT NULL,
	[FechaCreado] [datetime] NOT NULL,
	[Imagen] [image] NULL,
 CONSTRAINT [PK_tblProducto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblProducto] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblUsuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblUsuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Apellido] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Dni] [int] NULL,
	[Direccion] [varchar](500) COLLATE Modern_Spanish_CI_AS NULL,
	[Telefono] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Usuario] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Password] [varbinary](8000) NULL,
	[Tipo] [varchar](100) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_tblUsuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblUsuario] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblVenta]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblVenta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblVenta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[FechaVenta] [date] NOT NULL,
	[NumeroDocumento] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[TipoDocumento] [varchar](100) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_tblVenta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblVenta] TO  SCHEMA OWNER 
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblDetalleVenta_tblProducto]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblDetalleVenta]'))
ALTER TABLE [dbo].[tblDetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_tblDetalleVenta_tblProducto] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[tblProducto] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblDetalleVenta_tblProducto]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblDetalleVenta]'))
ALTER TABLE [dbo].[tblDetalleVenta] CHECK CONSTRAINT [FK_tblDetalleVenta_tblProducto]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblDetalleVenta_tblVenta]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblDetalleVenta]'))
ALTER TABLE [dbo].[tblDetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_tblDetalleVenta_tblVenta] FOREIGN KEY([VentaId])
REFERENCES [dbo].[tblVenta] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblDetalleVenta_tblVenta]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblDetalleVenta]'))
ALTER TABLE [dbo].[tblDetalleVenta] CHECK CONSTRAINT [FK_tblDetalleVenta_tblVenta]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblProducto_tblCategoria]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblProducto]'))
ALTER TABLE [dbo].[tblProducto]  WITH CHECK ADD  CONSTRAINT [FK_tblProducto_tblCategoria] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[tblCategoria] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblProducto_tblCategoria]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblProducto]'))
ALTER TABLE [dbo].[tblProducto] CHECK CONSTRAINT [FK_tblProducto_tblCategoria]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblVenta_tblCliente]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblVenta]'))
ALTER TABLE [dbo].[tblVenta]  WITH CHECK ADD  CONSTRAINT [FK_tblVenta_tblCliente] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[tblCliente] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblVenta_tblCliente]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblVenta]'))
ALTER TABLE [dbo].[tblVenta] CHECK CONSTRAINT [FK_tblVenta_tblCliente]
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCategoria_Actualizar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FCategoria_Actualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FCategoria_Actualizar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FCategoria_Actualizar]
	@Id [int],
	@Descripcion [varchar](300)
WITH EXECUTE AS CALLER
AS
Update tblCategoria set Descripcion=@Descripcion where Id=@Id

Select @@ROWCOUNT as cantidad

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCategoria_Actualizar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCategoria_Actualizar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCategoria_Eliminar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FCategoria_Eliminar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FCategoria_Eliminar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FCategoria_Eliminar]
	@Id [int]
WITH EXECUTE AS CALLER
AS
BEGIN
	delete from tblCategoria where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
	
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCategoria_Eliminar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCategoria_Eliminar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCategoria_GetAll]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FCategoria_GetAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FCategoria_GetAll] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FCategoria_GetAll]
WITH EXECUTE AS CALLER
AS
BEGIN
	select Id,Descripcion from tblCategoria
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCategoria_GetAll] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCategoria_GetAll] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCategoria_Insertar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FCategoria_Insertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FCategoria_Insertar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FCategoria_Insertar]
	@Descripcion [varchar](300)
WITH EXECUTE AS CALLER
AS
insert into tblCategoria (Descripcion) values (@Descripcion)

Select @@IDENTITY

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCategoria_Insertar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCategoria_Insertar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCliente_Actualizar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FCliente_Actualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FCliente_Actualizar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FCliente_Actualizar]
	@Id [int],
	@Nombre [varchar](50),
	@Apellido [varchar](50),
	@Dni [int],
	@Domicilio [varchar](500),
	@Telefono [varchar](50)
WITH EXECUTE AS CALLER
AS
Update tblCliente set Nombre=@Nombre,Direccion=@Domicilio,Apellido=@Apellido,Dni=@Dni,Telefono=@Telefono where Id=@Id

Select @@ROWCOUNT as cantidad

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCliente_Actualizar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCliente_Actualizar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCliente_Eliminar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FCliente_Eliminar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FCliente_Eliminar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FCliente_Eliminar]
	@Id [int]
WITH EXECUTE AS CALLER
AS
BEGIN
	delete from tblCliente where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
	
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCliente_Eliminar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCliente_Eliminar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCliente_GetAll]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FCliente_GetAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FCliente_GetAll] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FCliente_GetAll]
WITH EXECUTE AS CALLER
AS
BEGIN
	select Id,Nombre,Apellido,Telefono,Dni,Direccion as Domicilio from tblCliente
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCliente_GetAll] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCliente_GetAll] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCliente_Insertar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FCliente_Insertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FCliente_Insertar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FCliente_Insertar]
	@Nombre [varchar](50),
	@Apellido [varchar](50),
	@Dni [int],
	@Domicilio [varchar](500),
	@Telefono [varchar](50)
WITH EXECUTE AS CALLER
AS
insert into tblCliente (Nombre,Apellido,Dni,Telefono,Direccion)
values (@Nombre,@Apellido,@Dni,@Telefono,@Domicilio)

Select @@IDENTITY

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCliente_Insertar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FCliente_Insertar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FDetalleVenta_Actualizar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FDetalleVenta_Actualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FDetalleVenta_Actualizar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FDetalleVenta_Actualizar]
	@Id [int],
	@VentaId [int],
	@ProductoId [int],
	@Cantidad [decimal](18, 2),
	@PrecioUnitario [decimal](18, 2)
WITH EXECUTE AS CALLER
AS
BEGIN

 update tblDetalleVenta set VentaId=@VentaId, ProductoId=@ProductoId, Cantidad=@Cantidad, PrecioUnitario=@PrecioUnitario
where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FDetalleVenta_Actualizar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FDetalleVenta_Actualizar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FDetalleVenta_AumentarStock]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FDetalleVenta_AumentarStock]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FDetalleVenta_AumentarStock] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FDetalleVenta_AumentarStock]
	@ProductoId [int],
	@Cantidad [decimal](18, 2)
WITH EXECUTE AS CALLER
AS
BEGIN
	update tblProducto set Stock=Stock+@Cantidad where Id=@ProductoId
	
	select @@ROWCOUNT as CantidadAfectada
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FDetalleVenta_AumentarStock] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FDetalleVenta_AumentarStock] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FDetalleVenta_DisminuirStock]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FDetalleVenta_DisminuirStock]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FDetalleVenta_DisminuirStock] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FDetalleVenta_DisminuirStock]
	@ProductoId [int],
	@Cantidad [decimal](18, 2)
WITH EXECUTE AS CALLER
AS
BEGIN
	update tblProducto set Stock=Stock-@Cantidad where Id=@ProductoId
	select @@ROWCOUNT as CantidadAfectada
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FDetalleVenta_DisminuirStock] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FDetalleVenta_DisminuirStock] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FDetalleVenta_Eliminar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FDetalleVenta_Eliminar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FDetalleVenta_Eliminar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FDetalleVenta_Eliminar]
	@Id [int]
WITH EXECUTE AS CALLER
AS
BEGIN

 delete from tblDetalleVenta where Id=@Id
 select @@ROWCOUNT as CantidadAfectada	

END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FDetalleVenta_Eliminar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FDetalleVenta_Eliminar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FDetalleVenta_GetAll]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FDetalleVenta_GetAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FDetalleVenta_GetAll] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FDetalleVenta_GetAll]
	@VentaId [int]
WITH EXECUTE AS CALLER
AS
BEGIN
	SELECT      dbo.tblDetalleVenta.ProductoId, dbo.tblDetalleVenta.Id, dbo.tblDetalleVenta.VentaId, 
                      dbo.tblProducto.Nombre, dbo.tblDetalleVenta.Cantidad, dbo.tblProducto.PrecioVenta,dbo.tblDetalleVenta.PrecioUnitario
FROM         dbo.tblDetalleVenta INNER JOIN
                      dbo.tblProducto ON dbo.tblDetalleVenta.ProductoId = dbo.tblProducto.Id
              
      where  tblDetalleVenta.VentaId=@VentaId                     
                      
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FDetalleVenta_GetAll] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FDetalleVenta_GetAll] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FDetalleVenta_Insertar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FDetalleVenta_Insertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FDetalleVenta_Insertar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FDetalleVenta_Insertar]
	@VentaId [int],
	@ProductoId [int],
	@Cantidad [decimal](18, 2),
	@PrecioUnitario [decimal](18, 2)
WITH EXECUTE AS CALLER
AS
BEGIN
	insert into tblDetalleVenta
	(VentaId, ProductoId, Cantidad, PrecioUnitario)
	values
	(@VentaId, @ProductoId, @Cantidad, @PrecioUnitario)
	
	select @@IDENTITY as VentaDetalleId
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FDetalleVenta_Insertar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FDetalleVenta_Insertar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FLogin_ValidarLogin]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FLogin_ValidarLogin]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FLogin_ValidarLogin] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FLogin_ValidarLogin]
	@Usuario [varchar](100),
	@Password [varchar](100)
WITH EXECUTE AS CALLER
AS
BEGIN
	select	Id,Nombre,Apellido,Dni,Direccion,Telefono,Usuario,
			CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('password', Password)),Tipo
		 from	tblUsuario 
		 where	Usuario=@Usuario and 
				CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('password', Password))=@Password
END
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FLogin_ValidarLogin] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FLogin_ValidarLogin] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FProducto_Actualizar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FProducto_Actualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FProducto_Actualizar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FProducto_Actualizar]
	@Id [int],
	@CategoriaId [int],
	@Nombre [varchar](200),
	@Descripcion [varchar](1000),
	@Stock [decimal](18, 2),
	@PrecioCompra [decimal](18, 2),
	@PrecioVenta [decimal](18, 2),
	@FechaVencimiento [datetime],
	@Imagen [image]
WITH EXECUTE AS CALLER
AS
BEGIN
	 
	 update tblProducto set CategoriaId=@CategoriaId, Nombre=@Nombre, Descripcion=@Descripcion, 
	 Stock=@Stock, PrecioCompra=@PrecioCompra, PrecioVenta=@PrecioVenta, FechaVencimiento=@FechaVencimiento, 
	 Imagen=@Imagen
	 where Id=@Id
	 
	 select @@ROWCOUNT as CantidadAfectada
	 
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FProducto_Actualizar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FProducto_Actualizar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FProducto_Eliminar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FProducto_Eliminar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FProducto_Eliminar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FProducto_Eliminar]
	@Id [int]
WITH EXECUTE AS CALLER
AS
BEGIN
	 
	delete from tblProducto where Id=@Id
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FProducto_Eliminar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FProducto_Eliminar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FProducto_GetAll]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FProducto_GetAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FProducto_GetAll] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FProducto_GetAll]
WITH EXECUTE AS CALLER
AS
BEGIN
	   SELECT     dbo.tblCategoria.Descripcion AS CategoriaDescripcion, dbo.tblProducto.Id, dbo.tblProducto.CategoriaId, dbo.tblProducto.Nombre, dbo.tblProducto.Descripcion, dbo.tblProducto.Stock, 
                      dbo.tblProducto.PrecioCompra, dbo.tblProducto.PrecioVenta, dbo.tblProducto.FechaVencimiento, dbo.tblProducto.Imagen
FROM         dbo.tblCategoria INNER JOIN
                      dbo.tblProducto ON dbo.tblCategoria.Id = dbo.tblProducto.CategoriaId
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FProducto_GetAll] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FProducto_GetAll] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FProducto_Insertar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FProducto_Insertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FProducto_Insertar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FProducto_Insertar]
	@CategoriaId [int],
	@Nombre [varchar](200),
	@Descripcion [varchar](1000),
	@Stock [decimal](18, 2),
	@PrecioCompra [decimal](18, 2),
	@PrecioVenta [decimal](18, 2),
	@FechaVencimiento [datetime],
	@Imagen [image]
WITH EXECUTE AS CALLER
AS
BEGIN
	  insert into tblProducto (CategoriaId, Nombre, Descripcion, Stock, PrecioCompra, PrecioVenta, FechaVencimiento, FechaCreado, Imagen)
	  values (@CategoriaId, @Nombre, @Descripcion, @Stock, @PrecioCompra, @PrecioVenta, @FechaVencimiento,GETDATE() , @Imagen)
	  
	  select @@IDENTITY as ProductoId
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FProducto_Insertar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FProducto_Insertar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FUsuario_Actualizar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FUsuario_Actualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FUsuario_Actualizar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FUsuario_Actualizar]
	@Id [int],
	@Nombre [varchar](50),
	@Apellido [varchar](50),
	@Dni [int],
	@Direccion [varchar](500),
	@Telefono [varchar](50),
	@Usuario [varchar](50),
	@Password [varchar](max),
	@Tipo [varchar](100)
WITH EXECUTE AS CALLER
AS
Update tblUsuario set Nombre=@Nombre,Apellido=@Apellido,Dni=@Dni,
		Direccion=@Direccion,Telefono=@Telefono,Usuario=@Usuario,
		Password=ENCRYPTBYPASSPHRASE('password', @Password),Tipo=@Tipo
	where Id=@Id

Select @@ROWCOUNT as cantidad


GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FUsuario_Actualizar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FUsuario_Actualizar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FUsuario_Eliminar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FUsuario_Eliminar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FUsuario_Eliminar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FUsuario_Eliminar]
	@Id [int]
WITH EXECUTE AS CALLER
AS
delete from tblUsuario where Id = @Id
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FUsuario_Eliminar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FUsuario_Eliminar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FUsuario_GetAll]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FUsuario_GetAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FUsuario_GetAll] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FUsuario_GetAll]
WITH EXECUTE AS CALLER
AS
BEGIN
	select Id,Nombre,Apellido,Dni,Direccion,Telefono,Usuario,CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('password', Password)) as Contraseña,Tipo from tblUsuario
END


GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FUsuario_GetAll] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FUsuario_GetAll] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FUsuario_Insertar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FUsuario_Insertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FUsuario_Insertar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FUsuario_Insertar]
	@Nombre [varchar](50),
	@Apellido [varchar](50),
	@Dni [int],
	@Direccion [varchar](500),
	@Telefono [varchar](50),
	@Usuario [varchar](50),
	@Password [varchar](max),
	@Tipo [varchar](100)
WITH EXECUTE AS CALLER
AS
insert into tblUsuario (Nombre,Apellido,Dni,Direccion,Telefono,Usuario,Password,Tipo)
values (@Nombre,@Apellido,@Dni,@Direccion,@Telefono,@Usuario,ENCRYPTBYPASSPHRASE('password', @Password),@Tipo)

Select @@IDENTITY
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FUsuario_Insertar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FUsuario_Insertar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FUsuario_VerificarDNI]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FUsuario_VerificarDNI]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FUsuario_VerificarDNI] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FUsuario_VerificarDNI]
	@Dni [int]
WITH EXECUTE AS CALLER
AS
select * from tblUsuario where Dni=@Dni
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FUsuario_VerificarDNI] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FUsuario_VerificarDNI] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FVenta_Actualizar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FVenta_Actualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FVenta_Actualizar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FVenta_Actualizar]
	@Id [int],
	@ClienteId [int],
	@FechaVenta [datetime],
	@NumeroDocumento [varchar](50),
	@TipoDocumento [varchar](100)
WITH EXECUTE AS CALLER
AS
BEGIN
	
	Update tblVenta set ClienteId=@ClienteId, FechaVenta=@FechaVenta,
	 NumeroDocumento=@NumeroDocumento, TipoDocumento=@TipoDocumento
	 Where id=@Id
	
	Select @@RowCount as CantidadAfectada
	
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FVenta_Actualizar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FVenta_Actualizar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FVenta_Eliminar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FVenta_Eliminar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FVenta_Eliminar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FVenta_Eliminar]
	@Id [int]
WITH EXECUTE AS CALLER
AS
BEGIN
	
	Delete from tblVenta where Id=@Id
	
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FVenta_Eliminar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FVenta_Eliminar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FVenta_GetAll]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FVenta_GetAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FVenta_GetAll] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FVenta_GetAll]
WITH EXECUTE AS CALLER
AS
BEGIN

SELECT     dbo.tblVenta.Id, dbo.tblVenta.ClienteId, dbo.tblVenta.FechaVenta, dbo.tblVenta.NumeroDocumento, dbo.tblVenta.TipoDocumento, dbo.tblCliente.Nombre, 
                      dbo.tblCliente.Apellido
FROM         dbo.tblCliente INNER JOIN
                      dbo.tblVenta ON dbo.tblCliente.Id = dbo.tblVenta.ClienteId
	 
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FVenta_GetAll] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FVenta_GetAll] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FVenta_Insertar]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Data_FVenta_Insertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Data_FVenta_Insertar] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Data_FVenta_Insertar]
	@ClienteId [int],
	@FechaVenta [datetime],
	@NumeroDocumento [varchar](50),
	@TipoDocumento [varchar](100)
WITH EXECUTE AS CALLER
AS
BEGIN
	
	insert into tblVenta
	(ClienteId, FechaVenta, NumeroDocumento, TipoDocumento)
	values
	(@ClienteId, @FechaVenta, @NumeroDocumento, @TipoDocumento)
	
	Select @@IDENTITY as VentaId
	
END

GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FVenta_Insertar] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Data_FVenta_Insertar] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[usp_Reportes_GenrerarReporteVenta]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_Reportes_GenrerarReporteVenta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_Reportes_GenrerarReporteVenta] AS' 
END
GO
ALTER PROCEDURE [dbo].[usp_Reportes_GenrerarReporteVenta]
	@VentaId [int]
WITH EXECUTE AS CALLER
AS
BEGIN
	SELECT        dbo.tblDetalleVenta.VentaId, dbo.tblDetalleVenta.Cantidad, dbo.tblDetalleVenta.PrecioUnitario, dbo.tblVenta.FechaVenta, dbo.tblVenta.NumeroDocumento, dbo.tblVenta.TipoDocumento, dbo.tblCliente.Nombre, 
                         dbo.tblCliente.Apellido, dbo.tblCliente.Dni, dbo.tblProducto.Nombre AS ProductoDescripcion,
                         (dbo.tblDetalleVenta.Cantidad * dbo.tblDetalleVenta.PrecioUnitario) as TotalParcial
FROM            dbo.tblDetalleVenta INNER JOIN
                         dbo.tblVenta ON dbo.tblDetalleVenta.VentaId = dbo.tblVenta.Id INNER JOIN
                         dbo.tblCliente ON dbo.tblVenta.ClienteId = dbo.tblCliente.Id INNER JOIN
                         dbo.tblProducto ON dbo.tblDetalleVenta.ProductoId = dbo.tblProducto.Id
		where tblVenta.Id = @VentaId                           
END
GO
ALTER AUTHORIZATION ON [dbo].[usp_Reportes_GenrerarReporteVenta] TO  SCHEMA OWNER 
GO
ALTER AUTHORIZATION ON [dbo].[usp_Reportes_GenrerarReporteVenta] TO  SCHEMA OWNER 
GO
/****** Object:  Trigger [dbo].[usp_FDetalleVenta_Data_DisminuirStock]    Script Date: 12/11/2018 3:17:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[usp_FDetalleVenta_Data_DisminuirStock]'))
EXEC dbo.sp_executesql @statement = N'CREATE TRIGGER [dbo].[usp_FDetalleVenta_Data_DisminuirStock]
ON [dbo].[tblDetalleVenta] AFTER INSERT
AS
SET NOCOUNT ON
UPDATE [dbo].[tblProducto] 
SET [dbo].[tblProducto].[Stock] = [dbo].[tblProducto].[Stock] - inserted.Cantidad from inserted
INNER JOIN tblProducto ON inserted.ProductoId = tblProducto.Id ' 
GO
ALTER TABLE [dbo].[tblDetalleVenta] ENABLE TRIGGER [usp_FDetalleVenta_Data_DisminuirStock]
GO
USE [master]
GO
ALTER DATABASE [dbSFacturacion] SET  READ_WRITE 
GO
