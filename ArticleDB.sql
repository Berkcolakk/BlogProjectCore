USE [ArticleDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 29.04.2020 01:31:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUser]    Script Date: 29.04.2020 01:31:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUser](
	[ID] [uniqueidentifier] NOT NULL,
	[CreatedComputerName] [nvarchar](max) NULL,
	[CreatedIp] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedADUserName] [nvarchar](max) NULL,
	[ModifiedComputerName] [nvarchar](max) NULL,
	[ModifiedIp] [nvarchar](max) NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[ModifiedADUserName] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Birthdate] [datetime2](7) NOT NULL,
	[LastLogin] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AppUser] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blog]    Script Date: 29.04.2020 01:31:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blog](
	[ID] [uniqueidentifier] NOT NULL,
	[CreatedComputerName] [nvarchar](max) NULL,
	[CreatedIp] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedADUserName] [nvarchar](max) NULL,
	[ModifiedComputerName] [nvarchar](max) NULL,
	[ModifiedIp] [nvarchar](max) NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[ModifiedADUserName] [nvarchar](max) NULL,
	[Header] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Content] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[Homepage] [bit] NOT NULL,
	[Confirmation] [bit] NOT NULL,
	[ReadNumber] [int] NOT NULL,
	[AppUserID] [uniqueidentifier] NULL,
	[UsersID] [uniqueidentifier] NOT NULL,
	[CategoryID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Blog] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BlogComment]    Script Date: 29.04.2020 01:31:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BlogComment](
	[ID] [uniqueidentifier] NOT NULL,
	[CreatedComputerName] [nvarchar](max) NULL,
	[CreatedIp] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedADUserName] [nvarchar](max) NULL,
	[ModifiedComputerName] [nvarchar](max) NULL,
	[ModifiedIp] [nvarchar](max) NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[ModifiedADUserName] [nvarchar](max) NULL,
	[BlogID] [uniqueidentifier] NOT NULL,
	[CommentID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_BlogComment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 29.04.2020 01:31:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [uniqueidentifier] NOT NULL,
	[CreatedComputerName] [nvarchar](max) NULL,
	[CreatedIp] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedADUserName] [nvarchar](max) NULL,
	[ModifiedComputerName] [nvarchar](max) NULL,
	[ModifiedIp] [nvarchar](max) NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[ModifiedADUserName] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 29.04.2020 01:31:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[ID] [uniqueidentifier] NOT NULL,
	[CreatedComputerName] [nvarchar](max) NULL,
	[CreatedIp] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedADUserName] [nvarchar](max) NULL,
	[ModifiedComputerName] [nvarchar](max) NULL,
	[ModifiedIp] [nvarchar](max) NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[ModifiedADUserName] [nvarchar](max) NULL,
	[Body] [nvarchar](max) NULL,
	[BlogID] [uniqueidentifier] NOT NULL,
	[AppUsersID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Like]    Script Date: 29.04.2020 01:31:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Like](
	[ID] [uniqueidentifier] NOT NULL,
	[CreatedComputerName] [nvarchar](max) NULL,
	[CreatedIp] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedADUserName] [nvarchar](max) NULL,
	[ModifiedComputerName] [nvarchar](max) NULL,
	[ModifiedIp] [nvarchar](max) NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[ModifiedADUserName] [nvarchar](max) NULL,
	[AppUserID] [uniqueidentifier] NOT NULL,
	[BlogID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Like] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Blog]  WITH CHECK ADD  CONSTRAINT [FK_Blog_AppUser_AppUserID] FOREIGN KEY([AppUserID])
REFERENCES [dbo].[AppUser] ([ID])
GO
ALTER TABLE [dbo].[Blog] CHECK CONSTRAINT [FK_Blog_AppUser_AppUserID]
GO
ALTER TABLE [dbo].[Blog]  WITH CHECK ADD  CONSTRAINT [FK_Blog_Category_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Blog] CHECK CONSTRAINT [FK_Blog_Category_CategoryID]
GO
ALTER TABLE [dbo].[BlogComment]  WITH CHECK ADD  CONSTRAINT [FK_BlogComment_Blog_BlogID] FOREIGN KEY([BlogID])
REFERENCES [dbo].[Blog] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BlogComment] CHECK CONSTRAINT [FK_BlogComment_Blog_BlogID]
GO
ALTER TABLE [dbo].[BlogComment]  WITH CHECK ADD  CONSTRAINT [FK_BlogComment_Comment_CommentID] FOREIGN KEY([CommentID])
REFERENCES [dbo].[Comment] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BlogComment] CHECK CONSTRAINT [FK_BlogComment_Comment_CommentID]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_AppUser_AppUsersID] FOREIGN KEY([AppUsersID])
REFERENCES [dbo].[AppUser] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_AppUser_AppUsersID]
GO
ALTER TABLE [dbo].[Like]  WITH CHECK ADD  CONSTRAINT [FK_Like_AppUser_AppUserID] FOREIGN KEY([AppUserID])
REFERENCES [dbo].[AppUser] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Like] CHECK CONSTRAINT [FK_Like_AppUser_AppUserID]
GO
ALTER TABLE [dbo].[Like]  WITH CHECK ADD  CONSTRAINT [FK_Like_Blog_BlogID] FOREIGN KEY([BlogID])
REFERENCES [dbo].[Blog] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Like] CHECK CONSTRAINT [FK_Like_Blog_BlogID]
GO
