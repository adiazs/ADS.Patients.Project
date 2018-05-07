CREATE TABLE [dbo].[BloodTypes] (
    [ID]           INT           IDENTITY (1, 1) NOT NULL,
    [Description]  NVARCHAR (50) NULL,
    [Abbreviation] CHAR (3)      NOT NULL,
    CONSTRAINT [PK_BloodTypes] PRIMARY KEY CLUSTERED ([ID] ASC)
);

