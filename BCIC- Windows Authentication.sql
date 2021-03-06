USE [BCIC]
GO
/****** Object:  User [touhed]    Script Date: 02-Dec-18 10:01:52 PM ******/
CREATE USER [touhed] FOR LOGIN [touhed] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [touhed]
GO
/****** Object:  Table [dbo].[Actor]    Script Date: 02-Dec-18 10:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actor](
	[UserId] [bigint] IDENTITY(1,1) NOT NULL,
	[UserType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Actor] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 02-Dec-18 10:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminId] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admission]    Script Date: 02-Dec-18 10:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admission](
	[AdmissionId] [bigint] IDENTITY(1,1) NOT NULL,
	[AdmissionFees] [bigint] NULL,
	[LibraryFee] [bigint] NULL,
	[LaboratoryFee] [bigint] NULL,
	[FixedAmount] [bigint] NOT NULL,
	[PayAmount] [bigint] NULL,
	[StudentId] [bigint] NULL,
	[PaymentStatus] [bigint] NULL,
 CONSTRAINT [PK_Admission] PRIMARY KEY CLUSTERED 
(
	[AdmissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BanArtStudent]    Script Date: 02-Dec-18 10:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanArtStudent](
	[StudentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentName] [text] NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[PresentAddress] [nvarchar](50) NULL,
	[PermanentAddress] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NULL,
 CONSTRAINT [PK_BanArtStudent] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BanComStudent]    Script Date: 02-Dec-18 10:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanComStudent](
	[StudentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[PresentAddress] [nvarchar](50) NULL,
	[PermanentAddress] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BanComStudent] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BanSciStudent]    Script Date: 02-Dec-18 10:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanSciStudent](
	[StudentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentName] [text] NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[PresentAddress] [nvarchar](50) NULL,
	[PermanentAddress] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BanSciStudent] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EngArtStudent]    Script Date: 02-Dec-18 10:01:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EngArtStudent](
	[StudentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentName] [text] NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[PresentAddress] [nvarchar](100) NULL,
	[PermanentAddress] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EngArtStudent] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EngComStudent]    Script Date: 02-Dec-18 10:01:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EngComStudent](
	[StudentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentName] [text] NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[PresentAddress] [nvarchar](100) NULL,
	[PermanentAddress] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EngComStudent] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EngSciStudent]    Script Date: 02-Dec-18 10:01:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EngSciStudent](
	[StudentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentName] [text] NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[PresentAddress] [nvarchar](100) NULL,
	[PermanentAddress] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EngSciStudent] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartTimeTeacher]    Script Date: 02-Dec-18 10:01:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartTimeTeacher](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Designation] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PartTimeTeacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermanentTeacher]    Script Date: 02-Dec-18 10:01:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermanentTeacher](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Designation] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Facultys] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Register]    Script Date: 02-Dec-18 10:01:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Register](
	[RegisterId] [bigint] IDENTITY(1,1) NOT NULL,
	[RegisterName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Register] PRIMARY KEY CLUSTERED 
(
	[RegisterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 02-Dec-18 10:01:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[FatherName] [nvarchar](50) NOT NULL,
	[MotherName] [nvarchar](50) NOT NULL,
	[Version] [nvarchar](50) NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[Class] [nvarchar](50) NOT NULL,
	[Section] [nvarchar](50) NOT NULL,
	[Scholarship] [nvarchar](50) NOT NULL,
	[Session] [nvarchar](50) NOT NULL,
	[Nationality] [nvarchar](50) NULL,
	[DOB] [date] NULL,
	[Gender] [text] NOT NULL,
	[PresentAddress] [nvarchar](50) NULL,
	[PermanentAddress] [nvarchar](50) NOT NULL,
	[Contact] [bigint] NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StudentInfo1] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentAccount]    Script Date: 02-Dec-18 10:01:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAccount](
	[StudentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[PaymentStatus] [bigint] NULL,
 CONSTRAINT [PK_StudentAccount] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentPayment]    Script Date: 02-Dec-18 10:01:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentPayment](
	[PaymentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentId] [bigint] NULL,
	[Month] [nvarchar](50) NOT NULL,
	[Year] [nvarchar](50) NOT NULL,
	[TuitionFee] [bigint] NULL,
	[ExtraFeeCategory] [nvarchar](50) NULL,
	[ExtraFee] [bigint] NULL,
	[PaymentDate] [date] NULL,
	[TotalAmount] [bigint] NOT NULL,
	[SPayAmount] [bigint] NULL,
	[PaymentStatus] [bigint] NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeacherAccount]    Script Date: 02-Dec-18 10:01:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherAccount](
	[AccNo] [bigint] IDENTITY(1,1) NOT NULL,
	[TeacherId] [bigint] NOT NULL,
	[TeacherName] [nvarchar](50) NOT NULL,
	[TeacherType] [nvarchar](50) NOT NULL,
	[TeacherGread] [nvarchar](50) NOT NULL,
	[BasicSalary] [nvarchar](50) NOT NULL,
	[Month] [nvarchar](50) NOT NULL,
	[Year] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Faculty_Account_1] PRIMARY KEY CLUSTERED 
(
	[AccNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 02-Dec-18 10:01:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[LoginId] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[UserType] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Actor] ON 

INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (1, N'Admin')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (2, N'Register')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (3, N'PermanentTeacher')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (4, N'PartTimeTeacher')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (5, N'Account')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (6, N'EngSciStudent')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (7, N'EngArtStudent')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (8, N'EngComStudent')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (9, N'BanSciStudent')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (10, N'BanArtStudent')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (11, N'BanComStudent')
SET IDENTITY_INSERT [dbo].[Actor] OFF
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([AdminId], [Name], [Email], [Contact]) VALUES (1, N'Touhedur Rahman', N'touhedurrahman7@gmail.com', N'01775396637')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Admission] ON 

INSERT [dbo].[Admission] ([AdmissionId], [AdmissionFees], [LibraryFee], [LaboratoryFee], [FixedAmount], [PayAmount], [StudentId], [PaymentStatus]) VALUES (12, 5000, 2000, 2000, 9000, 9000, 2, 0)
INSERT [dbo].[Admission] ([AdmissionId], [AdmissionFees], [LibraryFee], [LaboratoryFee], [FixedAmount], [PayAmount], [StudentId], [PaymentStatus]) VALUES (13, 5000, 2000, 2000, 9000, 9000, 3, 0)
INSERT [dbo].[Admission] ([AdmissionId], [AdmissionFees], [LibraryFee], [LaboratoryFee], [FixedAmount], [PayAmount], [StudentId], [PaymentStatus]) VALUES (14, 5000, 2000, 2000, 9000, 9000, 4, 0)
SET IDENTITY_INSERT [dbo].[Admission] OFF
SET IDENTITY_INSERT [dbo].[EngSciStudent] ON 

INSERT [dbo].[EngSciStudent] ([StudentId], [StudentName], [Department], [PresentAddress], [PermanentAddress], [Email], [Contact]) VALUES (1, N'Karim', N'CSE', N'Uttara', N'Uttara', N'karim@gmail.com', N'01936587469')
SET IDENTITY_INSERT [dbo].[EngSciStudent] OFF
SET IDENTITY_INSERT [dbo].[PartTimeTeacher] ON 

INSERT [dbo].[PartTimeTeacher] ([Id], [Name], [Type], [Designation], [Contact], [Address], [Email]) VALUES (1, N'Karim', N'PartTime', N'Lecturar', N'01832659874', N'Mirpur-1', N'karim@gmail.com')
SET IDENTITY_INSERT [dbo].[PartTimeTeacher] OFF
SET IDENTITY_INSERT [dbo].[PermanentTeacher] ON 

INSERT [dbo].[PermanentTeacher] ([Id], [Name], [Type], [Designation], [Contact], [Address], [Email]) VALUES (1, N'Sadia Afrin', N'Permanent', N'Assistant Lecturar', N'01836529874', N'Uttara,Sector-10', N'sadiaafrinetu753@gmail.com')
SET IDENTITY_INSERT [dbo].[PermanentTeacher] OFF
SET IDENTITY_INSERT [dbo].[Register] ON 

INSERT [dbo].[Register] ([RegisterId], [RegisterName], [Email], [Contact], [Address]) VALUES (1, N'Maria Moon', N'mariamoon3349@gmail.com', N'01750578731', N'Uttara,Sector-10')
SET IDENTITY_INSERT [dbo].[Register] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentId], [StudentName], [FatherName], [MotherName], [Version], [Department], [Class], [Section], [Scholarship], [Session], [Nationality], [DOB], [Gender], [PresentAddress], [PermanentAddress], [Contact], [Email]) VALUES (1, N'Jamal', N'Kamal', N'aaa', N'English', N'Science', N'11', N'A', N'100%', N'2018', N'Bangladeshi', CAST(N'1997-06-12' AS Date), N'Male', N'Uttara', N'Uttara', 19837364232, N'jamal@gmail.com')
INSERT [dbo].[Student] ([StudentId], [StudentName], [FatherName], [MotherName], [Version], [Department], [Class], [Section], [Scholarship], [Session], [Nationality], [DOB], [Gender], [PresentAddress], [PermanentAddress], [Contact], [Email]) VALUES (2, N'Karim', N'fffff', N'asd', N'English', N'Arts', N'11', N'B', N'70%', N'2018', N'Bangladeshi', CAST(N'2018-11-12' AS Date), N'Male', N'Uttara, Sector 10', N'Uttara', 19837364232, N'karim@gmail.com')
INSERT [dbo].[Student] ([StudentId], [StudentName], [FatherName], [MotherName], [Version], [Department], [Class], [Section], [Scholarship], [Session], [Nationality], [DOB], [Gender], [PresentAddress], [PermanentAddress], [Contact], [Email]) VALUES (3, N'abc', N'asd', N'dsda', N'English', N'Commerce', N'11', N'C', N'80%', N'2018', N'Bangladeshi', CAST(N'1998-06-03' AS Date), N'Male', N'Uttara, Sector 10', N'Uttara', 1775396637, N'fdastydf@gmail.com')
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[StudentAccount] ON 

INSERT [dbo].[StudentAccount] ([StudentId], [StudentName], [PaymentStatus]) VALUES (2, N'Karim', NULL)
INSERT [dbo].[StudentAccount] ([StudentId], [StudentName], [PaymentStatus]) VALUES (3, N'a', NULL)
INSERT [dbo].[StudentAccount] ([StudentId], [StudentName], [PaymentStatus]) VALUES (4, N'b', NULL)
SET IDENTITY_INSERT [dbo].[StudentAccount] OFF
SET IDENTITY_INSERT [dbo].[StudentPayment] ON 

INSERT [dbo].[StudentPayment] ([PaymentId], [StudentId], [Month], [Year], [TuitionFee], [ExtraFeeCategory], [ExtraFee], [PaymentDate], [TotalAmount], [SPayAmount], [PaymentStatus]) VALUES (2, 4, N'December', N'2018', 5000, N'SessionFee', 2000, CAST(N'2018-12-02' AS Date), 8000, 7000, 0)
INSERT [dbo].[StudentPayment] ([PaymentId], [StudentId], [Month], [Year], [TuitionFee], [ExtraFeeCategory], [ExtraFee], [PaymentDate], [TotalAmount], [SPayAmount], [PaymentStatus]) VALUES (3, 2, N'December', N'2018', 5000, N'SessionFee', 2000, CAST(N'2018-12-02' AS Date), 8000, 7000, 1000)
INSERT [dbo].[StudentPayment] ([PaymentId], [StudentId], [Month], [Year], [TuitionFee], [ExtraFeeCategory], [ExtraFee], [PaymentDate], [TotalAmount], [SPayAmount], [PaymentStatus]) VALUES (4, 3, N'December', N'2018', 6000, N'SessionFee', 2000, CAST(N'2018-12-02' AS Date), 8000, 8000, 0)
SET IDENTITY_INSERT [dbo].[StudentPayment] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([LoginId], [UserId], [UserType], [FirstName], [LastName], [Email], [Password]) VALUES (1, 1, N'Admin', N'Touhedur', N'Rahman', N'touhedurrahman7@gmail.com', N'17103081')
INSERT [dbo].[Users] ([LoginId], [UserId], [UserType], [FirstName], [LastName], [Email], [Password]) VALUES (2, 2, N'Register', N'Maria', N'Moon', N'mariamoon3349@gmail.com', N'17103349')
INSERT [dbo].[Users] ([LoginId], [UserId], [UserType], [FirstName], [LastName], [Email], [Password]) VALUES (3, 3, N'PermanentTeacher', N'Sadia', N'Afrin', N'sadiaafrinetu753@gmail.com', N'17103358')
INSERT [dbo].[Users] ([LoginId], [UserId], [UserType], [FirstName], [LastName], [Email], [Password]) VALUES (4, 4, N'PartTimeTeacher', N'Karim', NULL, N'karim@gmail.com', N'0')
INSERT [dbo].[Users] ([LoginId], [UserId], [UserType], [FirstName], [LastName], [Email], [Password]) VALUES (5, 5, N'Account', N'Rahim', N'Rahman', N'rahim@gmail.com', N'1')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Admission]  WITH CHECK ADD  CONSTRAINT [FK_Admission_StudentAccount1] FOREIGN KEY([StudentId])
REFERENCES [dbo].[StudentAccount] ([StudentId])
GO
ALTER TABLE [dbo].[Admission] CHECK CONSTRAINT [FK_Admission_StudentAccount1]
GO
ALTER TABLE [dbo].[StudentPayment]  WITH CHECK ADD  CONSTRAINT [FK_StudentPayment_StudentAccount] FOREIGN KEY([StudentId])
REFERENCES [dbo].[StudentAccount] ([StudentId])
GO
ALTER TABLE [dbo].[StudentPayment] CHECK CONSTRAINT [FK_StudentPayment_StudentAccount]
GO
ALTER TABLE [dbo].[TeacherAccount]  WITH CHECK ADD  CONSTRAINT [FK_TeacherAccount_PartTimeTeacher] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[PartTimeTeacher] ([Id])
GO
ALTER TABLE [dbo].[TeacherAccount] CHECK CONSTRAINT [FK_TeacherAccount_PartTimeTeacher]
GO
ALTER TABLE [dbo].[TeacherAccount]  WITH CHECK ADD  CONSTRAINT [FK_TeacherAccount_PermanentTeacher] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[PermanentTeacher] ([Id])
GO
ALTER TABLE [dbo].[TeacherAccount] CHECK CONSTRAINT [FK_TeacherAccount_PermanentTeacher]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Actor] FOREIGN KEY([UserId])
REFERENCES [dbo].[Actor] ([UserId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Actor]
GO
