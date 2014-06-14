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
    public class ArtVarAusprDataDestination : IDataDestination
    {
        public ArtVarAusprDataDestination()
        {

        }

        public DataTable Read()
        {
            Log.LOG_START();

            DataTable dtWZNTArtikel = DBWZNT.ReadArtVarAuspr();

            Log.LOG_END();

            return dtWZNTArtikel;
        }
        public bool Write(DataTable data)
        {
            Log.LOG_START();

            bool ret = false;

            ret = DBWZNT.WriteArtVarAuspr(data);

            Log.LOG_END();

            return ret;
        }
    }
}
