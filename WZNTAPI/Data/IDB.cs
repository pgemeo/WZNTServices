using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace Data
{
    public interface IDB
    {
        DataTable ReadData(string sql, DataTableMapping dtm);
        DataTable ReadData(string sql);
        void WriteData(DataTable data);
    }
}
