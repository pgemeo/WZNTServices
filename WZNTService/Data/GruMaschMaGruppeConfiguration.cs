
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

    // GruMaschMaGruppe

    internal class GruMaschMaGruppeConfiguration : EntityTypeConfiguration<GruMaschMaGruppe>
    {
        public GruMaschMaGruppeConfiguration(string schema = "dbo")
        {
 
           ToTable(schema + ".GruMaschMaGruppe");
 
           HasKey(x => x.Id);


            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.MaGruppe).HasColumnName("MaGruppe").IsOptional().HasMaxLength(20);

            Property(x => x.Beschreibung).HasColumnName("Beschreibung").IsOptional().HasMaxLength(150);

            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);



        }
    }



}
