USE [dbpetsepets]
GO
/****** Object:  Table [dbo].[Animal]    Script Date: 03/07/2021 12:37:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[especie] [varchar](50) NOT NULL,
	[raca] [varchar](100) NULL,
	[nome] [varchar](100) NOT NULL,
	[idadenumero1] [varchar](3) NOT NULL,
	[idadetipo1] [varchar](10) NOT NULL,
	[idadenumero2] [nchar](3) NULL,
	[idadetipo2] [varchar](10) NULL,
	[proprietario] [varchar](100) NOT NULL,
	[telefone] [varchar](50) NULL,
	[email] [varchar](100) NULL,
	[cuidados_esp] [varchar](200) NULL,
	[alergico] [varchar](150) NULL,
	[foto] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 03/07/2021 12:37:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[email] [varchar](100) NULL,
	[rg] [varchar](50) NULL,
	[cpf] [varchar](50) NULL,
	[fone1] [varchar](50) NULL,
	[fone2] [varchar](50) NULL,
	[rua] [varchar](100) NULL,
	[numero] [varchar](50) NULL,
	[bairro] [varchar](100) NULL,
	[complemento] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcao]    Script Date: 03/07/2021 12:37:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](50) NULL,
 CONSTRAINT [PK_Funcao] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 03/07/2021 12:37:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[rg] [varchar](50) NULL,
	[cpf] [varchar](50) NULL,
	[telefone] [varchar](50) NULL,
	[email] [varchar](100) NULL,
	[rua] [varchar](100) NULL,
	[numero] [varchar](50) NULL,
	[bairro] [varchar](100) NULL,
	[comp] [varchar](100) NULL,
	[admissao] [varchar](50) NULL,
	[demissao] [varchar](50) NULL,
	[nascimento] [varchar](50) NULL,
	[status] [varchar](50) NULL,
	[jtinic] [varchar](50) NULL,
	[jtfinal] [varchar](50) NULL,
	[hora1] [varchar](50) NULL,
	[hora2] [varchar](50) NULL,
	[salario] [varchar](50) NULL,
	[id_funcao] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lembrarlogin]    Script Date: 03/07/2021 12:37:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lembrarlogin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[checksave] [bit] NOT NULL,
 CONSTRAINT [PK_Lembrarlogin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oservico]    Script Date: 03/07/2021 12:37:18 ******/
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
/****** Object:  Table [dbo].[Recibo]    Script Date: 03/07/2021 12:37:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recibo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[valor] [varchar](200) NOT NULL,
	[recebemosde] [varchar](200) NOT NULL,
	[importanciade1] [varchar](200) NOT NULL,
	[importanciade2] [varchar](200) NULL,
	[referentea1] [varchar](200) NOT NULL,
	[referentea2] [varchar](200) NULL,
	[emitente] [varchar](200) NULL,
	[cnpj] [varchar](100) NULL,
	[data] [datetime] NOT NULL,
	[datareport] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servico]    Script Date: 03/07/2021 12:37:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servico](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[servico] [varchar](100) NULL,
	[valor] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 03/07/2021 12:37:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[username] [varchar](100) NOT NULL,
	[senha] [varchar](100) NOT NULL,
	[id_funcao] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Funcao] FOREIGN KEY([id_funcao])
REFERENCES [dbo].[Funcao] ([id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Funcao]
GO
