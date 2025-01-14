USE [HotelSirius]
GO
/****** Object:  Table [dbo].[FichaUsuario]    Script Date: 28/10/2024 06:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FichaUsuario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_FichaUsuario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PagoEfectivo]    Script Date: 28/10/2024 06:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagoEfectivo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NombreTitular] [nvarchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[FechaIngreso] [date] NULL,
	[FechaSalida] [date] NULL,
	[DNI] [int] NOT NULL,
 CONSTRAINT [PK_PagoEfectivo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PagoTarjeta]    Script Date: 28/10/2024 06:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagoTarjeta](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NombreTitular] [nvarchar](50) NOT NULL,
	[DNI] [int] NOT NULL,
	[Precio] [float] NOT NULL,
	[CodigoSeguridad] [int] NOT NULL,
	[FechaVencimiento] [date] NULL,
	[FechaIngreso] [date] NULL,
	[FechaSalida] [date] NULL,
 CONSTRAINT [PK_PagoTarjeta] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
