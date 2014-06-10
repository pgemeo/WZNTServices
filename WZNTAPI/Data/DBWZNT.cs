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
        private const string T_WZNTARTIKEL = "[dbo].[WZNTArtikel]";

        public static DataTable ReadArtikel()
        {
            DataTable data = new DataTable();
            SqlCommand oCommand = new SqlCommand();

            try
            {
                string CS = ConfigurationManager.ConnectionStrings["WZNT"].ConnectionString;
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
                string CS = ConfigurationManager.ConnectionStrings["WZNT"].ConnectionString;

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


        public static DataTable ReadGruArtAufEinzelnutzen()
        {
            DataTable data = new DataTable();
            SqlCommand oCommand = new SqlCommand();

            try
            {
                string CS = ConfigurationManager.ConnectionStrings["WZNT"].ConnectionString;
                string SQL = "SELECT [ID],[Aufgabe],[O_TimeStamp] FROM [dbo].[GruArtAufEinzelnutzen]";

                oCommand.Connection = new SqlConnection(CS);
                oCommand.Connection.Open();

                oCommand.CommandType = System.Data.CommandType.Text;
                oCommand.CommandText = SQL;

                SqlDataReader reader = oCommand.ExecuteReader();
                data.Load(reader);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);   
            }

            if (oCommand.Connection.State.Equals(ConnectionState.Open))
                oCommand.Connection.Close();

            return data;
        }
        public static bool WriteGruArtAufEinzelnutzen(DataTable dt)
        {
            bool ret = false;

            try
            {
                string CS = ConfigurationManager.ConnectionStrings["WZNT"].ConnectionString;

                SqlBulkCopy bulkCopy = new SqlBulkCopy(CS);

                SqlBulkCopyColumnMapping mapping1 = new SqlBulkCopyColumnMapping("Aufgabe", "Aufgabe");
                SqlBulkCopyColumnMapping mapping2 = new SqlBulkCopyColumnMapping("O_TimeStamp", "O_TimeStamp");

                bulkCopy.ColumnMappings.Add(mapping1);
                bulkCopy.ColumnMappings.Add(mapping2);

                bulkCopy.DestinationTableName = "GruArtAufEinzelnutzen";
                bulkCopy.BatchSize = 1000;
                bulkCopy.BulkCopyTimeout = 3600;

                bulkCopy.WriteToServer(dt);

                ret = true;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            return ret;
        }
        public static bool DeleteGruArtAufEinzelnutzen()
        {
            SqlCommand oCommand = new SqlCommand();
            int rows = 0;

            try
            {
                string CS = ConfigurationManager.ConnectionStrings["WZNT"].ConnectionString;
                string SQL = "DELETE FROM [dbo].[GruArtAufEinzelnutzen]";

                oCommand.Connection = new SqlConnection(CS);
                oCommand.Connection.Open();

                oCommand.CommandType = System.Data.CommandType.Text;
                oCommand.CommandText = SQL;

                rows = oCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            if (oCommand.Connection.State.Equals(ConnectionState.Open))
                oCommand.Connection.Close();

            return rows > 0;
        }
    }
}
