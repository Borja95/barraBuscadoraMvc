--USE [Tutoriales] Tu base de datos, la mía se llama Tutoriales. Si aún no la has creado ejecuta: create database Tutoriales
GO
/****** Object:  Table [dbo].[Atletas]    Script Date: 23/02/2024 11:01:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atletas](
	[Id] [int] NOT NULL,
	[Nombre_Atleta] [varchar](200) NOT NULL,
	[Pais_Origen] [varchar](50) NOT NULL,
	[Marca] [varchar](15) NOT NULL,
	[Lugar_Marca] [varchar](50) NOT NULL,
	[Anio_Marca] [int] NOT NULL,
 CONSTRAINT [PK_Atletas2] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


INSERT INTO [dbo].[Atletas]([Id],[Nombre_Atleta],[Pais_Origen],[Marca],[Lugar_Marca],[Anio_Marca]) VALUES (1, 'Kelvin Kiptum', 'Kenia', '2:00:35', 'Chicago', 2023)
INSERT INTO [dbo].[Atletas]([Id],[Nombre_Atleta],[Pais_Origen],[Marca],[Lugar_Marca],[Anio_Marca]) VALUES (2, 'Eliud Kipchoge', 'Kenia', '2:01:09', 'Berlin', 2022)
INSERT INTO [dbo].[Atletas]([Id],[Nombre_Atleta],[Pais_Origen],[Marca],[Lugar_Marca],[Anio_Marca]) VALUES (3, 'Kenenisa Bekele', 'Etiopia', '2:01:41', 'Berlin', 2019)
INSERT INTO [dbo].[Atletas]([Id],[Nombre_Atleta],[Pais_Origen],[Marca],[Lugar_Marca],[Anio_Marca]) VALUES (4, 'Sisay Lemma', 'Etiopia', '2:01:48', 'Valencia', 2023)
INSERT INTO [dbo].[Atletas]([Id],[Nombre_Atleta],[Pais_Origen],[Marca],[Lugar_Marca],[Anio_Marca]) VALUES (5, 'Birhanu Legese', 'Etiopia', '2:02:47', 'Berlin', 2019)

