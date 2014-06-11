
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



    // GruBerBenGru


    public class GruBerBenGru
    {



        public int Id { get; set; } // ID (Primary key)


        public int IdBenutzer { get; set; } // ID_Benutzer


        public int IdGruppe { get; set; } // ID_Gruppe


        public DateTime? OTimeStamp { get; set; } // O_TimeStamp




        // Foreign keys


        public virtual GruBerBenutzer GruBerBenutzer { get; set; } // FK_GruBerBenGru_GruBerBenutzer

        public virtual GruBerGruppe GruBerGruppe { get; set; } // FK_GruBerBenGru_GruBerGruppe


    }



}
