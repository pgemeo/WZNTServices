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
    public class ArtikelJob : Job
    {
        public ArtikelJob(string standortKZ, JobParameters jobParameters)
        {
            _standortKZ = standortKZ;

            // creating data source origin
            _dataSourceOrigin = new ArtikelDataOrigin(jobParameters.DBServer, jobParameters.DBName, jobParameters.DBSchema
                , jobParameters.DBUser, jobParameters.DBPassword, jobParameters.DBEngine);
            
            // creating data source destination
            _dataSourceDestination = new ArtikelDataDestination();
        }

        public override bool Run()
        {
            Log.LOG_START();

            bool ret = false;

            try
            {
                Log.Info(String.Format("Reading Artikel data from WZNT (snapshot)..."));
                DataTable dtWZNTArtikel = _dataSourceDestination.Read();

                if (dtWZNTArtikel != null)
                {
                    Log.Info(String.Format("Total Artikels: {0}", dtWZNTArtikel.Rows.Count));

                    int times = 3;

                    while (times > 0)
                    {
                        Log.Info(String.Format("Testing connection ({0})...", times));
                        ret = _dataSourceOrigin.TestConnection();
                        Log.Info(String.Format("Testing connection successfully ? {0}.", ret));

                        if (ret)
                        {
                            times = 0;

                            Log.Info(String.Format("Trying syncronization ({0})...", times));

                            // Reading data from origin
                            Log.Info(String.Format("Reading Artikels from Origin..."));
                            DataTable dtArtikels = _dataSourceOrigin.Read();

                            if (dtArtikels != null)
                            {
                                Log.Info(String.Format("Total Artikels: {0}", dtArtikels.Rows.Count));

                                // Add standortKZ to the table
                                DataColumn dc = new DataColumn("StandortKZ");
                                dc.DataType = Type.GetType("System.String");
                                dc.DefaultValue = _standortKZ;
                                dtArtikels.Columns.Add(dc);

                                // Writing data into destination
                                Log.Info(String.Format("Writing Artikels into Destination..."));
                                ret = _dataSourceDestination.Write(dtArtikels);
                                Log.Info(String.Format("Writing Artikles into Destination Successfully ? {0}", ret));
                            }
                            else
                            {
                                Log.Warning(String.Format("There is no Artikels in Origin."));
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
                    Log.Error(String.Format("Could not take a snapshot from WZNT Artikel."));
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
