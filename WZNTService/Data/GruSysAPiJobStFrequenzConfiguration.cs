
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

    // GruSysAPiJobStFrequenz

    internal class GruSysAPiJobStFrequenzConfiguration : EntityTypeConfiguration<GruSysAPiJobStFrequenz>
    {
        public GruSysAPiJobStFrequenzConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruSysAPiJobStFrequenz");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Frequenz).HasColumnName("Frequenz").IsRequired().HasMaxLength(50);

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();



        }
    }



}
