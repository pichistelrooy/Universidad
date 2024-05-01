USE [OPERATIVA]
GO

/****** Object:  Table [dbo].[USUARIOS]    Script Date: 19/11/2017 12:44:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[USUARIOS](
	[IDUSUARIO] [int] IDENTITY(1,1) NOT NULL,
	[USUARIO] [nvarchar](50) NOT NULL,
	[NOMBRE] [nvarchar](50) NOT NULL,
	[PASSWORD] [nvarchar](20) NOT NULL,
	[IDPERMISO] [int] NOT NULL,
	[ACTIVO] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[USUARIOS] ADD  CONSTRAINT [DF_USUARIOS_ACTIVO]  DEFAULT ((1)) FOR [ACTIVO]
GO

ALTER TABLE [dbo].[USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_USUARIOS_PERMISOS] FOREIGN KEY([IDPERMISO])
REFERENCES [dbo].[PERMISOS] ([IDPERMISO])
GO

ALTER TABLE [dbo].[USUARIOS] CHECK CONSTRAINT [FK_USUARIOS_PERMISOS]
GO
