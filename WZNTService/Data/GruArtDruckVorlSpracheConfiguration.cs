
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

    // GruArtDruckVorlSprache

    internal class GruArtDruckVorlSpracheConfiguration : EntityTypeConfiguration<GruArtDruckVorlSprache>
    {
        public GruArtDruckVorlSpracheConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruArtDruckVorlSprache");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.IdSprache).HasColumnName("ID_Sprache").IsRequired();

            Property(x => x.IdDruckvorl).HasColumnName("ID_Druckvorl").IsRequired();

            Property(x => x.Uebersetzung).HasColumnName("Uebersetzung").IsOptional().HasMaxLength(100);

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);



            // Foreign keys


            HasRequired(a => a.GruSprachen).WithMany(b => b.GruArtDruckVorlSpraches).HasForeignKey(c => c.IdSprache); // fk_GruArtDruckVorlSprache_GruSprachen

            HasRequired(a => a.GruArtDruckvorl).WithMany(b => b.GruArtDruckVorlSpraches).HasForeignKey(c => c.IdDruckvorl); // fk_GruArtDruckVorlSprache_GruArtDruckvorl


        }
    }



}
