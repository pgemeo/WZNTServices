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
    // GruMaTypenDruKz
    internal class GruMaTypenDruKzConfiguration : EntityTypeConfiguration<GruMaTypenDruKz>
    {
        public GruMaTypenDruKzConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruMaTypenDruKz");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IdMaschine).HasColumnName("ID_Maschine").IsRequired();
            Property(x => x.IdWzTyp).HasColumnName("ID_WzTyp").IsRequired();
            Property(x => x.OdKz).HasColumnName("OdKz").IsOptional();
            Property(x => x.FdKz).HasColumnName("FdKz").IsOptional();
            Property(x => x.SdKz).HasColumnName("SdKz").IsOptional();
            Property(x => x.TdKz).HasColumnName("TdKz").IsOptional();
            Property(x => x.IjKz).HasColumnName("IjKz").IsOptional();
            Property(x => x.HpKz).HasColumnName("HpKz").IsOptional();
            Property(x => x.KpKz).HasColumnName("KpKz").IsOptional();
            Property(x => x.StKz).HasColumnName("StKz").IsOptional();
            Property(x => x.ZsKz).HasColumnName("ZsKz").IsOptional();
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            // Foreign keys
            HasRequired(a => a.GruWerkzWTypen).WithMany(b => b.GruMaTypenDruKzs).HasForeignKey(c => c.IdWzTyp); // fk_GruMaTypenDruKz_GruWerkzWTypen
        }
    }

}
