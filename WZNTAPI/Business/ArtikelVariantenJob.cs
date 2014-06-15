using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Generic;
using Data;

namespace Business
{
    public class ArtikelVariantenJob : Job
    {
        public ArtikelVariantenJob(string standortKZ, JobParameters jobParameters)
        {
            _standortKZ = standortKZ;

            // creating data source origin
            _dataSourceOrigin = new ArtikelVariantenDataOrigin(jobParameters.DBServer, jobParameters.DBName, jobParameters.DBSchema
                , jobParameters.DBUser, jobParameters.DBPassword, jobParameters.DBEngine);
            
            // creating data source destination
            _dataSourceDestination = new ArtikelVariantenDataDestination();
        }

        public override bool Run()
        {
            Log.LOG_START();

            bool ret = false;

            try
            {
                Log.Info(String.Format("Reading Artikel Varianten data from WZNT (snapshot)..."));
                DataTable dtWZNTArtikelVarianten = _dataSourceDestination.Read();

                if (dtWZNTArtikelVarianten != null)
                {
                    Log.Info(String.Format("Total Artikel Varianten: {0}", dtWZNTArtikelVarianten.Rows.Count));

                    int times = 3;

                    while (times > 0)
                    {
                        Log.Info(String.Format("Testing connection ({0})...", times));
                        ret = _dataSourceOrigin.CanAccess();
                        Log.Info(String.Format("Testing connection successfully ? {0}.", ret));

                        if (ret)
                        {
                            times = 0;

                            Log.Info(String.Format("Trying syncronization ({0})...", times));

                            // Reading data from origin
                            Log.Info(String.Format("Reading Artikel Varianten from Origin..."));
                            DataTable dtArtikelVarianten = _dataSourceOrigin.Read();

                            if (dtArtikelVarianten != null)
                            {
                                Log.Info(String.Format("Total Artikel Varianten: {0}", dtArtikelVarianten.Rows.Count));

                                // Lookup ArtikelID by Artikelnummer and AusprID
                                dtArtikelVarianten = 
                                    ((ArtikelVariantenDataDestination)_dataSourceDestination).Lookup(dtArtikelVarianten, _standortKZ);

                                // Writing data into destination
                                Log.Info(String.Format("Writing Artikel Varianten into Destination..."));
                                ret = _dataSourceDestination.Write(dtArtikelVarianten);
                                Log.Info(String.Format("Writing Artikle Varianten into Destination Successfully ? {0}", ret));
                            }
                            else
                            {
                                Log.Warning(String.Format("There is no Artikel Varianten in Origin."));
                            }
                        }
                        else
                        {
                            --times;
                        }
                    }
                }
                else
                {
                    Log.Error(String.Format("Could not take a ArtikelVarianten snapshot from WZNT."));
                }
            }
            catch (Exception ex)
            {
                ret = false;
                Log.Error(ex.Message);
            }

            Log.LOG_END();

            return ret;
        }
    }
}
