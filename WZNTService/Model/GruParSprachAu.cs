
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



    // GruParSprachAus


    public class GruParSprachAu
    {



        public int Id { get; set; } // ID (Primary key)


        public string Sprache { get; set; } // Sprache


        public string Iso { get; set; } // ISO


        public bool? AktivKz { get; set; } // AktivKZ


        public string Datei { get; set; } // Datei


        public string StandortKz { get; set; } // StandortKZ


        public DateTime? OTimeStamp { get; set; } // O_TimeStamp




    }



}
