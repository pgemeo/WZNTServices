using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public abstract class Job
    {
        protected IDataOrigin _dataSourceOrigin = null;
        protected IDataDestination _dataSourceDestination = null;
        
        public abstract bool Run();
    }
}
