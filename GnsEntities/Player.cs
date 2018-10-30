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

    // Player
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Player
    {
        public int PlayerId { get; set; } // PlayerId (Primary key)
        public string PlayerName { get; set; } // PlayerName (length: 50)

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) Player pointed by [PlayerDetail].[PlayerId] (FK_PlayerDetail_Player)
        /// </summary>
        public virtual PlayerDetail PlayerDetail { get; set; } // PlayerDetail.FK_PlayerDetail_Player
        /// <summary>
        /// Parent (One-to-One) Player pointed by [PlayerInventory].[PlayerId] (FK_PlayerInventory_Player)
        /// </summary>
        public virtual PlayerInventory PlayerInventory { get; set; } // PlayerInventory.FK_PlayerInventory_Player
        /// <summary>
        /// Child Characters (Many-to-Many) mapped by table [PlayerCharacterList]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Character> Characters { get; set; } // Many to many mapping

        public Player()
        {
            Characters = new System.Collections.Generic.List<Character>();
        }
    }

}
// </auto-generated>
