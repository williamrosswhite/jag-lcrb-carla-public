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
    /// Microsoft.Dynamics.CRM.solutioncomponentattributeconfiguration
    /// </summary>
    public partial class MicrosoftDynamicsCRMsolutioncomponentattributeconfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsolutioncomponentattributeconfiguration class.
        /// </summary>
        public MicrosoftDynamicsCRMsolutioncomponentattributeconfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsolutioncomponentattributeconfiguration class.
        /// </summary>
        public MicrosoftDynamicsCRMsolutioncomponentattributeconfiguration(string solutionid = default(string), int? statecode = default(int?), string name = default(string), string _createdonbehalfbyValue = default(string), int? encodingformat = default(int?), int? componentstate = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string solutioncomponentattributeconfigurationid = default(string), int? importsequencenumber = default(int?), string _modifiedonbehalfbyValue = default(string), bool? isexportdisabled = default(bool?), string fileextension = default(string), string iscustomizable = default(string), int? timezoneruleversionnumber = default(int?), bool? ismanaged = default(bool?), string _attributeidValue = default(string), int? utcconversiontimezonecode = default(int?), string _createdbyValue = default(string), int? statuscode = default(int?), string versionnumber = default(string), string _modifiedbyValue = default(string), string _solutioncomponentconfigurationidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), bool? isexportedasfile = default(bool?), string componentidunique = default(string), string _organizationidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> solutioncomponentattributeconfigurationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> solutioncomponentattributeconfigurationDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> solutioncomponentattributeconfigurationDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> solutioncomponentattributeconfigurationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> solutioncomponentattributeconfigurationMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> solutioncomponentattributeconfigurationProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> solutioncomponentattributeconfigurationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> solutioncomponentattributeconfigurationPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMattribute attributeId = default(MicrosoftDynamicsCRMattribute), MicrosoftDynamicsCRMsolutioncomponentconfiguration solutioncomponentconfigurationid = default(MicrosoftDynamicsCRMsolutioncomponentconfiguration))
        {
            Solutionid = solutionid;
            Statecode = statecode;
            Name = name;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Encodingformat = encodingformat;
            Componentstate = componentstate;
            Modifiedon = modifiedon;
            Solutioncomponentattributeconfigurationid = solutioncomponentattributeconfigurationid;
            Importsequencenumber = importsequencenumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Isexportdisabled = isexportdisabled;
            Fileextension = fileextension;
            Iscustomizable = iscustomizable;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Ismanaged = ismanaged;
            this._attributeidValue = _attributeidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            Versionnumber = versionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            this._solutioncomponentconfigurationidValue = _solutioncomponentconfigurationidValue;
            Overriddencreatedon = overriddencreatedon;
            Isexportedasfile = isexportedasfile;
            Componentidunique = componentidunique;
            this._organizationidValue = _organizationidValue;
            Createdon = createdon;
            Overwritetime = overwritetime;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            SolutioncomponentattributeconfigurationSyncErrors = solutioncomponentattributeconfigurationSyncErrors;
            SolutioncomponentattributeconfigurationDuplicateMatchingRecord = solutioncomponentattributeconfigurationDuplicateMatchingRecord;
            SolutioncomponentattributeconfigurationDuplicateBaseRecord = solutioncomponentattributeconfigurationDuplicateBaseRecord;
            SolutioncomponentattributeconfigurationAsyncOperations = solutioncomponentattributeconfigurationAsyncOperations;
            SolutioncomponentattributeconfigurationMailboxTrackingFolders = solutioncomponentattributeconfigurationMailboxTrackingFolders;
            SolutioncomponentattributeconfigurationProcessSession = solutioncomponentattributeconfigurationProcessSession;
            SolutioncomponentattributeconfigurationBulkDeleteFailures = solutioncomponentattributeconfigurationBulkDeleteFailures;
            SolutioncomponentattributeconfigurationPrincipalObjectAttributeAccesses = solutioncomponentattributeconfigurationPrincipalObjectAttributeAccesses;
            AttributeId = attributeId;
            Solutioncomponentconfigurationid = solutioncomponentconfigurationid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "encodingformat")]
        public int? Encodingformat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponentattributeconfigurationid")]
        public string Solutioncomponentattributeconfigurationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isexportdisabled")]
        public bool? Isexportdisabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fileextension")]
        public string Fileextension { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_attributeid_value")]
        public string _attributeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

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
        [JsonProperty(PropertyName = "_solutioncomponentconfigurationid_value")]
        public string _solutioncomponentconfigurationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isexportedasfile")]
        public bool? Isexportedasfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentidunique")]
        public string Componentidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponentattributeconfiguration_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SolutioncomponentattributeconfigurationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponentattributeconfiguration_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SolutioncomponentattributeconfigurationDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponentattributeconfiguration_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SolutioncomponentattributeconfigurationDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponentattributeconfiguration_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SolutioncomponentattributeconfigurationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponentattributeconfiguration_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SolutioncomponentattributeconfigurationMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponentattributeconfiguration_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SolutioncomponentattributeconfigurationProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponentattributeconfiguration_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SolutioncomponentattributeconfigurationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SolutioncomponentattributeconfigurationPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttributeId")]
        public MicrosoftDynamicsCRMattribute AttributeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponentconfigurationid")]
        public MicrosoftDynamicsCRMsolutioncomponentconfiguration Solutioncomponentconfigurationid { get; set; }

    }
}
