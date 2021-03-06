USE [dbpetsepets]
GO
/****** Object:  Table [dbo].[Oservico]    Script Date: 03/07/2021 23:18:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oservico](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nomepet] [varchar](100) NOT NULL,
	[especie] [varchar](50) NOT NULL,
	[raca] [varchar](50) NULL,
	[proprietario] [varchar](100) NOT NULL,
	[telefone] [varchar](50) NULL,
	[email] [varchar](100) NULL,
	[c_especiais] [varchar](200) NULL,
	[alergico] [varchar](150) NULL,
	[observacao] [varchar](150) NULL,
	[servico1] [varchar](50) NOT NULL,
	[checkserv1] [varchar](1) NULL,
	[valorserv1] [varchar](50) NOT NULL,
	[servico2] [varchar](50) NULL,
	[checkserv2] [varchar](1) NULL,
	[valorserv2] [varchar](50) NULL,
	[servico3] [varchar](50) NULL,
	[checkserv3] [varchar](1) NULL,
	[valorserv3] [varchar](50) NULL,
	[servico4] [varchar](50) NULL,
	[valorserv4] [varchar](50) NULL,
	[taxaentrega] [varchar](50) NULL,
	[hora] [varchar](10) NULL,
	[data] [datetime] NOT NULL,
	[dataos] [date] NOT NULL,
	[valortotal] [varchar](50) NOT NULL,
	[desconto] [varchar](50) NULL,
	[valorfinal] [varchar](50) NOT NULL,
	[formapgto1] [varchar](50) NOT NULL,
	[valor1] [varchar](50) NOT NULL,
	[checkpgto2] [varchar](1) NULL,
	[formapgto2] [varchar](50) NULL,
	[valor2] [varchar](50) NULL,
	[checkpgto3] [varchar](1) NULL,
	[formapgto3] [varchar](50) NULL,
	[valor3] [varchar](50) NULL
) ON [PRIMARY]
GO
