CREATE TABLE [dbo].[ArchtypeBonus] (
    [ArchtypeId]        INT NOT NULL,
    [BonusHealth]       INT NOT NULL,
    [BonusStamina]      INT NOT NULL,
    [BonusStrength]     INT NOT NULL,
    [BonusAgility]      INT NOT NULL,
    [BonusIntellect]    INT NOT NULL,
    [BonusBlock]    INT NOT NULL,
    [BonusDodge]    INT NOT NULL,
    [BonusResist] INT NOT NULL,
    CONSTRAINT [PK_RaceBonus] PRIMARY KEY CLUSTERED ([ArchtypeId] ASC),
    CONSTRAINT [FK_RaceBonus_Race] FOREIGN KEY ([ArchtypeId]) REFERENCES [dbo].[Archtype] ([ArchtypeId])
);





