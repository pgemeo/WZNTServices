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
    public interface IWZNTContext : IDisposable
    {
        IDbSet<GruArtAufEinSprache> GruArtAufEinSpraches { get; set; } // GruArtAufEinSprache
        IDbSet<GruArtAufEinzelnutzen> GruArtAufEinzelnutzens { get; set; } // GruArtAufEinzelnutzen
        IDbSet<GruArtBasisart> GruArtBasisarts { get; set; } // GruArtBasisart
        IDbSet<GruArtBasisArtSprache> GruArtBasisArtSpraches { get; set; } // GruArtBasisArtSprache
        IDbSet<GruArtDruckverf> GruArtDruckverfs { get; set; } // GruArtDruckverf
        IDbSet<GruArtDruckVerSprache> GruArtDruckVerSpraches { get; set; } // GruArtDruckVerSprache
        IDbSet<GruArtDruckvorl> GruArtDruckvorls { get; set; } // GruArtDruckvorl
        IDbSet<GruArtDruckVorlSprache> GruArtDruckVorlSpraches { get; set; } // GruArtDruckVorlSprache
        IDbSet<GruArtFarbtyp> GruArtFarbtyps { get; set; } // GruArtFarbtyp
        IDbSet<GruArtPunktform> GruArtPunktforms { get; set; } // GruArtPunktform
        IDbSet<GruMaCfg> GruMaCfgs { get; set; } // GruMaCFG
        IDbSet<GruMaschinen> GruMaschinens { get; set; } // GruMaschinen
        IDbSet<GruMaschMaGruppe> GruMaschMaGruppes { get; set; } // GruMaschMaGruppe
        IDbSet<GruMaTypenDruKz> GruMaTypenDruKzs { get; set; } // GruMaTypenDruKz
        IDbSet<GruProgAbrgru> GruProgAbrgrus { get; set; } // GruProgAbrgru
        IDbSet<GruProgAbrgruSprache> GruProgAbrgruSpraches { get; set; } // GruProgAbrgruSprache
        IDbSet<GruSprachen> GruSprachens { get; set; } // GruSprachen
        IDbSet<GruWerkzDruKontrE> GruWerkzDruKontrEs { get; set; } // GruWerkzDruKontrE
        IDbSet<GruWerkzMatKennl> GruWerkzMatKennls { get; set; } // GruWerkzMatKennl
        IDbSet<GruWerkzMatKennlArt> GruWerkzMatKennlArts { get; set; } // GruWerkzMatKennlArt
        IDbSet<GruWerkzRegMarke> GruWerkzRegMarkes { get; set; } // GruWerkzRegMarke
        IDbSet<GruWerkzRegMarkePos> GruWerkzRegMarkePos { get; set; } // GruWerkzRegMarkePos
        IDbSet<GruWerkzWTypen> GruWerkzWTypens { get; set; } // GruWerkzWTypen

        int SaveChanges();
    }

}
