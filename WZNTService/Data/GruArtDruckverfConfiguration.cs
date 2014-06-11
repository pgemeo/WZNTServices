
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;


using System.ComponentModel.DataAnnotations.Schema;


using System.Data.Entity;


using System.Data.Entity.ModelConfiguration;



using Model;





//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;



namespace Data
{

    // GruArtDruckverf

    internal class GruArtDruckverfConfiguration : EntityTypeConfiguration<GruArtDruckverf>
    {
        public GruArtDruckverfConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruArtDruckverf");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Druckverfahren).HasColumnName("Druckverfahren").IsOptional().HasMaxLength(100);

            Property(x => x.Kurzzeichen).HasColumnName("Kurzzeichen").IsOptional().HasMaxLength(20);

            Property(x => x.Auflosung).HasColumnName("Auflosung").IsOptional().HasMaxLength(20);

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);



        }
    }



}
