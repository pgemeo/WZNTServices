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
    // WZNTArtikel
    internal class WzntArtikelConfiguration : EntityTypeConfiguration<WzntArtikel>
    {
        public WzntArtikelConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".WZNTArtikel");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Artikelnummer).HasColumnName("Artikelnummer").IsOptional().HasMaxLength(20);
            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(5);
            Property(x => x.Matchcode).HasColumnName("Matchcode").IsOptional().HasMaxLength(50);
            Property(x => x.Artikelgruppe).HasColumnName("Artikelgruppe").IsOptional().HasMaxLength(20);
            Property(x => x.HArtikelgruppe).HasColumnName("HArtikelgruppe").IsOptional().HasMaxLength(20);
            Property(x => x.VArtikelgruppe).HasColumnName("VArtikelgruppe").IsOptional().HasMaxLength(10);
            Property(x => x.ArtikelKz).HasColumnName("ArtikelKZ").IsOptional();
            Property(x => x.UserRek1).HasColumnName("UserRek1").IsOptional().HasMaxLength(250);
            Property(x => x.UserRek2).HasColumnName("UserRek2").IsOptional().HasMaxLength(250);
            Property(x => x.UserRek3).HasColumnName("UserRek3").IsOptional().HasMaxLength(250);
            Property(x => x.Barcode).HasColumnName("Barcode").IsOptional().HasMaxLength(100);
            Property(x => x.Barcodetyp).HasColumnName("Barcodetyp").IsOptional().HasMaxLength(50);
            Property(x => x.FormatBreite).HasColumnName("FormatBreite").IsOptional().HasPrecision(19,4);
            Property(x => x.FormatVorschub).HasColumnName("FormatVorschub").IsOptional().HasPrecision(19,4);
            Property(x => x.DurchmKz).HasColumnName("DurchmKZ").IsOptional();
            Property(x => x.FormatMe).HasColumnName("FormatMe").IsOptional().HasMaxLength(10);
            Property(x => x.Basis).HasColumnName("Basis").IsOptional();
            Property(x => x.DocHoeheBkz).HasColumnName("DocHoeheBKZ").IsOptional();
            Property(x => x.DocHoeheVkz).HasColumnName("DocHoeheVKZ").IsOptional();
            Property(x => x.EskoJobId).HasColumnName("ESKOJobID").IsOptional();
            Property(x => x.IdMaschGru).HasColumnName("ID_MaschGru").IsOptional();
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
