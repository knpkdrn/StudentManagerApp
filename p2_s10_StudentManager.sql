USE [p2_s10_StudentManager]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2019. 09. 15. 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NeptunCode] [char](6) NOT NULL,
	[SubjectCode] [int] NOT NULL,
	[LastName] [varchar](20) NOT NULL,
	[FirstName] [varchar](20) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[City] [varchar](20) NOT NULL,
	[Street] [varchar](80) NOT NULL,
	[Gender] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 2019. 09. 15. 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SubjectCode] [char](12) NOT NULL,
	[SubjectName] [varchar](50) NOT NULL,
	[Credit] [int] NOT NULL,
	[TypeOfSubjectRequirement] [varchar](30) NULL,
	[TeacherID] [int] NOT NULL,
	[InstituteResponsibleForTheSubject] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 2019. 09. 15. 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NeptunCode] [char](6) NOT NULL,
	[Name] [varchar](40) NOT NULL,
	[BirthDate] [date] NULL,
	[City] [varchar](20) NULL,
	[Street] [varchar](80) NOT NULL,
	[Gender] [varchar](6) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (1, N'BGLE20', 3, N'Louis', N'Charlton', CAST(N'1975-05-13' AS Date), N'Stockton', N'3757 Richards Avenue', N'Male')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (2, N'LTR321', 3, N'Frank', N'Schmidt', CAST(N'1956-10-01' AS Date), N'Oklahoma City', N'1332 Hott Street', N'Male')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (3, N'MBNFGE', 3, N'Caridad', N'Hunt', CAST(N'1970-05-24' AS Date), N'Erie', N'4762 Spadafore Drive', N'Female')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (4, N'NHG321', 4, N'Stephen', N'Carter', CAST(N'1957-02-13' AS Date), N'Farmingdale', N'610 Heavner Court', N'Male')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (5, N'PGU9H3', 1, N'Robert', N'Barker', CAST(N'1989-08-03' AS Date), N'New Brunswick', N'2183 Duke Lane', N'Male')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (6, N'TSXC75', 3, N'Theresa', N'Handler', CAST(N'1980-11-26' AS Date), N'Westbury', N'4542 Gnatty Creek Road', N'Female')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (7, N'TZH345', 2, N'Eric', N'Hinojosa', CAST(N'1968-07-03' AS Date), N'Winter Haven', N'2407 Ethels Lane', N'Female')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (8, N'VBFTRZ', 1, N'Natalia', N'Caballero', CAST(N'1991-05-30' AS Date), N'Longview', N'4064 Pickens Way', N'Female')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (9, N'ADR958', 1, N'John', N'Schantz', CAST(N'1946-10-20' AS Date), N'Hayward', N'183 Station Street', N'Male')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (10, N'PDW210', 5, N'Nicholas', N'Mitchell', CAST(N'1975-02-07' AS Date), N'Greenwood', N'3220 Rafe Lane', N'Male')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (11, N'LGT775', 1, N'Molly', N'Lister', CAST(N'1955-09-06' AS Date), N'Macon', N'4073 Oakridge Lane', N'Female')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (12, N'DRE321', 6, N'Donna', N'Lindsey', CAST(N'1989-09-25' AS Date), N'Washington', N'1226 Passaic Street', N'Female')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (13, N'MNF855', 6, N'Lance', N'Crutchfield', CAST(N'1986-02-10' AS Date), N'West Point', N'3793 Radio Park Drive', N'Male')
INSERT [dbo].[Student] ([ID], [NeptunCode], [SubjectCode], [LastName], [FirstName], [BirthDate], [City], [Street], [Gender]) VALUES (14, N'WLO725', 7, N'Lillian', N'Kreger', CAST(N'1946-11-05' AS Date), N'Princeton', N'639 Rockford Mountain Lane', N'Female')
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([ID], [SubjectCode], [SubjectName], [Credit], [TypeOfSubjectRequirement], [TeacherID], [InstituteResponsibleForTheSubject]) VALUES (1, N'DUEN-INF-420', N'Software Development Technologies', 6, N'Mid-term exam', 1, N'Institute of Information Technology')
INSERT [dbo].[Subject] ([ID], [SubjectCode], [SubjectName], [Credit], [TypeOfSubjectRequirement], [TeacherID], [InstituteResponsibleForTheSubject]) VALUES (2, N'DUEN-INF-502', N'Programming 2', 5, N'Examination', 2, N'Institute of Information Technology')
INSERT [dbo].[Subject] ([ID], [SubjectCode], [SubjectName], [Credit], [TypeOfSubjectRequirement], [TeacherID], [InstituteResponsibleForTheSubject]) VALUES (3, N'DUEN-ISF-112', N'Internet technologies', 5, N'Examination', 2, N'Institute of Information Technology')
INSERT [dbo].[Subject] ([ID], [SubjectCode], [SubjectName], [Credit], [TypeOfSubjectRequirement], [TeacherID], [InstituteResponsibleForTheSubject]) VALUES (4, N'DUEN-ISF-213', N'Programming 1', 4, N'Mid-term exam', 1, N'Institute of Information Technology')
INSERT [dbo].[Subject] ([ID], [SubjectCode], [SubjectName], [Credit], [TypeOfSubjectRequirement], [TeacherID], [InstituteResponsibleForTheSubject]) VALUES (5, N'DUEN-ISF-155', N'Programming 3', 5, N'Examination', 2, N'Institute of Information Technology')
INSERT [dbo].[Subject] ([ID], [SubjectCode], [SubjectName], [Credit], [TypeOfSubjectRequirement], [TeacherID], [InstituteResponsibleForTheSubject]) VALUES (6, N'DUEN-ISF-111', N'Introduction to programming', 4, N'Mid-term exam', 1, N'Institute of Information Technology')
INSERT [dbo].[Subject] ([ID], [SubjectCode], [SubjectName], [Credit], [TypeOfSubjectRequirement], [TeacherID], [InstituteResponsibleForTheSubject]) VALUES (7, N'DFAN-INF-612', N'Development of information systems II.', 6, N'Mid-term exam', 1, N'Institute of Information Technology')
SET IDENTITY_INSERT [dbo].[Subject] OFF
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([ID], [NeptunCode], [Name], [BirthDate], [City], [Street], [Gender]) VALUES (1, N'GRE32W', N'Grady Woodard', CAST(N'1982-11-07' AS Date), N'Kenosha', N'2729 Whaley Lane', N'Female')
INSERT [dbo].[Teacher] ([ID], [NeptunCode], [Name], [BirthDate], [City], [Street], [Gender]) VALUES (2, N'FRG365', N'Sam D. Murff', CAST(N'1955-04-28' AS Date), N'Wilmington', N'1145 Callison Lane', N'Male')
SET IDENTITY_INSERT [dbo].[Teacher] OFF
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([SubjectCode])
REFERENCES [dbo].[Subject] ([ID])
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([ID])
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD CHECK  (([Gender]='Female' OR [Gender]='Male'))
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD CHECK  (([Gender]='Female' OR [Gender]='Male'))
GO
