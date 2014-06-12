
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

    // GruProgAbrgruSprache

    internal class GruProgAbrgruSpracheConfiguration : EntityTypeConfiguration<GruProgAbrgruSprache>
    {
        public GruProgAbrgruSpracheConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruProgAbrgruSprache");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.IdSprache).HasColumnName("ID_Sprache").IsRequired();

            Property(x => x.IdAbrGrund).HasColumnName("ID_Abr_grund").IsRequired();

            Property(x => x.UebAbrGrund).HasColumnName("UebAbr_grund").IsOptional().HasMaxLength(150);

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);



            // Foreign keys


            HasRequired(a => a.GruSprachen).WithMany(b => b.GruProgAbrgruSpraches).HasForeignKey(c => c.IdSprache); // fk_GruProgAbrgruSprache_GruSprachen

            HasRequired(a => a.GruProgAbrgru).WithMany(b => b.GruProgAbrgruSpraches).HasForeignKey(c => c.IdAbrGrund); // fk_GruProgAbrgruSprache_GruProgAbrgru


        }
    }



}
