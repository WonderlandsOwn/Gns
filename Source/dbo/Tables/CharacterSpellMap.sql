CREATE TABLE [dbo].[CharacterSpellMap] (
    [CharacterId] INT NOT NULL,
    [SpellId]     INT NOT NULL,
    CONSTRAINT [PK_CharacterSpellMap] PRIMARY KEY CLUSTERED ([CharacterId] ASC, [SpellId] ASC),
    CONSTRAINT [FK_CharacterSpellMap_Character] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Character] ([CharacterId]),
    CONSTRAINT [FK_CharacterSpellMap_Spell] FOREIGN KEY ([SpellId]) REFERENCES [dbo].[Spell] ([SpellId])
);

