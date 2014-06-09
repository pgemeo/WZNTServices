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
    // GruMaschMaGruppe
    public class GruMaschMaGruppe
    {
        public int Id { get; set; } // ID (Primary key)
        public string MaGruppe { get; set; } // MaGruppe
        public string Beschreibung { get; set; } // Beschreibung
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
        public string StandortKz { get; set; } // StandortKZ

        // Reverse navigation
        public virtual ICollection<GruMaschinen> GruMaschinens { get; set; } // GruMaschinen.fk_GruMaschinen_GruMaschMaGruppe

        public GruMaschMaGruppe()
        {
            GruMaschinens = new List<GruMaschinen>();
        }
    }

}
