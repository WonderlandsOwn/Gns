CREATE TABLE [dbo].[CharacterDetail] (
    [CharacterId] INT NOT NULL,
    CONSTRAINT [PK_CharacterDetail] PRIMARY KEY CLUSTERED ([CharacterId] ASC),
    CONSTRAINT [FK_CharacterDetail_Character] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Character] ([CharacterId])
);



