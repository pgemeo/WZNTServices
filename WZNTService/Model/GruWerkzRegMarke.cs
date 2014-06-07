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
    // GruWerkzRegMarke
    public class GruWerkzRegMarke
    {
        public int Id { get; set; } // ID (Primary key)
        public string Anzeichnung { get; set; } // Anzeichnung
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Reverse navigation
        public virtual ICollection<GruWerkzRegMarkePos> GruWerkzRegMarkePos { get; set; } // GruWerkzRegMarkePos.fk_GruWerkzRegMarkePos_GruWerkzRegMarke

        public GruWerkzRegMarke()
        {
            GruWerkzRegMarkePos = new List<GruWerkzRegMarkePos>();
        }
    }

}
