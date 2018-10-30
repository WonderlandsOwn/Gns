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

    // ArchtypeDetail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ArchtypeDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ArchtypeDetail>
    {
        public ArchtypeDetailConfiguration()
            : this("dbo")
        {
        }

        public ArchtypeDetailConfiguration(string schema)
        {
            ToTable("ArchtypeDetail", schema);
            HasKey(x => x.ArchtypeId);

            Property(x => x.ArchtypeId).HasColumnName(@"ArchtypeId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ArchtypeDescription).HasColumnName(@"ArchtypeDescription").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(100);
        }
    }

}
// </auto-generated>
