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
    // GruBerGruppe
    public class GruBerGruppe
    {
        public int Id { get; set; } // ID (Primary key)
        public string GruppenBez { get; set; } // GruppenBez
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Reverse navigation
        public virtual ICollection<GruBerBenGru> GruBerBenGrus { get; set; } // GruBerBenGru.FK_GruBerBenGru_GruBerGruppe
        public virtual ICollection<GruBerEinstellungenGruppe> GruBerEinstellungenGruppes { get; set; } // GruBerEinstellungenGruppe.FK_GruBerEinstellungenGruppe_GruBerGruppe

        public GruBerGruppe()
        {
            GruBerBenGrus = new List<GruBerBenGru>();
            GruBerEinstellungenGruppes = new List<GruBerEinstellungenGruppe>();
        }
    }

}
