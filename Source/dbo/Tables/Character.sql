CREATE TABLE [dbo].[Character] (
    [CharacterId]                  INT          IDENTITY (1, 1) NOT NULL,
    [CharacterPlayerId]            INT          NULL,
    [CharacterName]                VARCHAR (24) NOT NULL,
    [CharacterPrimaryArchtypeId]   INT          NOT NULL,
    [CharacterSecondaryArchtypeId] INT          NOT NULL,
    [CharacterTertiaryArchtypeId]  INT          NULL,
    CONSTRAINT [PK__Character] PRIMARY KEY CLUSTERED ([CharacterId] ASC),
    CONSTRAINT [FK_Character_Player] FOREIGN KEY ([CharacterPlayerId]) REFERENCES [dbo].[Player] ([PlayerId]),
    CONSTRAINT [FK_Character_PrimaryArchtype] FOREIGN KEY ([CharacterPrimaryArchtypeId]) REFERENCES [dbo].[Archtype] ([ArchtypeId]),
    CONSTRAINT [FK_Character_SecondaryArchtype] FOREIGN KEY ([CharacterSecondaryArchtypeId]) REFERENCES [dbo].[Archtype] ([ArchtypeId]),
    CONSTRAINT [FK_Character_TertiaryArchtype] FOREIGN KEY ([CharacterTertiaryArchtypeId]) REFERENCES [dbo].[Archtype] ([ArchtypeId])
);











