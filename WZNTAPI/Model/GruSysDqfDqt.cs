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
    // GruSysDqfDqt
    public class GruSysDqfDqt
    {
        public int Id { get; set; } // ID (Primary key)
        public int IdF { get; set; } // ID_F
        public int IdT { get; set; } // ID_T
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Foreign keys
        public virtual GruSysDqFeld GruSysDqFeld { get; set; } // fk_GruSysDqfDqt_GruSysDqFeld
        public virtual GruSysDqTabelle GruSysDqTabelle { get; set; } // fk_GruSysDqfDqt_GruSysDqTabelle
    }

}
