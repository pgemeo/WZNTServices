using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Business;
using Business.DTO;


namespace WZNTService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetData(int Value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType Composite);

        #region GruArtAufEinzelnutzen
        
        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool CreateGruArtAufEinzelnutzen(GruArtAufEinzelnutzen model);

        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool CreateGruArtAufEinzelnutzenList(ICollection<GruArtAufEinzelnutzen> models);

        [OperationContract]
        List<GruArtAufEinzelnutzen> ReadGruArtAufEinzelnutzenList(string locationId);

        [OperationContract]
        GruArtAufEinzelnutzen ReadGruArtAufEinzelnutzen(int Id);

        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool UpdateGruArtAufEinzelnutzenList(ICollection<GruArtAufEinzelnutzen> models);

        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool DeleteGruArtAufEinzelnutzenList(ICollection<GruArtAufEinzelnutzen> models);

        #endregion
        
        #region GruArtAufEinSprache

        [OperationContract]
        List<GruArtAufEinSprache> ReadGruArtAufEinSpracheList(GruArtAufEinzelnutzen model);
        
        #endregion

        #region GruSprachen

        [OperationContract]
        List<GruSprachen> ReadGruSprachenList(string locationId);
        
        #endregion

        #region GruSysStandort

        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool CreateGruSysStandortList(ICollection<GruSysStandort> models);

        [OperationContract]
        List<GruSysStandort> ReadGruSysStandortList();

        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool UpdateGruSysStandortList(ICollection<GruSysStandort> models);

        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool DeleteGruSysStandortList(ICollection<GruSysStandort> models);
        
        #endregion

        #region GruSysAPiJobl

        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool CreateGruSysAPiJoblList(ICollection<GruSysAPiJobl> models);

        [OperationContract]
        List<GruSysAPiJobl> ReadGruSysAPiJoblList();

        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool UpdateGruSysAPiJoblList(ICollection<GruSysAPiJobl> models);

        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool DeleteGruSysAPiJoblList(ICollection<GruSysAPiJobl> models);

        #endregion

        #region GruSysAPiJobSt

        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool CreateGruSysAPiJobStList(ICollection<GruSysAPiJobSt> models);

        [OperationContract]
        List<GruSysAPiJobSt> ReadGruSysAPiJobStList();

        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool UpdateGruSysAPiJobStList(ICollection<GruSysAPiJobSt> models);

        [OperationContract]
        //[TransactionFlow(TransactionFlowOption.Mandatory)]
        bool DeleteGruSysAPiJobStList(ICollection<GruSysAPiJobSt> models);

        #endregion

        #region GruSysAPiJobStFrequenz
        [OperationContract]
        List<GruSysAPiJobStFrequenz> ReadGruSysAPiJobStFrequenzList();
        #endregion

        #region ImageParser

        //
        // Image Parser
        //
        
        [OperationContract]
        double ParsePixels(string File1, string File2);
        
        [OperationContract]
        double ParseSimilarity(string File1, string File2);
        
        #endregion

    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
