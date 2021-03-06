USE [TPI]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/15/2016 00:30:13 ******/
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
INSERT [dbo].[Usuario] ([id], [password], [nombre], [apellido], [matricula], [activo], [email]) VALUES (6, N'asdf', N'Josefina', N'Paschetta', 3452, 0, N'jpaschetta@fca.com')
INSERT [dbo].[Usuario] ([id], [password], [nombre], [apellido], [matricula], [activo], [email]) VALUES (7, N'asd123', N'Ramon', N'Vega', 764, 0, N'rvega@fca.com')
INSERT [dbo].[Usuario] ([id], [password], [nombre], [apellido], [matricula], [activo], [email]) VALUES (8, N'test123', N'Juan', N'Fonseca', 764, 0, N'jfonseca@fca.com')
INSERT [dbo].[Usuario] ([id], [password], [nombre], [apellido], [matricula], [activo], [email]) VALUES (9, N'Hola1234', N'Gustavo', N'Perez', 764, 0, N'gperez@fca.com')
INSERT [dbo].[Usuario] ([id], [password], [nombre], [apellido], [matricula], [activo], [email]) VALUES (10, N'test1234', N'Miriam', N'Ruiz', 764, 0, N'mruiz@fca.com')
INSERT [dbo].[Usuario] ([id], [password], [nombre], [apellido], [matricula], [activo], [email]) VALUES (11, N'test1234', N'Esteban', N'Frias', 764, 0, N'efrias@fca.com')
INSERT [dbo].[Usuario] ([id], [password], [nombre], [apellido], [matricula], [activo], [email]) VALUES (12, N'qazwsx', N'tester', N'testing', 764, 0, N'something@domain.com')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  Table [dbo].[Tipo_Volumen]    Script Date: 11/15/2016 00:30:13 ******/
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
/****** Object:  Table [dbo].[Paises]    Script Date: 11/15/2016 00:30:13 ******/
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
/****** Object:  Table [dbo].[Material]    Script Date: 11/15/2016 00:30:13 ******/
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
/****** Object:  Table [dbo].[Calle]    Script Date: 11/15/2016 00:30:13 ******/
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
INSERT [dbo].[Calle] ([id_calle], [decrip], [habilitada], [llena], [tipo_volumen]) VALUES (1, N'alfa', 0, 0, 2)
INSERT [dbo].[Calle] ([id_calle], [decrip], [habilitada], [llena], [tipo_volumen]) VALUES (5, N'omega', 0, 0, 1)
INSERT [dbo].[Calle] ([id_calle], [decrip], [habilitada], [llena], [tipo_volumen]) VALUES (8, N'delta', 0, 0, 1)
INSERT [dbo].[Calle] ([id_calle], [decrip], [habilitada], [llena], [tipo_volumen]) VALUES (9, N'tau', 0, 0, 1)
INSERT [dbo].[Calle] ([id_calle], [decrip], [habilitada], [llena], [tipo_volumen]) VALUES (10, N'epsilon', 0, 0, 1)
INSERT [dbo].[Calle] ([id_calle], [decrip], [habilitada], [llena], [tipo_volumen]) VALUES (11, N'sigma', 0, 0, 1)
INSERT [dbo].[Calle] ([id_calle], [decrip], [habilitada], [llena], [tipo_volumen]) VALUES (12, N'lambda', 0, 0, 1)
SET IDENTITY_INSERT [dbo].[Calle] OFF
/****** Object:  Table [dbo].[Proveedor]    Script Date: 11/15/2016 00:30:13 ******/
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
INSERT [dbo].[Proveedor] ([cod_proveedor], [cuit], [razon_social], [pais], [contacto], [email], [habilitado]) VALUES (10, 77893456123, N'Magnetti                                          ', 8, N'', N'contact@marelli.com', 0)
INSERT [dbo].[Proveedor] ([cod_proveedor], [cuit], [razon_social], [pais], [contacto], [email], [habilitado]) VALUES (11, 33456781234, N'Bosch                                             ', 4, N'Damian Lopez', N'dlopez@bosch.com', 0)
INSERT [dbo].[Proveedor] ([cod_proveedor], [cuit], [razon_social], [pais], [contacto], [email], [habilitado]) VALUES (12, 12345678912, N'Sachs                                             ', 6, N'Ezequiel Rodriguez', N'erodriguez@sachs.com', 0)
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
/****** Object:  Table [dbo].[Ubicacion]    Script Date: 11/15/2016 00:30:13 ******/
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
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (305, 1, 1, 0, 1)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (306, 1, 2, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (307, 1, 3, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (308, 1, 4, 0, 1)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (309, 1, 5, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (310, 1, 6, 0, 1)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (315, 5, 1, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (326, 8, 1, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (327, 8, 2, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (328, 8, 3, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (329, 8, 4, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (330, 8, 5, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (331, 8, 6, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (332, 8, 7, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (333, 8, 8, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (334, 8, 9, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (335, 8, 10, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (336, 8, 11, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (337, 8, 12, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (338, 8, 13, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (339, 8, 14, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (340, 8, 15, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (341, 8, 16, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (342, 8, 17, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (343, 8, 18, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (344, 8, 19, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (345, 8, 20, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (346, 8, 21, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (347, 8, 22, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (348, 8, 23, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (349, 8, 24, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (350, 8, 25, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (351, 8, 26, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (352, 8, 27, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (353, 8, 28, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (354, 8, 29, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (355, 8, 30, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (356, 8, 31, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (357, 8, 32, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (358, 8, 33, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (359, 8, 34, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (360, 9, 1, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (361, 9, 2, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (362, 9, 3, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (363, 9, 4, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (364, 9, 5, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (365, 10, 1, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (366, 10, 2, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (367, 10, 3, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (368, 11, 1, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (369, 11, 2, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (373, 12, 1, 0, 0)
INSERT [dbo].[Ubicacion] ([id_ubicacion], [id_calle], [nro], [habilitada], [ocupada]) VALUES (374, 12, 2, 0, 0)
SET IDENTITY_INSERT [dbo].[Ubicacion] OFF
/****** Object:  Table [dbo].[Prov_X_Mat]    Script Date: 11/15/2016 00:30:13 ******/
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
/****** Object:  ForeignKey [FK_Calle_Tipo_Volumen]    Script Date: 11/15/2016 00:30:13 ******/
ALTER TABLE [dbo].[Calle]  WITH CHECK ADD  CONSTRAINT [FK_Calle_Tipo_Volumen] FOREIGN KEY([tipo_volumen])
REFERENCES [dbo].[Tipo_Volumen] ([id])
GO
ALTER TABLE [dbo].[Calle] CHECK CONSTRAINT [FK_Calle_Tipo_Volumen]
GO
/****** Object:  ForeignKey [FK_Material_Tipo_Volumen]    Script Date: 11/15/2016 00:30:13 ******/
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [FK_Material_Tipo_Volumen] FOREIGN KEY([tipo_vol])
REFERENCES [dbo].[Tipo_Volumen] ([id])
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [FK_Material_Tipo_Volumen]
GO
/****** Object:  ForeignKey [FK_Prov_X_Mat_Material]    Script Date: 11/15/2016 00:30:13 ******/
ALTER TABLE [dbo].[Prov_X_Mat]  WITH CHECK ADD  CONSTRAINT [FK_Prov_X_Mat_Material] FOREIGN KEY([id_mat])
REFERENCES [dbo].[Material] ([id_mat])
GO
ALTER TABLE [dbo].[Prov_X_Mat] CHECK CONSTRAINT [FK_Prov_X_Mat_Material]
GO
/****** Object:  ForeignKey [FK_Prov_X_Mat_Proveedor]    Script Date: 11/15/2016 00:30:13 ******/
ALTER TABLE [dbo].[Prov_X_Mat]  WITH CHECK ADD  CONSTRAINT [FK_Prov_X_Mat_Proveedor] FOREIGN KEY([id_prov])
REFERENCES [dbo].[Proveedor] ([cod_proveedor])
GO
ALTER TABLE [dbo].[Prov_X_Mat] CHECK CONSTRAINT [FK_Prov_X_Mat_Proveedor]
GO
/****** Object:  ForeignKey [FK_Proveedor_Paises]    Script Date: 11/15/2016 00:30:13 ******/
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Paises] FOREIGN KEY([pais])
REFERENCES [dbo].[Paises] ([id])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Paises]
GO
/****** Object:  ForeignKey [FK_Ubicacion_Calle]    Script Date: 11/15/2016 00:30:13 ******/
ALTER TABLE [dbo].[Ubicacion]  WITH CHECK ADD  CONSTRAINT [FK_Ubicacion_Calle] FOREIGN KEY([id_calle])
REFERENCES [dbo].[Calle] ([id_calle])
GO
ALTER TABLE [dbo].[Ubicacion] CHECK CONSTRAINT [FK_Ubicacion_Calle]
GO
