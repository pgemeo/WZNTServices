using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Generic;
using Data;

namespace Business
{
    public static class GrundlagenController
    {
        public static bool SyncGruArtAufEinSprache()
        {
            Log.LOG_START();

            bool ret = false;
            bool success = false;

            Log.Info(String.Format("Reading GruArtAufEinzelnutzen data from SAGE..."));
            DataTable dt = DBSAGE.ReadGruArtAufEinzelnutzen();
            Log.Info(String.Format("Total GruArtAufEinzelnutzens: {0}", dt.Rows.Count));

            Log.Info(String.Format("Deleting GruArtAufEinzelnutzen data from WZNT..."));
            success = DBWZNT.DeleteGruArtAufEinzelnutzen();
            Log.Info(String.Format("Deleting GruArtAufEinzelnutzens successfully ? {0}", success));

            Log.Info(String.Format("Writting GruArtAufEinzelnutzen data into WZNT..."));
            success = DBWZNT.WriteGruArtAufEinzelnutzen(dt);
            Log.Info(String.Format("Writting GruArtAufEinzelnutzens successfully ? {0}", success));

            Log.LOG_END();

            return ret;
        }

        public static bool SyncArtikel()
        {
            Log.LOG_START();

            bool success = false;

            Log.Info(String.Format("Reading Artikel data from WZNT..."));
            DataTable dtWZNTArtikel = DBWZNT.ReadArtikel();
            Log.Info(String.Format("Total Artikels: {0}", dtWZNTArtikel.Rows.Count));

            Log.Info(String.Format("Reading Artikel data from SAGE..."));
            DataTable dtSAGEArtikel = DBSAGE.ReadArtikel();
            Log.Info(String.Format("Total Artikels: {0}", dtSAGEArtikel.Rows.Count));
            
            Log.LOG_END();

            // TEST

            return success;
        }
    }
}
