
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

    // GruSprachen

    internal class GruSprachenConfiguration : EntityTypeConfiguration<GruSprachen>
    {
        public GruSprachenConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruSprachen");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Sprache).HasColumnName("Sprache").IsOptional().HasMaxLength(20);

            Property(x => x.Iso).HasColumnName("ISO").IsOptional().HasMaxLength(10);

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);



        }
    }



}
