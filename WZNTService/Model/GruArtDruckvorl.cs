
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



    // GruArtDruckvorl


    public class GruArtDruckvorl
    {



        public int Id { get; set; } // ID (Primary key)


        public string Druckvorlagen { get; set; } // Druckvorlagen


        public DateTime? OTimeStamp { get; set; } // O_TimeStamp


        public string StandortKz { get; set; } // StandortKZ



        // Reverse navigation


        public virtual ICollection<GruArtDruckVorlSprache> GruArtDruckVorlSpraches { get; set; } // GruArtDruckVorlSprache.fk_GruArtDruckVorlSprache_GruArtDruckvorl




        public GruArtDruckvorl()
        {


            GruArtDruckVorlSpraches = new List<GruArtDruckVorlSprache>();
        }

    }



}
