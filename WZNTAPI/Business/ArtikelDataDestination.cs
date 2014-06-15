using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Data;
using Generic;

namespace Business
{
    public class ArtikelDataDestination : IDataDestination
    {
        public ArtikelDataDestination()
        {

        }

        public DataTable Read()
        {
            Log.LOG_START();

            DataTable dtWZNTArtikel = DBWZNT.ReadArtikel();

            Log.LOG_END();

            return dtWZNTArtikel;
        }
        public bool Write(DataTable data)
        {
            Log.LOG_START();

            bool ret = false;

            ret = DBWZNT.WriteArtikel(data);

            Log.LOG_END();

            return ret;
        }
    }
}
