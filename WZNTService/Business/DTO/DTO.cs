

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "Data\App.Config"
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

        public GruArtAufEinzelnutzen GruArtAufEinzelnutzen { get; set; }
        public GruSprachen GruSprachen { get; set; }
    }

    public class GruArtAufEinzelnutzen
    {
        public int Id { get; set; }
        public string Aufgabe { get; set; }
        public DateTime? OTimeStamp { get; set; }

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

        public ICollection<GruArtDruckVerSprache> GruArtDruckVerSpraches { get; set; }

        public GruArtDruckverf()
        {
            GruArtDruckVerSpraches = new List<GruArtDruckVerSprache>();
        }
    }

    public class GruArtDruckVerSprache
    {
        public int Id { get; set; }
        public int IdSprache { get; set; }
        public int IdDruckvorl { get; set; }
        public string UebSetDruckv { get; set; }
        public string UebSetKurzz { get; set; }
        public DateTime? OTimeStamp { get; set; }

        public GruArtDruckverf GruArtDruckverf { get; set; }
        public GruSprachen GruSprachen { get; set; }
    }

    public class GruArtDruckvorl
    {
        public int Id { get; set; }
        public string Druckvorlagen { get; set; }
        public DateTime? OTimeStamp { get; set; }

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

        public GruArtDruckvorl GruArtDruckvorl { get; set; }
        public GruSprachen GruSprachen { get; set; }
    }

    public class GruArtFarbtyp
    {
        public int Id { get; set; }
        public string FarbtypSep { get; set; }
        public bool? WzNerz { get; set; }
        public DateTime? OTimeStamp { get; set; }
    }

    public class GruArtPunktform
    {
        public int Id { get; set; }
        public string Punktform { get; set; }
        public DateTime? OTimeStamp { get; set; }
    }

    public class GruMaCfg
    {
        public int Id { get; set; }
        public int IdMaschine { get; set; }
        public int IdMaschinenGrp { get; set; }
        public decimal? Baugruppe { get; set; }
        public int IdDruckverfahren { get; set; }
        public int IdRegistermarken { get; set; }
        public byte[] Bild { get; set; }
        public DateTime? OTimeStamp { get; set; }
    }

    public class GruMaschinen
    {
        public int Id { get; set; }
        public string Maschine { get; set; }
        public int IdMaGruppe { get; set; }
        public int IdRegisterMa { get; set; }
        public string Ort { get; set; }
        public DateTime? OTimeStamp { get; set; }

        public GruMaschMaGruppe GruMaschMaGruppe { get; set; }
    }

    public class GruMaschMaGruppe
    {
        public int Id { get; set; }
        public string MaGruppe { get; set; }
        public string Beschreibung { get; set; }
        public DateTime? OTimeStamp { get; set; }

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

        public GruWerkzWTypen GruWerkzWTypen { get; set; }
    }

    public class GruProgAbrgru
    {
        public int Id { get; set; }
        public string AbrGrund { get; set; }
        public DateTime? OTimeStamp { get; set; }

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

        public GruProgAbrgru GruProgAbrgru { get; set; }
        public GruSprachen GruSprachen { get; set; }
    }

    public class GruSprachen
    {
        public int Id { get; set; }
        public string Sprache { get; set; }
        public string Iso { get; set; }
        public DateTime? OTimeStamp { get; set; }

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
    }

    public class GruWerkzMatKennl
    {
        public int Id { get; set; }
        public string MaKennl { get; set; }
        public string Beschreibung { get; set; }
        public DateTime? OTimeStamp { get; set; }

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

        public GruWerkzMatKennl GruWerkzMatKennl { get; set; }
    }

    public class GruWerkzRegMarke
    {
        public int Id { get; set; }
        public string Anzeichnung { get; set; }
        public DateTime? OTimeStamp { get; set; }

        public ICollection<GruWerkzRegMarkePos> GruWerkzRegMarkePos { get; set; }

        public GruWerkzRegMarke()
        {
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

        public ICollection<GruMaTypenDruKz> GruMaTypenDruKzs { get; set; }

        public GruWerkzWTypen()
        {
            GruMaTypenDruKzs = new List<GruMaTypenDruKz>();
        }
    }

}

