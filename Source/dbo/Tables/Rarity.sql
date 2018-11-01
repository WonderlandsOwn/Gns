CREATE TABLE [dbo].[Rarity] (
    [RarityId]               INT          IDENTITY (1, 1) NOT NULL,
    [RarityName]             VARCHAR (50) NOT NULL,
    [RarityShortDescription] VARCHAR (50) NULL,
    [RarityLongDescription]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Rarity] PRIMARY KEY CLUSTERED ([RarityId] ASC)
);

