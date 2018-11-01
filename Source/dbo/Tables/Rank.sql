CREATE TABLE [dbo].[Rank] (
    [RankId]   INT          IDENTITY (1, 1) NOT NULL,
    [RankName] VARCHAR (24) NULL,
    CONSTRAINT [PK_Rank] PRIMARY KEY CLUSTERED ([RankId] ASC)
);


