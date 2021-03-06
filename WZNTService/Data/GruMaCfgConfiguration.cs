
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

    // GruMaCFG

    internal class GruMaCfgConfiguration : EntityTypeConfiguration<GruMaCfg>
    {
        public GruMaCfgConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruMaCFG");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.IdMaschine).HasColumnName("ID_Maschine").IsRequired();

            Property(x => x.IdMaschinenGrp).HasColumnName("ID_MaschinenGrp").IsRequired();

            Property(x => x.Baugruppe).HasColumnName("Baugruppe").IsOptional();

            Property(x => x.IdDruckverfahren).HasColumnName("ID_Druckverfahren").IsRequired();

            Property(x => x.IdRegistermarken).HasColumnName("ID_Registermarken").IsRequired();

            Property(x => x.Bild).HasColumnName("Bild").IsOptional();

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);



            // Foreign keys


            HasRequired(a => a.GruMaschinen).WithMany(b => b.GruMaCfgs).HasForeignKey(c => c.IdMaschine); // FK_GruMaCFG_GruMaschinen

            HasRequired(a => a.GruArtDruckverf).WithMany(b => b.GruMaCfgs).HasForeignKey(c => c.IdDruckverfahren); // FK_GruMaCFG_GruArtDruckverf

            HasRequired(a => a.GruWerkzRegMarke).WithMany(b => b.GruMaCfgs).HasForeignKey(c => c.IdRegistermarken); // FK_GruMaCFG_GruWerkzRegMarke


        }
    }



}
