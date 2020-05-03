CREATE TABLE [dbo].[Book]
(
    [Id] UNIQUEIDENTIFIER
        NOT NULL
        PRIMARY KEY,
    [Title] NVARCHAR(1024)
        NOT NULL,
    [Description] NVARCHAR(MAX),
    [PublicationDate] DATE,
    [Rating] FLOAT
        CHECK ([Rating] BETWEEN 0 AND 5),
    [CoverImage] NVARCHAR(MAX),
    [PublisherId] UNIQUEIDENTIFIER,
    CONSTRAINT [FK_Book_PublisherId] FOREIGN KEY ([PublisherId])
        REFERENCES [Publisher] ([Id])
)