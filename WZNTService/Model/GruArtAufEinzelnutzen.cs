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
    // GruArtAufEinzelnutzen
    public class GruArtAufEinzelnutzen
    {
        public int Id { get; set; } // ID (Primary key)
        public string Aufgabe { get; set; } // Aufgabe
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
        public string StandortKz { get; set; } // StandortKZ

        // Reverse navigation
        public virtual ICollection<GruArtAufEinSprache> GruArtAufEinSpraches { get; set; } // GruArtAufEinSprache.fk_GruArtAufEinSprache_GruArtAufEinzelnutzen

        public GruArtAufEinzelnutzen()
        {
            GruArtAufEinSpraches = new List<GruArtAufEinSprache>();
        }
    }

}
