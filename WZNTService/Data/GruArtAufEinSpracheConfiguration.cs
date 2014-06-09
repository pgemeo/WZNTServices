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
    // GruArtAufEinSprache
    internal class GruArtAufEinSpracheConfiguration : EntityTypeConfiguration<GruArtAufEinSprache>
    {
        public GruArtAufEinSpracheConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruArtAufEinSprache");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IdSprache).HasColumnName("ID_Sprache").IsRequired();
            Property(x => x.IdAufgabe).HasColumnName("ID_Aufgabe").IsRequired();
            Property(x => x.Uebersetzung).HasColumnName("Uebersetzung").IsOptional().HasMaxLength(100);
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(10);

            // Foreign keys
            HasRequired(a => a.GruSprachen).WithMany(b => b.GruArtAufEinSpraches).HasForeignKey(c => c.IdSprache); // fk_GruArtAufEinSprache_GruSprachen
            HasRequired(a => a.GruArtAufEinzelnutzen).WithMany(b => b.GruArtAufEinSpraches).HasForeignKey(c => c.IdAufgabe); // fk_GruArtAufEinSprache_GruArtAufEinzelnutzen
        }
    }

}
