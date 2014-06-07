// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Model;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Data
{
    // GruWerkzWTypen
    internal class GruWerkzWTypenConfiguration : EntityTypeConfiguration<GruWerkzWTypen>
    {
        public GruWerkzWTypenConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruWerkzWTypen");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Typ).HasColumnName("Typ").IsOptional();
            Property(x => x.Matchcode).HasColumnName("Matchcode").IsOptional().HasMaxLength(100);
            Property(x => x.MaxBreite).HasColumnName("MaxBreite").IsOptional();
            Property(x => x.Material).HasColumnName("Material").IsOptional().HasMaxLength(100);
            Property(x => x.MaxLfm).HasColumnName("maxLfm").IsOptional();
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
