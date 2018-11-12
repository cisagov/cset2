USE [CSETWeb]
GO
/****** Object:  Table [dbo].[ASSESSMENT_ROLES]    Script Date: 6/28/2018 8:21:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASSESSMENT_ROLES](
	[AssessmentRoleId] [int] IDENTITY(1,1) NOT NULL,
	[AssessmentRole] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ASSESSMENT_ROLES_1] PRIMARY KEY CLUSTERED 
(
	[AssessmentRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ASSESSMENT_ROLES] ON 

INSERT [dbo].[ASSESSMENT_ROLES] ([AssessmentRoleId], [AssessmentRole]) VALUES (1, N'User')
INSERT [dbo].[ASSESSMENT_ROLES] ([AssessmentRoleId], [AssessmentRole]) VALUES (2, N'Administrator')
SET IDENTITY_INSERT [dbo].[ASSESSMENT_ROLES] OFF
