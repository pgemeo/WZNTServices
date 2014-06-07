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
    // GruSysDatenquelle
    public class GruSysDatenquelle
    {
        public int Id { get; set; } // ID (Primary key)
        public string DboEngine { get; set; } // DboEngine
        public string Servername { get; set; } // Servername
        public string UserDesc { get; set; } // UserDesc
        public string Passwort { get; set; } // Passwort
        public string StandortKz { get; set; } // StandortKZ
        public bool? Status { get; set; } // Status
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Reverse navigation
        public virtual ICollection<GruSysDqtDq> GruSysDqtDqs { get; set; } // GruSysDqtDq.fk_GruSysDqtDq_GruSysDatenquelle

        public GruSysDatenquelle()
        {
            GruSysDqtDqs = new List<GruSysDqtDq>();
        }
    }

}
