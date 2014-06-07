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
    // GruArtBasisArtSprache
    internal class GruArtBasisArtSpracheConfiguration : EntityTypeConfiguration<GruArtBasisArtSprache>
    {
        public GruArtBasisArtSpracheConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruArtBasisArtSprache");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IdSprache).HasColumnName("ID_Sprache").IsRequired();
            Property(x => x.IdBasisart).HasColumnName("ID_Basisart").IsRequired();
            Property(x => x.Uebersetzung).HasColumnName("Uebersetzung").IsOptional().HasMaxLength(100);
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            // Foreign keys
            HasRequired(a => a.GruSprachen).WithMany(b => b.GruArtBasisArtSpraches).HasForeignKey(c => c.IdSprache); // fk_GruArtBasisArtSprache_GruSprachen
            HasRequired(a => a.GruArtBasisart).WithMany(b => b.GruArtBasisArtSpraches).HasForeignKey(c => c.IdBasisart); // fk_GruArtBasisArtSprache_GruArtBasisart
        }
    }

}
