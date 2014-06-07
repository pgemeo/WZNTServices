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
    // GruArtAufEinSprache
    public class GruArtAufEinSprache
    {
        public int Id { get; set; } // ID (Primary key)
        public int IdSprache { get; set; } // ID_Sprache
        public int IdAufgabe { get; set; } // ID_Aufgabe
        public string Uebersetzung { get; set; } // Uebersetzung
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Foreign keys
        public virtual GruArtAufEinzelnutzen GruArtAufEinzelnutzen { get; set; } // fk_GruArtAufEinSprache_GruArtAufEinzelnutzen
        public virtual GruSprachen GruSprachen { get; set; } // fk_GruArtAufEinSprache_GruSprachen
    }

}
