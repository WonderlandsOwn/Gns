// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace GnsEntities
{

    // Character
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Character
    {
        public int CharacterId { get; set; } // CharacterId (Primary key)
        public string CharacterName { get; set; } // CharacterName (length: 50)
        public int CharacterRaceId { get; set; } // CharacterRaceId
        public int CharacterPrimaryArchtypeId { get; set; } // CharacterPrimaryArchtypeId
        public int? CharacterSecondaryArchtypeId { get; set; } // CharacterSecondaryArchtypeId
        public int CharacterPrimarySpellId { get; set; } // CharacterPrimarySpellId
        public int? CharacterSecondarySpellId { get; set; } // CharacterSecondarySpellId
        public int? CharacterTertiarySpellId { get; set; } // CharacterTertiarySpellId
        public int? CharacterPassiveSpellId { get; set; } // CharacterPassiveSpellId
        public int? CharacterStatusId { get; set; } // CharacterStatusId

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) Character pointed by [CharacterDetail].[CharacterId] (FK_CharacterDetail_Character)
        /// </summary>
        public virtual CharacterDetail CharacterDetail { get; set; } // CharacterDetail.FK_CharacterDetail_Character
        /// <summary>
        /// Parent (One-to-One) Character pointed by [CharacterInventory].[CharacterId] (FK_CharacterInventory_Character)
        /// </summary>
        public virtual CharacterInventory CharacterInventory { get; set; } // CharacterInventory.FK_CharacterInventory_Character
        /// <summary>
        /// Parent (One-to-One) Character pointed by [CharacterStatus].[CharacterId] (FK_CharacterStatus_Character)
        /// </summary>
        public virtual CharacterStatu CharacterStatu { get; set; } // CharacterStatus.FK_CharacterStatus_Character
        /// <summary>
        /// Child Players (Many-to-Many) mapped by table [PlayerCharacterList]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Player> Players { get; set; } // Many to many mapping
        /// <summary>
        /// Child PlayerDetails where [PlayerDetail].[ActiveCharacterId] point to this entity (FK_PlayerDetail_Character)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PlayerDetail> PlayerDetails { get; set; } // PlayerDetail.FK_PlayerDetail_Character

        // Foreign keys

        /// <summary>
        /// Parent Archtype pointed by [Character].([CharacterPrimaryArchtypeId]) (FK_Character_Primary_Archtype)
        /// </summary>
        public virtual Archtype CharacterPrimaryArchtype { get; set; } // FK_Character_Primary_Archtype

        /// <summary>
        /// Parent Archtype pointed by [Character].([CharacterSecondaryArchtypeId]) (FK_Character_Secondary_Archtype)
        /// </summary>
        public virtual Archtype CharacterSecondaryArchtype { get; set; } // FK_Character_Secondary_Archtype

        /// <summary>
        /// Parent Race pointed by [Character].([CharacterRaceId]) (FK_Character_Race)
        /// </summary>
        public virtual Race Race { get; set; } // FK_Character_Race

        public Character()
        {
            PlayerDetails = new System.Collections.Generic.List<PlayerDetail>();
            Players = new System.Collections.Generic.List<Player>();
        }
    }

}
// </auto-generated>
