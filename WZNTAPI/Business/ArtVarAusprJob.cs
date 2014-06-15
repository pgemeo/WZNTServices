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
    public class ArtVarAusprJob : Job
    {
        public ArtVarAusprJob(string standortKZ, JobParameters jobParameters)
        {
            _standortKZ = standortKZ;

            // creating data source origin
            _dataSourceOrigin = new ArtVarAusprDataOrigin(jobParameters.DBServer, jobParameters.DBName, jobParameters.DBSchema
                , jobParameters.DBUser, jobParameters.DBPassword, jobParameters.DBEngine);
            
            // creating data source destination
            _dataSourceDestination = new ArtVarAusprDataDestination();
        }

        public override bool Run()
        {
            Log.LOG_START();

            bool ret = false;

            try
            {
                Log.Info(String.Format("Reading ArtVarAuspr data from WZNT (snapshot)..."));
                DataTable dtWZNTArtVarAuspr = _dataSourceDestination.Read();

                if (dtWZNTArtVarAuspr != null)
                {
                    Log.Info(String.Format("Total ArtVarAuspr: {0}", dtWZNTArtVarAuspr.Rows.Count));

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
                            Log.Info(String.Format("Reading ArtVarAuspr from Origin..."));
                            DataTable dtArtVarAuspr = _dataSourceOrigin.Read();

                            if (dtArtVarAuspr != null)
                            {
                                Log.Info(String.Format("Total ArtVarAuspr: {0}", dtArtVarAuspr.Rows.Count));

                                // Writing data into destination
                                Log.Info(String.Format("Writing ArtVarAuspr into Destination..."));
                                ret = _dataSourceDestination.Write(dtArtVarAuspr);
                                Log.Info(String.Format("Writing ArtVarAuspr into Destination Successfully ? {0}", ret));
                            }
                            else
                            {
                                Log.Warning(String.Format("There is no ArtVarAuspr in Origin."));
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
                    Log.Error(String.Format("Could not take a ArtVarAuspr snapshot from WZNT."));
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
