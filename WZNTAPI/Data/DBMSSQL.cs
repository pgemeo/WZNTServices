using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using Generic;


namespace Data
{
    public class DBMSSQL : IDB
    {
        private string _dbServer = null;
        private string _dbName = null;
        private string _dbShema = null;
        private string _dbUser = null;
        private string _dbPassword = null;

        private string _connectionString = null;

        public DBMSSQL()
        {

        }
        public DBMSSQL(string dbServer, string dbName, string dbSchema, string dbUser, string dbPassword)
        {
            _dbName = dbName;
            _dbPassword = dbPassword;
            _dbServer = dbServer;
            _dbShema = dbSchema;
            _dbUser = dbUser;

            this._connectionString = String.Format(@"Server={0};Database={1};User Id={2};Password={3};"
                    , _dbServer, _dbName, _dbUser, _dbPassword);

            //this._connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WZNT;user id=nearshoreDC;Password=nearshoreDC;";
        }

        public bool TestConnection()
        {
            bool ret = false;
            SqlCommand oCommand = new SqlCommand();

            try
            {
                oCommand.Connection = new SqlConnection(_connectionString);
                oCommand.Connection.Open();
                ret = true;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            if (oCommand.Connection.State.Equals(ConnectionState.Open))
                oCommand.Connection.Close();

            return ret;
        }


        public DataTable ReadData(string sql, DataTableMapping dtm)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, _connectionString);
            DataSet ds = new DataSet();

            da.TableMappings.Add(dtm);
            da.Fill(ds);

            return ds.Tables[0];
        }
        public DataTable ReadData(string sql)
        {
            DataTable data = new DataTable();
            SqlCommand oCommand = new SqlCommand();

            try
            {
                oCommand.Connection = new SqlConnection(_connectionString);
                oCommand.Connection.Open();

                oCommand.CommandType = System.Data.CommandType.Text;
                oCommand.CommandText = sql;

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
        public void WriteData(DataTable data)
        {
            SqlBulkCopy bulkCopy = new SqlBulkCopy(_connectionString);

            bulkCopy.BatchSize = 1000;
            bulkCopy.BulkCopyTimeout = 3600;

            string tableName = data.TableName;

            bulkCopy.DestinationTableName = tableName;

            //bulkCopy.SqlRowsCopied += new SqlRowsCopiedEventHandler(bulkCopy_SqlRowsCopied);

            //bulkCopy.NotifyAfter = 200;

            bulkCopy.WriteToServer(data);
        }
    }
}
