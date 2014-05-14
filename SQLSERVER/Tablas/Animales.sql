USE [msforraje]
GO

/****** Object:  Table [dbo].[Animales]    Script Date: 13/05/2014 23:03:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Animales](
	[cod_animal] [char](4) NOT NULL,
	[descripcion_larga] [varchar](20) NOT NULL,
	[descripcion_corta] [varchar](6) NOT NULL,
 CONSTRAINT [PK_Animales] PRIMARY KEY CLUSTERED 
(
	[cod_animal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Animales__B557E4052F245FAF] UNIQUE NONCLUSTERED 
(
	[descripcion_larga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Animales]  WITH CHECK ADD  CONSTRAINT [CK_Animales] CHECK  (([cod_animal] like '[A-Z][A-Z][0-9][0-9]'))
GO

ALTER TABLE [dbo].[Animales] CHECK CONSTRAINT [CK_Animales]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CODIGO DE ANIAMALES AA99' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Animales', @level2type=N'CONSTRAINT',@level2name=N'CK_Animales'
GO

