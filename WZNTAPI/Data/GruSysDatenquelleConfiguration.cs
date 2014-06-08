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
    // GruSysDatenquelle
    internal class GruSysDatenquelleConfiguration : EntityTypeConfiguration<GruSysDatenquelle>
    {
        public GruSysDatenquelleConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruSysDatenquelle");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DboEngine).HasColumnName("DboEngine").IsOptional().HasMaxLength(50);
            Property(x => x.Servername).HasColumnName("Servername").IsOptional().HasMaxLength(50);
            Property(x => x.UserDesc).HasColumnName("UserDesc").IsOptional().HasMaxLength(50);
            Property(x => x.Passwort).HasColumnName("Passwort").IsOptional().HasMaxLength(128);
            Property(x => x.StandortKz).HasColumnName("StandortKZ").IsOptional().HasMaxLength(5);
            Property(x => x.Status).HasColumnName("Status").IsOptional();
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();
        }
    }

}
