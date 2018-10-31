CREATE TABLE [dbo].[RaceDetail] (
    [RaceId]               INT           NOT NULL,
    [RaceShortDescription] VARCHAR (50)  NULL,
    [RaceDescription]      VARCHAR (100) NULL,
    CONSTRAINT [PK_RaceDetail] PRIMARY KEY CLUSTERED ([RaceId] ASC),
    CONSTRAINT [FK_RaceDetail_Race] FOREIGN KEY ([RaceId]) REFERENCES [dbo].[Race] ([RaceId])
);







