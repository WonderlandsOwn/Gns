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

    // Resource
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ResourceConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Resource>
    {
        public ResourceConfiguration()
            : this("dbo")
        {
        }

        public ResourceConfiguration(string schema)
        {
            ToTable("Resource", schema);
            HasKey(x => x.ResourceId);

            Property(x => x.ResourceId).HasColumnName(@"ResourceId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ResourceName).HasColumnName(@"ResourceName").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(24);
        }
    }

}
// </auto-generated>
