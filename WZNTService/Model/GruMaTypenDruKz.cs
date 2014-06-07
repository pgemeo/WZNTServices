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
    // GruMaTypenDruKz
    public class GruMaTypenDruKz
    {
        public int Id { get; set; } // ID (Primary key)
        public int IdMaschine { get; set; } // ID_Maschine
        public int IdWzTyp { get; set; } // ID_WzTyp
        public bool? OdKz { get; set; } // OdKz
        public bool? FdKz { get; set; } // FdKz
        public bool? SdKz { get; set; } // SdKz
        public bool? TdKz { get; set; } // TdKz
        public bool? IjKz { get; set; } // IjKz
        public bool? HpKz { get; set; } // HpKz
        public bool? KpKz { get; set; } // KpKz
        public bool? StKz { get; set; } // StKz
        public bool? ZsKz { get; set; } // ZsKz
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Foreign keys
        public virtual GruWerkzWTypen GruWerkzWTypen { get; set; } // fk_GruMaTypenDruKz_GruWerkzWTypen
    }

}
