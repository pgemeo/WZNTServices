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
    // GruSysAPiJobSt
    public class GruSysAPiJobSt
    {
        public int Id { get; set; } // ID (Primary key)
        public int JobId { get; set; } // JOB_ID
        public string Frequenz { get; set; } // Frequenz
        public DateTime? Startdatum { get; set; } // Startdatum
        public DateTime? Startzeit { get; set; } // Startzeit
        public bool? AktivKz { get; set; } // AktivKz
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
    }

}
