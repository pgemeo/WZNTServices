// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    // GruArtBasisart
    public class GruArtBasisart
    {
        public int Id { get; set; } // ID (Primary key)
        public string Basisart { get; set; } // Basisart
        public DateTime? OTimeStamp { get; set; } // O_TimeStamp

        // Reverse navigation
        public virtual ICollection<GruArtBasisArtSprache> GruArtBasisArtSpraches { get; set; } // GruArtBasisArtSprache.fk_GruArtBasisArtSprache_GruArtBasisart

        public GruArtBasisart()
        {
            GruArtBasisArtSpraches = new List<GruArtBasisArtSprache>();
        }
    }

}
