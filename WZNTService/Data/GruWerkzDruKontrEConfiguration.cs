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
    // GruWerkzDruKontrE
    internal class GruWerkzDruKontrEConfiguration : EntityTypeConfiguration<GruWerkzDruKontrE>
    {
        public GruWerkzDruKontrEConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruWerkzDruKontrE");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Typ).HasColumnName("Typ").IsRequired();
            Property(x => x.Matchcode).HasColumnName("Matchcode").IsOptional().HasMaxLength(100);
            Property(x => x.Farbzonen).HasColumnName("Farbzonen").IsOptional().HasMaxLength(10);
            Property(x => x.Felder).HasColumnName("Felder").IsOptional().HasMaxLength(10);
            Property(x => x.C1Streifen).HasColumnName("1_Streifen").IsOptional().HasMaxLength(20);
            Property(x => x.C2Streifen).HasColumnName("2_Streifen").IsOptional().HasMaxLength(20);
            Property(x => x.C3Streifen).HasColumnName("3_Streifen").IsOptional().HasMaxLength(20);
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
