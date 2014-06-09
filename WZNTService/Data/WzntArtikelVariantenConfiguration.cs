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
    // WZNTArtikelVarianten
    internal class WzntArtikelVariantenConfiguration : EntityTypeConfiguration<WzntArtikelVarianten>
    {
        public WzntArtikelVariantenConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".WZNTArtikelVarianten");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IdArtikel).HasColumnName("ID_Artikel").IsRequired();
            Property(x => x.AusprId).HasColumnName("AusprID").IsRequired();
            Property(x => x.Material).HasColumnName("Material").IsOptional().HasMaxLength(50);
            Property(x => x.MemoDr).HasColumnName("MemoDR").IsOptional().HasMaxLength(350);
            Property(x => x.DatenEKz).HasColumnName("DatenE_KZ").IsOptional();
            Property(x => x.FreigabeKz).HasColumnName("Freigabe_KZ").IsOptional();
            Property(x => x.Wickelschema).HasColumnName("Wickelschema").IsOptional();
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            // Foreign keys
            HasRequired(a => a.WzntArtikel).WithMany(b => b.WzntArtikelVariantens).HasForeignKey(c => c.IdArtikel); // fk_WZNTArtikelVarianten_WZNTArtikel
            HasRequired(a => a.WzntArtVarAuspr).WithMany(b => b.WzntArtikelVariantens).HasForeignKey(c => c.AusprId); // fk_WZNTArtikelVarianten_WZNTArtVarAuspr
        }
    }

}
