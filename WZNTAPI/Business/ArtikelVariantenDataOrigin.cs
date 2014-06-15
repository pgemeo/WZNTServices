using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Xml;
using System.Collections;
using Data;
using Generic;


namespace Business
{
    public class ArtikelVariantenDataOrigin : IDataOrigin
    {
        private string _dbServer;
        private string _dbName;
        private string _dbSchema;
        private string _dbUser;
        private string _dbPassword;
        private string _dbEngine;

        private XmlDocument _xmlDoc;

        private 

        IDB _db = null;

        public ArtikelVariantenDataOrigin(string dbServer, string dbName, string dbSchema, string dbUser, string dbPassword, string dbEngine)
        {
            _dbEngine = dbEngine;
            _dbName = dbName;
            _dbPassword = dbPassword;
            _dbSchema = dbSchema;
            _dbServer = dbServer;
            _dbUser = dbUser;

            // create database engine according to the configuration 
            _db = (IDB)Activator.CreateInstance(Type.GetType(String.Format("Data.DB{0}, Data", _dbEngine), true)
                , new object[] { _dbServer, _dbName, _dbSchema, _dbUser, _dbPassword });


            // load API config file for Artikel
            string configFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "App_Data"
                , System.Configuration.ConfigurationSettings.AppSettings["API_CONFIG_FILE_ARTIKEL_VARIANTEN"]);

            if (File.Exists(configFile))
            {
                _xmlDoc = new XmlDocument();
                _xmlDoc.Load(configFile);
            }
        }


        public bool CanAccess()
        {
            Log.LOG_START();

            bool ret = _db.TestConnection();

            Log.LOG_END();

            return ret;
        }

        public DataTable Read()
        {
            Log.LOG_START();

            DataTable dt = null;

            if (_xmlDoc == null)
            {
                Log.Warning(String.Format("There is no configuration file for Artikel Varianten."));
                return null;
            }

            string SQL = _xmlDoc.SelectSingleNode("//ArtikelVarianten/query").InnerText;

            // Mapping columns from origin to destination
            DataTableMapping dtm = new DataTableMapping();

            var nodes = _xmlDoc.SelectNodes("//ArtikelVarianten/mappings/mapping");
            if (nodes != null && nodes.Count > 0)
            {
                dtm.SourceTable = "Table";
                dtm.DataSetTable = "WZNTArtikelVarianten";

                
                IEnumerator inodes = nodes.GetEnumerator();  
                while (inodes.MoveNext()) {   
                    XmlNode node = (XmlNode) inodes.Current;
                    
                    var origin = node.SelectSingleNode("origin").InnerText;
                    var destination = node.SelectSingleNode("destination").InnerText;
                    dtm.ColumnMappings.Add(origin, destination);
                }   
            }

            dt = _db.ReadData(SQL, dtm);

            Log.LOG_END();

            return dt;
        }
    }
}
