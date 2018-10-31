CREATE TABLE [dbo].[Character] (
    [CharacterId]                  INT          IDENTITY (1, 1) NOT NULL,
    [CharacterPlayerId]            INT          NULL,
    [CharacterName]                VARCHAR (50) NOT NULL,
    [CharacterRaceId]              INT          NOT NULL,
    [CharacterPrimaryArchtypeId]   INT          NOT NULL,
    [CharacterSecondaryArchtypeId] INT          NULL,
    [CharacterPrimarySpellId]      INT          NOT NULL,
    [CharacterSecondarySpellId]    INT          NULL,
    [CharacterTertiarySpellId]     INT          NULL,
    [CharacterPassiveSpellId]      INT          NULL,
    [CharacterStatusId]            INT          NULL,
    CONSTRAINT [PK__Character] PRIMARY KEY CLUSTERED ([CharacterId] ASC),
    CONSTRAINT [FK_Character_Player] FOREIGN KEY ([CharacterPlayerId]) REFERENCES [dbo].[Player] ([PlayerId]),
	CONSTRAINT [FK_Character_Race] FOREIGN KEY ([CharacterRaceId]) REFERENCES [dbo].[Race] ([RaceId]),
    CONSTRAINT [FK_Character_Primary_Archtype] FOREIGN KEY ([CharacterPrimaryArchtypeId]) REFERENCES [dbo].[Archtype] ([ArchtypeId]),    
    CONSTRAINT [FK_Character_Secondary_Archtype] FOREIGN KEY ([CharacterSecondaryArchtypeId]) REFERENCES [dbo].[Archtype] ([ArchtypeId])
);







