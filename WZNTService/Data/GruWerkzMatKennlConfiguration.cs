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
    // GruWerkzMatKennl
    internal class GruWerkzMatKennlConfiguration : EntityTypeConfiguration<GruWerkzMatKennl>
    {
        public GruWerkzMatKennlConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruWerkzMatKennl");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MaKennl).HasColumnName("MaKennl").IsOptional().HasMaxLength(100);
            Property(x => x.Beschreibung).HasColumnName("Beschreibung").IsOptional().HasMaxLength(150);
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
