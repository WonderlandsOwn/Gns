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

    // CharacterInventory
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class CharacterInventory
    {
        public int CharacterId { get; set; } // CharacterId (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent Character pointed by [CharacterInventory].([CharacterId]) (FK_CharacterInventory_Character)
        /// </summary>
        public virtual Character Character { get; set; } // FK_CharacterInventory_Character
    }

}
// </auto-generated>
