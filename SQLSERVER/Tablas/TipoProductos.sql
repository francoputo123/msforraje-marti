USE [msforraje]
GO

/****** Object:  Table [dbo].[TipoProductos]    Script Date: 13/05/2014 23:04:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TipoProductos](
	[cod_tipoproducto] [char](4) NOT NULL,
	[descripcion_larga] [varchar](20) NULL,
	[descripcion_corta] [varchar](5) NOT NULL,
 CONSTRAINT [PK_TipoProducto] PRIMARY KEY CLUSTERED 
(
	[cod_tipoproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__TipoProd__F0584FF472859105] UNIQUE NONCLUSTERED 
(
	[cod_tipoproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[TipoProductos]  WITH CHECK ADD  CONSTRAINT [CK_TipoProductos] CHECK  (([cod_tipoproducto] like '[A-Z][A-Z][0-9][0-9]'))
GO

ALTER TABLE [dbo].[TipoProductos] CHECK CONSTRAINT [CK_TipoProductos]
GO

