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
    // GruExportEINU
    internal class GruExportEinuConfiguration : EntityTypeConfiguration<GruExportEinu>
    {
        public GruExportEinuConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruExportEINU");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.FeldWznteinu).HasColumnName("FeldWZNTEINU").IsOptional().HasMaxLength(100);
            Property(x => x.FeldEsko).HasColumnName("Feld_ESKO").IsOptional().HasMaxLength(100);
            Property(x => x.Feldtyp).HasColumnName("Feldtyp").IsOptional().HasMaxLength(50);
            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
