USE [msforraje]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 13/05/2014 23:03:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[cod_cliente] [char](4) NULL,
	[nombre] [varchar](50) NULL,
	[cod_localidad] [char](4) NOT NULL,
	[direccion] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[comentario] [text] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

