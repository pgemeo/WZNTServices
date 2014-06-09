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
    // WZNTArtVarAuspr
    internal class WzntArtVarAusprConfiguration : EntityTypeConfiguration<WzntArtVarAuspr>
    {
        public WzntArtVarAusprConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".WZNTArtVarAuspr");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Auspr1).HasColumnName("Auspr1").IsOptional().HasMaxLength(30);
            Property(x => x.Auspr2).HasColumnName("Auspr2").IsOptional().HasMaxLength(30);
            Property(x => x.BezAuspr1).HasColumnName("BezAuspr1").IsOptional().HasMaxLength(50);
            Property(x => x.BezAuspr2).HasColumnName("BezAuspr2").IsOptional().HasMaxLength(50);
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
