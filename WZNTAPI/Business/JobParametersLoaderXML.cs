using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using Model;
using Generic;

namespace Business
{
    public class JobParametersLoaderXML : IJobParametersLoader
    {
        private string _fileNameXML = null;
        private JobParameters _jobParameters = null;

        public JobParametersLoaderXML(string fileNameXML)
        {
            _fileNameXML = fileNameXML;
        }

        public JobParameters Load()
        {
            JobParameters jobParameters = null;

            try
            {
                Log.Info(String.Format("Loading Job Parameters from XML file..."));
                Log.Info(String.Format("FileName={0}", _fileNameXML));

                if (File.Exists(_fileNameXML))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(_fileNameXML);

                    string server = doc.SelectSingleNode("//database/server").InnerText;
                    string engine = doc.SelectSingleNode("//database/engine").InnerText;
                    string name = doc.SelectSingleNode("//database/name").InnerText;
                    string schema = doc.SelectSingleNode("//database/schema").InnerText;
                    string user = doc.SelectSingleNode("//database/user").InnerText;
                    string password = doc.SelectSingleNode("//database/password").InnerText;

                    jobParameters = new JobParameters();
                    jobParameters.DBEngine = engine;
                    jobParameters.DBName = name;
                    jobParameters.DBPassword = password;
                    jobParameters.DBUser = user;
                    jobParameters.DBSchema = schema;
                    jobParameters.DBServer = server;
                }
                else
                {
                    Log.Error(String.Format("File '{0}' does not exists.", _fileNameXML));
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            return jobParameters;
        }

        public JobParameters GetParameters()
        {
            return _jobParameters;
        }
    }
}
