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
    // GruSysDqtDq
    internal class GruSysDqtDqConfiguration : EntityTypeConfiguration<GruSysDqtDq>
    {
        public GruSysDqtDqConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GruSysDqtDq");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IdDq).HasColumnName("ID_Dq").IsRequired();
            Property(x => x.IdT).HasColumnName("ID_T").IsRequired();
            Property(x => x.OTimeStamp).HasColumnName("O_TimeStamp").IsOptional();

            // Foreign keys
            HasRequired(a => a.GruSysDatenquelle).WithMany(b => b.GruSysDqtDqs).HasForeignKey(c => c.IdDq); // fk_GruSysDqtDq_GruSysDatenquelle
            HasRequired(a => a.GruSysDqTabelle).WithMany(b => b.GruSysDqtDqs).HasForeignKey(c => c.IdT); // fk_GruSysDqtDq_GruSysDqTabelle
        }
    }

}
