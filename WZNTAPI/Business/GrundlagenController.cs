using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Generic;
using Data;
using Model;

namespace Business
{
    public class GrundlagenController
    {
        private WZNTAPIContext _context = new WZNTAPIContext();
        
        public bool SyncArtikel()
        {
            Log.LOG_START();

            bool success = false;

            Log.Info(String.Format("Reading Artikel data from WZNT..."));
            DataTable dtWZNTArtikel = DBWZNT.ReadArtikel();
            if (dtWZNTArtikel != null)
            {
                Log.Info(String.Format("Total Artikels: {0}", dtWZNTArtikel.Rows.Count));

                int times = 3;

                while (times > 0)
                {
                    --times;

                    Log.Info(String.Format("Trying syncronization... {0}", times));
                    
                    // getting server settings and table information
                    Log.Info(String.Format("Getting server settings and table information..."));

                    var tabelles = 
                        (from t in _context.GruSysDqTabelles
                         join dq in _context.GruSysDqtDqs on t.Id equals dq.IdT
                         join quelle in _context.GruSysDatenquelles on dq.IdDq equals quelle.Id
                         where t.Tabellenname.Equals("Artikel")
                         select new 
                            { GruSysDqTabelle_Id = t.Id, GruSysDqTabelle_Tabellenname = t.Tabellenname, GruSysDqTabelle_OTimeStamp = t.OTimeStamp
                                , GruSysDqtDq_Id = dq.Id
                                , GruSysDatenquelle_DboEngine = quelle.DboEngine, GruSysDatenquelle_Id = quelle.Id
                                , GruSysDatenquelle_OTimeStamp = quelle.OTimeStamp, GruSysDatenquelle_Passwort = quelle.Passwort
                                , GruSysDatenquelle_Servername = quelle.Servername, GruSysDatenquelle_StandortKz = quelle.StandortKz
                                , GruSysDatenquelle_Status = quelle.Status, GruSysDatenquelle_UserDesc = quelle.UserDesc
                            }
                         ).ToList();

                    Log.Info(String.Format("Total records: {0}", tabelles.Count));

                    foreach(var tabelle in tabelles)
                    {
                        Log.Info(String.Format("Processing table={0}, server={1}, engine={2}, user={3}, status={4}, prefix={5}"
                            , tabelle.GruSysDqTabelle_Tabellenname
                            , tabelle.GruSysDatenquelle_Servername
                            , tabelle.GruSysDatenquelle_DboEngine
                            , tabelle.GruSysDatenquelle_UserDesc
                            , tabelle.GruSysDatenquelle_Status
                            , tabelle.GruSysDatenquelle_StandortKz));

                        DBSource dbSource = new DBSource(tabelle.GruSysDatenquelle_DboEngine, tabelle.GruSysDatenquelle_Servername
                            , tabelle.GruSysDatenquelle_UserDesc, tabelle.GruSysDatenquelle_Passwort
                            , tabelle.GruSysDatenquelle_Status, tabelle.GruSysDatenquelle_StandortKz);

                        success = dbSource.TestConnection();
                    }
                }
            }
                        
            Log.LOG_END();

            return success;
        }
    }
}
