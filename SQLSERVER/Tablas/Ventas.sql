USE [msforraje]
GO

/****** Object:  Table [dbo].[Ventas]    Script Date: 13/05/2014 23:04:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ventas](
	[id_venta] [int] NOT NULL,
	[fechahora] [datetime] NOT NULL,
	[id_cliente] [int] NULL,
	[descuento] [float] NULL,
	[comentario] [text] NULL,
 CONSTRAINT [PK_Ventas_1] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO

ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO

