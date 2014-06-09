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
    // GruSysAPiJobl
    internal class GruSysAPiJoblConfiguration : EntityTypeConfiguration<GruSysAPiJobl>
    {
        public GruSysAPiJoblConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruSysAPiJobl");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.JobId).HasColumnName("JOB_ID").IsRequired();
            Property(x => x.JobBez).HasColumnName("JOB_Bez").IsOptional().HasMaxLength(50);
            Property(x => x.Parameterdatei).HasColumnName("Parameterdatei").IsOptional().HasMaxLength(100);
            Property(x => x.AktivKz).HasColumnName("AktivKZ").IsOptional();
            Property(x => x.StandortKz).HasColumnName("StandortKz").IsOptional().HasMaxLength(10);
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
