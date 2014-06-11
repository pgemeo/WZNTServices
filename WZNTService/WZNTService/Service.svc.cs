using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.Text;
using System.Data;
using Business;
using Business.DTO;
using Generic;


namespace WZNTService
{
    public class Service : IService
    {
        // Grundlagen Module
        #region Grundlagen


        #region GruArtAufEinzelnutzen

        //[OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        public bool CreateGruArtAufEinzelnutzen(GruArtAufEinzelnutzen model)
        {
            Log.LOG_START();

            bool ret = false;

            try
            {
                GrundlagenController controller = new GrundlagenController();
                controller.InsertGruArtAufEinzelnutzen(model);
                int rows = controller.Save();
                ret = rows > 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            
            Log.LOG_END();

            return ret;
        }

        //[OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        public bool CreateGruArtAufEinzelnutzenList(ICollection<GruArtAufEinzelnutzen> models)
        {
            Log.LOG_START();

            bool ret = false;

            try
            {
                GrundlagenController controller = new GrundlagenController();
                foreach (var model in models)
                {
                    controller.InsertGruArtAufEinzelnutzen(model);
                }
                int rows = controller.Save();
                ret = rows > 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            Log.LOG_END();

            return ret;
        }
        
        public GruArtAufEinzelnutzen ReadGruArtAufEinzelnutzen(int id)
        {
            Log.LOG_START();

            GrundlagenController controller = new GrundlagenController();
            var model = controller.GetGruArtAufEinzelnutzen(id);

            Log.LOG_END();

            return model;
        }

        public List<GruArtAufEinzelnutzen> ReadGruArtAufEinzelnutzenList(string locationId = null)
        {
            Generic.Log.LOG_START();
            
            GrundlagenController controller = new GrundlagenController();
            var collection = controller.GetGruArtAufEinzelnutzenList(locationId);
            
            Generic.Log.LOG_END();
            
            return collection;
        }

        //[OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        public bool UpdateGruArtAufEinzelnutzenList(ICollection<GruArtAufEinzelnutzen> models)
        {
            Log.LOG_START();

            bool ret = false;

            try
            {
                GrundlagenController controller = new GrundlagenController();
                foreach (var model in models)
                {
                    controller.UpdateGruArtAufEinzelnutzen(model);
                }
                int rows = controller.Save();
                ret = rows > 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            Log.LOG_END();

            return ret;
        }

        //[OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        public bool DeleteGruArtAufEinzelnutzenList(ICollection<GruArtAufEinzelnutzen> models)
        {
            Log.LOG_START();

            bool ret = false;

            try
            {
                GrundlagenController controller = new GrundlagenController();
                foreach (var model in models)
                {
                    controller.DeleteGruArtAufEinzelnutzen(model);
                }
                int rows = controller.Save();
                ret = rows > 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            Log.LOG_END();

            return ret;
        }

        #endregion



        #region GruArtAufEinSprache

        public List<GruArtAufEinSprache> ReadGruArtAufEinSpracheList(GruArtAufEinzelnutzen model)
        {
            GrundlagenController controller = new GrundlagenController();
            return controller.GetGruArtAufEinSpracheList(model);
        }
        
        #endregion



        #region GruSprachen
        
        public List<GruSprachen> ReadGruSprachenList(string locationId = null)
        {
            GrundlagenController controller = new GrundlagenController();
            return controller.GetGruSprachenList(locationId);
        }

        #endregion



        #region GruSysStandort
        
        //[OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        public bool CreateGruSysStandort(GruSysStandort model)
        {
            Log.LOG_START();

            bool ret = false;

            try
            {
                GrundlagenController controller = new GrundlagenController();
                controller.InsertGruSysStandort(model);
                int rows = controller.Save();
                ret = rows > 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            Log.LOG_END();

            return ret;
        }

        //[OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        public bool CreateGruSysStandortList(ICollection<GruSysStandort> models)
        {
            Log.LOG_START();

            bool ret = false;

            try
            {
                GrundlagenController controller = new GrundlagenController();
                foreach (var model in models)
                {
                    controller.InsertGruSysStandort(model);
                }
                int rows = controller.Save();
                ret = rows > 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            Log.LOG_END();

            return ret;
        }
        
        public List<GruSysStandort> ReadGruSysStandortList()
        {
            GrundlagenController controller = new GrundlagenController();
            return controller.GetGruSysStandortList();
        }

        //[OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        public bool UpdateGruSysStandortList(ICollection<GruSysStandort> models)
        {
            Log.LOG_START();

            bool ret = false;

            try
            {
                GrundlagenController controller = new GrundlagenController();
                foreach (var model in models)
                {
                    controller.UpdateGruSysStandort(model);
                }
                int rows = controller.Save();
                ret = rows > 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            Log.LOG_END();

            return ret;
        }

        //[OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        public bool DeleteGruSysStandortList(ICollection<GruSysStandort> models)
        {
            Log.LOG_START();

            bool ret = false;

            try
            {
                GrundlagenController controller = new GrundlagenController();
                foreach (var model in models)
                {
                    controller.DeleteGruSysStandort(model);
                }
                int rows = controller.Save();
                ret = rows > 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            Log.LOG_END();

            return ret;
        }

        #endregion



        #endregion






        #region Image Parser
        public double ParsePixels(string File1, string File2)
        {
            return ImageParser.ParsePixels(File1, File2);
        }
        public double ParseSimilarity(string File1, string File2)
        {
            return ImageParser.ParseSimilarity(File1, File2);
        }
        #endregion



        #region Test
        public string GetData(int Value)
        {
            // Testing data access
            return Value.ToString();
        }
        public CompositeType GetDataUsingDataContract(CompositeType Composite)
        {
            if (Composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (Composite.BoolValue)
            {
                Composite.StringValue += "Suffix";
            }
            return Composite;
        }
        #endregion
    }
}
