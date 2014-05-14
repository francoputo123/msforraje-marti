USE [msforraje]
GO

/****** Object:  Table [dbo].[Ventas_Detalles]    Script Date: 13/05/2014 23:05:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Ventas_Detalles](
	[id_venta] [int] NOT NULL,
	[cod_producto] [char](6) NOT NULL,
	[id_articulo] [int] NOT NULL,
	[costo] [money] NOT NULL,
	[venta] [money] NOT NULL,
	[n_excepcion] [int] NULL,
 CONSTRAINT [PK_Ventas_Detalles] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC,
	[cod_producto] ASC,
	[id_articulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Ventas_Detalles]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Detalles_Articulos] FOREIGN KEY([id_articulo], [cod_producto])
REFERENCES [dbo].[Articulos] ([id_articulo], [cod_producto])
GO

ALTER TABLE [dbo].[Ventas_Detalles] CHECK CONSTRAINT [FK_Ventas_Detalles_Articulos]
GO

ALTER TABLE [dbo].[Ventas_Detalles]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Detalles_Excepciones_Ventas] FOREIGN KEY([cod_producto], [id_articulo], [id_venta], [n_excepcion])
REFERENCES [dbo].[Excepciones_Ventas] ([cod_producto], [id_articulo], [id_venta], [n_excepcion])
GO

ALTER TABLE [dbo].[Ventas_Detalles] CHECK CONSTRAINT [FK_Ventas_Detalles_Excepciones_Ventas]
GO

ALTER TABLE [dbo].[Ventas_Detalles]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Detalles_Ventas] FOREIGN KEY([id_venta])
REFERENCES [dbo].[Ventas] ([id_venta])
GO

ALTER TABLE [dbo].[Ventas_Detalles] CHECK CONSTRAINT [FK_Ventas_Detalles_Ventas]
GO

