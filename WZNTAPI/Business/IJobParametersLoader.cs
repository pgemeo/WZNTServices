using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IJobParametersLoader
    {
        JobParameters Load();
    }

    public class JobParameters
    {
        public string DBEngine { get; set; }
        public string DBServer { get; set; }
        public string DBName { get; set; }
        public string DBSchema { get; set; }
        public string DBUser { get; set; }
        public string DBPassword { get; set; }
    }
}
