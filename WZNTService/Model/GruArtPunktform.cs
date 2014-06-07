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
    // GruArtPunktform
    public class GruArtPunktform
    {
        public int Id { get; set; } // ID (Primary key)
        public string Punktform { get; set; } // Punktform
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
    }

}
