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
    // GruSysDqManst
    internal class GruSysDqManstConfiguration : EntityTypeConfiguration<GruSysDqManst>
    {
        public GruSysDqManstConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruSysDqManst");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(20);
            Property(x => x.UserName).HasColumnName("UserName").IsOptional().HasMaxLength(50);
            Property(x => x.UserIp).HasColumnName("UserIP").IsOptional().HasMaxLength(20);
            Property(x => x.StartDatum).HasColumnName("StartDatum").IsOptional();
            Property(x => x.StartZeit).HasColumnName("StartZeit").IsOptional();
            Property(x => x.EndDatum).HasColumnName("EndDatum").IsOptional();
            Property(x => x.EndZeit).HasColumnName("EndZeit").IsOptional();
            Property(x => x.Status).HasColumnName("Status").IsOptional();
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
