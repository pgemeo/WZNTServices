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
    // GruProgAbrgru
    public class GruProgAbrgru
    {
        public int Id { get; set; } // ID (Primary key)
        public string AbrGrund { get; set; } // Abr_grund
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
        public string StandortKz { get; set; } // StandortKZ

        // Reverse navigation
        public virtual ICollection<GruProgAbrgruSprache> GruProgAbrgruSpraches { get; set; } // GruProgAbrgruSprache.fk_GruProgAbrgruSprache_GruProgAbrgru

        public GruProgAbrgru()
        {
            GruProgAbrgruSpraches = new List<GruProgAbrgruSprache>();
        }
    }

}
