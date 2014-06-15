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
    public class ArtikelVariantenDataDestination : IDataDestination
    {
        public ArtikelVariantenDataDestination()
        {

        }

        public DataTable Read()
        {
            Log.LOG_START();

            DataTable dtWZNTArtikel = DBWZNT.ReadArtikelVarianten();

            Log.LOG_END();

            return dtWZNTArtikel;
        }
        public bool Write(DataTable data)
        {
            Log.LOG_START();

            bool ret = false;

            ret = DBWZNT.WriteArtikelVarianten(data);

            Log.LOG_END();

            return ret;
        }
        public DataTable Lookup(DataTable data, string standortKZ)
        {
            Log.LOG_START();

            
            using (WZNTEntities context = new WZNTEntities())
            {
                foreach (DataRow row in data.Rows)
                {
                    if (row["ID_Artikel"] != null)
                    {
                        string artikelNummer = row["ID_Artikel"].ToString();
                        
                        var elems = context.WZNTArtikel.Where(m=>m.Artikelnummer.Equals(artikelNummer) && m.StandortKZ.Equals(standortKZ)).ToList();

                        if (elems.Count == 1)
                        {
                            row["ID_Artikel"] = elems[0].ID;
                        }
                    }
                    else
                    {
                        return new DataTable();
                    }

                    if (row["AusprID"] != null)
                    {
                        string ausprID = row["AusprID"].ToString();

                        var elems = context.WZNTArtVarAuspr.Where(m => m.ID.Equals(ausprID)).ToList();

                        if (elems.Count == 1)
                        {
                            row["AusprID"] = elems[0].ID;
                        }
                    }
                    else
                    {
                        return new DataTable();
                    }
                }
            }

            Log.LOG_END();

            return data;
        }
    }
}
