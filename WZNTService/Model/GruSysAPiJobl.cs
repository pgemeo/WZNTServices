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
    // GruSysAPiJobl
    public class GruSysAPiJobl
    {
        public int Id { get; set; } // ID (Primary key)
        public int JobId { get; set; } // JOB_ID
        public string JobBez { get; set; } // JOB_Bez
        public string Parameterdatei { get; set; } // Parameterdatei
        public bool? AktivKz { get; set; } // AktivKZ
        public string StandortKz { get; set; } // StandortKz
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
    }

}
