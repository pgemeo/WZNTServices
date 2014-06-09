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
    // GruBerBenGru
    internal class GruBerBenGruConfiguration : EntityTypeConfiguration<GruBerBenGru>
    {
        public GruBerBenGruConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruBerBenGru");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IdBenutzer).HasColumnName("ID_Benutzer").IsRequired();
            Property(x => x.IdGruppe).HasColumnName("ID_Gruppe").IsRequired();
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            // Foreign keys
            HasRequired(a => a.GruBerBenutzer).WithMany(b => b.GruBerBenGrus).HasForeignKey(c => c.IdBenutzer); // FK_GruBerBenGru_GruBerBenutzer
            HasRequired(a => a.GruBerGruppe).WithMany(b => b.GruBerBenGrus).HasForeignKey(c => c.IdGruppe); // FK_GruBerBenGru_GruBerGruppe
        }
    }

}
