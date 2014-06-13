using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Data;

namespace Business
{
    public class ArtikelDataDestination : IDataDestination
    {
        public ArtikelDataDestination()
        {

        }

        public DataTable Read()
        {
            DataTable dtWZNTArtikel = DBWZNT.ReadArtikel();

            return dtWZNTArtikel;
        }
        public bool Write(DataTable data)
        {
            bool ret = false;

            ret = DBWZNT.WriteArtikel(data);

            return ret;
        }
    }
}
