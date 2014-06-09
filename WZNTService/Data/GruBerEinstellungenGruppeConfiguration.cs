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
    // GruBerEinstellungenGruppe
    internal class GruBerEinstellungenGruppeConfiguration : EntityTypeConfiguration<GruBerEinstellungenGruppe>
    {
        public GruBerEinstellungenGruppeConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruBerEinstellungenGruppe");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IdEinstellungen).HasColumnName("ID_Einstellungen").IsRequired();
            Property(x => x.IdGruppe).HasColumnName("ID_Gruppe").IsRequired();
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            // Foreign keys
            HasRequired(a => a.GruBerEinstellungen).WithMany(b => b.GruBerEinstellungenGruppes).HasForeignKey(c => c.IdEinstellungen); // FK_GruBerEinstellungenGruppe_GruBerEinstellungen
            HasRequired(a => a.GruBerGruppe).WithMany(b => b.GruBerEinstellungenGruppes).HasForeignKey(c => c.IdGruppe); // FK_GruBerEinstellungenGruppe_GruBerGruppe
        }
    }

}
