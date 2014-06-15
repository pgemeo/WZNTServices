using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Reflection;
using Generic;
using Data;
using Model;

namespace Business
{
    public class GrundlagenController
    {
        private WZNTEntities _context = new WZNTEntities();
        
        public bool RunJobs()
        {
            Log.LOG_START();

            bool success = false;

            var jobs = _context.GruSysAPiJobl.Where(m=>m.AktivKZ == true).ToList();

            if (jobs.Count == 0)
            {
                Log.Warning(String.Format("There is no Job to be processed."));
            }
            else
            {
                Log.Info(String.Format("Total Jobs: {0}", jobs.Count));

                foreach (var job in jobs)
                {
                    /*
                    JobInfo job = new JobInfo();
                    job.AktivKZ = true;
                    job.ID = 1;
                    job.JobBez = "Artikel";
                    job.JobID = 1;
                    job.ParameterDatei = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "App_Data", "Gebesee.xml");
                    job.StandortKZ = "A01";
                    */

                    job.Parameterdatei = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "App_Data", "Gebesee.xml");
                    JobController jobController = new JobController(job);
                    jobController.Run();
                }
            }
            
                        
            Log.LOG_END();

            return success;
        }
    }
}
