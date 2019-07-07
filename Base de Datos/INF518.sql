USE [master]
GO
/****** Object:  Database [INF518]    Script Date: 7/7/2019 3:55:00 p. m. ******/
CREATE DATABASE [INF518]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'INF518', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\INF518.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'INF518_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\INF518_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [INF518] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [INF518].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [INF518] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [INF518] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [INF518] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [INF518] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [INF518] SET ARITHABORT OFF 
GO
ALTER DATABASE [INF518] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [INF518] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [INF518] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [INF518] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [INF518] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [INF518] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [INF518] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [INF518] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [INF518] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [INF518] SET  DISABLE_BROKER 
GO
ALTER DATABASE [INF518] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [INF518] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [INF518] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [INF518] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [INF518] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [INF518] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [INF518] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [INF518] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [INF518] SET  MULTI_USER 
GO
ALTER DATABASE [INF518] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [INF518] SET DB_CHAINING OFF 
GO
ALTER DATABASE [INF518] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [INF518] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [INF518] SET DELAYED_DURABILITY = DISABLED 
GO
USE [INF518]
GO
/****** Object:  Table [dbo].[tblAsignaturas]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblAsignaturas](
	[AsignaturaID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[CarreraID] [int] NOT NULL,
	[Creditos] [int] NOT NULL,
	[Observaciones] [varchar](max) NULL,
	[Codigo] [varchar](10) NULL,
	[Inactivo] [bit] NOT NULL CONSTRAINT [DF_tblAsignaturas_Inactivo]  DEFAULT ((0)),
 CONSTRAINT [PK_tblAsignaturas] PRIMARY KEY CLUSTERED 
(
	[AsignaturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblAulas]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblAulas](
	[AulaID] [int] IDENTITY(1,1) NOT NULL,
	[Capacidad] [smallint] NOT NULL CONSTRAINT [DF_tblAulas_Capacidad]  DEFAULT ((25)),
	[Descripcion] [varchar](100) NOT NULL,
	[CentroID] [int] NOT NULL,
	[Observaciones] [varchar](max) NULL,
	[Inactivo] [bit] NULL CONSTRAINT [DF_tblAulas_Inactivo]  DEFAULT ((0)),
 CONSTRAINT [PK_tblAulas] PRIMARY KEY CLUSTERED 
(
	[AulaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCarreras]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCarreras](
	[CarreraID] [int] IDENTITY(1000,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Creditos] [int] NULL,
	[Observaciones] [varchar](max) NULL CONSTRAINT [DF_tblCarreras_Observaciones]  DEFAULT ((0)),
	[Inactivo] [bit] NULL,
 CONSTRAINT [PK_tblCarreras] PRIMARY KEY CLUSTERED 
(
	[CarreraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCentros]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCentros](
	[CentroID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[NombreCorto] [varchar](30) NOT NULL,
	[Descripcion] [varchar](200) NULL,
	[WebSite] [varchar](256) NULL,
	[Telefono] [varchar](20) NULL,
	[Observaciones] [varchar](max) NULL,
	[Inactivo] [bit] NULL CONSTRAINT [DF_tblCentros_Inactivo]  DEFAULT ((0)),
 CONSTRAINT [PK_tblCentros] PRIMARY KEY CLUSTERED 
(
	[CentroID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDetalleInscripcion]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDetalleInscripcion](
	[IDInscripcion] [int] NOT NULL,
	[IDSeccion] [int] NULL,
	[Inactivo] [bit] NULL,
 CONSTRAINT [PK_tblDetalleInscripcion] PRIMARY KEY CLUSTERED 
(
	[IDInscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDias]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDias](
	[DiaID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_tblDias] PRIMARY KEY CLUSTERED 
(
	[DiaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEstudiantes]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEstudiantes](
	[EstudianteID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](45) NOT NULL,
	[Apellido] [varchar](85) NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Cedula] [varchar](20) NULL,
	[TipoEstudianteID] [int] NULL,
	[Matricula] [varchar](50) NULL,
	[Sexo] [char](1) NULL,
	[EstadoCivil] [char](1) NULL,
	[TelefonoCasa] [varchar](15) NULL,
	[TelefonoMovil] [varchar](15) NULL,
	[Email] [varchar](255) NULL,
	[Observaciones] [varchar](max) NULL,
	[CarreraID] [int] NULL,
	[Balance] [money] NULL CONSTRAINT [DF_tblEstudiantes_Balance]  DEFAULT ((0)),
	[Inactivo] [bit] NULL CONSTRAINT [DF_tblEstudiantes_Inactivo]  DEFAULT ((0)),
 CONSTRAINT [PK__tblEstud__3214EC278008EF90] PRIMARY KEY CLUSTERED 
(
	[EstudianteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblInscripcion]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblInscripcion](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDEstudiante] [int] NULL,
	[Fecha] [datetime] NULL,
	[Inactivo] [bit] NULL,
 CONSTRAINT [PK_tblInscripcion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblProfesores]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProfesores](
	[ProfesorID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[Cedula] [varchar](20) NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[EstadoCivil] [char](1) NOT NULL,
	[TelefonoCasa] [varchar](20) NULL,
	[TelefonoMovil] [varchar](20) NULL,
	[Email] [varchar](255) NULL,
	[Observaciones] [varchar](max) NULL,
	[Inactivo] [bit] NULL CONSTRAINT [DF_tblProfesores_Inactivo]  DEFAULT ((0)),
 CONSTRAINT [PK_tblProfesores] PRIMARY KEY CLUSTERED 
(
	[ProfesorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSecciones]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSecciones](
	[SeccionID] [int] IDENTITY(1,1) NOT NULL,
	[CentroID] [int] NOT NULL,
	[ProfesorID] [int] NOT NULL,
	[AsignaturaID] [int] NOT NULL,
	[Capacidad] [int] NOT NULL,
	[AulaID] [int] NOT NULL,
	[Dia1ID] [int] NOT NULL,
	[HoraInicioDia1] [time](7) NOT NULL,
	[HoraFinDia1] [time](7) NOT NULL,
	[Dia2ID] [int] NOT NULL,
	[HoraInicioDia2] [time](7) NOT NULL,
	[HoraFinDia2] [time](7) NOT NULL,
	[Observaciones] [varchar](max) NULL,
	[Inactivo] [bit] NULL CONSTRAINT [DF_tblSecciones_Inactivo]  DEFAULT ((0)),
 CONSTRAINT [PK_tblSecciones] PRIMARY KEY CLUSTERED 
(
	[SeccionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTipoEstudiantes]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTipoEstudiantes](
	[TopoEstudianteID] [int] IDENTITY(1000,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[CostoCredito] [money] NOT NULL,
	[CostoInscripcion] [money] NOT NULL,
	[Observaciones] [varchar](max) NOT NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_tblTipoEstudiantes] PRIMARY KEY CLUSTERED 
(
	[TopoEstudianteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTipoUsuario]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTipoUsuario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Inactivo] [bit] NULL,
	[Permisos] [varchar](max) NULL,
 CONSTRAINT [PK_tblTipoUsuario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUsuarios]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUsuarios](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Usuario] [varchar](50) NULL,
	[Password] [varbinary](512) NULL,
	[TipoUsuarioID] [int] NULL,
	[Observaciones] [varchar](max) NULL,
	[Inactivo] [bit] NULL CONSTRAINT [DF_Usuarios_Inactivo]  DEFAULT ((0)),
 CONSTRAINT [PK__Usuarios__DE4431C5C9DF00DF] PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblEstudiantes]  WITH CHECK ADD  CONSTRAINT [FK_tblEstudiantes_tblCarrera] FOREIGN KEY([CarreraID])
REFERENCES [dbo].[tblCarreras] ([CarreraID])
GO
ALTER TABLE [dbo].[tblEstudiantes] CHECK CONSTRAINT [FK_tblEstudiantes_tblCarrera]
GO
/****** Object:  StoredProcedure [dbo].[backupdb]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery2.sql|0|0|C:\Users\Joel\AppData\Local\Temp\~vs1510.sql
CREATE procedure [dbo].[backupdb]
as
BACKUP DATABASE [INF518] TO  DISK =N'C:\copia\test.bak'
WITH NOFORMAT, NOINIT,  NAME = N'test-Completa Base de datos Copia de seguridad', SKIP,NOREWIND, NOUNLOAD,  STATS = 10

GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarProfesor]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizarProfesor]
	@profesorID INT,
	@nombre VARCHAR(50),
	@apellido VARCHAR(100),
	@cedula VARCHAR(20),
	@sexo VARCHAR(1),
	@fechaNacimiento DATE,
	@estadoCivil CHAR(1),
	@telefonoCasa VARCHAR(20),
	@telefonoMovil VARCHAR(20),
	@email VARCHAR(255),
	@observaciones VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT OFF;

	UPDATE tblProfesores
	SET 
		Nombre = @nombre,
		Apellido = @apellido,
		Cedula = @cedula,
		Sexo = @sexo,
		FechaNacimiento = @fechaNacimiento,
		EstadoCivil = @estadoCivil,
		TelefonoCasa = @telefonoCasa,
		TelefonoMovil = @telefonoMovil,
		Email = @email,
		Observaciones = @observaciones
	WHERE
		ProfesorID = @profesorID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarSeccion]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_actualizarSeccion]
	@seccionID INT,
	@centroID INT,
	@profesorID INT,
	@asignaturaID INT,
	@capacidad INT,
	@aulaID INT,
	@dia1ID INT,
	@dia2ID INT,
	@HoraInicioDia1 TIME,
	@HoraFinDia1 TIME,
	@HoraInicioDia2 TIME,
	@HoraFinDia2 TIME,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT OFF;
	UPDATE tblSecciones
	SET
		CentroID = @centroID,
		ProfesorID = @profesorID,
		AsignaturaID = @asignaturaID,
		Capacidad = @capacidad,
		AulaID = @aulaID,
		Dia1ID = @dia1ID,
		HoraInicioDia1 = @HoraInicioDia1,
		HoraFinDia1 = @HoraFinDia1,
		Dia2ID = @dia2ID,
		HoraInicioDia2 = @HoraInicioDia2,
		HoraFinDia2 = @HoraFinDia2,
		Observaciones = @observaciones
	WHERE
		SeccionID = @seccionID;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_buscarAsignaturas]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_buscarAsignaturas]
	@busqueda VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		AsignaturaID,
		Descripcion,
		Codigo
	FROM tblAsignaturas
	WHERE 
		Descripcion LIKE '%' + @busqueda + '%'
		OR Codigo LIKE '%' + @busqueda + '%'
END

GO
/****** Object:  StoredProcedure [dbo].[sp_buscarAulas]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_buscarAulas]
	@busqueda VARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		A.AulaID,
		A.Descripción,
		C.Nombre AS 'Centro'
	FROM tblAulas A
	INNER JOIN tblCentros C
		ON C.CentroID = A.CentroID
	WHERE 
		Descripcion LIKE '%' + @busqueda + '%'
		OR C.Nombre LIKE  '%' + @busqueda + '%'
END

GO
/****** Object:  StoredProcedure [dbo].[sp_buscarCarreras]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_buscarCarreras]
	@busqueda VARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		CarreraID,
		Descripcion,
		Creditos
	FROM tblCarreras	
	WHERE
		Descripcion LIKE '%' + @busqueda +'%'
END

GO
/****** Object:  StoredProcedure [dbo].[sp_buscarCentros]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_buscarCentros]
	@busqueda VARCHAR(100)
AS
BEGIN
	SELECT 
		CentroID,
		Nombre,
		NombreCorto
	FROM tblCentros
	WHERE
		Nombre LIKE '%' + @busqueda +'%'
		OR NombreCorto LIKE '%' + @busqueda +'%'
END

GO
/****** Object:  StoredProcedure [dbo].[sp_buscarEstudiantes]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_buscarEstudiantes]
	@busqueda VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;


	SELECT 
		EstudianteID,
		Matricula,
		Nombre,
		Apellido,
		Cedula
	FROM tblEstudiantes
	WHERE 
		Nombre LIKE '%' + @busqueda+'%'
		OR Apellido LIKE '%' + @busqueda+'%'
		OR Cedula LIKE '%' + @busqueda+'%'
		OR Matricula LIKE '%' + @busqueda+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[sp_buscarProfesores]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_buscarProfesores]
	@busqueda VARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		ProfesorID,
		Nombre + ' ' + Apellido AS 'Nombre',
		Cedula
	FROM tblProfesores
	WHERE
		Inactivo = 0
		AND 
		(
			Nombre LIKE '%'+ @busqueda +'%'
			OR Apellido LIKE '%'+ @busqueda +'%'
			OR Cedula LIKE '%'+ @busqueda +'%'
		)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_buscarSecciones]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_buscarSecciones]
	@asignaturaID INT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		S.SeccionID,
		P.Nombre + ' ' + P.Apellido AS 'Profesor',
		D1.Nombre AS 'Dia1',
		S.HoraInicioDia1,
		S.HoraFinDia1,
		D2.Nombre AS 'Dia2',
		S.HoraInicioDia2,
		S.HoraFinDia2
	FROM tblSecciones S
	INNER JOIN tblProfesores P
		ON P.ProfesorID = S.ProfesorID
	INNER JOIN tblDias D1
		ON D1.DiaID = S.Dia1ID
	INNER JOIN tblDias D2
		ON D2.DiaID = S.Dia2ID
	WHERE
		S.AsignaturaID = @asignaturaID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_crearAsignatura]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_crearAsignatura]
	@descripcion VARCHAR(100),
	@carreraID INT,
	@codigo VARCHAR(10),
	@creditos INT,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT OFF;

	INSERT INTO tblAsignaturas(
		Descripción,
		CarreraID,
		Creditos,
		Codigo,
		Observaciones
	)VALUES(
		@descripcion,
		@carreraID,
		@creditos,
		@codigo,
		@observaciones
	)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_crearAula]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_crearAula]
	@descripcion VARCHAR(100),
	@capacidad SMALLINT,
	@centroId INT,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT OFF;

	INSERT INTO tblAulas(
		Descripcion,
		Capacidad,
		CentroID,
		Observaciones
	)VALUES(
	
		@descripcion,
		@capacidad,
		@centroId,
		@observaciones
	)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_crearCarrera]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_crearCarrera]
	@descripcion VARCHAR(100),
	@creditos INT,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT OFF;

	INSERT INTO tblCarreras(
		Descripcion,
		Creditos,
		Observaciones
	)VALUES(
		@descripcion,
		@creditos,
		@observaciones
	)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_crearCentro]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_crearCentro]
	@nombre VARCHAR(100),
	@nombreCorto VARCHAR(30),
	@descripcion VARCHAR(200),
	@webSite VARCHAR(256),
	@telefono VARCHAR(20),
	@observaciones VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT OFF;
	
	INSERT INTO tblCentros(
		Nombre,
		NombreCorto,
		Descripcion,
		WebSite,
		Telefono,
		Observaciones
	)VALUES(
		@nombre,
		@nombreCorto,
		@descripcion,
		@webSite,
		@telefono,
		@observaciones
	)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_crearEstudiante]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_crearEstudiante]
	@nombre VARCHAR(45),
	@apellido varchar(85),
	@fechaNacimiento DATE,
	@cedula VARCHAR(20),
	@tipoEstudianteID INT,
	@matricula VARCHAR(50),
	@sexo CHAR(1),
	@estadoCivil CHAR(1),
	@telefonoCasa VARCHAR(15),
	@telefonoMovil VARCHAR(15),
	@email VARCHAR(100),
	@observaciones VARCHAR(MAX),
	@carreraID INT
AS
BEGIN
	SET NOCOUNT OFF;

	INSERT INTO tblEstudiantes(
		[Nombre],
		[Apellido],
		[FechaNacimiento],
		[Cedula],
		[TipoEstudianteID],
		[Matricula],
		[Sexo],
		[EstadoCivil],
		[TelefonoCasa],
		[TelefonoMovil],
		[Email],
		[Observaciones],
		[CarreraID]
	)VALUES(
		@nombre,
		@apellido,
		@fechaNacimiento,
		@cedula,
		@tipoEstudianteID,
		@matricula,
		@sexo,
		@estadoCivil,
		@telefonoCasa,
		@telefonoMovil,
		@email,
		@observaciones,
		@carreraID
	)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_crearProfesor]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_crearProfesor]
	@nombre VARCHAR(50),
	@apellido VARCHAR(100),
	@cedula VARCHAR(20),
	@sexo VARCHAR(1),
	@fechaNacimiento DATE,
	@estadoCivil CHAR(1),
	@telefonoCasa VARCHAR(20),
	@telefonoMovil VARCHAR(20),
	@email VARCHAR(255),
	@observaciones VARCHAR(MAX)
AS
BEGIN

	SET NOCOUNT OFF;

	INSERT INTO tblProfesores(
		Nombre,
		Apellido,
		Cedula,
		Sexo,
		FechaNacimiento,
		EstadoCivil,
		TelefonoCasa,
		TelefonoMovil,
		Email,
		Observaciones
	)VALUES(
		@nombre,
		@apellido,
		@cedula,
		@sexo,
		@fechaNacimiento,
		@estadoCivil,
		@telefonoCasa,
		@telefonoMovil,
		@email,
		@observaciones
	)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_crearSeccion]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_crearSeccion]
	@centroID INT,
	@profesorID INT,
	@asignaturaID INT,
	@capacidad INT,
	@aulaID INT,
	@dia1ID INT,
	@dia2ID INT,
	@HoraInicioDia1 TIME,
	@HoraFinDia1 TIME,
	@HoraInicioDia2 TIME,
	@HoraFinDia2 TIME,
	@observaciones VARCHAR(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

	INSERT INTO tblSecciones(
		CentroID,
		ProfesorID,
		AsignaturaID,
		Capacidad,
		AulaID,
		Dia1ID,
		Dia2ID,
		HoraInicioDia1,
		HoraFinDia1,
		HoraInicioDia2,
		HoraFinDia2,
		Observaciones
	)VALUES (
		@centroID,
		@profesorID,
		@asignaturaID,
		@capacidad,
		@aulaID,
		@dia1ID,
		@dia2ID,
		@HoraInicioDia1,
		@HoraFinDia1,
		@HoraInicioDia2,
		@HoraFinDia2,
		@observaciones
	)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_crearUsuario]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[sp_crearUsuario]
	@nombre varchar(100),
	@password varchar(50),
	@usuario varchar(50),
	@tipoUsuarioID int,
	@observaciones varchar(MAX)
AS
BEGIN
	SET NOCOUNT OFF;
	
	INSERT INTO tblUsuarios(
		Nombre,
		Usuario,
		Password,
		TipoUsuarioID,
		Observaciones
	)VALUES(
		@nombre,
		@usuario,
		PWDENCRYPT(@password),
		@tipoUsuarioID,
		@observaciones
	)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_detalleProfesor]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_detalleProfesor]
	@profesorID INT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		Nombre,
		Apellido,
		Cedula,
		Sexo,
		FechaNacimiento,
		EstadoCivil,
		TelefonoCasa,
		TelefonoMovil,
		Email,
		Observaciones
	FROM tblProfesores
	WHERE 
		ProfesorID = @profesorID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_detalleSeccion]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_detalleSeccion]
	@seccionID INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
		S.SeccionID,
		S.CentroID,
		S.ProfesorID,
		S.AsignaturaID,
		S.Capacidad,
		S.AulaID,
		S.Dia1ID,
		S.HoraInicioDia1,
		S.HoraFinDia1,
		S.Dia2ID,
		S.HoraInicioDia2,
		S.HoraFinDia2,
		S.Observaciones
	FROM tblSecciones S
	WHERE
		S.SeccionID = @seccionID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_listadoAulasPorCentro]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_listadoAulasPorCentro]
	@centroID INT
AS
BEGIN

	SET NOCOUNT OFF;

	SELECT 
		AulaID,
		Descripcion
	FROM tblAulas
	WHERE
		CentroID = @centroID
		AND Inactivo = 0
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ListadoCarrera]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 
CREATE PROCEDURE  [dbo].[sp_ListadoCarrera]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT  
		ID,
		Descripcion
		
	FROM tblCarreras
END

GO
/****** Object:  StoredProcedure [dbo].[sp_listadoDias]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_listadoDias]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		DiaID,
		Nombre
	FROM tblDias
END

GO
/****** Object:  StoredProcedure [dbo].[sp_listadoTipoEstudiante]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE PROCEDURE  [dbo].[sp_listadoTipoEstudiante]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT  
		TopoEstudianteID,
		Descripcion 
	FROM tblTipoEstudiantes 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_matricularEstudiante]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_matricularEstudiante]
	@nombre VARCHAR(45),
	@apellido varchar(85),
	@fechaNacimiento DATE,
	@cedula VARCHAR(20),
	@tipoEstudianteID INT,
	@matricula VARCHAR(50),
	@sexo CHAR(1),
	@estadoCivil CHAR(1),
	@telefonoCasa VARCHAR(15),
	@telefonoMovil VARCHAR(15),
	@email VARCHAR(100),
	@observaciones VARCHAR(MAX),
	@carreraID INT
AS
BEGIN
	SET NOCOUNT OFF;

	INSERT INTO tblEstudiantes(
		[Nombre],
		[Apellido],
		[FechaNacimiento],
		[Cedula],
		[TipoEstudianteID],
		[Matricula],
		[Sexo],
		[EstadoCivil],
		[TelefonoCasa],
		[TelefonoMovil],
		[Email],
		[Observaciones],
		[CarreraID]
	)VALUES(
		@nombre,
		@apellido,
		@fechaNacimiento,
		@cedula,
		@tipoEstudianteID,
		@matricula,
		@sexo,
		@estadoCivil,
		@telefonoCasa,
		@telefonoMovil,
		@email,
		@observaciones,
		@carreraID
	)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_validarLogin]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_validarLogin]
	@usuario varchar(50),
	@password varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
		U.UsuarioID,
		U.Nombre,
		U.Usuario,
		TU.Permisos,
		TU.Nombre AS 'TipoUsuario'
	FROM tblUsuarios U
	INNER JOIN tblTipoUsuario TU
		ON U.TipoUsuarioID = TU.ID
	WHERE
		Usuario = @usuario
		AND PWDCOMPARE(@password,Password) = 1 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_verificarConflictosAula]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_verificarConflictosAula]
	@seccionID INT,
	@aulaID INT,
	@dia1 INT,
	@horaInicioDia1 TIME,
	@horaFinDia1 TIME,
	@dia2 INT,
	@horaInicioDia2 TIME,
	@horaFinDia2 TIME
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT 
		S.SeccionID,
		A.Descripcion AS 'Aula',
		D1.Nombre AS 'Dia1',
		S.HoraInicioDia1,
		S.HoraFinDia1,
		D2.Nombre AS 'Dia2',
		S.HoraInicioDia2,
		S.HoraFinDia2
	FROM tblAulas A
	INNER JOIN tblSecciones S
		ON S.AulaID = A.AulaID
	INNER JOIN tblDias D1
		ON D1.DiaID = S.Dia1ID
	INNER JOIN tblDias D2
		ON D2.DiaID = S.Dia2ID
	WHERE
		S.AulaID = @aulaID
		AND
		(
			(
				S.Dia1ID = @dia1
				AND (S.HoraInicioDia1 BETWEEN  @horaInicioDia1 AND @horaFinDia1 OR  S.HoraFinDia1 BETWEEN @horaInicioDia1 AND @horaFinDia1)

			)OR
			(
				S.Dia2ID = @dia1
				AND (S.HoraInicioDia2 BETWEEN  @horaInicioDia1 AND @horaFinDia1 OR  S.HoraFinDia2 BETWEEN @horaInicioDia1 AND @horaFinDia1)
			)
		)
		AND S.SeccionID <> @seccionID
	UNION 
	SELECT 
		S.SeccionID,
		A.Descripcion AS 'Aula',
		D1.Nombre AS 'Dia1',
		S.HoraInicioDia1,
		S.HoraFinDia1,
		D2.Nombre AS 'Dia2',
		S.HoraInicioDia2,
		S.HoraFinDia2
	FROM tblAulas A
	INNER JOIN tblSecciones S
		ON S.AulaID = A.AulaID
	INNER JOIN tblDias D1
		ON D1.DiaID = S.Dia1ID
	INNER JOIN tblDias D2
		ON D2.DiaID = S.Dia2ID
	WHERE
		S.AulaID = @aulaID
		AND 
		(
			(
				S.Dia1ID = @dia2
				AND 
					(S.HoraInicioDia2 BETWEEN  @horaInicioDia2 AND @horaFinDia2 OR  S.HoraFinDia2 BETWEEN @horaInicioDia2 AND @horaFinDia2)

			)OR
			(
				S.Dia2ID = @dia2
				AND 
					(S.HoraInicioDia2 BETWEEN  @horaInicioDia2 AND @horaFinDia2 OR  S.HoraFinDia2 BETWEEN @horaInicioDia2 AND @horaFinDia2)
			)
		)
		AND S.SeccionID <> @seccionID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_verificarConflictosProfesor]    Script Date: 7/7/2019 3:55:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_verificarConflictosProfesor]
	@seccionID INT,
	@profesorID INT,
	@dia1 INT,
	@horaInicioDia1 TIME,
	@horaFinDia1 TIME,
	@dia2 INT,
	@horaInicioDia2 TIME,
	@horaFinDia2 TIME
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT 
		S.SeccionID,
		A.Descripcion AS 'Aula',
		D1.Nombre AS 'Dia1',
		S.HoraInicioDia1,
		S.HoraFinDia1,
		D2.Nombre AS 'Dia2',
		S.HoraInicioDia2,
		S.HoraFinDia2
	FROM tblSecciones S
	INNER JOIN tblAulas A 
		ON A.AulaID = S.AulaID
	INNER JOIN tblDias D1
		ON D1.DiaID = S.Dia1ID
	INNER JOIN tblDias D2
		ON D2.DiaID = S.Dia2ID
	WHERE
		S.AulaID = @profesorID
		AND
		(
			(
				S.Dia1ID = @dia1
				AND (S.HoraInicioDia1 BETWEEN  @horaInicioDia1 AND @horaFinDia1 OR  S.HoraFinDia1 BETWEEN @horaInicioDia1 AND @horaFinDia1)

			)OR
			(
				S.Dia2ID = @dia1
				AND (S.HoraInicioDia2 BETWEEN  @horaInicioDia1 AND @horaFinDia1 OR  S.HoraFinDia2 BETWEEN @horaInicioDia1 AND @horaFinDia1)
			)
		)
		AND S.SeccionID <> @seccionID
	UNION 
	SELECT 
		S.SeccionID,
		A.Descripcion AS 'Aula',
		D1.Nombre AS 'Dia1',
		S.HoraInicioDia1,
		S.HoraFinDia1,
		D2.Nombre AS 'Dia2',
		S.HoraInicioDia2,
		S.HoraFinDia2
	FROM tblSecciones S
	INNER JOIN tblAulas A 
		ON A.AulaID = S.AulaID
	INNER JOIN tblDias D1
		ON D1.DiaID = S.Dia1ID
	INNER JOIN tblDias D2
		ON D2.DiaID = S.Dia2ID
	WHERE
		S.AulaID = @profesorID
		AND 
		(
			(
				S.Dia1ID = @dia2
				AND 
					(S.HoraInicioDia2 BETWEEN  @horaInicioDia2 AND @horaFinDia2 OR  S.HoraFinDia2 BETWEEN @horaInicioDia2 AND @horaFinDia2)

			)OR
			(
				S.Dia2ID = @dia2
				AND 
					(S.HoraInicioDia2 BETWEEN  @horaInicioDia2 AND @horaFinDia2 OR  S.HoraFinDia2 BETWEEN @horaInicioDia2 AND @horaFinDia2)
			)
		)
		AND S.SeccionID <> @seccionID
END

GO
USE [master]
GO
ALTER DATABASE [INF518] SET  READ_WRITE 
GO
