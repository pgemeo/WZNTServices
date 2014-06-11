
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

    // GruMaschinen

    internal class GruMaschinenConfiguration : EntityTypeConfiguration<GruMaschinen>
    {
        public GruMaschinenConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruMaschinen");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Maschine).HasColumnName("Maschine").IsOptional().HasMaxLength(30);

            Property(x => x.IdMaGruppe).HasColumnName("ID_MaGruppe").IsRequired();

            Property(x => x.IdRegisterMa).HasColumnName("ID_RegisterMa").IsRequired();

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);

            Property(x => x.AnzBaugruppe).HasColumnName("AnzBaugruppe").IsOptional().HasMaxLength(10);



            // Foreign keys


            HasRequired(a => a.GruMaschMaGruppe).WithMany(b => b.GruMaschinens).HasForeignKey(c => c.IdMaGruppe); // fk_GruMaschinen_GruMaschMaGruppe


        }
    }



}
