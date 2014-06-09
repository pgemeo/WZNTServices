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
    // GruParSprachAus
    internal class GruParSprachAuConfiguration : EntityTypeConfiguration<GruParSprachAu>
    {
        public GruParSprachAuConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruParSprachAus");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Sprache).HasColumnName("Sprache").IsOptional().HasMaxLength(50);
            Property(x => x.Iso).HasColumnName("ISO").IsRequired().HasMaxLength(2);
            Property(x => x.AktivKz).HasColumnName("AktivKZ").IsOptional();
            Property(x => x.Datei).HasColumnName("Datei").IsOptional().HasMaxLength(100);
            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
