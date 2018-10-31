CREATE TABLE [dbo].[ArchtypeDetail] (
    [ArchtypeId]               INT           NOT NULL,
    [ArchtypeShortDescription] VARCHAR (50)  NULL,
    [ArchtypeDescription]      VARCHAR (100) NULL,
    CONSTRAINT [PK_ArchtypeDetail] PRIMARY KEY CLUSTERED ([ArchtypeId] ASC),
	CONSTRAINT [FK_ArchtypeDetail_ArchType] FOREIGN KEY ([ArchtypeId]) REFERENCES [dbo].[Archtype] ([ArchtypeId])
);





