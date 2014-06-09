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
    // GruBerEinstellungenGruppe
    public class GruBerEinstellungenGruppe
    {
        public int Id { get; set; } // ID (Primary key)
        public int IdEinstellungen { get; set; } // ID_Einstellungen
        public int IdGruppe { get; set; } // ID_Gruppe
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Foreign keys
        public virtual GruBerEinstellungen GruBerEinstellungen { get; set; } // FK_GruBerEinstellungenGruppe_GruBerEinstellungen
        public virtual GruBerGruppe GruBerGruppe { get; set; } // FK_GruBerEinstellungenGruppe_GruBerGruppe
    }

}
