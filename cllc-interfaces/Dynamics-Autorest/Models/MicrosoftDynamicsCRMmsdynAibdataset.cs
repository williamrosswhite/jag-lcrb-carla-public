// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.msdyn_aibdataset
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynAibdataset
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAibdataset class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAibdataset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAibdataset class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAibdataset(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string msdynAibdatasetid = default(string), string _modifiedonbehalfbyValue = default(string), string _owninguserValue = default(string), string _createdbyValue = default(string), int? timezoneruleversionnumber = default(int?), int? statecode = default(int?), int? importsequencenumber = default(int?), int? statuscode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string msdynName = default(string), string _owneridValue = default(string), string msdynMetadata = default(string), string _createdonbehalfbyValue = default(string), string versionnumber = default(string), string _modifiedbyValue = default(string), string _msdynAibdatasetscontaineridValue = default(string), string _owningteamValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynAibdatasetSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynAibdatasetDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynAibdatasetDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> msdynAibdatasetAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynAibdatasetMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynAibdatasetProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynAibdatasetBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynAibdatasetPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMmsdynAibdatasetscontainer msdynAIBDatasetsContainerId = default(MicrosoftDynamicsCRMmsdynAibdatasetscontainer), IList<MicrosoftDynamicsCRMmsdynAibdatasetfile> msdynAIBDatasetFileMsdynAIBDatas = default(IList<MicrosoftDynamicsCRMmsdynAibdatasetfile>), IList<MicrosoftDynamicsCRMmsdynAibdatasetrecord> msdynAIBDatasetRecordMsdynAIBDataset = default(IList<MicrosoftDynamicsCRMmsdynAibdatasetrecord>))
        {
            Overriddencreatedon = overriddencreatedon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedon = modifiedon;
            MsdynAibdatasetid = msdynAibdatasetid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owninguserValue = _owninguserValue;
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statecode = statecode;
            Importsequencenumber = importsequencenumber;
            Statuscode = statuscode;
            Createdon = createdon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            MsdynName = msdynName;
            this._owneridValue = _owneridValue;
            MsdynMetadata = msdynMetadata;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            this._msdynAibdatasetscontaineridValue = _msdynAibdatasetscontaineridValue;
            this._owningteamValue = _owningteamValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynAibdatasetSyncErrors = msdynAibdatasetSyncErrors;
            MsdynAibdatasetDuplicateMatchingRecord = msdynAibdatasetDuplicateMatchingRecord;
            MsdynAibdatasetDuplicateBaseRecord = msdynAibdatasetDuplicateBaseRecord;
            MsdynAibdatasetAsyncOperations = msdynAibdatasetAsyncOperations;
            MsdynAibdatasetMailboxTrackingFolders = msdynAibdatasetMailboxTrackingFolders;
            MsdynAibdatasetProcessSession = msdynAibdatasetProcessSession;
            MsdynAibdatasetBulkDeleteFailures = msdynAibdatasetBulkDeleteFailures;
            MsdynAibdatasetPrincipalObjectAttributeAccesses = msdynAibdatasetPrincipalObjectAttributeAccesses;
            MsdynAIBDatasetsContainerId = msdynAIBDatasetsContainerId;
            MsdynAIBDatasetFileMsdynAIBDatas = msdynAIBDatasetFileMsdynAIBDatas;
            MsdynAIBDatasetRecordMsdynAIBDataset = msdynAIBDatasetRecordMsdynAIBDataset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aibdatasetid")]
        public string MsdynAibdatasetid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_name")]
        public string MsdynName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_metadata")]
        public string MsdynMetadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_aibdatasetscontainerid_value")]
        public string _msdynAibdatasetscontaineridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aibdataset_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynAibdatasetSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aibdataset_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynAibdatasetDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aibdataset_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynAibdatasetDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aibdataset_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynAibdatasetAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aibdataset_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynAibdatasetMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aibdataset_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynAibdatasetProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aibdataset_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynAibdatasetBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aibdataset_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynAibdatasetPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_AIBDatasetsContainerId")]
        public MicrosoftDynamicsCRMmsdynAibdatasetscontainer MsdynAIBDatasetsContainerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_AIBDatasetFile_msdyn_AIBDatas")]
        public IList<MicrosoftDynamicsCRMmsdynAibdatasetfile> MsdynAIBDatasetFileMsdynAIBDatas { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_AIBDatasetRecord_msdyn_AIBDataset")]
        public IList<MicrosoftDynamicsCRMmsdynAibdatasetrecord> MsdynAIBDatasetRecordMsdynAIBDataset { get; set; }

    }
}
