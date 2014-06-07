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
    // GruSysDqFeld
    public class GruSysDqFeld
    {
        public int Id { get; set; } // ID (Primary key)
        public string Feld { get; set; } // Feld
        public string Feldtyp { get; set; } // Feldtyp
        public string OTimeStamp { get; set; } // O_TimeStamp

        // Reverse navigation
        public virtual ICollection<GruSysDqfDqt> GruSysDqfDqts { get; set; } // GruSysDqfDqt.fk_GruSysDqfDqt_GruSysDqFeld

        public GruSysDqFeld()
        {
            GruSysDqfDqts = new List<GruSysDqfDqt>();
        }
    }

}
