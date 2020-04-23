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
    /// Microsoft.Dynamics.CRM.adoxio_worker
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioWorker
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioWorker
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioWorker()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioWorker
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioWorker(string adoxioBcidcardnumber = default(string), int? adoxioIsmanual = default(int?), int? adoxioSelfdisclosure = default(int?), int? statecode = default(int?), System.DateTimeOffset? adoxioDateofbirth = default(System.DateTimeOffset?), int? adoxioIslettersent = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioPaymentreceiveddate = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioExpirydate = default(System.DateTimeOffset?), int? adoxioTriggerphs = default(int?), int? adoxioIsldbworker = default(int?), int? utcconversiontimezonecode = default(int?), string _adoxioInvoiceValue = default(string), string _createdonbehalfbyValue = default(string), bool? adoxioCertifyinformationiscorrect = default(bool?), bool? adoxioConsenttosecurityscreening = default(bool?), int? adoxioConsentvalidated = default(int?), int? importsequencenumber = default(int?), int? statuscode = default(int?), string adoxioBirthplace = default(string), int? adoxioInvoicetrigger = default(int?), int? adoxioSecuritystatus = default(int?), string adoxioExpirydatelongdatestring = default(string), string adoxioDateofbirthshortdatestring = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? adoxioCurrentaddressdatefrom = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string adoxioEmail = default(string), string adoxioPhonenumber = default(string), string adoxioDriverslicencenumber = default(string), string _owneridValue = default(string), string _adoxioContactidValue = default(string), string adoxioFirstname = default(string), string adoxioMiddlename = default(string), string adoxioElectronicsignature = default(string), string adoxioDateofbirthlongdatestring = default(string), string _owningteamValue = default(string), string adoxioWorkerid = default(string), string _owninguserValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioExporteddate = default(System.DateTimeOffset?), int? adoxioGendercode = default(int?), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? adoxioSecuritycompletedon = default(System.DateTimeOffset?), string adoxioLastname = default(string), string _createdbyValue = default(string), int? adoxioPaymentreceived = default(int?), string adoxioName = default(string), string versionnumber = default(string), string adoxioEffectivedatelongdatestring = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> adoxioWorkerActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> adoxioWorkerAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> adoxioWorkerEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> adoxioWorkerFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> adoxioWorkerLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> adoxioWorkerPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> adoxioWorkerServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> adoxioWorkerTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> adoxioWorkerRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> adoxioWorkerSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> adoxioWorkerAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), IList<MicrosoftDynamicsCRMsyncerror> adoxioWorkerSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioWorkerDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioWorkerDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> adoxioWorkerSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMqueueitem> adoxioWorkerQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMannotation> adoxioWorkerAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioWorkerAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioWorkerMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioWorkerProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioWorkerBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioWorkerPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMcontact adoxioContactId = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMinvoice adoxioInvoice = default(MicrosoftDynamicsCRMinvoice), IList<MicrosoftDynamicsCRMadoxioWorkerinvoicehistory> adoxioWorkerAdoxioWorkerinvoicehistoryWorker = default(IList<MicrosoftDynamicsCRMadoxioWorkerinvoicehistory>), IList<MicrosoftDynamicsCRMadoxioAlias> adoxioWorkerAliases = default(IList<MicrosoftDynamicsCRMadoxioAlias>), IList<MicrosoftDynamicsCRMadoxioPreviousaddress> adoxioWorkerPreviousaddresses = default(IList<MicrosoftDynamicsCRMadoxioPreviousaddress>), IList<MicrosoftDynamicsCRMadoxioPersonalhistorysummary> adoxioWorkerregistrationPersonalhistorysummary = default(IList<MicrosoftDynamicsCRMadoxioPersonalhistorysummary>), IList<MicrosoftDynamicsCRMadoxioDocument> adoxioWorkerDocuments = default(IList<MicrosoftDynamicsCRMadoxioDocument>))
        {
            AdoxioBcidcardnumber = adoxioBcidcardnumber;
            AdoxioIsmanual = adoxioIsmanual;
            AdoxioSelfdisclosure = adoxioSelfdisclosure;
            Statecode = statecode;
            AdoxioDateofbirth = adoxioDateofbirth;
            AdoxioIslettersent = adoxioIslettersent;
            Modifiedon = modifiedon;
            Createdon = createdon;
            AdoxioPaymentreceiveddate = adoxioPaymentreceiveddate;
            AdoxioExpirydate = adoxioExpirydate;
            AdoxioTriggerphs = adoxioTriggerphs;
            AdoxioIsldbworker = adoxioIsldbworker;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._adoxioInvoiceValue = _adoxioInvoiceValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioCertifyinformationiscorrect = adoxioCertifyinformationiscorrect;
            AdoxioConsenttosecurityscreening = adoxioConsenttosecurityscreening;
            AdoxioConsentvalidated = adoxioConsentvalidated;
            Importsequencenumber = importsequencenumber;
            Statuscode = statuscode;
            AdoxioBirthplace = adoxioBirthplace;
            AdoxioInvoicetrigger = adoxioInvoicetrigger;
            AdoxioSecuritystatus = adoxioSecuritystatus;
            AdoxioExpirydatelongdatestring = adoxioExpirydatelongdatestring;
            AdoxioDateofbirthshortdatestring = adoxioDateofbirthshortdatestring;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioCurrentaddressdatefrom = adoxioCurrentaddressdatefrom;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioEmail = adoxioEmail;
            AdoxioPhonenumber = adoxioPhonenumber;
            AdoxioDriverslicencenumber = adoxioDriverslicencenumber;
            this._owneridValue = _owneridValue;
            this._adoxioContactidValue = _adoxioContactidValue;
            AdoxioFirstname = adoxioFirstname;
            AdoxioMiddlename = adoxioMiddlename;
            AdoxioElectronicsignature = adoxioElectronicsignature;
            AdoxioDateofbirthlongdatestring = adoxioDateofbirthlongdatestring;
            this._owningteamValue = _owningteamValue;
            AdoxioWorkerid = adoxioWorkerid;
            this._owninguserValue = _owninguserValue;
            Overriddencreatedon = overriddencreatedon;
            AdoxioExporteddate = adoxioExporteddate;
            AdoxioGendercode = adoxioGendercode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioSecuritycompletedon = adoxioSecuritycompletedon;
            AdoxioLastname = adoxioLastname;
            this._createdbyValue = _createdbyValue;
            AdoxioPaymentreceived = adoxioPaymentreceived;
            AdoxioName = adoxioName;
            Versionnumber = versionnumber;
            AdoxioEffectivedatelongdatestring = adoxioEffectivedatelongdatestring;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioWorkerActivityPointers = adoxioWorkerActivityPointers;
            AdoxioWorkerAppointments = adoxioWorkerAppointments;
            AdoxioWorkerEmails = adoxioWorkerEmails;
            AdoxioWorkerFaxes = adoxioWorkerFaxes;
            AdoxioWorkerLetters = adoxioWorkerLetters;
            AdoxioWorkerPhoneCalls = adoxioWorkerPhoneCalls;
            AdoxioWorkerServiceAppointments = adoxioWorkerServiceAppointments;
            AdoxioWorkerTasks = adoxioWorkerTasks;
            AdoxioWorkerRecurringAppointmentMasters = adoxioWorkerRecurringAppointmentMasters;
            AdoxioWorkerSocialActivities = adoxioWorkerSocialActivities;
            AdoxioWorkerAbsScheduledprocessexecutions = adoxioWorkerAbsScheduledprocessexecutions;
            AdoxioWorkerSyncErrors = adoxioWorkerSyncErrors;
            AdoxioWorkerDuplicateMatchingRecord = adoxioWorkerDuplicateMatchingRecord;
            AdoxioWorkerDuplicateBaseRecord = adoxioWorkerDuplicateBaseRecord;
            AdoxioWorkerSharePointDocumentLocations = adoxioWorkerSharePointDocumentLocations;
            AdoxioWorkerQueueItems = adoxioWorkerQueueItems;
            AdoxioWorkerAnnotations = adoxioWorkerAnnotations;
            AdoxioWorkerAsyncOperations = adoxioWorkerAsyncOperations;
            AdoxioWorkerMailboxTrackingFolders = adoxioWorkerMailboxTrackingFolders;
            AdoxioWorkerProcessSession = adoxioWorkerProcessSession;
            AdoxioWorkerBulkDeleteFailures = adoxioWorkerBulkDeleteFailures;
            AdoxioWorkerPrincipalObjectAttributeAccesses = adoxioWorkerPrincipalObjectAttributeAccesses;
            AdoxioContactId = adoxioContactId;
            AdoxioInvoice = adoxioInvoice;
            AdoxioWorkerAdoxioWorkerinvoicehistoryWorker = adoxioWorkerAdoxioWorkerinvoicehistoryWorker;
            AdoxioWorkerAliases = adoxioWorkerAliases;
            AdoxioWorkerPreviousaddresses = adoxioWorkerPreviousaddresses;
            AdoxioWorkerregistrationPersonalhistorysummary = adoxioWorkerregistrationPersonalhistorysummary;
            AdoxioWorkerDocuments = adoxioWorkerDocuments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_bcidcardnumber")]
        public string AdoxioBcidcardnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ismanual")]
        public int? AdoxioIsmanual { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdisclosure")]
        public int? AdoxioSelfdisclosure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofbirth")]
        public System.DateTimeOffset? AdoxioDateofbirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_islettersent")]
        public int? AdoxioIslettersent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_paymentreceiveddate")]
        public System.DateTimeOffset? AdoxioPaymentreceiveddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_expirydate")]
        public System.DateTimeOffset? AdoxioExpirydate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_triggerphs")]
        public int? AdoxioTriggerphs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isldbworker")]
        public int? AdoxioIsldbworker { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_invoice_value")]
        public string _adoxioInvoiceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_certifyinformationiscorrect")]
        public bool? AdoxioCertifyinformationiscorrect { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_consenttosecurityscreening")]
        public bool? AdoxioConsenttosecurityscreening { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_consentvalidated")]
        public int? AdoxioConsentvalidated { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_birthplace")]
        public string AdoxioBirthplace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_invoicetrigger")]
        public int? AdoxioInvoicetrigger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_securitystatus")]
        public int? AdoxioSecuritystatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_expirydatelongdatestring")]
        public string AdoxioExpirydatelongdatestring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofbirthshortdatestring")]
        public string AdoxioDateofbirthshortdatestring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_currentaddressdatefrom")]
        public System.DateTimeOffset? AdoxioCurrentaddressdatefrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_email")]
        public string AdoxioEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phonenumber")]
        public string AdoxioPhonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_driverslicencenumber")]
        public string AdoxioDriverslicencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contactid_value")]
        public string _adoxioContactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstname")]
        public string AdoxioFirstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_middlename")]
        public string AdoxioMiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_electronicsignature")]
        public string AdoxioElectronicsignature { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofbirthlongdatestring")]
        public string AdoxioDateofbirthlongdatestring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_workerid")]
        public string AdoxioWorkerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_exporteddate")]
        public System.DateTimeOffset? AdoxioExporteddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_gendercode")]
        public int? AdoxioGendercode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_securitycompletedon")]
        public System.DateTimeOffset? AdoxioSecuritycompletedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lastname")]
        public string AdoxioLastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_paymentreceived")]
        public int? AdoxioPaymentreceived { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_effectivedatelongdatestring")]
        public string AdoxioEffectivedatelongdatestring { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_worker_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> AdoxioWorkerActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> AdoxioWorkerAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_Emails")]
        public IList<MicrosoftDynamicsCRMemail> AdoxioWorkerEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> AdoxioWorkerFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_Letters")]
        public IList<MicrosoftDynamicsCRMletter> AdoxioWorkerLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> AdoxioWorkerPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> AdoxioWorkerServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> AdoxioWorkerTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> AdoxioWorkerRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> AdoxioWorkerSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> AdoxioWorkerAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioWorkerSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioWorkerDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioWorkerDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> AdoxioWorkerSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> AdoxioWorkerQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> AdoxioWorkerAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioWorkerAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioWorkerMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioWorkerProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioWorkerBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioWorkerPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ContactId")]
        public MicrosoftDynamicsCRMcontact AdoxioContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Invoice")]
        public MicrosoftDynamicsCRMinvoice AdoxioInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_adoxio_workerinvoicehistory_Worker")]
        public IList<MicrosoftDynamicsCRMadoxioWorkerinvoicehistory> AdoxioWorkerAdoxioWorkerinvoicehistoryWorker { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_aliases")]
        public IList<MicrosoftDynamicsCRMadoxioAlias> AdoxioWorkerAliases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_previousaddresses")]
        public IList<MicrosoftDynamicsCRMadoxioPreviousaddress> AdoxioWorkerPreviousaddresses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_workerregistration_personalhistorysummary")]
        public IList<MicrosoftDynamicsCRMadoxioPersonalhistorysummary> AdoxioWorkerregistrationPersonalhistorysummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_documents")]
        public IList<MicrosoftDynamicsCRMadoxioDocument> AdoxioWorkerDocuments { get; set; }

    }
}
