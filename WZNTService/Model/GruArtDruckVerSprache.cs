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
    // GruArtDruckVerSprache
    public class GruArtDruckVerSprache
    {
        public int Id { get; set; } // ID (Primary key)
        public int IdSprache { get; set; } // ID_Sprache
        public int IdDruckvorl { get; set; } // ID_Druckvorl
        public string UebSetDruckv { get; set; } // UebSetDruckv
        public string UebSetKurzz { get; set; } // UebSetKurzz
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Foreign keys
        public virtual GruArtDruckverf GruArtDruckverf { get; set; } // fk_GruArtDruckVerSprache_GruArtDruckverf
        public virtual GruSprachen GruSprachen { get; set; } // fk_GruArtDruckVerSprache_GruSprachen
    }

}
