using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace Business
{
    public interface IDataOrigin
    {
        bool TestConnection();
        DataTable Read();
    }
}
