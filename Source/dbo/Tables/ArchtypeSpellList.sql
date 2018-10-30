﻿CREATE TABLE [dbo].[ArchtypeSpellList] (
    [ArchtypeId] INT NOT NULL,
    [SpellId]    INT NOT NULL,
    CONSTRAINT [PK_ArchtypeSpellList] PRIMARY KEY CLUSTERED ([ArchtypeId] ASC, [SpellId] ASC),
    CONSTRAINT [FK_ArchtypeSpellList_Archtype] FOREIGN KEY ([ArchtypeId]) REFERENCES [dbo].[Archtype] ([ArchtypeId]),
    CONSTRAINT [FK_ArchtypeSpellList_Spell] FOREIGN KEY ([ArchtypeId]) REFERENCES [dbo].[Spell] ([SpellId])
);



