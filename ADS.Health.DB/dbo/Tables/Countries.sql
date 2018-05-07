CREATE TABLE [dbo].[Countries] (
    [ID]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (150) NOT NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED ([ID] ASC)
);

