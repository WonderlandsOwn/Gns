CREATE TABLE [dbo].[Unlock] (
    [UnlockId]               INT           NOT NULL,
    [UnlockName]             VARCHAR (24)  NOT NULL,
    [UnlockShortDescription] VARCHAR (50)  NULL,
    [UnlockLongDescription]  VARCHAR (150) NULL,
    [UnlockRarityId]         INT           NOT NULL,
    CONSTRAINT [PK_Unlock] PRIMARY KEY CLUSTERED ([UnlockId] ASC),
    CONSTRAINT [FK_Unlock_Rarity] FOREIGN KEY ([UnlockRarityId]) REFERENCES [dbo].[Rarity] ([RarityId])
);

