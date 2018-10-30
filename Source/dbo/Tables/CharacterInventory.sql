CREATE TABLE [dbo].[CharacterInventory] (
    [CharacterId] INT NOT NULL,
    CONSTRAINT [PK_CharacterInventory] PRIMARY KEY CLUSTERED ([CharacterId] ASC),
    CONSTRAINT [FK_CharacterInventory_Character] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Character] ([CharacterId])
);



