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
    // GruSysDqTabelle
    public class GruSysDqTabelle
    {
        public int Id { get; set; } // ID (Primary key)
        public string Tabellenname { get; set; } // Tabellenname
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Reverse navigation
        public virtual ICollection<GruSysDqfDqt> GruSysDqfDqts { get; set; } // GruSysDqfDqt.fk_GruSysDqfDqt_GruSysDqTabelle
        public virtual ICollection<GruSysDqtDq> GruSysDqtDqs { get; set; } // GruSysDqtDq.fk_GruSysDqtDq_GruSysDqTabelle

        public GruSysDqTabelle()
        {
            GruSysDqfDqts = new List<GruSysDqfDqt>();
            GruSysDqtDqs = new List<GruSysDqtDq>();
        }
    }

}
