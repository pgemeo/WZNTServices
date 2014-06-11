
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

    // GruSysStandort

    internal class GruSysStandortConfiguration : EntityTypeConfiguration<GruSysStandort>
    {
        public GruSysStandortConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruSysStandort");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.StandortId).HasColumnName("StandortId").IsRequired().HasMaxLength(50);

            Property(x => x.Standort).HasColumnName("Standort").IsRequired().HasMaxLength(50);

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();



        }
    }



}
