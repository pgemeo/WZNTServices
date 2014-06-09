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
    // GruSysStandort
    public class GruSysStandort
    {
        public int Id { get; set; } // ID (Primary key)
        public string StandortId { get; set; } // StandortID
        public string Standort { get; set; } // Standort
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
    }

}
