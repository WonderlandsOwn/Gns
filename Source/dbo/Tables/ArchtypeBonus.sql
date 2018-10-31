CREATE TABLE [dbo].[ArchtypeBonus] (
    [ArchtypeId]        INT NOT NULL,
    [BonusHealth]       INT NOT NULL,
    [BonusStamina]      INT NOT NULL,
    [BonusStrength]     INT NOT NULL,
    [BonusAgility]      INT NOT NULL,
    [BonusIntellect]    INT NOT NULL,
    [BonusFortitude]    INT NOT NULL,
    [BonusEndurance]    INT NOT NULL,
    [BonusConstitution] INT NOT NULL,
    CONSTRAINT [PK_ArchtypeBonus] PRIMARY KEY CLUSTERED ([ArchtypeId] ASC),
    CONSTRAINT [FK_ArchtypeBonus_Archtype] FOREIGN KEY ([ArchtypeId]) REFERENCES [dbo].[Archtype] ([ArchtypeId])
);



