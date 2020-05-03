CREATE TABLE [dbo].[Author]
(
    [Id] UNIQUEIDENTIFIER
        NOT NULL
        PRIMARY KEY,
    [FirstName] NVARCHAR(128)
        NOT NULL,
    [LastName] NVARCHAR(128)
        NOT NULL
)
