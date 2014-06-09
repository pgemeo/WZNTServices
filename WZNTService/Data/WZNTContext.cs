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
    public class WZNTContext : DbContext, IWZNTContext
    {
        public IDbSet<GruArtAufEinSprache> GruArtAufEinSpraches { get; set; } // GruArtAufEinSprache
        public IDbSet<GruArtAufEinzelnutzen> GruArtAufEinzelnutzens { get; set; } // GruArtAufEinzelnutzen
        public IDbSet<GruArtBasisart> GruArtBasisarts { get; set; } // GruArtBasisart
        public IDbSet<GruArtBasisArtSprache> GruArtBasisArtSpraches { get; set; } // GruArtBasisArtSprache
        public IDbSet<GruArtDruckverf> GruArtDruckverfs { get; set; } // GruArtDruckverf
        public IDbSet<GruArtDruckVerSprache> GruArtDruckVerSpraches { get; set; } // GruArtDruckVerSprache
        public IDbSet<GruArtDruckvorl> GruArtDruckvorls { get; set; } // GruArtDruckvorl
        public IDbSet<GruArtDruckVorlSprache> GruArtDruckVorlSpraches { get; set; } // GruArtDruckVorlSprache
        public IDbSet<GruArtFarbtyp> GruArtFarbtyps { get; set; } // GruArtFarbtyp
        public IDbSet<GruArtPunktform> GruArtPunktforms { get; set; } // GruArtPunktform
        public IDbSet<GruBerBenGru> GruBerBenGrus { get; set; } // GruBerBenGru
        public IDbSet<GruBerBenutzer> GruBerBenutzers { get; set; } // GruBerBenutzer
        public IDbSet<GruBerEinstellungen> GruBerEinstellungens { get; set; } // GruBerEinstellungen
        public IDbSet<GruBerEinstellungenGruppe> GruBerEinstellungenGruppes { get; set; } // GruBerEinstellungenGruppe
        public IDbSet<GruBerGruppe> GruBerGruppes { get; set; } // GruBerGruppe
        public IDbSet<GruExportDaCs> GruExportDaCs { get; set; } // GruExportDA_CS
        public IDbSet<GruExportDrkl> GruExportDrkls { get; set; } // GruExportDRKL
        public IDbSet<GruExportEinu> GruExportEinus { get; set; } // GruExportEINU
        public IDbSet<GruExportWz> GruExportWzs { get; set; } // GruExportWZ
        public IDbSet<GruMaCfg> GruMaCfgs { get; set; } // GruMaCFG
        public IDbSet<GruMaschinen> GruMaschinens { get; set; } // GruMaschinen
        public IDbSet<GruMaschMaGruppe> GruMaschMaGruppes { get; set; } // GruMaschMaGruppe
        public IDbSet<GruMaTypenDruKz> GruMaTypenDruKzs { get; set; } // GruMaTypenDruKz
        public IDbSet<GruParSprachAu> GruParSprachAus { get; set; } // GruParSprachAus
        public IDbSet<GruProgAbrgru> GruProgAbrgrus { get; set; } // GruProgAbrgru
        public IDbSet<GruProgAbrgruSprache> GruProgAbrgruSpraches { get; set; } // GruProgAbrgruSprache
        public IDbSet<GruProgParameter> GruProgParameters { get; set; } // GruProgParameter
        public IDbSet<GruSprachen> GruSprachens { get; set; } // GruSprachen
        public IDbSet<GruSysAPiJobl> GruSysAPiJobls { get; set; } // GruSysAPiJobl
        public IDbSet<GruSysAPiJobSt> GruSysAPiJobSts { get; set; } // GruSysAPiJobSt
        public IDbSet<GruSysStandort> GruSysStandorts { get; set; } // GruSysStandort
        public IDbSet<GruWerkzDruKontrE> GruWerkzDruKontrEs { get; set; } // GruWerkzDruKontrE
        public IDbSet<GruWerkzMatKennl> GruWerkzMatKennls { get; set; } // GruWerkzMatKennl
        public IDbSet<GruWerkzMatKennlArt> GruWerkzMatKennlArts { get; set; } // GruWerkzMatKennlArt
        public IDbSet<GruWerkzRegMarke> GruWerkzRegMarkes { get; set; } // GruWerkzRegMarke
        public IDbSet<GruWerkzRegMarkePos> GruWerkzRegMarkePos { get; set; } // GruWerkzRegMarkePos
        public IDbSet<GruWerkzWTypen> GruWerkzWTypens { get; set; } // GruWerkzWTypen
        public IDbSet<WzntArtikel> WzntArtikels { get; set; } // WZNTArtikel
        public IDbSet<WzntArtikelVarianten> WzntArtikelVariantens { get; set; } // WZNTArtikelVarianten
        public IDbSet<WzntArtVarAuspr> WzntArtVarAusprs { get; set; } // WZNTArtVarAuspr

        static WZNTContext()
        {
            Database.SetInitializer<WZNTContext>(null);
        }

        public WZNTContext()
            : base("Name=WZNT")
        {
			//Configuration.ProxyCreationEnabled = true;
			//Configuration.LazyLoadingEnabled = true;
        }

        public WZNTContext(string connectionString) : base(connectionString)
        {
        }

        public WZNTContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new GruArtAufEinSpracheConfiguration());
            modelBuilder.Configurations.Add(new GruArtAufEinzelnutzenConfiguration());
            modelBuilder.Configurations.Add(new GruArtBasisartConfiguration());
            modelBuilder.Configurations.Add(new GruArtBasisArtSpracheConfiguration());
            modelBuilder.Configurations.Add(new GruArtDruckverfConfiguration());
            modelBuilder.Configurations.Add(new GruArtDruckVerSpracheConfiguration());
            modelBuilder.Configurations.Add(new GruArtDruckvorlConfiguration());
            modelBuilder.Configurations.Add(new GruArtDruckVorlSpracheConfiguration());
            modelBuilder.Configurations.Add(new GruArtFarbtypConfiguration());
            modelBuilder.Configurations.Add(new GruArtPunktformConfiguration());
            modelBuilder.Configurations.Add(new GruBerBenGruConfiguration());
            modelBuilder.Configurations.Add(new GruBerBenutzerConfiguration());
            modelBuilder.Configurations.Add(new GruBerEinstellungenConfiguration());
            modelBuilder.Configurations.Add(new GruBerEinstellungenGruppeConfiguration());
            modelBuilder.Configurations.Add(new GruBerGruppeConfiguration());
            modelBuilder.Configurations.Add(new GruExportDaCsConfiguration());
            modelBuilder.Configurations.Add(new GruExportDrklConfiguration());
            modelBuilder.Configurations.Add(new GruExportEinuConfiguration());
            modelBuilder.Configurations.Add(new GruExportWzConfiguration());
            modelBuilder.Configurations.Add(new GruMaCfgConfiguration());
            modelBuilder.Configurations.Add(new GruMaschinenConfiguration());
            modelBuilder.Configurations.Add(new GruMaschMaGruppeConfiguration());
            modelBuilder.Configurations.Add(new GruMaTypenDruKzConfiguration());
            modelBuilder.Configurations.Add(new GruParSprachAuConfiguration());
            modelBuilder.Configurations.Add(new GruProgAbrgruConfiguration());
            modelBuilder.Configurations.Add(new GruProgAbrgruSpracheConfiguration());
            modelBuilder.Configurations.Add(new GruProgParameterConfiguration());
            modelBuilder.Configurations.Add(new GruSprachenConfiguration());
            modelBuilder.Configurations.Add(new GruSysAPiJoblConfiguration());
            modelBuilder.Configurations.Add(new GruSysAPiJobStConfiguration());
            modelBuilder.Configurations.Add(new GruSysStandortConfiguration());
            modelBuilder.Configurations.Add(new GruWerkzDruKontrEConfiguration());
            modelBuilder.Configurations.Add(new GruWerkzMatKennlConfiguration());
            modelBuilder.Configurations.Add(new GruWerkzMatKennlArtConfiguration());
            modelBuilder.Configurations.Add(new GruWerkzRegMarkeConfiguration());
            modelBuilder.Configurations.Add(new GruWerkzRegMarkePosConfiguration());
            modelBuilder.Configurations.Add(new GruWerkzWTypenConfiguration());
            modelBuilder.Configurations.Add(new WzntArtikelConfiguration());
            modelBuilder.Configurations.Add(new WzntArtikelVariantenConfiguration());
            modelBuilder.Configurations.Add(new WzntArtVarAusprConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new GruArtAufEinSpracheConfiguration(schema));
            modelBuilder.Configurations.Add(new GruArtAufEinzelnutzenConfiguration(schema));
            modelBuilder.Configurations.Add(new GruArtBasisartConfiguration(schema));
            modelBuilder.Configurations.Add(new GruArtBasisArtSpracheConfiguration(schema));
            modelBuilder.Configurations.Add(new GruArtDruckverfConfiguration(schema));
            modelBuilder.Configurations.Add(new GruArtDruckVerSpracheConfiguration(schema));
            modelBuilder.Configurations.Add(new GruArtDruckvorlConfiguration(schema));
            modelBuilder.Configurations.Add(new GruArtDruckVorlSpracheConfiguration(schema));
            modelBuilder.Configurations.Add(new GruArtFarbtypConfiguration(schema));
            modelBuilder.Configurations.Add(new GruArtPunktformConfiguration(schema));
            modelBuilder.Configurations.Add(new GruBerBenGruConfiguration(schema));
            modelBuilder.Configurations.Add(new GruBerBenutzerConfiguration(schema));
            modelBuilder.Configurations.Add(new GruBerEinstellungenConfiguration(schema));
            modelBuilder.Configurations.Add(new GruBerEinstellungenGruppeConfiguration(schema));
            modelBuilder.Configurations.Add(new GruBerGruppeConfiguration(schema));
            modelBuilder.Configurations.Add(new GruExportDaCsConfiguration(schema));
            modelBuilder.Configurations.Add(new GruExportDrklConfiguration(schema));
            modelBuilder.Configurations.Add(new GruExportEinuConfiguration(schema));
            modelBuilder.Configurations.Add(new GruExportWzConfiguration(schema));
            modelBuilder.Configurations.Add(new GruMaCfgConfiguration(schema));
            modelBuilder.Configurations.Add(new GruMaschinenConfiguration(schema));
            modelBuilder.Configurations.Add(new GruMaschMaGruppeConfiguration(schema));
            modelBuilder.Configurations.Add(new GruMaTypenDruKzConfiguration(schema));
            modelBuilder.Configurations.Add(new GruParSprachAuConfiguration(schema));
            modelBuilder.Configurations.Add(new GruProgAbrgruConfiguration(schema));
            modelBuilder.Configurations.Add(new GruProgAbrgruSpracheConfiguration(schema));
            modelBuilder.Configurations.Add(new GruProgParameterConfiguration(schema));
            modelBuilder.Configurations.Add(new GruSprachenConfiguration(schema));
            modelBuilder.Configurations.Add(new GruSysAPiJoblConfiguration(schema));
            modelBuilder.Configurations.Add(new GruSysAPiJobStConfiguration(schema));
            modelBuilder.Configurations.Add(new GruSysStandortConfiguration(schema));
            modelBuilder.Configurations.Add(new GruWerkzDruKontrEConfiguration(schema));
            modelBuilder.Configurations.Add(new GruWerkzMatKennlConfiguration(schema));
            modelBuilder.Configurations.Add(new GruWerkzMatKennlArtConfiguration(schema));
            modelBuilder.Configurations.Add(new GruWerkzRegMarkeConfiguration(schema));
            modelBuilder.Configurations.Add(new GruWerkzRegMarkePosConfiguration(schema));
            modelBuilder.Configurations.Add(new GruWerkzWTypenConfiguration(schema));
            modelBuilder.Configurations.Add(new WzntArtikelConfiguration(schema));
            modelBuilder.Configurations.Add(new WzntArtikelVariantenConfiguration(schema));
            modelBuilder.Configurations.Add(new WzntArtVarAusprConfiguration(schema));
            return modelBuilder;
        }
    }
}
