
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

    // GruExportWZ

    internal class GruExportWzConfiguration : EntityTypeConfiguration<GruExportWz>
    {
        public GruExportWzConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruExportWZ");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.FeldWzntwz).HasColumnName("FeldWZNTWZ").IsOptional().HasMaxLength(100);

            Property(x => x.FeldEsko).HasColumnName("Feld_ESKO").IsOptional().HasMaxLength(100);

            Property(x => x.Feldtyp).HasColumnName("Feldtyp").IsOptional().HasMaxLength(50);

            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();



        }
    }



}
