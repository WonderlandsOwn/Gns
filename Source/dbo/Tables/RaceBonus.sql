CREATE TABLE [dbo].[RaceBonus] (
    [RaceId]            INT NOT NULL,
    [BonusHealth]       INT NOT NULL,
    [BonusStamina]      INT NOT NULL,
    [BonusStrength]     INT NOT NULL,
    [BonusAgility]      INT NOT NULL,
    [BonusIntellect]    INT NOT NULL,
    [BonusFortitude]    INT NOT NULL,
    [BonusEndurance]    INT NOT NULL,
    [BonusConstitution] INT NOT NULL,
    CONSTRAINT [PK_RaceBonus] PRIMARY KEY CLUSTERED ([RaceId] ASC),
    CONSTRAINT [FK_RaceBonus_Race] FOREIGN KEY ([RaceId]) REFERENCES [dbo].[Race] ([RaceId])
);
