USE [msforraje]
GO

/****** Object:  Table [dbo].[Marcas]    Script Date: 13/05/2014 23:04:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Marcas](
	[cod_marca] [char](6) NOT NULL,
	[descripcion_larga] [varchar](20) NULL,
	[descripcion_corta] [varchar](6) NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[cod_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Marcas__BD29DD91A9D1A948] UNIQUE NONCLUSTERED 
(
	[cod_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Marcas]  WITH CHECK ADD  CONSTRAINT [CK_Marcas] CHECK  (([cod_marca] like '[A-Z][A-Z][0-9][0-9]'))
GO

ALTER TABLE [dbo].[Marcas] CHECK CONSTRAINT [CK_Marcas]
GO
