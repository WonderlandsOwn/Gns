CREATE TABLE [dbo].[SpellDetail] (
    [SpellId]               INT           NOT NULL,
    [SpellShortDescription] VARCHAR (50)  NULL,
    [SpellDescription]      VARCHAR (100) NULL,
    [SpellDamage]           INT           NULL,
    [SpellCost]             INT           NULL,
    [SpellCooldown]         INT           NULL,
    CONSTRAINT [PK_SpellDetail] PRIMARY KEY CLUSTERED ([SpellId] ASC),
	CONSTRAINT [FK_SpellDetail_Spell] FOREIGN KEY ([SpellId]) REFERENCES [dbo].[Spell] ([SpellId])
);

