CREATE TABLE [dbo].[PlayerCharacterList] (
    [PlayerId]    INT NOT NULL,
    [CharacterId] INT NOT NULL,
    CONSTRAINT [PK_PlayerCharacterList] PRIMARY KEY CLUSTERED ([PlayerId] ASC, [CharacterId] ASC),
    CONSTRAINT [FK_PlayerCharacterList_Character] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Character] ([CharacterId]),
    CONSTRAINT [FK_PlayerCharacterList_Player] FOREIGN KEY ([PlayerId]) REFERENCES [dbo].[Player] ([PlayerId])
);



