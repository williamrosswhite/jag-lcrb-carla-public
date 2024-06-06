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
    /// Microsoft.Dynamics.CRM.adoxio_region
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioRegion
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioRegion
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioRegion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioRegion
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioRegion(string _owneridValue = default(string), string _adoxioRegionalinspectoridValue = default(string), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? statuscode = default(int?), string _owningteamValue = default(string), string _adoxioRegionalmanagerValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owninguserValue = default(string), string versionnumber = default(string), int? importsequencenumber = default(int?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), string adoxioRegionid = default(string), string _adoxioManagerofinvestigationsidValue = default(string), string _createdbyValue = default(string), int? statecode = default(int?), string adoxioName = default(string), string _adoxioRegionaladminValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioRegionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioRegionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioRegionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioRegionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioRegionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioRegionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioRegionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioRegionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioAdoxioRegionAdoxioApplicationRegion = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioLicences> adoxioAdoxioRegionAdoxioLicencesRegion = default(IList<MicrosoftDynamicsCRMadoxioLicences>), IList<MicrosoftDynamicsCRMadoxioTerritory> adoxioAdoxioRegionAdoxioTerritoryRegion = default(IList<MicrosoftDynamicsCRMadoxioTerritory>), IList<MicrosoftDynamicsCRMincident> adoxioAdoxioRegionIncidentRegion = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMadoxioArea> adoxioRegionAdoxioAreaRegion = default(IList<MicrosoftDynamicsCRMadoxioArea>), IList<MicrosoftDynamicsCRMadoxioCitydistrict> adoxioRegionAdoxioCitydistrictRegionId = default(IList<MicrosoftDynamicsCRMadoxioCitydistrict>), MicrosoftDynamicsCRMsystemuser adoxioRegionalAdmin = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser adoxioRegionalManager = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMadoxioComplaint> adoxioRegionComplaints = default(IList<MicrosoftDynamicsCRMadoxioComplaint>), IList<MicrosoftDynamicsCRMadoxioContravention> adoxioRegionContraventions = default(IList<MicrosoftDynamicsCRMadoxioContravention>), MicrosoftDynamicsCRMsystemuser adoxioRegionalInspectorId = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMadoxioComplianceinvestigation> adoxioRegionInvestigations = default(IList<MicrosoftDynamicsCRMadoxioComplianceinvestigation>), IList<MicrosoftDynamicsCRMadoxioEstablishment> adoxioRegionEstablishments = default(IList<MicrosoftDynamicsCRMadoxioEstablishment>), IList<MicrosoftDynamicsCRMadoxioEvent> adoxioRegionEvents = default(IList<MicrosoftDynamicsCRMadoxioEvent>), IList<MicrosoftDynamicsCRMadoxioRmreview> adoxioRegionAdoxioRmreviewRegion = default(IList<MicrosoftDynamicsCRMadoxioRmreview>), IList<MicrosoftDynamicsCRMadoxioEnforcementaction> adoxioRegionEnforcementactions = default(IList<MicrosoftDynamicsCRMadoxioEnforcementaction>), IList<MicrosoftDynamicsCRMadoxioInspectorreport> adoxioRegionAdoxioInspectorreportRegion = default(IList<MicrosoftDynamicsCRMadoxioInspectorreport>), IList<MicrosoftDynamicsCRMadoxioInvestigationrequest> adoxioRegionInvestigationrequests = default(IList<MicrosoftDynamicsCRMadoxioInvestigationrequest>), MicrosoftDynamicsCRMsystemuser adoxioManagerofInvestigationsId = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMadoxioAdditionalinspector> adoxioRegionAdditionalinspectors = default(IList<MicrosoftDynamicsCRMadoxioAdditionalinspector>), IList<MicrosoftDynamicsCRMadoxioSpecialevent> adoxioRegionSpecialevents = default(IList<MicrosoftDynamicsCRMadoxioSpecialevent>))
        {
            this._owneridValue = _owneridValue;
            this._adoxioRegionalinspectoridValue = _adoxioRegionalinspectoridValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Overriddencreatedon = overriddencreatedon;
            Statuscode = statuscode;
            this._owningteamValue = _owningteamValue;
            this._adoxioRegionalmanagerValue = _adoxioRegionalmanagerValue;
            Createdon = createdon;
            this._owninguserValue = _owninguserValue;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedon = modifiedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioRegionid = adoxioRegionid;
            this._adoxioManagerofinvestigationsidValue = _adoxioManagerofinvestigationsidValue;
            this._createdbyValue = _createdbyValue;
            Statecode = statecode;
            AdoxioName = adoxioName;
            this._adoxioRegionaladminValue = _adoxioRegionaladminValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioRegionSyncErrors = adoxioRegionSyncErrors;
            AdoxioRegionDuplicateMatchingRecord = adoxioRegionDuplicateMatchingRecord;
            AdoxioRegionDuplicateBaseRecord = adoxioRegionDuplicateBaseRecord;
            AdoxioRegionAsyncOperations = adoxioRegionAsyncOperations;
            AdoxioRegionMailboxTrackingFolders = adoxioRegionMailboxTrackingFolders;
            AdoxioRegionProcessSession = adoxioRegionProcessSession;
            AdoxioRegionBulkDeleteFailures = adoxioRegionBulkDeleteFailures;
            AdoxioRegionPrincipalObjectAttributeAccesses = adoxioRegionPrincipalObjectAttributeAccesses;
            AdoxioAdoxioRegionAdoxioApplicationRegion = adoxioAdoxioRegionAdoxioApplicationRegion;
            AdoxioAdoxioRegionAdoxioLicencesRegion = adoxioAdoxioRegionAdoxioLicencesRegion;
            AdoxioAdoxioRegionAdoxioTerritoryRegion = adoxioAdoxioRegionAdoxioTerritoryRegion;
            AdoxioAdoxioRegionIncidentRegion = adoxioAdoxioRegionIncidentRegion;
            AdoxioRegionAdoxioAreaRegion = adoxioRegionAdoxioAreaRegion;
            AdoxioRegionAdoxioCitydistrictRegionId = adoxioRegionAdoxioCitydistrictRegionId;
            AdoxioRegionalAdmin = adoxioRegionalAdmin;
            AdoxioRegionalManager = adoxioRegionalManager;
            AdoxioRegionComplaints = adoxioRegionComplaints;
            AdoxioRegionContraventions = adoxioRegionContraventions;
            AdoxioRegionalInspectorId = adoxioRegionalInspectorId;
            AdoxioRegionInvestigations = adoxioRegionInvestigations;
            AdoxioRegionEstablishments = adoxioRegionEstablishments;
            AdoxioRegionEvents = adoxioRegionEvents;
            AdoxioRegionAdoxioRmreviewRegion = adoxioRegionAdoxioRmreviewRegion;
            AdoxioRegionEnforcementactions = adoxioRegionEnforcementactions;
            AdoxioRegionAdoxioInspectorreportRegion = adoxioRegionAdoxioInspectorreportRegion;
            AdoxioRegionInvestigationrequests = adoxioRegionInvestigationrequests;
            AdoxioManagerofInvestigationsId = adoxioManagerofInvestigationsId;
            AdoxioRegionAdditionalinspectors = adoxioRegionAdditionalinspectors;
            AdoxioRegionSpecialevents = adoxioRegionSpecialevents;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_regionalinspectorid_value")]
        public string _adoxioRegionalinspectoridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_regionalmanager_value")]
        public string _adoxioRegionalmanagerValue { get; set; }

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
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

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
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_regionid")]
        public string AdoxioRegionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_managerofinvestigationsid_value")]
        public string _adoxioManagerofinvestigationsidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_regionaladmin_value")]
        public string _adoxioRegionaladminValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_region_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioRegionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioRegionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioRegionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioRegionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioRegionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioRegionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioRegionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioRegionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_region_adoxio_application_Region")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioAdoxioRegionAdoxioApplicationRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_region_adoxio_licences_Region")]
        public IList<MicrosoftDynamicsCRMadoxioLicences> AdoxioAdoxioRegionAdoxioLicencesRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_region_adoxio_territory_Region")]
        public IList<MicrosoftDynamicsCRMadoxioTerritory> AdoxioAdoxioRegionAdoxioTerritoryRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_region_incident_Region")]
        public IList<MicrosoftDynamicsCRMincident> AdoxioAdoxioRegionIncidentRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_adoxio_area_Region")]
        public IList<MicrosoftDynamicsCRMadoxioArea> AdoxioRegionAdoxioAreaRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_adoxio_citydistrict_RegionId")]
        public IList<MicrosoftDynamicsCRMadoxioCitydistrict> AdoxioRegionAdoxioCitydistrictRegionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RegionalAdmin")]
        public MicrosoftDynamicsCRMsystemuser AdoxioRegionalAdmin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RegionalManager")]
        public MicrosoftDynamicsCRMsystemuser AdoxioRegionalManager { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_complaints")]
        public IList<MicrosoftDynamicsCRMadoxioComplaint> AdoxioRegionComplaints { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_contraventions")]
        public IList<MicrosoftDynamicsCRMadoxioContravention> AdoxioRegionContraventions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RegionalInspectorId")]
        public MicrosoftDynamicsCRMsystemuser AdoxioRegionalInspectorId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_investigations")]
        public IList<MicrosoftDynamicsCRMadoxioComplianceinvestigation> AdoxioRegionInvestigations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_establishments")]
        public IList<MicrosoftDynamicsCRMadoxioEstablishment> AdoxioRegionEstablishments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_events")]
        public IList<MicrosoftDynamicsCRMadoxioEvent> AdoxioRegionEvents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_adoxio_rmreview_Region")]
        public IList<MicrosoftDynamicsCRMadoxioRmreview> AdoxioRegionAdoxioRmreviewRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_enforcementactions")]
        public IList<MicrosoftDynamicsCRMadoxioEnforcementaction> AdoxioRegionEnforcementactions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_adoxio_inspectorreport_Region")]
        public IList<MicrosoftDynamicsCRMadoxioInspectorreport> AdoxioRegionAdoxioInspectorreportRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_investigationrequests")]
        public IList<MicrosoftDynamicsCRMadoxioInvestigationrequest> AdoxioRegionInvestigationrequests { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ManagerofInvestigationsId")]
        public MicrosoftDynamicsCRMsystemuser AdoxioManagerofInvestigationsId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_additionalinspectors")]
        public IList<MicrosoftDynamicsCRMadoxioAdditionalinspector> AdoxioRegionAdditionalinspectors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region_specialevents")]
        public IList<MicrosoftDynamicsCRMadoxioSpecialevent> AdoxioRegionSpecialevents { get; set; }

    }
}
