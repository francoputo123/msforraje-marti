USE [msforraje]
GO

/****** Object:  Table [dbo].[Articulos]    Script Date: 13/05/2014 23:03:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Articulos](
	[id_articulo] [int] IDENTITY(1,1) NOT NULL,
	[cod_producto] [char](6) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[unidad_articulo] [float] NOT NULL,
	[habilitado] [bit] NOT NULL,
	[fecha_ingreso] [smalldatetime] NOT NULL,
	[fecha_modificacion] [smalldatetime] NOT NULL,
	[costo] [money] NOT NULL,
	[venta] [money] NOT NULL,
	[costo2] [money] NULL,
	[venta2] [money] NULL,
	[stock] [float] NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[id_articulo] ASC,
	[cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Productos] FOREIGN KEY([cod_producto])
REFERENCES [dbo].[Productos] ([cod_producto])
GO

ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Productos]
GO

