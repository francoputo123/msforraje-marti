USE [msforraje]
GO

/****** Object:  Table [dbo].[Precios]    Script Date: 13/05/2014 23:04:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Precios](
	[cod_producto] [char](6) NOT NULL,
	[id_articulo] [int] NOT NULL,
	[fechahora] [smalldatetime] NOT NULL,
	[costo] [money] NOT NULL,
	[venta] [money] NOT NULL,
	[costo2] [money] NULL,
	[venta2] [money] NULL,
 CONSTRAINT [PK_Precios_1] PRIMARY KEY CLUSTERED 
(
	[cod_producto] ASC,
	[id_articulo] ASC,
	[fechahora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Precios]  WITH CHECK ADD  CONSTRAINT [FK_Precios_Articulos] FOREIGN KEY([id_articulo], [cod_producto])
REFERENCES [dbo].[Articulos] ([id_articulo], [cod_producto])
GO

ALTER TABLE [dbo].[Precios] CHECK CONSTRAINT [FK_Precios_Articulos]
GO

