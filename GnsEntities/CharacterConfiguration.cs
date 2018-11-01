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
    public class CharacterConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Character>
    {
        public CharacterConfiguration()
            : this("dbo")
        {
        }

        public CharacterConfiguration(string schema)
        {
            ToTable("Character", schema);
            HasKey(x => x.CharacterId);

            Property(x => x.CharacterId).HasColumnName(@"CharacterId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CharacterPlayerId).HasColumnName(@"CharacterPlayerId").HasColumnType("int").IsOptional();
            Property(x => x.CharacterName).HasColumnName(@"CharacterName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(24);
            Property(x => x.CharacterPrimaryArchtypeId).HasColumnName(@"CharacterPrimaryArchtypeId").HasColumnType("int").IsRequired();
            Property(x => x.CharacterSecondaryArchtypeId).HasColumnName(@"CharacterSecondaryArchtypeId").HasColumnType("int").IsRequired();
            Property(x => x.CharacterTertiaryArchtypeId).HasColumnName(@"CharacterTertiaryArchtypeId").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.CharacterTertiaryArchtype).WithMany(b => b.Characters_CharacterTertiaryArchtypeId).HasForeignKey(c => c.CharacterTertiaryArchtypeId).WillCascadeOnDelete(false); // FK_Character_TertiaryArchtype
            HasOptional(a => a.Player).WithMany(b => b.Characters).HasForeignKey(c => c.CharacterPlayerId).WillCascadeOnDelete(false); // FK_Character_Player
            HasRequired(a => a.CharacterPrimaryArchtype).WithMany(b => b.Characters_CharacterPrimaryArchtypeId).HasForeignKey(c => c.CharacterPrimaryArchtypeId).WillCascadeOnDelete(false); // FK_Character_PrimaryArchtype
            HasRequired(a => a.CharacterSecondaryArchtype).WithMany(b => b.Characters_CharacterSecondaryArchtypeId).HasForeignKey(c => c.CharacterSecondaryArchtypeId).WillCascadeOnDelete(false); // FK_Character_SecondaryArchtype
            HasMany(t => t.Unlocks).WithMany(t => t.Characters).Map(m =>
            {
                m.ToTable("CharacterUnlockList", "dbo");
                m.MapLeftKey("CharacterId");
                m.MapRightKey("UnlockId");
            });
            HasMany(t => t.Spells).WithMany(t => t.Characters).Map(m =>
            {
                m.ToTable("CharacterSpellMap", "dbo");
                m.MapLeftKey("CharacterId");
                m.MapRightKey("SpellId");
            });
        }
    }

}
// </auto-generated>
