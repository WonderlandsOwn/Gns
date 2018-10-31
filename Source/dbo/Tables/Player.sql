CREATE TABLE [dbo].[Player] (
    [PlayerId]                INT          IDENTITY (1, 1) NOT NULL,
    [PlayerName]              VARCHAR (50) NULL,
    [PlayerActiveCharacterID] INT          NULL,
    CONSTRAINT [PK__Player] PRIMARY KEY CLUSTERED ([PlayerId] ASC),
    CONSTRAINT [FK_Player_Character] FOREIGN KEY ([PlayerActiveCharacterID]) REFERENCES [dbo].[Character] ([CharacterId])
);







