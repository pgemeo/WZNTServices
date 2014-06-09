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
    // WZNTArtikelVarianten
    public class WzntArtikelVarianten
    {
        public int Id { get; set; } // ID (Primary key)
        public int IdArtikel { get; set; } // ID_Artikel
        public int AusprId { get; set; } // AusprID
        public string Material { get; set; } // Material
        public string MemoDr { get; set; } // MemoDR
        public bool? DatenEKz { get; set; } // DatenE_KZ
        public bool? FreigabeKz { get; set; } // Freigabe_KZ
        public int? Wickelschema { get; set; } // Wickelschema
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Foreign keys
        public virtual WzntArtikel WzntArtikel { get; set; } // fk_WZNTArtikelVarianten_WZNTArtikel
        public virtual WzntArtVarAuspr WzntArtVarAuspr { get; set; } // fk_WZNTArtikelVarianten_WZNTArtVarAuspr
    }

}
