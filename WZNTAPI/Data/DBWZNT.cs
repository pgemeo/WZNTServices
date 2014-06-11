using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Generic;

namespace Data
{
    public class DBWZNT
    {
        private static string T_WZNTARTIKEL = "[dbo].[WZNTArtikel]";
        private static string CS = ConfigurationManager.ConnectionStrings["WZNT"].ConnectionString;

        public static DataTable ReadArtikel()
        {
            DataTable data = new DataTable();
            SqlCommand oCommand = new SqlCommand();

            try
            {
                string SQL = String.Format("SELECT * FROM {0}", T_WZNTARTIKEL);

                oCommand.Connection = new SqlConnection(CS);
                oCommand.Connection.Open();

                oCommand.CommandType = System.Data.CommandType.Text;
                oCommand.CommandText = SQL;

                SqlDataReader reader = oCommand.ExecuteReader();
                data.Load(reader);
            }
            catch (Exception ex)
            {
                data = null;
                Log.Error(ex.Message);
            }

            if (oCommand.Connection.State.Equals(ConnectionState.Open))
                oCommand.Connection.Close();

            return data;
        }
        public static bool WriteArtikel(DataTable data)
        {
            bool ret = false;

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(CS);

                bulkCopy.BatchSize = 1000;
                bulkCopy.BulkCopyTimeout = 3600;

                string tableName = data.TableName;

                bulkCopy.DestinationTableName = tableName;

                //bulkCopy.SqlRowsCopied += new SqlRowsCopiedEventHandler(bulkCopy_SqlRowsCopied);

                //bulkCopy.NotifyAfter = 200;

                bulkCopy.WriteToServer(data);
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
