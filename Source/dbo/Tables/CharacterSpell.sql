CREATE TABLE [dbo].[CharacterSpell] (
    [CharacterId]      INT NOT NULL,
    [BaseSpellId]      INT NULL,
    [PrimarySpellId]   INT NULL,
    [SecondarySpellId] INT NULL,
    [TertiarySpellId]  INT NULL,
    CONSTRAINT [PK_CharacterSpell] PRIMARY KEY CLUSTERED ([CharacterId] ASC),
    CONSTRAINT [FK_CharacterSpell_Character] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Character] ([CharacterId])
);

