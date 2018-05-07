CREATE TABLE [dbo].[Patients] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (50)  NOT NULL,
    [LastName]    NVARCHAR (50)  NOT NULL,
    [DateBirth]   NVARCHAR (10)  NOT NULL,
    [Nationality] INT            NOT NULL,
    [BloodType]   INT            NOT NULL,
    [Diseases]    NVARCHAR (150) NULL,
    [PhoneNumber] INT            NOT NULL,
    CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Patients_BloodTypes] FOREIGN KEY ([BloodType]) REFERENCES [dbo].[BloodTypes] ([ID]),
    CONSTRAINT [FK_Patients_Countries] FOREIGN KEY ([Nationality]) REFERENCES [dbo].[Countries] ([ID])
);





