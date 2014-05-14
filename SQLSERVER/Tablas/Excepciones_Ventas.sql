USE [msforraje]
GO

/****** Object:  Table [dbo].[Excepciones_Ventas]    Script Date: 13/05/2014 23:04:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Excepciones_Ventas](
	[cod_producto] [char](6) NOT NULL,
	[id_articulo] [int] NOT NULL,
	[id_venta] [int] NOT NULL,
	[n_excepcion] [int] IDENTITY(1,1) NOT NULL,
	[comentario] [text] NOT NULL,
	[costo] [float] NOT NULL,
	[venta] [float] NOT NULL,
 CONSTRAINT [PK_Excepciones_Ventas_1] PRIMARY KEY CLUSTERED 
(
	[cod_producto] ASC,
	[id_articulo] ASC,
	[id_venta] ASC,
	[n_excepcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

