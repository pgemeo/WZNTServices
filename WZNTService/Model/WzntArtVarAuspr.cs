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
    // WZNTArtVarAuspr
    public class WzntArtVarAuspr
    {
        public int Id { get; set; } // ID (Primary key)
        public string Auspr1 { get; set; } // Auspr1
        public string Auspr2 { get; set; } // Auspr2
        public string BezAuspr1 { get; set; } // BezAuspr1
        public string BezAuspr2 { get; set; } // BezAuspr2
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Reverse navigation
        public virtual ICollection<WzntArtikelVarianten> WzntArtikelVariantens { get; set; } // WZNTArtikelVarianten.fk_WZNTArtikelVarianten_WZNTArtVarAuspr

        public WzntArtVarAuspr()
        {
            WzntArtikelVariantens = new List<WzntArtikelVarianten>();
        }
    }

}
