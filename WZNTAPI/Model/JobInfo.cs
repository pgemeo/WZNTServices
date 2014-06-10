using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class JobInfo
    {
        public int ID { get; set; }
        public int JobID { get; set; }
        public string JobBez { get; set; }
        public string ParameterDatei { get; set; }
        public bool AktivKZ { get; set; }
        public string StandortKZ { get; set; }
        public DateTime OTimeStamp { get; set; }
    }
}
