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
    /// Microsoft.Dynamics.CRM.adoxio_hoursofservicesdefault
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioHoursofservicesdefault
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioHoursofservicesdefault class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioHoursofservicesdefault()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioHoursofservicesdefault class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioHoursofservicesdefault(string _createdbyValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), int? statecode = default(int?), int? adoxioSundayclose = default(int?), string _createdonbehalfbyValue = default(string), string _modifiedonbehalfbyValue = default(string), int? adoxioFridayclose = default(int?), int? adoxioWednesdayopen = default(int?), string _owneridValue = default(string), int? adoxioWednesdayclose = default(int?), int? timezoneruleversionnumber = default(int?), string adoxioName = default(string), int? adoxioThursdayopen = default(int?), int? adoxioSundayopen = default(int?), int? utcconversiontimezonecode = default(int?), int? adoxioSaturdayopen = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? adoxioMondayclose = default(int?), int? statuscode = default(int?), string versionnumber = default(string), int? adoxioFridayopen = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? adoxioTuesdayopen = default(int?), int? adoxioMondayopen = default(int?), string _owninguserValue = default(string), string adoxioHoursofservicesdefaultid = default(string), string _modifiedbyValue = default(string), string _adoxioApplicationtypeValue = default(string), int? adoxioThursdayclose = default(int?), int? adoxioSaturdayclose = default(int?), int? adoxioTuesdayclose = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioHoursofservicesdefaultSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioHoursofservicesdefaultAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioHoursofservicesdefaultMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioHoursofservicesdefaultProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioHoursofservicesdefaultBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioHoursofservicesdefaultPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioApplicationtype adoxioApplicationType = default(MicrosoftDynamicsCRMadoxioApplicationtype))
        {
            this._createdbyValue = _createdbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            Statecode = statecode;
            AdoxioSundayclose = adoxioSundayclose;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioFridayclose = adoxioFridayclose;
            AdoxioWednesdayopen = adoxioWednesdayopen;
            this._owneridValue = _owneridValue;
            AdoxioWednesdayclose = adoxioWednesdayclose;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioName = adoxioName;
            AdoxioThursdayopen = adoxioThursdayopen;
            AdoxioSundayopen = adoxioSundayopen;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioSaturdayopen = adoxioSaturdayopen;
            Modifiedon = modifiedon;
            AdoxioMondayclose = adoxioMondayclose;
            Statuscode = statuscode;
            Versionnumber = versionnumber;
            AdoxioFridayopen = adoxioFridayopen;
            Overriddencreatedon = overriddencreatedon;
            Createdon = createdon;
            Importsequencenumber = importsequencenumber;
            AdoxioTuesdayopen = adoxioTuesdayopen;
            AdoxioMondayopen = adoxioMondayopen;
            this._owninguserValue = _owninguserValue;
            AdoxioHoursofservicesdefaultid = adoxioHoursofservicesdefaultid;
            this._modifiedbyValue = _modifiedbyValue;
            this._adoxioApplicationtypeValue = _adoxioApplicationtypeValue;
            AdoxioThursdayclose = adoxioThursdayclose;
            AdoxioSaturdayclose = adoxioSaturdayclose;
            AdoxioTuesdayclose = adoxioTuesdayclose;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioHoursofservicesdefaultSyncErrors = adoxioHoursofservicesdefaultSyncErrors;
            AdoxioHoursofservicesdefaultAsyncOperations = adoxioHoursofservicesdefaultAsyncOperations;
            AdoxioHoursofservicesdefaultMailboxTrackingFolders = adoxioHoursofservicesdefaultMailboxTrackingFolders;
            AdoxioHoursofservicesdefaultProcessSession = adoxioHoursofservicesdefaultProcessSession;
            AdoxioHoursofservicesdefaultBulkDeleteFailures = adoxioHoursofservicesdefaultBulkDeleteFailures;
            AdoxioHoursofservicesdefaultPrincipalObjectAttributeAccesses = adoxioHoursofservicesdefaultPrincipalObjectAttributeAccesses;
            AdoxioApplicationType = adoxioApplicationType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sundayclose")]
        public int? AdoxioSundayclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fridayclose")]
        public int? AdoxioFridayclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_wednesdayopen")]
        public int? AdoxioWednesdayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_wednesdayclose")]
        public int? AdoxioWednesdayclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_thursdayopen")]
        public int? AdoxioThursdayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sundayopen")]
        public int? AdoxioSundayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_saturdayopen")]
        public int? AdoxioSaturdayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_mondayclose")]
        public int? AdoxioMondayclose { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_fridayopen")]
        public int? AdoxioFridayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tuesdayopen")]
        public int? AdoxioTuesdayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_mondayopen")]
        public int? AdoxioMondayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_hoursofservicesdefaultid")]
        public string AdoxioHoursofservicesdefaultid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicationtype_value")]
        public string _adoxioApplicationtypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_thursdayclose")]
        public int? AdoxioThursdayclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_saturdayclose")]
        public int? AdoxioSaturdayclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tuesdayclose")]
        public int? AdoxioTuesdayclose { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_hoursofservicesdefault_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioHoursofservicesdefaultSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_hoursofservicesdefault_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioHoursofservicesdefaultAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_hoursofservicesdefault_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioHoursofservicesdefaultMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_hoursofservicesdefault_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioHoursofservicesdefaultProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_hoursofservicesdefault_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioHoursofservicesdefaultBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_hoursofservicesdefault_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioHoursofservicesdefaultPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ApplicationType")]
        public MicrosoftDynamicsCRMadoxioApplicationtype AdoxioApplicationType { get; set; }

    }
}
