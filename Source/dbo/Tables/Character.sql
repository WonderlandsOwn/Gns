CREATE TABLE [dbo].[Character] (
    [CharacterId]                  INT          NOT NULL,
    [CharacterName]                VARCHAR (50) NULL,
    [CharacterRaceId]              INT          NOT NULL,
    [CharacterPrimaryArchtypeId]   INT          NOT NULL,
    [CharacterSecondaryArchtypeId] INT          NULL,
    [CharacterPrimarySpellId]      INT          NOT NULL,
    [CharacterSecondarySpellId]    INT          NULL,
    [CharacterTertiarySpellId]     INT          NULL,
    [CharacterPassiveSpellId]      INT          NULL,
    [CharacterStatusId]            INT          NULL,
    CONSTRAINT [PK__Characte__757BC9A0CC643B44] PRIMARY KEY CLUSTERED ([CharacterId] ASC),
    CONSTRAINT [FK_Character_Primary_Archtype] FOREIGN KEY ([CharacterPrimaryArchtypeId]) REFERENCES [dbo].[Archtype] ([ArchtypeId]),
    CONSTRAINT [FK_Character_Race] FOREIGN KEY ([CharacterRaceId]) REFERENCES [dbo].[Race] ([RaceId]),
    CONSTRAINT [FK_Character_Secondary_Archtype] FOREIGN KEY ([CharacterSecondaryArchtypeId]) REFERENCES [dbo].[Archtype] ([ArchtypeId])
);



