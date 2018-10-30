CREATE TABLE [dbo].[RaceSpellList] (
    [RaceId]  INT NOT NULL,
    [SpellId] INT NOT NULL,
    CONSTRAINT [PK_RaceSpellList] PRIMARY KEY CLUSTERED ([RaceId] ASC, [SpellId] ASC),
    CONSTRAINT [FK_RaceSpellList_Race] FOREIGN KEY ([RaceId]) REFERENCES [dbo].[Race] ([RaceId]),
    CONSTRAINT [FK_RaceSpellList_Spell] FOREIGN KEY ([SpellId]) REFERENCES [dbo].[Spell] ([SpellId])
);



