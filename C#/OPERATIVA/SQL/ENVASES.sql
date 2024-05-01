USE [OPERATIVA]
GO

/****** Object:  Table [dbo].[ENVASES]    Script Date: 14/11/2017 22:13:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ENVASES](
	[IDENVASE] [int] IDENTITY(1,1) NOT NULL,
	[DENOMINACION] [nvarchar](50) NOT NULL,
	[CAPACIDAD] [int] NOT NULL,
 CONSTRAINT [PK_ENVASES] PRIMARY KEY CLUSTERED 
(
	[IDENVASE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


