USE [TPI]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/08/2016 21:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[password] [varchar](8) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[matricula] [int] NOT NULL,
	[activo] [bit] NOT NULL,
	[email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT [dbo].[Usuario] ([id], [password], [nombre], [apellido], [matricula], [activo], [email]) VALUES (1, N'user1234', N'toto1', N'perez', 9539, 0, N'tester@dominio.com')
INSERT [dbo].[Usuario] ([id], [password], [nombre], [apellido], [matricula], [activo], [email]) VALUES (2, N'1234', N'test1', N'lolo', 123, 0, N'lala@gmail.com')
INSERT [dbo].[Usuario] ([id], [password], [nombre], [apellido], [matricula], [activo], [email]) VALUES (5, N'asdf', N'tester', N'Dummy', 55322, 0, N'test@something.com')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  Table [dbo].[Tipo_Volumen]    Script Date: 11/08/2016 21:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipo_Volumen](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tipo_Volumen] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo_Volumen] ON
INSERT [dbo].[Tipo_Volumen] ([id], [descripcion]) VALUES (1, N'Voluminoso')
INSERT [dbo].[Tipo_Volumen] ([id], [descripcion]) VALUES (2, N'Minutería')
INSERT [dbo].[Tipo_Volumen] ([id], [descripcion]) VALUES (3, N'Regular')
SET IDENTITY_INSERT [dbo].[Tipo_Volumen] OFF
/****** Object:  Table [dbo].[Paises]    Script Date: 11/08/2016 21:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Paises](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Paises] ON
INSERT [dbo].[Paises] ([id], [descripcion]) VALUES (1, N'Argentina')
INSERT [dbo].[Paises] ([id], [descripcion]) VALUES (2, N'Chile')
INSERT [dbo].[Paises] ([id], [descripcion]) VALUES (3, N'Uruguay')
INSERT [dbo].[Paises] ([id], [descripcion]) VALUES (4, N'Paraguay')
INSERT [dbo].[Paises] ([id], [descripcion]) VALUES (5, N'Brasil')
INSERT [dbo].[Paises] ([id], [descripcion]) VALUES (6, N'Colombia')
INSERT [dbo].[Paises] ([id], [descripcion]) VALUES (7, N'Peru')
INSERT [dbo].[Paises] ([id], [descripcion]) VALUES (8, N'Venezuela')
SET IDENTITY_INSERT [dbo].[Paises] OFF
/****** Object:  Table [dbo].[Material]    Script Date: 11/08/2016 21:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Material](
	[id_mat] [bigint] IDENTITY(1,1) NOT NULL,
	[descrip] [varchar](100) NOT NULL,
	[tipo_vol] [int] NOT NULL,
	[habilitado] [int] NOT NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[id_mat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Material] ON
INSERT [dbo].[Material] ([id_mat], [descrip], [tipo_vol], [habilitado]) VALUES (1, N'lateral derecho', 3, 0)
INSERT [dbo].[Material] ([id_mat], [descrip], [tipo_vol], [habilitado]) VALUES (2, N'tornillo', 2, 0)
INSERT [dbo].[Material] ([id_mat], [descrip], [tipo_vol], [habilitado]) VALUES (3, N'árbol de leva', 3, 0)
INSERT [dbo].[Material] ([id_mat], [descrip], [tipo_vol], [habilitado]) VALUES (4, N'clavo', 2, 0)
INSERT [dbo].[Material] ([id_mat], [descrip], [tipo_vol], [habilitado]) VALUES (5, N'tachuela', 2, 1)
INSERT [dbo].[Material] ([id_mat], [descrip], [tipo_vol], [habilitado]) VALUES (6, N'Insonorizante', 2, 0)
INSERT [dbo].[Material] ([id_mat], [descrip], [tipo_vol], [habilitado]) VALUES (7, N'cpu', 3, 0)
INSERT [dbo].[Material] ([id_mat], [descrip], [tipo_vol], [habilitado]) VALUES (8, N'mouse', 3, 0)
INSERT [dbo].[Material] ([id_mat], [descrip], [tipo_vol], [habilitado]) VALUES (9, N'teclado', 2, 0)
SET IDENTITY_INSERT [dbo].[Material] OFF
/****** Object:  Table [dbo].[Calle]    Script Date: 11/08/2016 21:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Calle](
	[id_calle] [int] IDENTITY(1,1) NOT NULL,
	[decrip] [varchar](50) NOT NULL,
	[habilitada] [int] NOT NULL,
	[llena] [int] NOT NULL,
	[tipo_volumen] [int] NOT NULL,
 CONSTRAINT [PK_Calle] PRIMARY KEY CLUSTERED 
(
	[id_calle] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Calle] ON
INSERT [dbo].[Calle] ([id_calle], [decrip], [habilitada], [llena], [tipo_volumen]) VALUES (1, N'mi calle', 0, 0, 1)
INSERT [dbo].[Calle] ([id_calle], [decrip], [habilitada], [llena], [tipo_volumen]) VALUES (2, N'calle zeta', 0, 0, 1)
SET IDENTITY_INSERT [dbo].[Calle] OFF
/****** Object:  Table [dbo].[Proveedor]    Script Date: 11/08/2016 21:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[cod_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[cuit] [bigint] NOT NULL,
	[razon_social] [char](50) NOT NULL,
	[pais] [int] NOT NULL,
	[contacto] [varchar](100) NULL,
	[email] [varchar](100) NOT NULL,
	[habilitado] [bit] NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[cod_proveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON
INSERT [dbo].[Proveedor] ([cod_proveedor], [cuit], [razon_social], [pais], [contacto], [email], [habilitado]) VALUES (7, 27355728698, N'GESTAMP                                           ', 1, N'Contacto GESTAMP', N'algo@gmail.com', 0)
INSERT [dbo].[Proveedor] ([cod_proveedor], [cuit], [razon_social], [pais], [contacto], [email], [habilitado]) VALUES (8, 12345678912, N'Tiberina                                          ', 3, N'Tibe', N'pablo@tiberina.com', 0)
INSERT [dbo].[Proveedor] ([cod_proveedor], [cuit], [razon_social], [pais], [contacto], [email], [habilitado]) VALUES (9, 98765432123, N'DENSO Manufacturing                               ', 1, N'', N'11@denso.com', 1)
INSERT [dbo].[Proveedor] ([cod_proveedor], [cuit], [razon_social], [pais], [contacto], [email], [habilitado]) VALUES (10, 77893456123, N'Magnetti                                          ', 8, N'.', N'contact@marelli.com', 0)
INSERT [dbo].[Proveedor] ([cod_proveedor], [cuit], [razon_social], [pais], [contacto], [email], [habilitado]) VALUES (11, 33456781234, N'mcdonalds                                         ', 4, N'nada', N'algo@gmail.com', 0)
INSERT [dbo].[Proveedor] ([cod_proveedor], [cuit], [razon_social], [pais], [contacto], [email], [habilitado]) VALUES (12, 12345678912, N'puflito                                           ', 6, N'lolo', N'al@go.com', 0)
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
/****** Object:  Table [dbo].[Ubicacion]    Script Date: 11/08/2016 21:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ubicacion](
	[id_ubicacion] [bigint] IDENTITY(1,1) NOT NULL,
	[id_calle] [int] NOT NULL,
	[nro] [int] NOT NULL,
	[habilitada] [int] NOT NULL,
	[ocupada] [int] NOT NULL,
 CONSTRAINT [PK_Ubicacion] PRIMARY KEY CLUSTERED 
(
	[id_ubicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ubicacion] ON
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (1, 2, 1, 0, 0)
SET IDENTITY_INSERT [dbo].[Ubicacion] OFF
/****** Object:  Table [dbo].[Prov_X_Mat]    Script Date: 11/08/2016 21:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prov_X_Mat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_mat] [bigint] NOT NULL,
	[id_prov] [int] NOT NULL,
 CONSTRAINT [PK_Prov_X_Mat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Prov_X_Mat] ON
INSERT [dbo].[Prov_X_Mat] ([id], [id_mat], [id_prov]) VALUES (11, 5, 8)
INSERT [dbo].[Prov_X_Mat] ([id], [id_mat], [id_prov]) VALUES (12, 6, 7)
INSERT [dbo].[Prov_X_Mat] ([id], [id_mat], [id_prov]) VALUES (14, 2, 7)
INSERT [dbo].[Prov_X_Mat] ([id], [id_mat], [id_prov]) VALUES (17, 3, 8)
INSERT [dbo].[Prov_X_Mat] ([id], [id_mat], [id_prov]) VALUES (18, 3, 10)
INSERT [dbo].[Prov_X_Mat] ([id], [id_mat], [id_prov]) VALUES (19, 4, 8)
INSERT [dbo].[Prov_X_Mat] ([id], [id_mat], [id_prov]) VALUES (22, 1, 7)
INSERT [dbo].[Prov_X_Mat] ([id], [id_mat], [id_prov]) VALUES (23, 7, 12)
INSERT [dbo].[Prov_X_Mat] ([id], [id_mat], [id_prov]) VALUES (24, 8, 11)
INSERT [dbo].[Prov_X_Mat] ([id], [id_mat], [id_prov]) VALUES (25, 9, 8)
SET IDENTITY_INSERT [dbo].[Prov_X_Mat] OFF
/****** Object:  ForeignKey [FK_Calle_Tipo_Volumen]    Script Date: 11/08/2016 21:02:32 ******/
ALTER TABLE [dbo].[Calle]  WITH CHECK ADD  CONSTRAINT [FK_Calle_Tipo_Volumen] FOREIGN KEY([tipo_volumen])
REFERENCES [dbo].[Tipo_Volumen] ([id])
GO
ALTER TABLE [dbo].[Calle] CHECK CONSTRAINT [FK_Calle_Tipo_Volumen]
GO
/****** Object:  ForeignKey [FK_Material_Tipo_Volumen]    Script Date: 11/08/2016 21:02:32 ******/
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [FK_Material_Tipo_Volumen] FOREIGN KEY([tipo_vol])
REFERENCES [dbo].[Tipo_Volumen] ([id])
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [FK_Material_Tipo_Volumen]
GO
/****** Object:  ForeignKey [FK_Prov_X_Mat_Material]    Script Date: 11/08/2016 21:02:32 ******/
ALTER TABLE [dbo].[Prov_X_Mat]  WITH CHECK ADD  CONSTRAINT [FK_Prov_X_Mat_Material] FOREIGN KEY([id_mat])
REFERENCES [dbo].[Material] ([id_mat])
GO
ALTER TABLE [dbo].[Prov_X_Mat] CHECK CONSTRAINT [FK_Prov_X_Mat_Material]
GO
/****** Object:  ForeignKey [FK_Prov_X_Mat_Proveedor]    Script Date: 11/08/2016 21:02:32 ******/
ALTER TABLE [dbo].[Prov_X_Mat]  WITH CHECK ADD  CONSTRAINT [FK_Prov_X_Mat_Proveedor] FOREIGN KEY([id_prov])
REFERENCES [dbo].[Proveedor] ([cod_proveedor])
GO
ALTER TABLE [dbo].[Prov_X_Mat] CHECK CONSTRAINT [FK_Prov_X_Mat_Proveedor]
GO
/****** Object:  ForeignKey [FK_Proveedor_Paises]    Script Date: 11/08/2016 21:02:32 ******/
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Paises] FOREIGN KEY([pais])
REFERENCES [dbo].[Paises] ([id])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Paises]
GO
/****** Object:  ForeignKey [FK_Ubicacion_Calle]    Script Date: 11/08/2016 21:02:32 ******/
ALTER TABLE [dbo].[Ubicacion]  WITH CHECK ADD  CONSTRAINT [FK_Ubicacion_Calle] FOREIGN KEY([id_calle])
REFERENCES [dbo].[Calle] ([id_calle])
GO
ALTER TABLE [dbo].[Ubicacion] CHECK CONSTRAINT [FK_Ubicacion_Calle]
GO
