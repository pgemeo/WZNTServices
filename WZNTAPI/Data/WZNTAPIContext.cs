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
    public class WZNTAPIContext : DbContext, IWZNTAPIContext
    {
        public IDbSet<GruSysDatenquelle> GruSysDatenquelles { get; set; } // GruSysDatenquelle
        public IDbSet<GruSysDqfDqt> GruSysDqfDqts { get; set; } // GruSysDqfDqt
        public IDbSet<GruSysDqFeld> GruSysDqFelds { get; set; } // GruSysDqFeld
        public IDbSet<GruSysDqJobst> GruSysDqJobsts { get; set; } // GruSysDqJobst
        public IDbSet<GruSysDqManst> GruSysDqMansts { get; set; } // GruSysDqManst
        public IDbSet<GruSysDqTabelle> GruSysDqTabelles { get; set; } // GruSysDqTabelle
        public IDbSet<GruSysDqtDq> GruSysDqtDqs { get; set; } // GruSysDqtDq
        public IDbSet<GruSysStandort> GruSysStandorts { get; set; } // GruSysStandort

        static WZNTAPIContext()
        {
            Database.SetInitializer<WZNTAPIContext>(null);
        }

        public WZNTAPIContext()
            : base("Name=WZNTAPI")
        {
        }

        public WZNTAPIContext(string connectionString) : base(connectionString)
        {
        }

        public WZNTAPIContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new GruSysDatenquelleConfiguration());
            modelBuilder.Configurations.Add(new GruSysDqfDqtConfiguration());
            modelBuilder.Configurations.Add(new GruSysDqFeldConfiguration());
            modelBuilder.Configurations.Add(new GruSysDqJobstConfiguration());
            modelBuilder.Configurations.Add(new GruSysDqManstConfiguration());
            modelBuilder.Configurations.Add(new GruSysDqTabelleConfiguration());
            modelBuilder.Configurations.Add(new GruSysDqtDqConfiguration());
            modelBuilder.Configurations.Add(new GruSysStandortConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new GruSysDatenquelleConfiguration(schema));
            modelBuilder.Configurations.Add(new GruSysDqfDqtConfiguration(schema));
            modelBuilder.Configurations.Add(new GruSysDqFeldConfiguration(schema));
            modelBuilder.Configurations.Add(new GruSysDqJobstConfiguration(schema));
            modelBuilder.Configurations.Add(new GruSysDqManstConfiguration(schema));
            modelBuilder.Configurations.Add(new GruSysDqTabelleConfiguration(schema));
            modelBuilder.Configurations.Add(new GruSysDqtDqConfiguration(schema));
            modelBuilder.Configurations.Add(new GruSysStandortConfiguration(schema));
            return modelBuilder;
        }
    }
}
