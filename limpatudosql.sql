USE [limpatudoltda]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 30/06/2017 05:34:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[endereco] [varchar](35) NULL,
	[nome] [varchar](40) NULL,
	[cidade] [varchar](25) NULL,
	[estado] [varchar](2) NULL,
	[telefone] [varchar](20) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemPedido]    Script Date: 30/06/2017 05:34:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemPedido](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pedido] [int] NULL,
	[produto] [int] NULL,
	[entrega] [float] NULL,
	[dias] [int] NULL,
 CONSTRAINT [PK_ItemPedido] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 30/06/2017 05:34:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pedido](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[data] [datetime] NULL,
	[cliente] [varchar](35) NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 30/06/2017 05:34:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Produto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](50) NULL,
	[valor] [float] NULL,
	[status] [char](1) NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id], [endereco], [nome], [cidade], [estado], [telefone]) VALUES (1, N'Joao', N'Rua AB', N'Assis', N'SP', N'18 997192015')
INSERT [dbo].[Cliente] ([id], [endereco], [nome], [cidade], [estado], [telefone]) VALUES (2, N'Eduardo', N'Rua B', N'Assis', N'SP', N'18 996387500')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[Pedido] ON 

INSERT [dbo].[Pedido] ([id], [data], [cliente]) VALUES (2, CAST(N'2017-06-30 00:00:00.000' AS DateTime), N'1')
SET IDENTITY_INSERT [dbo].[Pedido] OFF
SET IDENTITY_INSERT [dbo].[Produto] ON 

INSERT [dbo].[Produto] ([id], [descricao], [valor], [status]) VALUES (1, N'Desinfetante', 45, N'L')
INSERT [dbo].[Produto] ([id], [descricao], [valor], [status]) VALUES (3, N'dfd', 45, N'E')
SET IDENTITY_INSERT [dbo].[Produto] OFF
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Pedido] FOREIGN KEY([id])
REFERENCES [dbo].[Pedido] ([id])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Pedido]
GO
