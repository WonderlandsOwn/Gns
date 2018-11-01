CREATE TABLE [dbo].[Spell] (
    [SpellId]   INT          IDENTITY (1, 1) NOT NULL,
    [SpellRank] NCHAR (10)   NULL,
    [SpellName] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK__Spell] PRIMARY KEY CLUSTERED ([SpellId] ASC)
);









