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
    /// Microsoft.Dynamics.CRM.msdyn_knowledgearticletemplate
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynKnowledgearticletemplate
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynKnowledgearticletemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynKnowledgearticletemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynKnowledgearticletemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynKnowledgearticletemplate(string msdynContent = default(string), int? importsequencenumber = default(int?), string msdynLanguageLocaleIdName = default(string), string _owningteamValue = default(string), string msdynKeywords = default(string), int? statecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owninguserValue = default(string), string _modifiedbyValue = default(string), string _owneridValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), bool? msdynIsinternal = default(bool?), string msdynTitle = default(string), string msdynDescription = default(string), int? statuscode = default(int?), string _createdbyValue = default(string), string msdynName = default(string), string _msdynSubjectidValue = default(string), string msdynKnowledgearticletemplateid = default(string), string _modifiedonbehalfbyValue = default(string), string versionnumber = default(string), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), string msdynLanguagelocaleid = default(string), string _createdonbehalfbyValue = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynKnowledgearticletemplateSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynKnowledgearticletemplateDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynKnowledgearticletemplateDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> msdynKnowledgearticletemplateSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMasyncoperation> msdynKnowledgearticletemplateAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynKnowledgearticletemplateMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynKnowledgearticletemplateProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynKnowledgearticletemplateBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynKnowledgearticletemplatePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMqueueitem> msdynKnowledgearticletemplateQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMsubject msdynSubjectid = default(MicrosoftDynamicsCRMsubject))
        {
            MsdynContent = msdynContent;
            Importsequencenumber = importsequencenumber;
            MsdynLanguageLocaleIdName = msdynLanguageLocaleIdName;
            this._owningteamValue = _owningteamValue;
            MsdynKeywords = msdynKeywords;
            Statecode = statecode;
            Createdon = createdon;
            this._owninguserValue = _owninguserValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._owneridValue = _owneridValue;
            Overriddencreatedon = overriddencreatedon;
            MsdynIsinternal = msdynIsinternal;
            MsdynTitle = msdynTitle;
            MsdynDescription = msdynDescription;
            Statuscode = statuscode;
            this._createdbyValue = _createdbyValue;
            MsdynName = msdynName;
            this._msdynSubjectidValue = _msdynSubjectidValue;
            MsdynKnowledgearticletemplateid = msdynKnowledgearticletemplateid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Versionnumber = versionnumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            MsdynLanguagelocaleid = msdynLanguagelocaleid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedon = modifiedon;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynKnowledgearticletemplateSyncErrors = msdynKnowledgearticletemplateSyncErrors;
            MsdynKnowledgearticletemplateDuplicateMatchingRecord = msdynKnowledgearticletemplateDuplicateMatchingRecord;
            MsdynKnowledgearticletemplateDuplicateBaseRecord = msdynKnowledgearticletemplateDuplicateBaseRecord;
            MsdynKnowledgearticletemplateSharePointDocumentLocations = msdynKnowledgearticletemplateSharePointDocumentLocations;
            MsdynKnowledgearticletemplateAsyncOperations = msdynKnowledgearticletemplateAsyncOperations;
            MsdynKnowledgearticletemplateMailboxTrackingFolders = msdynKnowledgearticletemplateMailboxTrackingFolders;
            MsdynKnowledgearticletemplateProcessSession = msdynKnowledgearticletemplateProcessSession;
            MsdynKnowledgearticletemplateBulkDeleteFailures = msdynKnowledgearticletemplateBulkDeleteFailures;
            MsdynKnowledgearticletemplatePrincipalObjectAttributeAccesses = msdynKnowledgearticletemplatePrincipalObjectAttributeAccesses;
            MsdynKnowledgearticletemplateQueueItems = msdynKnowledgearticletemplateQueueItems;
            MsdynSubjectid = msdynSubjectid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_content")]
        public string MsdynContent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_LanguageLocaleIdName")]
        public string MsdynLanguageLocaleIdName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_keywords")]
        public string MsdynKeywords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_isinternal")]
        public bool? MsdynIsinternal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_title")]
        public string MsdynTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_description")]
        public string MsdynDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_name")]
        public string MsdynName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_subjectid_value")]
        public string _msdynSubjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgearticletemplateid")]
        public string MsdynKnowledgearticletemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_languagelocaleid")]
        public string MsdynLanguagelocaleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_knowledgearticletemplate_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynKnowledgearticletemplateSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgearticletemplate_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynKnowledgearticletemplateDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgearticletemplate_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynKnowledgearticletemplateDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgearticletemplate_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> MsdynKnowledgearticletemplateSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgearticletemplate_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynKnowledgearticletemplateAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgearticletemplate_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynKnowledgearticletemplateMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgearticletemplate_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynKnowledgearticletemplateProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgearticletemplate_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynKnowledgearticletemplateBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynKnowledgearticletemplatePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgearticletemplate_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> MsdynKnowledgearticletemplateQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_subjectid")]
        public MicrosoftDynamicsCRMsubject MsdynSubjectid { get; set; }

    }
}
