CREATE TABLE [dbo].[RaceDetail] (
    [RaceId]          INT         NOT NULL,
    [RaceDescription] NCHAR (100) NULL,
    CONSTRAINT [PK_RaceDetail] PRIMARY KEY CLUSTERED ([RaceId] ASC),
    CONSTRAINT [FK_RaceDetail_Race] FOREIGN KEY ([RaceId]) REFERENCES [dbo].[Race] ([RaceId])
);





