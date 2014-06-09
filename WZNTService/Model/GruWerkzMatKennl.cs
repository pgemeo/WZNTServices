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
    // GruWerkzMatKennl
    public class GruWerkzMatKennl
    {
        public int Id { get; set; } // ID (Primary key)
        public string MaKennl { get; set; } // MaKennl
        public string Beschreibung { get; set; } // Beschreibung
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
        public string StandortKz { get; set; } // StandortKZ

        // Reverse navigation
        public virtual ICollection<GruWerkzMatKennlArt> GruWerkzMatKennlArts { get; set; } // GruWerkzMatKennlArt.fk_GruWerkzMatKennlArt_GruWerkzMatKennl

        public GruWerkzMatKennl()
        {
            GruWerkzMatKennlArts = new List<GruWerkzMatKennlArt>();
        }
    }

}
