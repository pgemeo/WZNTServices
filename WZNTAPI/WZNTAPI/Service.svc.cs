using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Generic;
using Business;


namespace WZNTAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public string GetData(int value)
        {
            Log.LOG_START();
            
            var ret = String.Format("You entered: {0}", value);
            
            Log.LOG_END();
            
            return ret;
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        #region Grundlagen

        public bool Run()
        {
            Log.LOG_START();

            GrundlagenController controller = new GrundlagenController();
            bool ret = controller.SyncArtikel();

            Log.LOG_END();
            
            return ret;
        }
        
        #endregion
    }
}
