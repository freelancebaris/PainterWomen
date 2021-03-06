USE [PainterWoman]
GO
/****** Object:  Table [dbo].[Blog]    Script Date: 10/14/2013 20:25:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Blog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](8000) NULL,
	[Explain] [varchar](8000) NULL,
	[Content] [varchar](8000) NULL,
	[ImagePath] [varchar](8000) NULL,
	[Date] [datetime] NULL,
	[Author] [varchar](8000) NULL,
	[Lang] [varchar](8000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Blog] ON
INSERT [dbo].[Blog] ([Id], [Title], [Explain], [Content], [ImagePath], [Date], [Author], [Lang]) VALUES (3, N'Baslık', NULL, N'     There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.<br>     There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.<br>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.<br> There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.<br>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.<br> There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.<br>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.<br> There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.<br>', NULL, CAST(0x0000A29200000000 AS DateTime), NULL, N'TR')
INSERT [dbo].[Blog] ([Id], [Title], [Explain], [Content], [ImagePath], [Date], [Author], [Lang]) VALUES (5, N'Title', NULL, N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable. There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable. There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable. There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable. There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable. There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.  ', NULL, CAST(0x0000A0E800000000 AS DateTime), NULL, N'TR')
INSERT [dbo].[Blog] ([Id], [Title], [Explain], [Content], [ImagePath], [Date], [Author], [Lang]) VALUES (6, N'Baslık', NULL, N'     There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.<br>     There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomized words which don''t look even slightly believable.<br>', NULL, CAST(0x0000A29200000000 AS DateTime), NULL, N'TR')
SET IDENTITY_INSERT [dbo].[Blog] OFF
