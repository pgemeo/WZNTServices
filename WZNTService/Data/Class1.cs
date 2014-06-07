using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    class Class1
    {
        public void Test()
        {
            GruArtAufEinSprache c = new GruArtAufEinSprache();
            c.Id = 1;

            WZNTContext ctx = new WZNTContext();
            ctx.GruArtAufEinSpraches.Add(c);
        }
        
    }
}
