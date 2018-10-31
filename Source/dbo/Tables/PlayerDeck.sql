CREATE TABLE [dbo].[PlayerDeck] (
    [PlayerId] INT NOT NULL,
    CONSTRAINT [PK_PlayerDeck] PRIMARY KEY CLUSTERED ([PlayerId] ASC),
    CONSTRAINT [FK_PlayerDeck_Player] FOREIGN KEY ([PlayerId]) REFERENCES [dbo].[Player] ([PlayerId])
);

