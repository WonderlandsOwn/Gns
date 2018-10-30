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
        public string SpellName { get; set; } // SpellName (length: 24)
        public int? SpellDamage { get; set; } // SpellDamage
        public int? SpellDamageTypeId { get; set; } // SpellDamageTypeId
        public int SpellCoolDown { get; set; } // SpellCoolDown
        public int SpellCost { get; set; } // SpellCost
        public int? SpellResourceId { get; set; } // SpellResourceId
        public int SpellTargetId { get; set; } // SpellTargetId

        // Reverse navigation

        /// <summary>
        /// Child ArchtypeSpellLists where [ArchtypeSpellList].[ArchtypeId] point to this entity (FK_ArchtypeSpellList_Spell)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ArchtypeSpellList> ArchtypeSpellLists { get; set; } // ArchtypeSpellList.FK_ArchtypeSpellList_Spell
        /// <summary>
        /// Child Races (Many-to-Many) mapped by table [RaceSpellList]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Race> Races { get; set; } // Many to many mapping

        public Spell()
        {
            ArchtypeSpellLists = new System.Collections.Generic.List<ArchtypeSpellList>();
            Races = new System.Collections.Generic.List<Race>();
        }
    }

}
// </auto-generated>
