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
    /// Microsoft.Dynamics.CRM.adoxio_applicationbpf_dormancy
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioApplicationbpfDormancy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationbpfDormancy class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationbpfDormancy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationbpfDormancy class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationbpfDormancy(string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? activestagestartedon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _activestageidValue = default(string), int? bpfDuration = default(int?), int? importsequencenumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _organizationidValue = default(string), int? statecode = default(int?), int? timezoneruleversionnumber = default(int?), string traversedpath = default(string), string versionnumber = default(string), string _createdbyValue = default(string), string bpfName = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statuscode = default(int?), string _modifiedbyValue = default(string), string _bpfAdoxioApplicationidValue = default(string), int? utcconversiontimezonecode = default(int?), string _createdonbehalfbyValue = default(string), string businessprocessflowinstanceid = default(string), string _processidValue = default(string), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMprocessstage activestageid = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMworkflow processid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMsyncerror> adoxioApplicationbpfDormancySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioApplicationbpfDormancyAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMworkflowlog> adoxioApplicationbpfDormancyWorkflowLogs = default(IList<MicrosoftDynamicsCRMworkflowlog>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioApplicationbpfDormancyMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioApplicationbpfDormancyProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioApplicationbpfDormancyBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioApplicationbpfDormancyPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioApplication bpfAdoxioApplicationid = default(MicrosoftDynamicsCRMadoxioApplication))
        {
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Activestagestartedon = activestagestartedon;
            Overriddencreatedon = overriddencreatedon;
            this._activestageidValue = _activestageidValue;
            BpfDuration = bpfDuration;
            Importsequencenumber = importsequencenumber;
            Modifiedon = modifiedon;
            this._organizationidValue = _organizationidValue;
            Statecode = statecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Traversedpath = traversedpath;
            Versionnumber = versionnumber;
            this._createdbyValue = _createdbyValue;
            BpfName = bpfName;
            Createdon = createdon;
            Statuscode = statuscode;
            this._modifiedbyValue = _modifiedbyValue;
            this._bpfAdoxioApplicationidValue = _bpfAdoxioApplicationidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Businessprocessflowinstanceid = businessprocessflowinstanceid;
            this._processidValue = _processidValue;
            Completedon = completedon;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            Activestageid = activestageid;
            Processid = processid;
            AdoxioApplicationbpfDormancySyncErrors = adoxioApplicationbpfDormancySyncErrors;
            AdoxioApplicationbpfDormancyAsyncOperations = adoxioApplicationbpfDormancyAsyncOperations;
            AdoxioApplicationbpfDormancyWorkflowLogs = adoxioApplicationbpfDormancyWorkflowLogs;
            AdoxioApplicationbpfDormancyMailboxTrackingFolders = adoxioApplicationbpfDormancyMailboxTrackingFolders;
            AdoxioApplicationbpfDormancyProcessSession = adoxioApplicationbpfDormancyProcessSession;
            AdoxioApplicationbpfDormancyBulkDeleteFailures = adoxioApplicationbpfDormancyBulkDeleteFailures;
            AdoxioApplicationbpfDormancyPrincipalObjectAttributeAccesses = adoxioApplicationbpfDormancyPrincipalObjectAttributeAccesses;
            BpfAdoxioApplicationid = bpfAdoxioApplicationid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestagestartedon")]
        public System.DateTimeOffset? Activestagestartedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_activestageid_value")]
        public string _activestageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_duration")]
        public int? BpfDuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_name")]
        public string BpfName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bpf_adoxio_applicationid_value")]
        public string _bpfAdoxioApplicationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessprocessflowinstanceid")]
        public string Businessprocessflowinstanceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

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
        [JsonProperty(PropertyName = "activestageid")]
        public MicrosoftDynamicsCRMprocessstage Activestageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public MicrosoftDynamicsCRMworkflow Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationbpf_dormancy_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioApplicationbpfDormancySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationbpf_dormancy_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioApplicationbpfDormancyAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationbpf_dormancy_WorkflowLogs")]
        public IList<MicrosoftDynamicsCRMworkflowlog> AdoxioApplicationbpfDormancyWorkflowLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationbpf_dormancy_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioApplicationbpfDormancyMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationbpf_dormancy_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioApplicationbpfDormancyProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationbpf_dormancy_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioApplicationbpfDormancyBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationbpf_dormancy_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioApplicationbpfDormancyPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_adoxio_applicationid")]
        public MicrosoftDynamicsCRMadoxioApplication BpfAdoxioApplicationid { get; set; }

    }
}
