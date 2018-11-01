CREATE TABLE [dbo].[Archtype] (
    [ArchtypeId]               INT           IDENTITY (1, 1) NOT NULL,
    [ArchtypeRankId]           INT           NULL,
    [ArchtypeName]             VARCHAR (24)  NOT NULL,
    [ArchtypeShortDescription] VARCHAR (50)  NULL,
    [ArchtypeDescription]      VARCHAR (150) NULL,
    [ArchtypeUnlockId]         INT           NULL,
    CONSTRAINT [PK__Race] PRIMARY KEY CLUSTERED ([ArchtypeId] ASC),
    CONSTRAINT [FK_Archtype_Rank] FOREIGN KEY ([ArchtypeRankId]) REFERENCES [dbo].[Rank] ([RankId]),
    CONSTRAINT [FK_Archtype_Unlock] FOREIGN KEY ([ArchtypeUnlockId]) REFERENCES [dbo].[Unlock] ([UnlockId])
);









