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
    // GruBerEinstellungen
    internal class GruBerEinstellungenConfiguration : EntityTypeConfiguration<GruBerEinstellungen>
    {
        public GruBerEinstellungenConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruBerEinstellungen");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.BeDecs).HasColumnName("BeDECS").IsOptional();
            Property(x => x.BeDk).HasColumnName("BeDK").IsOptional();
            Property(x => x.BeEn).HasColumnName("BeEN").IsOptional();
            Property(x => x.BeWe).HasColumnName("BeWE").IsOptional();
            Property(x => x.BeGrul).HasColumnName("BeGrul").IsOptional();
            Property(x => x.BeAPi).HasColumnName("BeAPi").IsOptional();
            Property(x => x.StandortBer).HasColumnName("StandortBer").IsOptional().HasMaxLength(20);
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
