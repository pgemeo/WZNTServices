
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



    // GruArtDruckVorlSprache


    public class GruArtDruckVorlSprache
    {



        public int Id { get; set; } // ID (Primary key)


        public int IdSprache { get; set; } // ID_Sprache


        public int IdDruckvorl { get; set; } // ID_Druckvorl


        public string Uebersetzung { get; set; } // Uebersetzung


        public DateTime? OTimeStamp { get; set; } // O_TimeStamp


        public string StandortKz { get; set; } // StandortKZ




        // Foreign keys


        public virtual GruArtDruckvorl GruArtDruckvorl { get; set; } // fk_GruArtDruckVorlSprache_GruArtDruckvorl

        public virtual GruSprachen GruSprachen { get; set; } // fk_GruArtDruckVorlSprache_GruSprachen


    }



}
