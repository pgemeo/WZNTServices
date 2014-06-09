// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    // WZNTArtikel
    public class WzntArtikel
    {
        public int Id { get; set; } // ID (Primary key)
        public string Artikelnummer { get; set; } // Artikelnummer
        public string StandortKz { get; set; } // StandortKZ
        public string Matchcode { get; set; } // Matchcode
        public string Artikelgruppe { get; set; } // Artikelgruppe
        public string HArtikelgruppe { get; set; } // HArtikelgruppe
        public string VArtikelgruppe { get; set; } // VArtikelgruppe
        public bool? ArtikelKz { get; set; } // ArtikelKZ
        public string UserRek1 { get; set; } // UserRek1
        public string UserRek2 { get; set; } // UserRek2
        public string UserRek3 { get; set; } // UserRek3
        public string Barcode { get; set; } // Barcode
        public string Barcodetyp { get; set; } // Barcodetyp
        public decimal? FormatBreite { get; set; } // FormatBreite
        public decimal? FormatVorschub { get; set; } // FormatVorschub
        public bool? DurchmKz { get; set; } // DurchmKZ
        public string FormatMe { get; set; } // FormatMe
        public byte[] Basis { get; set; } // Basis
        public bool? DocHoeheBkz { get; set; } // DocHoeheBKZ
        public bool? DocHoeheVkz { get; set; } // DocHoeheVKZ
        public int? EskoJobId { get; set; } // ESKOJobID
        public int? IdMaschGru { get; set; } // ID_MaschGru
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Reverse navigation
        public virtual ICollection<WzntArtikelVarianten> WzntArtikelVariantens { get; set; } // WZNTArtikelVarianten.fk_WZNTArtikelVarianten_WZNTArtikel

        public WzntArtikel()
        {
            WzntArtikelVariantens = new List<WzntArtikelVarianten>();
        }
    }

}
