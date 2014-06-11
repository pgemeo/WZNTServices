
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

    // GruArtDruckVerSprache

    internal class GruArtDruckVerSpracheConfiguration : EntityTypeConfiguration<GruArtDruckVerSprache>
    {
        public GruArtDruckVerSpracheConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruArtDruckVerSprache");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.IdSprache).HasColumnName("ID_Sprache").IsRequired();

            Property(x => x.IdDruckverf).HasColumnName("ID_Druckverf").IsRequired();

            Property(x => x.UebSetDruckv).HasColumnName("UebSetDruckv").IsOptional().HasMaxLength(100);

            Property(x => x.UebSetKurzz).HasColumnName("UebSetKurzz").IsOptional().HasMaxLength(10);

            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();



            // Foreign keys


            HasRequired(a => a.GruSprachen).WithMany(b => b.GruArtDruckVerSpraches).HasForeignKey(c => c.IdSprache); // FK_GruArtDruckVerSprache_GruSprachen

            HasRequired(a => a.GruArtDruckverf).WithMany(b => b.GruArtDruckVerSpraches).HasForeignKey(c => c.IdDruckverf); // FK_GruArtDruckVerSprache_GruArtDruckverf


        }
    }



}
