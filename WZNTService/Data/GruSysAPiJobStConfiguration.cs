
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

    // GruSysAPiJobSt

    internal class GruSysAPiJobStConfiguration : EntityTypeConfiguration<GruSysAPiJobSt>
    {
        public GruSysAPiJobStConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruSysAPiJobSt");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.JobId).HasColumnName("JOB_ID").IsRequired();

            Property(x => x.Frequenz).HasColumnName("Frequenz").IsOptional().HasMaxLength(10);

            Property(x => x.Startdatum).HasColumnName("Startdatum").IsOptional();

            Property(x => x.Startzeit).HasColumnName("Startzeit").IsOptional();

            Property(x => x.AktivKz).HasColumnName("AktivKz").IsOptional();

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();



        }
    }



}
