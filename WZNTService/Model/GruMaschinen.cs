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
    // GruMaschinen
    public class GruMaschinen
    {
        public int Id { get; set; } // ID (Primary key)
        public string Maschine { get; set; } // Maschine
        public int IdMaGruppe { get; set; } // ID_MaGruppe
        public int IdRegisterMa { get; set; } // ID_RegisterMa
        public string Ort { get; set; } // Ort
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Foreign keys
        public virtual GruMaschMaGruppe GruMaschMaGruppe { get; set; } // fk_GruMaschinen_GruMaschMaGruppe
    }

}
