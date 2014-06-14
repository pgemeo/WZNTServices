using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic;
using Data;

namespace Business
{
    public class JobController
    {
        private GruSysAPiJobl _jobInfo = null;

        public JobController(GruSysAPiJobl jobInfo)
        {
            _jobInfo = jobInfo;
        }


        public bool Run()
        {
            Log.LOG_START();

            bool ret = false;

            try
            {
                Log.Info(String.Format("JobID={0}, JobBez={1}, StandortKZ={2}, ParameterDatei={3}, AktivKz={4}"
                    , _jobInfo.ID, _jobInfo.JOB_Bez, _jobInfo.StandortKz, _jobInfo.Parameterdatei, _jobInfo.AktivKZ));

                // loading job parameters
                IJobParametersLoader jobParamsLoader = new JobParametersLoaderXML(_jobInfo.Parameterdatei);
                JobParameters jobParameters = jobParamsLoader.Load();

                switch (_jobInfo.JOB_Bez)
                {
                    case "Artikel":
                        // creating job for processing Artikel
                        Job job = new ArtikelJob(_jobInfo.StandortKz, jobParameters);
                        job.Run();
                        break;

                    default:
                        break;
                }



                ret = true;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            Log.LOG_END();

            return ret;
        }
    }
}
