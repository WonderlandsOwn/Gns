CREATE TABLE [dbo].[RaceResourceList] (
    [RaceId]     INT NOT NULL,
    [ResourceId] INT NOT NULL,
    CONSTRAINT [PK_RaceResourceList] PRIMARY KEY CLUSTERED ([RaceId] ASC, [ResourceId] ASC),
    CONSTRAINT [FK_RaceResourceList_Race] FOREIGN KEY ([RaceId]) REFERENCES [dbo].[Race] ([RaceId]),
    CONSTRAINT [FK_RaceResourceList_Resource] FOREIGN KEY ([ResourceId]) REFERENCES [dbo].[Resource] ([ResourceId])
);



