USE [msforraje]
GO

/****** Object:  Table [dbo].[Productos]    Script Date: 13/05/2014 23:04:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Productos](
	[cod_producto] [char](6) NOT NULL,
	[cod_marca] [char](6) NOT NULL,
	[cod_tipoproducto] [char](4) NOT NULL,
	[cod_animal] [char](4) NOT NULL,
	[nombre_producto] [varchar](50) NOT NULL,
	[fecha_ingreso] [datetime] NOT NULL,
	[fecha_modificacion] [datetime] NOT NULL,
	[stock_limite] [float] NOT NULL,
	[habilitado] [bit] NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Producto__118203AC04BEE639] UNIQUE NONCLUSTERED 
(
	[cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Animales] FOREIGN KEY([cod_animal])
REFERENCES [dbo].[Animales] ([cod_animal])
GO

ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Animales]
GO

ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Marcas] FOREIGN KEY([cod_marca])
REFERENCES [dbo].[Marcas] ([cod_marca])
GO

ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Marcas]
GO

ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_TipoProductos] FOREIGN KEY([cod_tipoproducto])
REFERENCES [dbo].[TipoProductos] ([cod_tipoproducto])
GO

ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_TipoProductos]
GO

ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [CK_Productos] CHECK  (([cod_producto] like '[A-Z][A-Z][A-Z][0-9][0-9][0-9]'))
GO

ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [CK_Productos]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Producto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Productos', @level2type=N'CONSTRAINT',@level2name=N'CK_Productos'
GO

