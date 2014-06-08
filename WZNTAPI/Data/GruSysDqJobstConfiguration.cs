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
    // GruSysDqJobst
    internal class GruSysDqJobstConfiguration : EntityTypeConfiguration<GruSysDqJobst>
    {
        public GruSysDqJobstConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruSysDqJobst");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(5);
            Property(x => x.Frequenz).HasColumnName("Frequenz").IsOptional().HasMaxLength(10);
            Property(x => x.Startdatum).HasColumnName("Startdatum").IsOptional();
            Property(x => x.Startzeit).HasColumnName("Startzeit").IsOptional();
            Property(x => x.Status).HasColumnName("Status").IsOptional();
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
