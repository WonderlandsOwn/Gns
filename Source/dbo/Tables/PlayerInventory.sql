CREATE TABLE [dbo].[PlayerInventory] (
    [PlayerId] INT NOT NULL,
    CONSTRAINT [PK_PlayerInventory] PRIMARY KEY CLUSTERED ([PlayerId] ASC),
    CONSTRAINT [FK_PlayerInventory_Player] FOREIGN KEY ([PlayerId]) REFERENCES [dbo].[Player] ([PlayerId])
);



