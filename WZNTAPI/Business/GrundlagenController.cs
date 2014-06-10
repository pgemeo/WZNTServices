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
        private WZNTEntities _context = new WZNTEntities();
        
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
                    Log.Info(String.Format("Trying syncronization ({0})...", times));

                    JobInfo job = new JobInfo();
                    job.AktivKZ = true;
                    job.ID = 1;
                    job.JobBez = "Artikel";
                    job.JobID = 1;
                    job.ParameterDatei = @"c:\temp\tesxt.xml";
                    job.StandortKZ = "A01";

                    JobController jobController = new JobController(job);
                    jobController.Run();


                    /*
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


                        Log.Info(String.Format("Testing connection..."));
                        success = dbSource.TestConnection();
                        Log.Info(String.Format("Testing connection successfully ? {0}", success));
                    }

                    */

                    if (!success)
                    {
                        --times;
                    }
                    else
                    {
                        times = 0;
                    }
                }
            }
                        
            Log.LOG_END();

            return success;
        }
    }
}
