
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



    // GruWerkzRegMarkePos


    public class GruWerkzRegMarkePos
    {



        public int Id { get; set; } // ID (Primary key)


        public int IdRegM { get; set; } // ID_RegM


        public int Pos { get; set; } // Pos


        public string Abstand { get; set; } // Abstand


        public DateTime? OTimeStamp { get; set; } // O_TimeStamp


        public string StandortKz { get; set; } // StandortKZ




        // Foreign keys


        public virtual GruWerkzRegMarke GruWerkzRegMarke { get; set; } // fk_GruWerkzRegMarkePos_GruWerkzRegMarke


    }



}
