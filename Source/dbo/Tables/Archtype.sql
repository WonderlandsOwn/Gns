CREATE TABLE [dbo].[Archtype] (
    [ArchtypeId]   INT          NOT NULL,
    [ArchtypeName] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([ArchtypeId] ASC),
    CONSTRAINT [FK_Archtype_ArchtypeDetail] FOREIGN KEY ([ArchtypeId]) REFERENCES [dbo].[ArchtypeDetail] ([ArchtypeId])
);



