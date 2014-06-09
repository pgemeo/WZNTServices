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
    // GruBerBenutzer
    public class GruBerBenutzer
    {
        public int Id { get; set; } // ID (Primary key)
        public string LoginName { get; set; } // LoginName
        public string Vorname { get; set; } // Vorname
        public string Nachname { get; set; } // Nachname
        public string Passwort { get; set; } // Passwort
        public string Gruppe { get; set; } // Gruppe
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Reverse navigation
        public virtual ICollection<GruBerBenGru> GruBerBenGrus { get; set; } // GruBerBenGru.FK_GruBerBenGru_GruBerBenutzer

        public GruBerBenutzer()
        {
            GruBerBenGrus = new List<GruBerBenGru>();
        }
    }

}
