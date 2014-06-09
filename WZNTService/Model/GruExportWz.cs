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
    // GruExportWZ
    public class GruExportWz
    {
        public int Id { get; set; } // ID (Primary key)
        public string FeldWzntwz { get; set; } // FeldWZNTWZ
        public string FeldEsko { get; set; } // Feld_ESKO
        public string Feldtyp { get; set; } // Feldtyp
        public string StandortKz { get; set; } // StandortKZ
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
    }

}
