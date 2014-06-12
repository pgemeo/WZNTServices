
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



    // GruWerkzMatKennlArt


    public class GruWerkzMatKennlArt
    {



        public int Id { get; set; } // ID (Primary key)


        public int IdMatKennl { get; set; } // ID_MatKennl


        public string Artikelnummer { get; set; } // Artikelnummer


        public string Matchcode { get; set; } // Matchcode


        public DateTime? OTimeStamp { get; set; } // O_TimeStamp


        public string StandortKz { get; set; } // StandortKZ




        // Foreign keys


        public virtual GruWerkzMatKennl GruWerkzMatKennl { get; set; } // fk_GruWerkzMatKennlArt_GruWerkzMatKennl


    }



}
