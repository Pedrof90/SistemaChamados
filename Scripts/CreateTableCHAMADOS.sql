USE [Sistema_De_Chamados]
GO

/****** Object:  Table [dbo].[Chamado]    Script Date: 26/10/2019 17:54:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Chamado](
	[IdChamado] [int] IDENTITY(800,1) NOT NULL,
	[Titulo] [varchar](500) NULL,
	[Produto] [varchar](500) NULL,
	[Contato] [varchar](20) NULL,
	[Descricao] [varchar](1000) NULL,
	[Solucao] [varchar](1000) NULL,
	[StatusChamado] [varchar](200) NULL,
	[Prioridade] [varchar](200) NULL,
	[DataCriacao] [datetime] NULL,
	[DataAlteracao] [datetime] NULL,
	[UsuarioChamado] [varchar](500) NULL,
	[Tecnico] [varchar](500) NULL
) ON [PRIMARY]
GO


