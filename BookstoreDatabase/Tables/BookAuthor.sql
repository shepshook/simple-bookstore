CREATE TABLE [dbo].[BookAuthor]
(
    [BookId] UNIQUEIDENTIFIER
        NOT NULL,
    [AuthorId] UNIQUEIDENTIFIER
        NOT NULL,
    CONSTRAINT [FK_BookAuthorBookID] FOREIGN KEY ([BookId])
        REFERENCES [Book] ([Id]),
    CONSTRAINT [FK_BookAuthorAuthorID] FOREIGN KEY ([AuthorId])
        REFERENCES [Author] ([Id]),
    CONSTRAINT [UC_BookAuthor] UNIQUE ([BookId], [AuthorId])
)