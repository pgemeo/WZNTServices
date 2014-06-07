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
    // GruArtBasisArtSprache
    public class GruArtBasisArtSprache
    {
        public int Id { get; set; } // ID (Primary key)
        public int IdSprache { get; set; } // ID_Sprache
        public int IdBasisart { get; set; } // ID_Basisart
        public string Uebersetzung { get; set; } // Uebersetzung
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Foreign keys
        public virtual GruArtBasisart GruArtBasisart { get; set; } // fk_GruArtBasisArtSprache_GruArtBasisart
        public virtual GruSprachen GruSprachen { get; set; } // fk_GruArtBasisArtSprache_GruSprachen
    }

}
