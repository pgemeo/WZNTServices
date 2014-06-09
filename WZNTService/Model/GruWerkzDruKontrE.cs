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
    // GruWerkzDruKontrE
    public class GruWerkzDruKontrE
    {
        public int Id { get; set; } // ID (Primary key)
        public int Typ { get; set; } // Typ
        public string Matchcode { get; set; } // Matchcode
        public string Farbzonen { get; set; } // Farbzonen
        public string Felder { get; set; } // Felder
        public string C1Streifen { get; set; } // 1_Streifen
        public string C2Streifen { get; set; } // 2_Streifen
        public string C3Streifen { get; set; } // 3_Streifen
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp
        public string StandortKz { get; set; } // StandortKZ
    }

}
