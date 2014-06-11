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
        
        public bool RunJobs()
        {
            Log.LOG_START();

            bool success = false;

            Log.Info(String.Format("Running Jobs for Grundlagen..."));
            
            JobInfo job = new JobInfo();
            job.AktivKZ = true;
            job.ID = 1;
            job.JobBez = "Artikel";
            job.JobID = 1;
            job.ParameterDatei = @"c:\temp\tesxt.xml";
            job.StandortKZ = "A01";

            JobController jobController = new JobController(job);
            jobController.Run();
            
                        
            Log.LOG_END();

            return success;
        }
    }
}
