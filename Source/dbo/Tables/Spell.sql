CREATE TABLE [dbo].[Spell] (
    [SpellId]           INT        NOT NULL,
    [SpellName]         NCHAR (24) NOT NULL,
    [SpellDamage]       INT        NULL,
    [SpellDamageTypeId] INT        NULL,
    [SpellCoolDown]     INT        NOT NULL,
    [SpellCost]         INT        NOT NULL,
    [SpellResourceId]   INT        NULL,
    [SpellTargetId]     INT        NOT NULL,
    CONSTRAINT [PK__Spell__52BE41BE028220EA] PRIMARY KEY CLUSTERED ([SpellId] ASC)
);

