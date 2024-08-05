USE [CrudTest]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 04/08/2024 21:43:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empleado]') AND type in (N'U'))
DROP TABLE [dbo].[Empleado]
GO
/****** Object:  Table [dbo].[Cat_Entidades]    Script Date: 04/08/2024 21:43:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cat_Entidades]') AND type in (N'U'))
DROP TABLE [dbo].[Cat_Entidades]
GO
/****** Object:  Table [dbo].[Cat_Entidades]    Script Date: 04/08/2024 21:43:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cat_Entidades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 04/08/2024 21:43:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumeroNomina] [varchar](200) NULL,
	[Nombre] [varchar](100) NULL,
	[ApellidoPaterno] [varchar](100) NULL,
	[ApellidoMaterno] [varchar](100) NULL,
	[IdEstado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cat_Entidades] ON 
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (1, N'Aguascalientes')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (2, N'Baja California')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (3, N'Baja California Sur')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (4, N'Campeche')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (5, N'Coahuila de Zaragoza')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (6, N'Colima')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (7, N'Chiapas')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (8, N'Chihuahua')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (9, N'Distrito Federal')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (10, N'Durango')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (11, N'Guanajuato')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (12, N'Guerrero')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (13, N'Hidalgo')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (14, N'Jalisco')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (15, N'Mexico')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (16, N'Michoacan de Ocampo')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (17, N'Morelos')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (18, N'Nayarit')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (19, N'Nuevo Leon')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (20, N'Oaxaca de Juarez')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (21, N'Puebla')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (22, N'Queretaro')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (23, N'Quintana Roo')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (24, N'San Luis Potosi')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (25, N'Sinaloa')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (26, N'Sonora')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (27, N'Tabasco')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (28, N'Tamaulipas')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (29, N'Tlaxcala')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (30, N'Veracruz de Ignacio de la Llave')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (31, N'Yucatan')
GO
INSERT [dbo].[Cat_Entidades] ([Id], [Estado]) VALUES (32, N'Zacatecas')
GO
SET IDENTITY_INSERT [dbo].[Cat_Entidades] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 
GO
INSERT [dbo].[Empleado] ([Id], [NumeroNomina], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [IdEstado]) VALUES (1, N'1-1', N'Daniel', N'Ochoa', N'Ochoa', 13)
GO
INSERT [dbo].[Empleado] ([Id], [NumeroNomina], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [IdEstado]) VALUES (2, N'4-2', N'Nicolas', N'Barrera', N'Vera', 4)
GO
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO

create  trigger [dbo].[TR_Empleados]
  on [dbo].[Empleado]
  for insert
  as
   declare @idEstdo    int
   declare @id    int=0;
   SELECT @id=MAX(ID) FROM Empleado
   SELECT @idEstdo=IDeSTADO FROM Empleado WHERE  Id=@id

  
    update Empleado set NumeroNomina=CAST(@idEstdo AS VARCHAR)+'-' +CAST(@id AS VARCHAR)
    
     where Id=@id
GO
