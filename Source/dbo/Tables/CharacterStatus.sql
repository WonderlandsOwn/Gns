CREATE TABLE [dbo].[CharacterStatus] (
    [CharacterId]               INT NOT NULL,
    [CharacterBaseHealth]       INT NOT NULL,
    [CharacterCurrentHealth]    INT NOT NULL,
    [CharacterBaseStamina]      INT NOT NULL,
    [CharacterCurrentStamina]   INT NOT NULL,
    [CharacterBaseStrength]     INT NOT NULL,
    [CharacterBaseAgility]      INT NOT NULL,
    [CharacterBaseIntellect]    INT NOT NULL,
    [CharacterBaseFortitude]    INT NOT NULL,
    [CharacterBaseEndurance]    INT NOT NULL,
    [CharacterBaseConstitution] INT NOT NULL,
    CONSTRAINT [PK_CharacterStatus] PRIMARY KEY CLUSTERED ([CharacterId] ASC),
	CONSTRAINT [FK_CharacterStatus_Character] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Character] ([CharacterId])
);







