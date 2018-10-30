CREATE TABLE [dbo].[CharacterStatus] (
    [CharacterId]                  INT NOT NULL,
    [CharacterPrimaryResourceId]   INT NULL,
    [CharacterSecondaryResourceId] INT NULL,
    CONSTRAINT [PK_CharacterStatus] PRIMARY KEY CLUSTERED ([CharacterId] ASC),
    CONSTRAINT [FK_CharacterStatus_Character] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Character] ([CharacterId]),
    CONSTRAINT [FK_CharacterStatus_Primary_Resource] FOREIGN KEY ([CharacterPrimaryResourceId]) REFERENCES [dbo].[Resource] ([ResourceId]),
    CONSTRAINT [FK_CharacterStatus_Secondary_Resource] FOREIGN KEY ([CharacterSecondaryResourceId]) REFERENCES [dbo].[Resource] ([ResourceId])
);



