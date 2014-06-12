
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

    // GruArtAufEinzelnutzen

    internal class GruArtAufEinzelnutzenConfiguration : EntityTypeConfiguration<GruArtAufEinzelnutzen>
    {
        public GruArtAufEinzelnutzenConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruArtAufEinzelnutzen");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Aufgabe).HasColumnName("Aufgabe").IsOptional().HasMaxLength(100);

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);



        }
    }



}
