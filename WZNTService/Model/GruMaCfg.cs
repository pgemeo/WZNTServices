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
    // GruMaCFG
    public class GruMaCfg
    {
        public int Id { get; set; } // ID (Primary key)
        public int IdMaschine { get; set; } // ID_Maschine
        public int IdMaschinenGrp { get; set; } // ID_MaschinenGrp
        public decimal? Baugruppe { get; set; } // Baugruppe
        public int IdDruckverfahren { get; set; } // ID_Druckverfahren
        public int IdRegistermarken { get; set; } // ID_Registermarken
        public byte[] Bild { get; set; } // Bild
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
    }

}
