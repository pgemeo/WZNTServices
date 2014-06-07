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
    public interface IWZNTAPIContext : IDisposable
    {
        IDbSet<GruSysDatenquelle> GruSysDatenquelles { get; set; } // GruSysDatenquelle
        IDbSet<GruSysDqfDqt> GruSysDqfDqts { get; set; } // GruSysDqfDqt
        IDbSet<GruSysDqFeld> GruSysDqFelds { get; set; } // GruSysDqFeld
        IDbSet<GruSysDqJobst> GruSysDqJobsts { get; set; } // GruSysDqJobst
        IDbSet<GruSysDqManst> GruSysDqMansts { get; set; } // GruSysDqManst
        IDbSet<GruSysDqTabelle> GruSysDqTabelles { get; set; } // GruSysDqTabelle
        IDbSet<GruSysDqtDq> GruSysDqtDqs { get; set; } // GruSysDqtDq
        IDbSet<GruSysStandort> GruSysStandorts { get; set; } // GruSysStandort

        int SaveChanges();
    }

}
