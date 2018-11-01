CREATE TABLE [dbo].[CharacterUnlockList] (
    [CharacterId] INT NOT NULL,
    [UnlockId]    INT NOT NULL,
    CONSTRAINT [PK_CharacterUnlockList] PRIMARY KEY CLUSTERED ([CharacterId] ASC, [UnlockId] ASC),
    CONSTRAINT [FK_CharacterUnlockList_Character] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Character] ([CharacterId]),
    CONSTRAINT [FK_CharacterUnlockList_Unlock] FOREIGN KEY ([UnlockId]) REFERENCES [dbo].[Unlock] ([UnlockId])
);

