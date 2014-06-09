

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "Business\App.config"
//     Connection String Name: "WZNT"
//     Connection String:      "Data Source=.\SQLEXPRESS;Initial Catalog=WZNT;Integrated Security=True;"

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.DTO
{

    // ************************************************************************
    // POCO classes

    public class GruArtAufEinSprache
    {
        public int Id { get; set; }
        public int IdSprache { get; set; }
        public int IdAufgabe { get; set; }
        public string Uebersetzung { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public GruArtAufEinzelnutzen GruArtAufEinzelnutzen { get; set; }
        public GruSprachen GruSprachen { get; set; }
    }

    public class GruArtAufEinzelnutzen
    {
        public int Id { get; set; }
        public string Aufgabe { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public ICollection<GruArtAufEinSprache> GruArtAufEinSpraches { get; set; }

        public GruArtAufEinzelnutzen()
        {
            GruArtAufEinSpraches = new List<GruArtAufEinSprache>();
        }
    }

    public class GruArtBasisart
    {
        public int Id { get; set; }
        public string Basisart { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public ICollection<GruArtBasisArtSprache> GruArtBasisArtSpraches { get; set; }

        public GruArtBasisart()
        {
            GruArtBasisArtSpraches = new List<GruArtBasisArtSprache>();
        }
    }

    public class GruArtBasisArtSprache
    {
        public int Id { get; set; }
        public int IdSprache { get; set; }
        public int IdBasisart { get; set; }
        public string Uebersetzung { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public GruArtBasisart GruArtBasisart { get; set; }
        public GruSprachen GruSprachen { get; set; }
    }

    public class GruArtDruckverf
    {
        public int Id { get; set; }
        public string Druckverfahren { get; set; }
        public string Kurzzeichen { get; set; }
        public string Auflosung { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public ICollection<GruArtDruckVerSprache> GruArtDruckVerSpraches { get; set; }
        public ICollection<GruMaCfg> GruMaCfgs { get; set; }

        public GruArtDruckverf()
        {
            GruArtDruckVerSpraches = new List<GruArtDruckVerSprache>();
            GruMaCfgs = new List<GruMaCfg>();
        }
    }

    public class GruArtDruckVerSprache
    {
        public int Id { get; set; }
        public int IdSprache { get; set; }
        public int IdDruckverf { get; set; }
        public string UebSetDruckv { get; set; }
        public string UebSetKurzz { get; set; }
        public string StandortKz { get; set; }
        public DateTime? OTimeStamp { get; set; }

        public GruArtDruckverf GruArtDruckverf { get; set; }
        public GruSprachen GruSprachen { get; set; }
    }

    public class GruArtDruckvorl
    {
        public int Id { get; set; }
        public string Druckvorlagen { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public ICollection<GruArtDruckVorlSprache> GruArtDruckVorlSpraches { get; set; }

        public GruArtDruckvorl()
        {
            GruArtDruckVorlSpraches = new List<GruArtDruckVorlSprache>();
        }
    }

    public class GruArtDruckVorlSprache
    {
        public int Id { get; set; }
        public int IdSprache { get; set; }
        public int IdDruckvorl { get; set; }
        public string Uebersetzung { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public GruArtDruckvorl GruArtDruckvorl { get; set; }
        public GruSprachen GruSprachen { get; set; }
    }

    public class GruArtFarbtyp
    {
        public int Id { get; set; }
        public string FarbtypSep { get; set; }
        public bool? WzNerz { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }
    }

    public class GruArtPunktform
    {
        public int Id { get; set; }
        public string Punktform { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }
    }

    public class GruBerBenGru
    {
        public int Id { get; set; }
        public int IdBenutzer { get; set; }
        public int IdGruppe { get; set; }
        public DateTime? OTimeStamp { get; set; }

        public GruBerBenutzer GruBerBenutzer { get; set; }
        public GruBerGruppe GruBerGruppe { get; set; }
    }

    public class GruBerBenutzer
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Passwort { get; set; }
        public string Gruppe { get; set; }
        public DateTime? OTimeStamp { get; set; }

        public ICollection<GruBerBenGru> GruBerBenGrus { get; set; }

        public GruBerBenutzer()
        {
            GruBerBenGrus = new List<GruBerBenGru>();
        }
    }

    public class GruBerEinstellungen
    {
        public int Id { get; set; }
        public bool? BeDecs { get; set; }
        public bool? BeDk { get; set; }
        public bool? BeEn { get; set; }
        public bool? BeWe { get; set; }
        public bool? BeGrul { get; set; }
        public bool? BeAPi { get; set; }
        public string StandortBer { get; set; }
        public DateTime? OTimeStamp { get; set; }

        public ICollection<GruBerEinstellungenGruppe> GruBerEinstellungenGruppes { get; set; }

        public GruBerEinstellungen()
        {
            GruBerEinstellungenGruppes = new List<GruBerEinstellungenGruppe>();
        }
    }

    public class GruBerEinstellungenGruppe
    {
        public int Id { get; set; }
        public int IdEinstellungen { get; set; }
        public int IdGruppe { get; set; }
        public DateTime? OTimeStamp { get; set; }

        public GruBerEinstellungen GruBerEinstellungen { get; set; }
        public GruBerGruppe GruBerGruppe { get; set; }
    }

    public class GruBerGruppe
    {
        public int Id { get; set; }
        public string GruppenBez { get; set; }
        public DateTime? OTimeStamp { get; set; }

        public ICollection<GruBerBenGru> GruBerBenGrus { get; set; }
        public ICollection<GruBerEinstellungenGruppe> GruBerEinstellungenGruppes { get; set; }

        public GruBerGruppe()
        {
            GruBerBenGrus = new List<GruBerBenGru>();
            GruBerEinstellungenGruppes = new List<GruBerEinstellungenGruppe>();
        }
    }

    public class GruExportDaCs
    {
        public int Id { get; set; }
        public string FeldWzntdaCs { get; set; }
        public string FeldEsko { get; set; }
        public string Feldtyp { get; set; }
        public string StandortKz { get; set; }
        public DateTime? OTimeStamp { get; set; }
    }

    public class GruExportDrkl
    {
        public int Id { get; set; }
        public string FeldWzntdrkl { get; set; }
        public string FeldEsko { get; set; }
        public string Feldtyp { get; set; }
        public string StandortKz { get; set; }
        public DateTime? OTimeStamp { get; set; }
    }

    public class GruExportEinu
    {
        public int Id { get; set; }
        public string FeldWznteinu { get; set; }
        public string FeldEsko { get; set; }
        public string Feldtyp { get; set; }
        public string StandortKz { get; set; }
        public DateTime? OTimeStamp { get; set; }
    }

    public class GruExportWz
    {
        public int Id { get; set; }
        public string FeldWzntwz { get; set; }
        public string FeldEsko { get; set; }
        public string Feldtyp { get; set; }
        public string StandortKz { get; set; }
        public DateTime? OTimeStamp { get; set; }
    }

    public class GruMaCfg
    {
        public int Id { get; set; }
        public int IdMaschine { get; set; }
        public decimal? Baugruppe { get; set; }
        public int IdDruckverfahren { get; set; }
        public int IdRegistermarken { get; set; }
        public byte[] Bild { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public GruArtDruckverf GruArtDruckverf { get; set; }
        public GruMaschinen GruMaschinen { get; set; }
        public GruWerkzRegMarke GruWerkzRegMarke { get; set; }
    }

    public class GruMaschinen
    {
        public int Id { get; set; }
        public string Maschine { get; set; }
        public int IdMaGruppe { get; set; }
        public int IdRegisterMa { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }
        public string AnzBaugruppe { get; set; }

        public ICollection<GruMaCfg> GruMaCfgs { get; set; }
        public ICollection<GruMaTypenDruKz> GruMaTypenDruKzs { get; set; }

        public GruMaschMaGruppe GruMaschMaGruppe { get; set; }

        public GruMaschinen()
        {
            GruMaCfgs = new List<GruMaCfg>();
            GruMaTypenDruKzs = new List<GruMaTypenDruKz>();
        }
    }

    public class GruMaschMaGruppe
    {
        public int Id { get; set; }
        public string MaGruppe { get; set; }
        public string Beschreibung { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public ICollection<GruMaschinen> GruMaschinens { get; set; }

        public GruMaschMaGruppe()
        {
            GruMaschinens = new List<GruMaschinen>();
        }
    }

    public class GruMaTypenDruKz
    {
        public int Id { get; set; }
        public int IdMaschine { get; set; }
        public int IdWzTyp { get; set; }
        public bool? OdKz { get; set; }
        public bool? FdKz { get; set; }
        public bool? SdKz { get; set; }
        public bool? TdKz { get; set; }
        public bool? IjKz { get; set; }
        public bool? HpKz { get; set; }
        public bool? KpKz { get; set; }
        public bool? StKz { get; set; }
        public bool? ZsKz { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public GruMaschinen GruMaschinen { get; set; }
        public GruWerkzWTypen GruWerkzWTypen { get; set; }
    }

    public class GruParSprachAu
    {
        public int Id { get; set; }
        public string Sprache { get; set; }
        public string Iso { get; set; }
        public bool? AktivKz { get; set; }
        public string Datei { get; set; }
        public string StandortKz { get; set; }
        public DateTime? OTimeStamp { get; set; }
    }

    public class GruProgAbrgru
    {
        public int Id { get; set; }
        public string AbrGrund { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public ICollection<GruProgAbrgruSprache> GruProgAbrgruSpraches { get; set; }

        public GruProgAbrgru()
        {
            GruProgAbrgruSpraches = new List<GruProgAbrgruSprache>();
        }
    }

    public class GruProgAbrgruSprache
    {
        public int Id { get; set; }
        public int IdSprache { get; set; }
        public int IdAbrGrund { get; set; }
        public string UebAbrGrund { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public GruProgAbrgru GruProgAbrgru { get; set; }
        public GruSprachen GruSprachen { get; set; }
    }

    public class GruProgParameter
    {
        public int Id { get; set; }
        public string StandortKz { get; set; }
        public DateTime? OTimeStamp { get; set; }
    }

    public class GruSprachen
    {
        public int Id { get; set; }
        public string Sprache { get; set; }
        public string Iso { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public ICollection<GruArtAufEinSprache> GruArtAufEinSpraches { get; set; }
        public ICollection<GruArtBasisArtSprache> GruArtBasisArtSpraches { get; set; }
        public ICollection<GruArtDruckVerSprache> GruArtDruckVerSpraches { get; set; }
        public ICollection<GruArtDruckVorlSprache> GruArtDruckVorlSpraches { get; set; }
        public ICollection<GruProgAbrgruSprache> GruProgAbrgruSpraches { get; set; }

        public GruSprachen()
        {
            GruArtAufEinSpraches = new List<GruArtAufEinSprache>();
            GruArtBasisArtSpraches = new List<GruArtBasisArtSprache>();
            GruArtDruckVerSpraches = new List<GruArtDruckVerSprache>();
            GruArtDruckVorlSpraches = new List<GruArtDruckVorlSprache>();
            GruProgAbrgruSpraches = new List<GruProgAbrgruSprache>();
        }
    }

    public class GruSysAPiJobl
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public string JobBez { get; set; }
        public string Parameterdatei { get; set; }
        public bool? AktivKz { get; set; }
        public string StandortKz { get; set; }
        public DateTime? OTimeStamp { get; set; }
    }

    public class GruSysAPiJobSt
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public string Frequenz { get; set; }
        public DateTime? Startdatum { get; set; }
        public DateTime? Startzeit { get; set; }
        public bool? AktivKz { get; set; }
        public DateTime? OTimeStamp { get; set; }
    }

    public class GruSysStandort
    {
        public int Id { get; set; }
        public string StandortId { get; set; }
        public string Standort { get; set; }
        public DateTime? OTimeStamp { get; set; }
    }

    public class GruWerkzDruKontrE
    {
        public int Id { get; set; }
        public int Typ { get; set; }
        public string Matchcode { get; set; }
        public string Farbzonen { get; set; }
        public string Felder { get; set; }
        public string C1Streifen { get; set; }
        public string C2Streifen { get; set; }
        public string C3Streifen { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }
    }

    public class GruWerkzMatKennl
    {
        public int Id { get; set; }
        public string MaKennl { get; set; }
        public string Beschreibung { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public ICollection<GruWerkzMatKennlArt> GruWerkzMatKennlArts { get; set; }

        public GruWerkzMatKennl()
        {
            GruWerkzMatKennlArts = new List<GruWerkzMatKennlArt>();
        }
    }

    public class GruWerkzMatKennlArt
    {
        public int Id { get; set; }
        public int IdMatKennl { get; set; }
        public string Artikelnummer { get; set; }
        public string Matchcode { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public GruWerkzMatKennl GruWerkzMatKennl { get; set; }
    }

    public class GruWerkzRegMarke
    {
        public int Id { get; set; }
        public string Anzeichnung { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public ICollection<GruMaCfg> GruMaCfgs { get; set; }
        public ICollection<GruWerkzRegMarkePos> GruWerkzRegMarkePos { get; set; }

        public GruWerkzRegMarke()
        {
            GruMaCfgs = new List<GruMaCfg>();
            GruWerkzRegMarkePos = new List<GruWerkzRegMarkePos>();
        }
    }

    public class GruWerkzRegMarkePos
    {
        public int Id { get; set; }
        public int IdRegM { get; set; }
        public int Pos { get; set; }
        public string Abstand { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public GruWerkzRegMarke GruWerkzRegMarke { get; set; }
    }

    public class GruWerkzWTypen
    {
        public int Id { get; set; }
        public decimal? Typ { get; set; }
        public string Matchcode { get; set; }
        public decimal? MaxBreite { get; set; }
        public string Material { get; set; }
        public decimal? MaxLfm { get; set; }
        public DateTime? OTimeStamp { get; set; }
        public string StandortKz { get; set; }

        public ICollection<GruMaTypenDruKz> GruMaTypenDruKzs { get; set; }

        public GruWerkzWTypen()
        {
            GruMaTypenDruKzs = new List<GruMaTypenDruKz>();
        }
    }

    public class WzntArtikel
    {
        public int Id { get; set; }
        public string Artikelnummer { get; set; }
        public string StandortKz { get; set; }
        public string Matchcode { get; set; }
        public string Artikelgruppe { get; set; }
        public string HArtikelgruppe { get; set; }
        public string VArtikelgruppe { get; set; }
        public bool? ArtikelKz { get; set; }
        public string UserRek1 { get; set; }
        public string UserRek2 { get; set; }
        public string UserRek3 { get; set; }
        public string Barcode { get; set; }
        public string Barcodetyp { get; set; }
        public decimal? FormatBreite { get; set; }
        public decimal? FormatVorschub { get; set; }
        public bool? DurchmKz { get; set; }
        public string FormatMe { get; set; }
        public byte[] Basis { get; set; }
        public bool? DocHoeheBkz { get; set; }
        public bool? DocHoeheVkz { get; set; }
        public int? EskoJobId { get; set; }
        public int? IdMaschGru { get; set; }
        public DateTime? OTimeStamp { get; set; }

        public ICollection<WzntArtikelVarianten> WzntArtikelVariantens { get; set; }

        public WzntArtikel()
        {
            WzntArtikelVariantens = new List<WzntArtikelVarianten>();
        }
    }

    public class WzntArtikelVarianten
    {
        public int Id { get; set; }
        public int IdArtikel { get; set; }
        public int AusprId { get; set; }
        public string Material { get; set; }
        public string MemoDr { get; set; }
        public bool? DatenEKz { get; set; }
        public bool? FreigabeKz { get; set; }
        public int? Wickelschema { get; set; }
        public DateTime? OTimeStamp { get; set; }

        public WzntArtikel WzntArtikel { get; set; }
        public WzntArtVarAuspr WzntArtVarAuspr { get; set; }
    }

    public class WzntArtVarAuspr
    {
        public int Id { get; set; }
        public string Auspr1 { get; set; }
        public string Auspr2 { get; set; }
        public string BezAuspr1 { get; set; }
        public string BezAuspr2 { get; set; }
        public DateTime? OTimeStamp { get; set; }

        public ICollection<WzntArtikelVarianten> WzntArtikelVariantens { get; set; }

        public WzntArtVarAuspr()
        {
            WzntArtikelVariantens = new List<WzntArtikelVarianten>();
        }
    }

}

