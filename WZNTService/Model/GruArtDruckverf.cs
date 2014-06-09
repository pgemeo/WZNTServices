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
    // GruArtDruckverf
    public class GruArtDruckverf
    {
        public int Id { get; set; } // ID (Primary key)
        public string Druckverfahren { get; set; } // Druckverfahren
        public string Kurzzeichen { get; set; } // Kurzzeichen
        public string Auflosung { get; set; } // Auflosung
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
        public string StandortKz { get; set; } // StandortKZ

        // Reverse navigation
        public virtual ICollection<GruArtDruckVerSprache> GruArtDruckVerSpraches { get; set; } // GruArtDruckVerSprache.FK_GruArtDruckVerSprache_GruArtDruckverf
        public virtual ICollection<GruMaCfg> GruMaCfgs { get; set; } // GruMaCFG.FK_GruMaCFG_GruArtDruckverf

        public GruArtDruckverf()
        {
            GruArtDruckVerSpraches = new List<GruArtDruckVerSprache>();
            GruMaCfgs = new List<GruMaCfg>();
        }
    }

}
