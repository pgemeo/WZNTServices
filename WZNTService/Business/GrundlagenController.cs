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
                    GruArtAufEinSpraches =
                        (from se in model.GruArtAufEinSpraches
                         select new GruArtAufEinSprache
                         {
                             Id = se.Id,
                             IdAufgabe = se.IdAufgabe,
                             IdSprache = se.IdSprache,
                             OTimeStamp = se.OTimeStamp,
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
        public List<GruArtAufEinzelnutzen> GetGruArtAufEinzelnutzenList()
        {
            try
            {
                var elements = _context.GruArtAufEinzelnutzens.ToList();

                var collection =
                    (from e in elements
                     select new GruArtAufEinzelnutzen
                     {
                         Id = e.Id,
                         Aufgabe = e.Aufgabe,
                         OTimeStamp = e.OTimeStamp,
                         GruArtAufEinSpraches =
                            (from se in e.GruArtAufEinSpraches
                             select new GruArtAufEinSprache
                             {
                                 Id = se.Id,
                                 IdAufgabe = se.IdAufgabe,
                                 IdSprache = se.IdSprache,
                                 OTimeStamp = se.OTimeStamp,
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

                if (modelDB != null)
                {
                    // delete on cascade
                    if (modelDB.GruArtAufEinSpraches != null)
                    {
                        var spraches = modelDB.GruArtAufEinSpraches.ToList();

                        for (int i = spraches.Count() - 1; i >= 0; i--)
                        {
                            _context.GruArtAufEinSpraches.Remove(spraches[i]);
                        }
                    }

                    _context.GruArtAufEinzelnutzens.Remove(modelDB);
                }
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
                             IdSprache = s1.IdSprache
                             ,
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
        public List<GruSprachen> GetGruSprachenList()
        {
            var elements = _context.GruSprachens.ToList();

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


        #region Global
        public int Save()
        {
            return _context.SaveChanges();
        }
        #endregion
    }
}