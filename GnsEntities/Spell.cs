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

    // Spell
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Spell
    {
        public int SpellId { get; set; } // SpellId (Primary key)
        public string SpellRank { get; set; } // SpellRank (length: 10)
        public string SpellName { get; set; } // SpellName (length: 50)

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) Spell pointed by [SpellDetail].[SpellId] (FK_SpellDetail_Spell)
        /// </summary>
        public virtual SpellDetail SpellDetail { get; set; } // SpellDetail.FK_SpellDetail_Spell
        /// <summary>
        /// Child Archtypes (Many-to-Many) mapped by table [ArchtypeSpellList]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Archtype> Archtypes { get; set; } // Many to many mapping
        /// <summary>
        /// Child Characters (Many-to-Many) mapped by table [CharacterSpellMap]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Character> Characters { get; set; } // Many to many mapping

        public Spell()
        {
            Characters = new System.Collections.Generic.List<Character>();
            Archtypes = new System.Collections.Generic.List<Archtype>();
        }
    }

}
// </auto-generated>
