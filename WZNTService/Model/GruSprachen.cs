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
    // GruSprachen
    public class GruSprachen
    {
        public int Id { get; set; } // ID (Primary key)
        public string Sprache { get; set; } // Sprache
        public string Iso { get; set; } // ISO
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Reverse navigation
        public virtual ICollection<GruArtAufEinSprache> GruArtAufEinSpraches { get; set; } // GruArtAufEinSprache.fk_GruArtAufEinSprache_GruSprachen
        public virtual ICollection<GruArtBasisArtSprache> GruArtBasisArtSpraches { get; set; } // GruArtBasisArtSprache.fk_GruArtBasisArtSprache_GruSprachen
        public virtual ICollection<GruArtDruckVerSprache> GruArtDruckVerSpraches { get; set; } // GruArtDruckVerSprache.fk_GruArtDruckVerSprache_GruSprachen
        public virtual ICollection<GruArtDruckVorlSprache> GruArtDruckVorlSpraches { get; set; } // GruArtDruckVorlSprache.fk_GruArtDruckVorlSprache_GruSprachen
        public virtual ICollection<GruProgAbrgruSprache> GruProgAbrgruSpraches { get; set; } // GruProgAbrgruSprache.fk_GruProgAbrgruSprache_GruSprachen

        public GruSprachen()
        {
            GruArtAufEinSpraches = new List<GruArtAufEinSprache>();
            GruArtBasisArtSpraches = new List<GruArtBasisArtSprache>();
            GruArtDruckVerSpraches = new List<GruArtDruckVerSprache>();
            GruArtDruckVorlSpraches = new List<GruArtDruckVorlSprache>();
            GruProgAbrgruSpraches = new List<GruProgAbrgruSprache>();
        }
    }

}
