USE [Sistema_De_Chamados]
GO

/****** Object:  Table [dbo].[Usuario]    Script Date: 26/10/2019 17:54:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuario](
	[Login] [varchar](20) NULL,
	[Inscricao] [varchar](20) NULL,
	[Email] [varchar](500) NULL,
	[Celular] [varchar](20) NULL,
	[Senha] [varchar](20) NULL,
	[TipoUsuario] [int] NULL
) ON [PRIMARY]
GO


