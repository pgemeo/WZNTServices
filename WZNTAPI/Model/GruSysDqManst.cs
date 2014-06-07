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
    // GruSysDqManst
    public class GruSysDqManst
    {
        public int Id { get; set; } // ID (Primary key)
        public string StandortKz { get; set; } // StandortKZ
        public string UserName { get; set; } // UserName
        public string UserIp { get; set; } // UserIP
        public DateTime? StartDatum { get; set; } // StartDatum
        public DateTime? StartZeit { get; set; } // StartZeit
        public DateTime? EndDatum { get; set; } // EndDatum
        public DateTime? EndZeit { get; set; } // EndZeit
        public bool? Status { get; set; } // Status
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
    }

}
