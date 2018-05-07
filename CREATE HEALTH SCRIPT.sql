/*
Description: Create database bd_Health.
Author: Anthony Díaz.
Date create: 6/5/2018
*/
CREATE DATABASE bd_Health
GO

USE [bd_Health]
GO

/*
Description: Create table of Blood Types.
Author: Anthony Díaz.
Date create: 6/5/2018
*/

CREATE TABLE [dbo].[BloodTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[Abbreviation] [char](3) NOT NULL,
 CONSTRAINT [PK_BloodTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
/*
Description: Create table of Countries.
Author: Anthony Díaz.
Date create: 6/5/2018
*/

CREATE TABLE [dbo].[Countries](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO






/*
Description: Create table of patients.
Author: Anthony Díaz.
Date create: 6/5/2018
*/
CREATE TABLE [dbo].[Patients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DateBirth] [nvarchar](10) NOT NULL,
	[Nationality] [int] NOT NULL,
	[BloodType] [int] NOT NULL,
	[Diseases] [nvarchar](150) NULL,
	[PhoneNumber] [int] NOT NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Patients]  WITH CHECK ADD  CONSTRAINT [FK_Patients_BloodTypes] FOREIGN KEY([BloodType])
REFERENCES [dbo].[BloodTypes] ([ID])
GO

ALTER TABLE [dbo].[Patients] CHECK CONSTRAINT [FK_Patients_BloodTypes]
GO

ALTER TABLE [dbo].[Patients]  WITH CHECK ADD  CONSTRAINT [FK_Patients_Countries] FOREIGN KEY([Nationality])
REFERENCES [dbo].[Countries] ([ID])
GO

ALTER TABLE [dbo].[Patients] CHECK CONSTRAINT [FK_Patients_Countries]
GO

