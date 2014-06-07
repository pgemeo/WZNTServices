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
    // GruSysDqtDq
    public class GruSysDqtDq
    {
        public int Id { get; set; } // ID (Primary key)
        public int IdDq { get; set; } // ID_Dq
        public int IdT { get; set; } // ID_T
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Foreign keys
        public virtual GruSysDatenquelle GruSysDatenquelle { get; set; } // fk_GruSysDqtDq_GruSysDatenquelle
        public virtual GruSysDqTabelle GruSysDqTabelle { get; set; } // fk_GruSysDqtDq_GruSysDqTabelle
    }

}
