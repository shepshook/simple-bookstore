CREATE TABLE [dbo].[Publisher]
(
    [Id] UNIQUEIDENTIFIER
        NOT NULL
        PRIMARY KEY,
    [Name] NVARCHAR(64)
        NOT NULL
        CONSTRAINT [UC_Publisher_Name] UNIQUE
);
