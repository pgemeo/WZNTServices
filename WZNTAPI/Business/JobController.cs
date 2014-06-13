using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Generic;

namespace Business
{
    public class JobController
    {
        private JobInfo _jobInfo = null;

        public JobController(JobInfo jobInfo)
        {
            _jobInfo = jobInfo;
        }


        public bool Run()
        {
            bool ret = false;

            try
            {
                Log.Info(String.Format("Running Job Controller..."));
                Log.Info(String.Format("JobID={0}, JobBez={1}, StandortKZ={2}, ParameterDatei={3}, AktivKz={4}"
                    , _jobInfo.ID, _jobInfo.JobBez, _jobInfo.StandortKZ, _jobInfo.ParameterDatei, _jobInfo.AktivKZ));

                // loading job parameters
                IJobParametersLoader jobParamsLoader = new JobParametersLoaderXML(_jobInfo.ParameterDatei);
                JobParameters jobParameters = jobParamsLoader.Load();

                switch (_jobInfo.JobBez)
                {
                    case "Artikel":
                        // creating job for processing Artikel
                        Job job = new ArtikelJob(_jobInfo.StandortKZ, jobParameters);
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

            return ret;
        }
    }
}
