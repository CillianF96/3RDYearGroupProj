USE [ProductTracker]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01/17/2014 14:06:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Name] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[UserType] [nvarchar](15) NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 01/17/2014 14:06:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderCode] [int] NOT NULL,
	[AgentCode] [int] NOT NULL,
	[CustomerCode] [int] NOT NULL,
	[Complete] [bit] NOT NULL,
	[OrderDate] [Date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductLines]    Script Date: 28/10/2014 15:42:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductLines](
	[ProductLineCode] [int] NOT NULL,
	[OrderCode] [int] NOT NULL,
	[ProductCode] [nchar](10) NOT NULL,
	[QtyOrdered] [int] NOT NULL,
	[QtyPrepared] [int] NOT NULL,
	[Complete] [bit] NOT NULL,
 CONSTRAINT [PK_ProductLines] PRIMARY KEY CLUSTERED 
(
	[ProductLineCode] ASC,
	[OrderCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

