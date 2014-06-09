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
    // GruBerBenutzer
    internal class GruBerBenutzerConfiguration : EntityTypeConfiguration<GruBerBenutzer>
    {
        public GruBerBenutzerConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruBerBenutzer");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LoginName).HasColumnName("LoginName").IsOptional().HasMaxLength(50);
            Property(x => x.Vorname).HasColumnName("Vorname").IsOptional().HasMaxLength(50);
            Property(x => x.Nachname).HasColumnName("Nachname").IsOptional().HasMaxLength(50);
            Property(x => x.Passwort).HasColumnName("Passwort").IsOptional().HasMaxLength(50);
            Property(x => x.Gruppe).HasColumnName("Gruppe").IsOptional().HasMaxLength(50);
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
