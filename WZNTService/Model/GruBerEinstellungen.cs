
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



    // GruBerEinstellungen


    public class GruBerEinstellungen
    {



        public int Id { get; set; } // ID (Primary key)


        public int IdGruppe { get; set; } // ID_Gruppe


        public bool? BeDecs { get; set; } // BeDECS


        public bool? BeDk { get; set; } // BeDK


        public bool? BeEn { get; set; } // BeEN


        public bool? BeWe { get; set; } // BeWE


        public bool? BeGrul { get; set; } // BeGrul


        public bool? BeAPi { get; set; } // BeAPi


        public string StandortBer { get; set; } // StandortBer


        public DateTime? OTimeStamp { get; set; } // O_TimeStamp




        // Foreign keys


        public virtual GruBerGruppe GruBerGruppe { get; set; } // FK_GruBerEinstellungen_GruBerGruppe


    }



}
