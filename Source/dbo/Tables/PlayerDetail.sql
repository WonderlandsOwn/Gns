CREATE TABLE [dbo].[PlayerDetail] (
    [PlayerId]          INT NOT NULL,
    [ActiveCharacterId] INT NULL,
    CONSTRAINT [PK_PlayerDetail] PRIMARY KEY CLUSTERED ([PlayerId] ASC),
    CONSTRAINT [FK_PlayerDetail_Character] FOREIGN KEY ([ActiveCharacterId]) REFERENCES [dbo].[Character] ([CharacterId]),
    CONSTRAINT [FK_PlayerDetail_Player] FOREIGN KEY ([PlayerId]) REFERENCES [dbo].[Player] ([PlayerId])
);





