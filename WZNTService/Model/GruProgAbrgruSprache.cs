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
    // GruProgAbrgruSprache
    public class GruProgAbrgruSprache
    {
        public int Id { get; set; } // ID (Primary key)
        public int IdSprache { get; set; } // ID_Sprache
        public int IdAbrGrund { get; set; } // ID_Abr_grund
        public string UebAbrGrund { get; set; } // UebAbr_grund
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Foreign keys
        public virtual GruProgAbrgru GruProgAbrgru { get; set; } // fk_GruProgAbrgruSprache_GruProgAbrgru
        public virtual GruSprachen GruSprachen { get; set; } // fk_GruProgAbrgruSprache_GruSprachen
    }

}
