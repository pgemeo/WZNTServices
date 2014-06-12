
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


        IDbSet<GruBerBenGru> GruBerBenGrus { get; set; } // GruBerBenGru


        IDbSet<GruBerBenutzer> GruBerBenutzers { get; set; } // GruBerBenutzer


        IDbSet<GruBerEinstellungen> GruBerEinstellungens { get; set; } // GruBerEinstellungen


        IDbSet<GruBerGruppe> GruBerGruppes { get; set; } // GruBerGruppe


        IDbSet<GruExportDaCs> GruExportDaCs { get; set; } // GruExportDA_CS


        IDbSet<GruExportDrkl> GruExportDrkls { get; set; } // GruExportDRKL


        IDbSet<GruExportEinu> GruExportEinus { get; set; } // GruExportEINU


        IDbSet<GruExportWz> GruExportWzs { get; set; } // GruExportWZ


        IDbSet<GruMaCfg> GruMaCfgs { get; set; } // GruMaCFG


        IDbSet<GruMaschinen> GruMaschinens { get; set; } // GruMaschinen


        IDbSet<GruMaschMaGruppe> GruMaschMaGruppes { get; set; } // GruMaschMaGruppe


        IDbSet<GruMaTypenDruKz> GruMaTypenDruKzs { get; set; } // GruMaTypenDruKz


        IDbSet<GruParSprachAu> GruParSprachAus { get; set; } // GruParSprachAus


        IDbSet<GruProgAbrgru> GruProgAbrgrus { get; set; } // GruProgAbrgru


        IDbSet<GruProgAbrgruSprache> GruProgAbrgruSpraches { get; set; } // GruProgAbrgruSprache


        IDbSet<GruProgParameter> GruProgParameters { get; set; } // GruProgParameter


        IDbSet<GruSprachen> GruSprachens { get; set; } // GruSprachen


        IDbSet<GruSysStandort> GruSysStandorts { get; set; } // GruSysStandort


        IDbSet<GruWerkzDruKontrE> GruWerkzDruKontrEs { get; set; } // GruWerkzDruKontrE


        IDbSet<GruWerkzMatKennl> GruWerkzMatKennls { get; set; } // GruWerkzMatKennl


        IDbSet<GruWerkzMatKennlArt> GruWerkzMatKennlArts { get; set; } // GruWerkzMatKennlArt


        IDbSet<GruWerkzRegMarke> GruWerkzRegMarkes { get; set; } // GruWerkzRegMarke


        IDbSet<GruWerkzRegMarkePos> GruWerkzRegMarkePos { get; set; } // GruWerkzRegMarkePos


        IDbSet<GruWerkzWTypen> GruWerkzWTypens { get; set; } // GruWerkzWTypen



        int SaveChanges();
    }


}
