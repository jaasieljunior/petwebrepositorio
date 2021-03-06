USE [master]
GO
/****** Object:  Database [petweb]    Script Date: 07/12/2016 11:40:48 ******/
CREATE DATABASE [petweb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'petweb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\petweb.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'petweb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\petweb_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [petweb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [petweb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [petweb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [petweb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [petweb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [petweb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [petweb] SET ARITHABORT OFF 
GO
ALTER DATABASE [petweb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [petweb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [petweb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [petweb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [petweb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [petweb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [petweb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [petweb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [petweb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [petweb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [petweb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [petweb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [petweb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [petweb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [petweb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [petweb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [petweb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [petweb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [petweb] SET  MULTI_USER 
GO
ALTER DATABASE [petweb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [petweb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [petweb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [petweb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [petweb] SET DELAYED_DURABILITY = DISABLED 
GO
USE [petweb]
GO
/****** Object:  Table [dbo].[animal]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[animal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NULL,
	[idade] [int] NULL,
	[peso] [float] NULL,
	[especie_id] [int] NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[animal_cliente]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[animal_cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[animal_id] [int] NULL,
	[cliente_id] [int] NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cliente]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[usuario_id] [int] NOT NULL,
	[cpf] [varchar](255) NULL,
	[rg] [varchar](255) NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cor]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cor_animal]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cor_animal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[animal_id] [int] NULL,
	[cor_id] [int] NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[doenca]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[doenca](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NULL,
	[descricao] [varchar](255) NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dose]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dose](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dosagem] [varchar](255) NULL,
	[numero] [float] NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dose_vacina]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dose_vacina](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dose_id] [int] NULL,
	[vacina_id] [int] NULL,
	[data_proxima_aplicacao] [datetime] NULL,
	[data_aplicacao] [timestamp] NOT NULL,
	[vacinacao_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[especie]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[especie](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NULL,
	[descricao] [varchar](255) NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[periodicidade]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[periodicidade](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[periodo] [int] NULL,
	[descricao] [varchar](255) NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[permissao]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[permissao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NULL,
	[descricao] [text] NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[raca]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[raca](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[raca_animal]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[raca_animal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[animal_id] [int] NULL,
	[raca_id] [int] NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuario]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NULL,
	[login] [varchar](255) NULL,
	[senha] [varchar](255) NULL,
	[email] [varchar](255) NULL,
	[telefone] [varchar](12) NULL,
	[data_cadastro] [datetime] NULL,
	[tipo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario_permissao]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario_permissao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NULL,
	[permissao_id] [int] NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vacina]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vacina](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NULL,
	[descricao] [varchar](255) NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vacina_doenca]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vacina_doenca](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[doenca_id] [int] NULL,
	[vacina_id] [int] NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vacina_especie]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vacina_especie](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[especie_id] [int] NULL,
	[vacina_id] [int] NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vacina_periodicidade]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vacina_periodicidade](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[periodicidade_id] [int] NULL,
	[vacina_id] [int] NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vacinacao]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vacinacao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[veterinario_id] [int] NULL,
	[animal_id] [int] NULL,
	[data_vacinacao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[veterinario]    Script Date: 07/12/2016 11:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[veterinario](
	[usuario_id] [int] NOT NULL,
	[crmv] [varchar](255) NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[animal]  WITH CHECK ADD FOREIGN KEY([especie_id])
REFERENCES [dbo].[especie] ([id])
GO
ALTER TABLE [dbo].[animal_cliente]  WITH CHECK ADD FOREIGN KEY([animal_id])
REFERENCES [dbo].[animal] ([id])
GO
ALTER TABLE [dbo].[animal_cliente]  WITH CHECK ADD FOREIGN KEY([cliente_id])
REFERENCES [dbo].[cliente] ([usuario_id])
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD FOREIGN KEY([usuario_id])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[cor_animal]  WITH CHECK ADD FOREIGN KEY([animal_id])
REFERENCES [dbo].[animal] ([id])
GO
ALTER TABLE [dbo].[cor_animal]  WITH CHECK ADD FOREIGN KEY([cor_id])
REFERENCES [dbo].[cor] ([id])
GO
ALTER TABLE [dbo].[dose_vacina]  WITH CHECK ADD FOREIGN KEY([dose_id])
REFERENCES [dbo].[dose] ([id])
GO
ALTER TABLE [dbo].[dose_vacina]  WITH CHECK ADD FOREIGN KEY([vacina_id])
REFERENCES [dbo].[vacina] ([id])
GO
ALTER TABLE [dbo].[dose_vacina]  WITH CHECK ADD FOREIGN KEY([vacinacao_id])
REFERENCES [dbo].[vacinacao] ([id])
GO
ALTER TABLE [dbo].[raca_animal]  WITH CHECK ADD FOREIGN KEY([animal_id])
REFERENCES [dbo].[animal] ([id])
GO
ALTER TABLE [dbo].[raca_animal]  WITH CHECK ADD FOREIGN KEY([raca_id])
REFERENCES [dbo].[raca] ([id])
GO
ALTER TABLE [dbo].[usuario_permissao]  WITH CHECK ADD FOREIGN KEY([permissao_id])
REFERENCES [dbo].[permissao] ([id])
GO
ALTER TABLE [dbo].[usuario_permissao]  WITH CHECK ADD FOREIGN KEY([usuario_id])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[vacina_doenca]  WITH CHECK ADD FOREIGN KEY([doenca_id])
REFERENCES [dbo].[doenca] ([id])
GO
ALTER TABLE [dbo].[vacina_doenca]  WITH CHECK ADD FOREIGN KEY([vacina_id])
REFERENCES [dbo].[vacina] ([id])
GO
ALTER TABLE [dbo].[vacina_especie]  WITH CHECK ADD FOREIGN KEY([especie_id])
REFERENCES [dbo].[especie] ([id])
GO
ALTER TABLE [dbo].[vacina_especie]  WITH CHECK ADD FOREIGN KEY([vacina_id])
REFERENCES [dbo].[vacina] ([id])
GO
ALTER TABLE [dbo].[vacina_periodicidade]  WITH CHECK ADD FOREIGN KEY([periodicidade_id])
REFERENCES [dbo].[periodicidade] ([id])
GO
ALTER TABLE [dbo].[vacina_periodicidade]  WITH CHECK ADD FOREIGN KEY([vacina_id])
REFERENCES [dbo].[vacina] ([id])
GO
ALTER TABLE [dbo].[vacinacao]  WITH CHECK ADD FOREIGN KEY([animal_id])
REFERENCES [dbo].[animal] ([id])
GO
ALTER TABLE [dbo].[vacinacao]  WITH CHECK ADD FOREIGN KEY([veterinario_id])
REFERENCES [dbo].[veterinario] ([usuario_id])
GO
ALTER TABLE [dbo].[veterinario]  WITH CHECK ADD FOREIGN KEY([usuario_id])
REFERENCES [dbo].[usuario] ([id])
GO
USE [master]
GO
ALTER DATABASE [petweb] SET  READ_WRITE 
GO
