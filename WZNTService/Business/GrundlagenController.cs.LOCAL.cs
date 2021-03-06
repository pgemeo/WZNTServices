﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data;
using Business.DTO;
using Generic;


namespace Business
{
    public class GrundlagenController
    {
        internal WZNTContext _context = new WZNTContext();

        #region GruArtAufEinzelnutzen
        public GruArtAufEinzelnutzen GetGruArtAufEinzelnutzen(int id)
        {
            var model = _context.GruArtAufEinzelnutzens.Where(m => m.Id == id).FirstOrDefault();

            try
            {
                var element = new GruArtAufEinzelnutzen
                {
                    Id = model.Id,
                    Aufgabe = model.Aufgabe,
                    OTimeStamp = model.OTimeStamp,
                    StandortKz = model.StandortKz,
                    GruArtAufEinSpraches =
                        (from se in model.GruArtAufEinSpraches
                         select new GruArtAufEinSprache
                         {
                             Id = se.Id,
                             IdAufgabe = se.IdAufgabe,
                             IdSprache = se.IdSprache,
                             OTimeStamp = se.OTimeStamp,
                             StandortKz = se.StandortKz,
                             Uebersetzung = se.Uebersetzung
                         }).ToList()
                    /*(from se in _context.GruArtAufEinSpraches
                    where se.IdAufgabe == model.Id
                    select new GruArtAufEinSprache
                    {
                        Id = se.Id,
                        IdAufgabe = se.IdAufgabe,
                        IdSprache = se.IdSprache,
                        OTimeStamp = se.OTimeStamp,
                        Uebersetzung = se.Uebersetzung
                    }).ToList()*/
                };

                return element;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            return null;
        }
        public List<GruArtAufEinzelnutzen> GetGruArtAufEinzelnutzenList(string locationId)
        {
            try
            {
                ICollection<Model.GruArtAufEinzelnutzen> elements = new List<Model.GruArtAufEinzelnutzen>();

                if (!String.IsNullOrEmpty(locationId))
                {
                    elements = _context.GruArtAufEinzelnutzens.Where(m => m.StandortKz.Equals(locationId)).ToList();
                }
                else
                {
                    elements = _context.GruArtAufEinzelnutzens.ToList();
                }

                var collection =
                    (from e in elements
                     select new GruArtAufEinzelnutzen
                     {
                         Id = e.Id,
                         Aufgabe = e.Aufgabe,
                         OTimeStamp = e.OTimeStamp,
                         StandortKz = e.StandortKz,
                         GruArtAufEinSpraches =
                            (from se in e.GruArtAufEinSpraches
                             select new GruArtAufEinSprache
                             {
                                 Id = se.Id,
                                 IdAufgabe = se.IdAufgabe,
                                 IdSprache = se.IdSprache,
                                 OTimeStamp = se.OTimeStamp,
                                 StandortKz = se.StandortKz,
                                 Uebersetzung = se.Uebersetzung
                             }).ToList()
                     }
                    ).ToList();

                return collection;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            return new List<GruArtAufEinzelnutzen>();
        }
        public void DeleteGruArtAufEinzelnutzen(GruArtAufEinzelnutzen model)
        {
            try
            {
                // get database entity for 'GruArtAufEinzelnutzen'
                Model.GruArtAufEinzelnutzen modelDB = _context.GruArtAufEinzelnutzens.Find(model.Id);
                
                _context.GruArtAufEinzelnutzens.Remove(modelDB);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
        public void InsertGruArtAufEinzelnutzen(GruArtAufEinzelnutzen model)
        {
            try
            {
                // create database entity for 'GruArtAufEinzelnutzen'
                Model.GruArtAufEinzelnutzen modelDB = new Model.GruArtAufEinzelnutzen();

                if (model != null)
                {
                    modelDB.Aufgabe = model.Aufgabe;
                    modelDB.OTimeStamp = model.OTimeStamp;
                    modelDB.StandortKz = model.StandortKz;

                    // create database entity for 'GruArtAufEinSprache'
                    if (model.GruArtAufEinSpraches != null)
                    {
                        foreach (var sprache in model.GruArtAufEinSpraches)
                        {
                            var spracheDB = new Model.GruArtAufEinSprache();
                            spracheDB.IdAufgabe = sprache.IdAufgabe;
                            spracheDB.IdSprache = sprache.IdSprache;
                            spracheDB.OTimeStamp = sprache.OTimeStamp;
                            spracheDB.Uebersetzung = sprache.Uebersetzung;
                            spracheDB.StandortKz = sprache.StandortKz;

                            modelDB.GruArtAufEinSpraches.Add(spracheDB);
                        }
                    }

                    _context.GruArtAufEinzelnutzens.Add(modelDB);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
        public void UpdateGruArtAufEinzelnutzen(GruArtAufEinzelnutzen model)
        {
            try
            {
                if (model == null)
                {
                    return;
                }

                // get database entity for 'GruArtAufEinzelnutzen'
                Model.GruArtAufEinzelnutzen modelDB = _context.GruArtAufEinzelnutzens.Find(model.Id);

                // update current fields
                modelDB.Aufgabe = model.Aufgabe;
                modelDB.OTimeStamp = model.OTimeStamp;
                modelDB.StandortKz = model.StandortKz;

                // remove all 'GruArtAufEinSprache'
                if (model.GruArtAufEinSpraches == null || model.GruArtAufEinSpraches.Count() == 0)
                {
                    modelDB.GruArtAufEinSpraches = null;
                }

                // update existing 'GruArtAufEinSprache'
                if (model.GruArtAufEinSpraches != null)
                {
                    foreach (var sprache in model.GruArtAufEinSpraches)
                    {
                        var spracheDB = modelDB.GruArtAufEinSpraches.Where(s => s.Id == sprache.Id).SingleOrDefault();

                        if (spracheDB != null)
                        {
                            //spracheDB.IdAufgabe = sprache.IdAufgabe;
                            spracheDB.IdSprache = sprache.IdSprache;
                            spracheDB.OTimeStamp = sprache.OTimeStamp;
                            spracheDB.Uebersetzung = sprache.Uebersetzung;
                            sprache.StandortKz = sprache.StandortKz;
                        }
                    }
                }

                // add new 'GruArtAufEinSprache'
                if (model.GruArtAufEinSpraches != null)
                {
                    var sprachesDBToAdd =
                        (from s1 in model.GruArtAufEinSpraches
                         join s2 in modelDB.GruArtAufEinSpraches on s1.Id equals s2.Id into ls
                         from s3 in ls.DefaultIfEmpty()
                         where s3 == null
                         select new Model.GruArtAufEinSprache()
                         {
                             Id = s1.Id,
                             IdAufgabe = s1.IdAufgabe,
                             IdSprache = s1.IdSprache,
                             StandortKz = s1.StandortKz,
                             OTimeStamp = s1.OTimeStamp,
                             Uebersetzung = s1.Uebersetzung
                         }
                        );

                    if (sprachesDBToAdd != null)
                    {
                        var spraches = sprachesDBToAdd.ToList();

                        foreach (var s in spraches)
                        {
                            var sDB = new Model.GruArtAufEinSprache();
                            sDB.Id = s.Id;
                            sDB.IdAufgabe = s.IdAufgabe;
                            sDB.IdSprache = s.IdSprache;
                            sDB.OTimeStamp = s.OTimeStamp;
                            sDB.Uebersetzung = s.Uebersetzung;
                            sDB.StandortKz = s.StandortKz;

                            modelDB.GruArtAufEinSpraches.Add(sDB);
                        }
                    }
                }


                // delete older 'GruArtAufEinSprache'
                var sprachesDBToDel =
                    (from s1 in modelDB.GruArtAufEinSpraches
                     join s2 in model.GruArtAufEinSpraches on s1.Id equals s2.Id into ls
                     from s3 in ls.DefaultIfEmpty()
                     where s3 == null
                     select s1
                    );

                if (sprachesDBToDel != null)
                {
                    var spraches = sprachesDBToDel.ToList();

                    for (int i = spraches.Count() - 1; i >= 0; i--)
                    {
                        _context.GruArtAufEinSpraches.Remove(spraches[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
        #endregion

        #region GruArtAufEinSprache
        public List<GruArtAufEinSprache> GetGruArtAufEinSpracheList(GruArtAufEinzelnutzen model)
        {
            var elements = _context.GruArtAufEinSpraches.Where(m => m.IdAufgabe == model.Id).ToList();

            var collection = (from c in elements
                        select new GruArtAufEinSprache
                        {
                            Id = c.Id,
                            IdAufgabe = c.IdAufgabe,
                            IdSprache = c.IdSprache,
                            OTimeStamp = c.OTimeStamp,
                            Uebersetzung = c.Uebersetzung,
                            GruArtAufEinzelnutzen = model
                        }).ToList();

            return collection;
        }
        #endregion

        #region GruSprachen
        public List<GruSprachen> GetGruSprachenList(string locationId)
        {
            ICollection<Model.GruSprachen> elements = new List<Model.GruSprachen>();

            if (!String.IsNullOrEmpty(locationId))
            {
                elements = _context.GruSprachens.Where(m=>m.StandortKz.Equals(locationId)).ToList();
            }
            else
            {
                elements = _context.GruSprachens.ToList();
            }

            var collection =
                (from e in elements
                 select new GruSprachen
                 {
                     Id = e.Id,
                     Iso = e.Iso,
                     OTimeStamp = e.OTimeStamp,
                     Sprache = e.Sprache
                 }
                ).ToList();

            return collection;
        }
        #endregion

        #region GruSysStandort
        public List<GruSysStandort> GetGruSysStandortList()
        {
            var elements = _context.GruSysStandorts.ToList();

            var collection =
                (from e in elements
                 select new GruSysStandort
                 {
                     Id = e.Id,
                     OTimeStamp = e.OTimeStamp,
                     Standort = e.Standort,
                     StandortId = e.StandortId
                 }
                ).ToList();

            return collection;
        }
        public void DeleteGruSysStandort(GruSysStandort model)
        {
            try
            {
                // get database entity for 'GruSysStandort'
                Model.GruSysStandort modelDB = _context.GruSysStandorts.Find(model.Id);

                _context.GruSysStandorts.Remove(modelDB);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
        public void InsertGruSysStandort(GruSysStandort model)
        {
            try
            {
                // create database entity for 'GruSysStandort'
                Model.GruSysStandort modelDB = new Model.GruSysStandort();

                if (model != null)
                {
                    modelDB.StandortId = model.StandortId;
                    modelDB.Standort = model.Standort;
                    modelDB.OTimeStamp = model.OTimeStamp;

                    _context.GruSysStandorts.Add(modelDB);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
        public void UpdateGruSysStandort(GruSysStandort model)
        {
            try
            {
                if (model == null)
                {
                    return;
                }

                // get database entity for 'GruSysStandort'
                Model.GruSysStandort modelDB = _context.GruSysStandorts.Find(model.Id);

                // update current fields
                modelDB.StandortId = model.StandortId;
                modelDB.Standort = model.Standort;
                modelDB.OTimeStamp = model.OTimeStamp;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
        #endregion

        #region GruSysAPiJobl
        public List<GruSysAPiJobl> GetGruSysAPiJoblList()
        {
            var elements = _context.GruSysAPiJobls.ToList();

            var collection =
                (from e in elements
                 select new GruSysAPiJobl
                 {
                     Id = e.Id,
                     OTimeStamp = e.OTimeStamp,
                     AktivKz = e.AktivKz,
                     JobBez = e.JobBez,
                     JobId = e.JobId,
                     Parameterdatei = e.Parameterdatei,
                     StandortKz = e.StandortKz
                 }
                ).ToList();

            return collection;
        }
        public void DeleteGruSysAPiJobl(GruSysAPiJobl model)
        {
            try
            {
                // get database entity for 'GruSysAPiJobl'
                Model.GruSysAPiJobl modelDB = _context.GruSysAPiJobls.Find(model.Id);

                _context.GruSysAPiJobls.Remove(modelDB);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
        public void InsertGruSysAPiJobl(GruSysAPiJobl model)
        {
            try
            {
                // create database entity for 'GruSysAPiJobl'
                Model.GruSysAPiJobl modelDB = new Model.GruSysAPiJobl();

                if (model != null)
                {
                    modelDB.JobBez = model.JobBez;
                    modelDB.JobId = model.JobId;
                    modelDB.Parameterdatei = model.Parameterdatei;
                    modelDB.StandortKz = model.StandortKz;
                    modelDB.OTimeStamp = model.OTimeStamp;

                    _context.GruSysAPiJobls.Add(modelDB);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
        public void UpdateGruSysAPiJobl(GruSysAPiJobl model)
        {
            try
            {
                if (model == null)
                {
                    return;
                }

                // get database entity for 'GruSysAPiJobl'
                Model.GruSysAPiJobl modelDB = _context.GruSysAPiJobls.Find(model.Id);

                // update current fields
                modelDB.JobBez = model.JobBez;
                modelDB.JobId = model.JobId;
                modelDB.Parameterdatei = model.Parameterdatei;
                modelDB.StandortKz = model.StandortKz;
                modelDB.OTimeStamp = model.OTimeStamp;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
        #endregion

        #region GruSysAPiJobSt
        public List<GruSysAPiJobSt> GetGruSysAPiJobStList()
        {
            var elements = _context.GruSysAPiJobSts.ToList();

            var collection =
                (from e in elements
                 select new GruSysAPiJobSt
                 {
                     OTimeStamp = e.OTimeStamp,
                     AktivKz = e.AktivKz,
                     Frequenz = e.Frequenz,
                     Startdatum = e.Startdatum,
                     Startzeit = e.Startzeit,
                     JobId = e.JobId
                 }
                ).ToList();

            return collection;
        }
        public void DeleteGruSysAPiJobSt(GruSysAPiJobSt model)
        {
            try
            {
                // get database entity for 'GruSysAPiJobSt'
                Model.GruSysAPiJobSt modelDB = _context.GruSysAPiJobSts.Find(model.Id);

                _context.GruSysAPiJobSts.Remove(modelDB);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
        public void InsertGruSysAPiJobSt(GruSysAPiJobSt model)
        {
            try
            {
                // create database entity for 'GruSysAPiJobSt'
                Model.GruSysAPiJobSt modelDB = new Model.GruSysAPiJobSt();

                if (model != null)
                {
                    modelDB.OTimeStamp = model.OTimeStamp;
                    modelDB.AktivKz = model.AktivKz;
                    modelDB.Frequenz = model.Frequenz;
                    modelDB.Startdatum = model.Startdatum;
                    modelDB.Startzeit = model.Startzeit;
                    modelDB.JobId = model.JobId;

                    _context.GruSysAPiJobSts.Add(modelDB);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
        public void UpdateGruSysAPiJobSt(GruSysAPiJobSt model)
        {
            try
            {
                if (model == null)
                {
                    return;
                }

                // get database entity for 'GruSysAPiJobSt'
                Model.GruSysAPiJobSt modelDB = _context.GruSysAPiJobSts.Find(model.Id);

                // update current fields
                modelDB.OTimeStamp = model.OTimeStamp;
                modelDB.AktivKz = model.AktivKz;
                modelDB.Frequenz = model.Frequenz;
                modelDB.Startdatum = model.Startdatum;
                modelDB.Startzeit = model.Startzeit;
                modelDB.JobId = model.JobId;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
        #endregion

        #region GruSysAPiJobStFrequenz
        public List<GruSysAPiJobStFrequenz> GetGruSysAPiJobStFrequenzList()
        {
            var elements = _context.GruSysAPiJobStFrequenzs.ToList();

            var collection =
                (from e in elements
                 select new GruSysAPiJobStFrequenz
                 {
                     OTimeStamp = e.OTimeStamp,
                     Frequenz = e.Frequenz
                 }
                ).ToList();

            return collection;
        }
        #endregion

        #region Global
        public int Save()
        {
            return _context.SaveChanges();
        }
        #endregion
    }
}