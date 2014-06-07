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
    // GruWerkzMatKennlArt
    internal class GruWerkzMatKennlArtConfiguration : EntityTypeConfiguration<GruWerkzMatKennlArt>
    {
        public GruWerkzMatKennlArtConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruWerkzMatKennlArt");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IdMatKennl).HasColumnName("ID_MatKennl").IsRequired();
            Property(x => x.Artikelnummer).HasColumnName("Artikelnummer").IsOptional().HasMaxLength(20);
            Property(x => x.Matchcode).HasColumnName("Matchcode").IsOptional().HasMaxLength(100);
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            // Foreign keys
            HasRequired(a => a.GruWerkzMatKennl).WithMany(b => b.GruWerkzMatKennlArts).HasForeignKey(c => c.IdMatKennl); // fk_GruWerkzMatKennlArt_GruWerkzMatKennl
        }
    }

}
