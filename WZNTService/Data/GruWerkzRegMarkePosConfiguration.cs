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
    // GruWerkzRegMarkePos
    internal class GruWerkzRegMarkePosConfiguration : EntityTypeConfiguration<GruWerkzRegMarkePos>
    {
        public GruWerkzRegMarkePosConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruWerkzRegMarkePos");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IdRegM).HasColumnName("ID_RegM").IsRequired();
            Property(x => x.Pos).HasColumnName("Pos").IsRequired();
            Property(x => x.Abstand).HasColumnName("Abstand").IsOptional().HasMaxLength(100);
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            // Foreign keys
            HasRequired(a => a.GruWerkzRegMarke).WithMany(b => b.GruWerkzRegMarkePos).HasForeignKey(c => c.IdRegM); // fk_GruWerkzRegMarkePos_GruWerkzRegMarke
        }
    }

}
