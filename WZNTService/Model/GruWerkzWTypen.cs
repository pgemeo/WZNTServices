
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



    // GruWerkzWTypen


    public class GruWerkzWTypen
    {



        public int Id { get; set; } // ID (Primary key)


        public decimal? Typ { get; set; } // Typ


        public string Matchcode { get; set; } // Matchcode


        public decimal? MaxBreite { get; set; } // MaxBreite


        public string Material { get; set; } // Material


        public decimal? MaxLfm { get; set; } // maxLfm


        public DateTime? OTimeStamp { get; set; } // O_TimeStamp


        public string StandortKz { get; set; } // StandortKZ



        // Reverse navigation


        public virtual ICollection<GruMaTypenDruKz> GruMaTypenDruKzs { get; set; } // GruMaTypenDruKz.fk_GruMaTypenDruKz_GruWerkzWTypen




        public GruWerkzWTypen()
        {


            GruMaTypenDruKzs = new List<GruMaTypenDruKz>();
        }

    }



}
