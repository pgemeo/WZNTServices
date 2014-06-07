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
    // GruSysDqJobst
    public class GruSysDqJobst
    {
        public int Id { get; set; } // ID (Primary key)
        public string StandortKz { get; set; } // StandortKZ
        public string Frequenz { get; set; } // Frequenz
        public DateTime? Startdatum { get; set; } // Startdatum
        public DateTime? Startzeit { get; set; } // Startzeit
        public bool? Status { get; set; } // Status
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
    }

}
