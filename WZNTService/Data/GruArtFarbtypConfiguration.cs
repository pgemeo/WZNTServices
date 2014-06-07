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
    // GruArtFarbtyp
    internal class GruArtFarbtypConfiguration : EntityTypeConfiguration<GruArtFarbtyp>
    {
        public GruArtFarbtypConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruArtFarbtyp");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FarbtypSep).HasColumnName("FarbtypSep").IsOptional().HasMaxLength(100);
            Property(x => x.WzNerz).HasColumnName("WZNerz").IsOptional();
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
