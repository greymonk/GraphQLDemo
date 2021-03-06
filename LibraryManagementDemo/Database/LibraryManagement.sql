USE [GraphQLDemo]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 27-05-2020 18:38:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Author](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Surname] [varchar](50) NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Book]    Script Date: 27-05-2020 18:38:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AuthorId] [int] NULL,
	[Title] [varchar](100) NULL,
	[Price] [decimal](8, 2) NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([Id], [Name], [Surname]) VALUES (1, N'Dino', N'by Dino Esposito')
INSERT [dbo].[Author] ([Id], [Name], [Surname]) VALUES (2, N'Valerio', N'De Sanctis')
INSERT [dbo].[Author] ([Id], [Name], [Surname]) VALUES (3, N'David', N'Paqutte')
INSERT [dbo].[Author] ([Id], [Name], [Surname]) VALUES (4, N'Chandar', N'Dhall')
INSERT [dbo].[Author] ([Id], [Name], [Surname]) VALUES (5, N'Jonas', N'Fagerberg')
INSERT [dbo].[Author] ([Id], [Name], [Surname]) VALUES (6, N'Adam', N'Freeman')
INSERT [dbo].[Author] ([Id], [Name], [Surname]) VALUES (7, N'Mark', N'Price')
INSERT [dbo].[Author] ([Id], [Name], [Surname]) VALUES (8, N'Rahul', N'Sahay')
SET IDENTITY_INSERT [dbo].[Author] OFF
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([Id], [AuthorId], [Title], [Price]) VALUES (2, 1, N'Asp.Net Core Application Devlopment', CAST(518.00 AS Decimal(8, 2)))
INSERT [dbo].[Book] ([Id], [AuthorId], [Title], [Price]) VALUES (3, 2, N'ASP.NET Core 3 and Angular 9', CAST(457.00 AS Decimal(8, 2)))
INSERT [dbo].[Book] ([Id], [AuthorId], [Title], [Price]) VALUES (4, 1, N'Programming ASP.NET Core', CAST(476.00 AS Decimal(8, 2)))
INSERT [dbo].[Book] ([Id], [AuthorId], [Title], [Price]) VALUES (5, 3, N'Building Single Page Application Using ASP.NET Core & Angular', CAST(900.00 AS Decimal(8, 2)))
INSERT [dbo].[Book] ([Id], [AuthorId], [Title], [Price]) VALUES (6, 4, N'C# 8.0 and .NET Core 3.0 - Modern Cross-Platform Development', CAST(457.00 AS Decimal(8, 2)))
INSERT [dbo].[Book] ([Id], [AuthorId], [Title], [Price]) VALUES (7, 5, N'Essential Angular for ASP.NET Core MVC', CAST(2435.00 AS Decimal(8, 2)))
INSERT [dbo].[Book] ([Id], [AuthorId], [Title], [Price]) VALUES (8, 2, N'Asp.Net Step By Step', CAST(525.00 AS Decimal(8, 2)))
INSERT [dbo].[Book] ([Id], [AuthorId], [Title], [Price]) VALUES (9, 1, N'Asp.Net Core Black Book', CAST(565.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[Book] OFF
/****** Object:  Index [IX_Author]    Script Date: 27-05-2020 18:38:50 ******/
CREATE NONCLUSTERED INDEX [IX_Author] ON [dbo].[Author]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO