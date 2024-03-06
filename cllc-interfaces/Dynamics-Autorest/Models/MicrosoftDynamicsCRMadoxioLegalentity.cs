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
    /// Microsoft.Dynamics.CRM.adoxio_legalentity
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioLegalentity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLegalentity class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLegalentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLegalentity class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLegalentity(bool? adoxioIstrustee = default(bool?), string _adoxioLegalentityownedValue = default(string), int? adoxioGendercode = default(int?), decimal? adoxioInterestpercentage = default(decimal?), int? adoxioPartnertype = default(int?), System.DateTimeOffset? adoxioDateofappointment = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string adoxioBcidcardnumber = default(string), bool? adoxioIsdirector = default(bool?), decimal? adoxioAnnualmembershipfee = default(decimal?), bool? adoxioIsdonotsendtospd = default(bool?), string adoxioInstructionsoninsertform = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), bool? adoxioIsshareholder = default(bool?), string _owningbusinessunitValue = default(string), int? adoxioSelfdisclosure = default(int?), string adoxioName = default(string), string _adoxioCorrespondingpersonalhistorysummaryValue = default(string), int? adoxioPreferredvotingshares = default(int?), bool? adoxioIspartner = default(bool?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? adoxioDateemailsent = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioSelfdeclaredlicencecapdate = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioSelfdeclaredtiedhousedate = default(System.DateTimeOffset?), int? adoxioLegalentitytype = default(int?), bool? adoxioSameastheapplyingperson = default(bool?), string _owninguserValue = default(string), int? adoxioNumberofmembers = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? adoxioSelfdeclaredtiedhouse = default(int?), string adoxioFirstname = default(string), string versionnumber = default(string), string _adoxioRelatedlicenceValue = default(string), int? adoxioPosition = default(int?), System.DateTimeOffset? adoxioIncorporationdate = default(System.DateTimeOffset?), string _adoxioShareholderaccountidValue = default(string), string adoxioPhonenumber = default(string), int? adoxioCommonvotingshares = default(int?), string _adoxioProfilenameValue = default(string), string adoxioExternalid = default(string), string adoxioJobtitle = default(string), System.DateTimeOffset? adoxioDateofsharesissued = default(System.DateTimeOffset?), int? adoxioIsindividual = default(int?), bool? adoxioIsapplicant = default(bool?), int? adoxioPreferrednonvotingshares = default(int?), bool? adoxioIsofficer = default(bool?), int? statuscode = default(int?), string adoxioBirthplace = default(string), string adoxioMiddlename = default(string), bool? adoxioIskeypersonnel = default(bool?), int? statecode = default(int?), string _createdonbehalfbyValue = default(string), string _adoxioRelatedapplicationValue = default(string), string adoxioOtherlegalentitytype = default(string), string adoxioLastname = default(string), string _createdbyValue = default(string), bool? adoxioIsdeemedassociate = default(bool?), bool? adoxioIsowner = default(bool?), int? adoxioCommonnonvotingshares = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioSharepointanchor = default(string), string _modifiedbyValue = default(string), int? adoxioSameasapplyingperson = default(int?), int? adoxioTotalcompanyshares = default(int?), string adoxioDriverslicencenumber = default(string), int? adoxioSelfdeclaredlicencecap = default(int?), string _modifiedonbehalfbyValue = default(string), int? adoxioTotalshares = default(int?), int? adoxioAssociatedecisionby = default(int?), bool? adoxioIsseniormanagement = default(bool?), string _adoxioContactValue = default(string), string _adoxioAccountValue = default(string), string adoxioEmail = default(string), bool? adoxioIswithdrawn = default(bool?), string _owningteamValue = default(string), System.DateTimeOffset? adoxioDateofbirth = default(System.DateTimeOffset?), string _owneridValue = default(string), string adoxioLegalentityid = default(string), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioLegalentitySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLegalentityDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLegalentityDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> adoxioLegalentitySharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioLegalentityAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioLegalentityMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioLegalentityProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioLegalentityBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioLegalentityPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMaccount adoxioAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMaccount adoxioProfileNameAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMaccount adoxioShareholderAccountID = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMadoxioApplication adoxioRelatedApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioLegalentity adoxioLegalEntityOwned = default(MicrosoftDynamicsCRMadoxioLegalentity), IList<MicrosoftDynamicsCRMadoxioLegalentity> adoxioAdoxioLegalentityAdoxioLegalentityLegalEntityOwned = default(IList<MicrosoftDynamicsCRMadoxioLegalentity>), MicrosoftDynamicsCRMadoxioLicences adoxioRelatedLicence = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioPersonalhistorysummary adoxioCorrespondingPersonalHistorySummary = default(MicrosoftDynamicsCRMadoxioPersonalhistorysummary), MicrosoftDynamicsCRMcontact adoxioContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMcontact adoxioProfileNameContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMadoxioPreviousaddress> adoxioLegalentityAdoxioPreviousaddressLegalEntityId = default(IList<MicrosoftDynamicsCRMadoxioPreviousaddress>), IList<MicrosoftDynamicsCRMadoxioAlias> adoxioLegalentityAliases = default(IList<MicrosoftDynamicsCRMadoxioAlias>), IList<MicrosoftDynamicsCRMadoxioPersonalhistorysummary> adoxioLegalentityPersonalhistorysummaries = default(IList<MicrosoftDynamicsCRMadoxioPersonalhistorysummary>), IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> adoxioParentlegalentityChangelogs = default(IList<MicrosoftDynamicsCRMadoxioLicenseechangelog>), IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> adoxioLegalentityChangelogs = default(IList<MicrosoftDynamicsCRMadoxioLicenseechangelog>), IList<MicrosoftDynamicsCRMtask> adoxioLegalentityTaskLegalEntity = default(IList<MicrosoftDynamicsCRMtask>))
        {
            AdoxioIstrustee = adoxioIstrustee;
            this._adoxioLegalentityownedValue = _adoxioLegalentityownedValue;
            AdoxioGendercode = adoxioGendercode;
            AdoxioInterestpercentage = adoxioInterestpercentage;
            AdoxioPartnertype = adoxioPartnertype;
            AdoxioDateofappointment = adoxioDateofappointment;
            Importsequencenumber = importsequencenumber;
            AdoxioBcidcardnumber = adoxioBcidcardnumber;
            AdoxioIsdirector = adoxioIsdirector;
            AdoxioAnnualmembershipfee = adoxioAnnualmembershipfee;
            AdoxioIsdonotsendtospd = adoxioIsdonotsendtospd;
            AdoxioInstructionsoninsertform = adoxioInstructionsoninsertform;
            Createdon = createdon;
            AdoxioIsshareholder = adoxioIsshareholder;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioSelfdisclosure = adoxioSelfdisclosure;
            AdoxioName = adoxioName;
            this._adoxioCorrespondingpersonalhistorysummaryValue = _adoxioCorrespondingpersonalhistorysummaryValue;
            AdoxioPreferredvotingshares = adoxioPreferredvotingshares;
            AdoxioIspartner = adoxioIspartner;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioDateemailsent = adoxioDateemailsent;
            AdoxioSelfdeclaredlicencecapdate = adoxioSelfdeclaredlicencecapdate;
            AdoxioSelfdeclaredtiedhousedate = adoxioSelfdeclaredtiedhousedate;
            AdoxioLegalentitytype = adoxioLegalentitytype;
            AdoxioSameastheapplyingperson = adoxioSameastheapplyingperson;
            this._owninguserValue = _owninguserValue;
            AdoxioNumberofmembers = adoxioNumberofmembers;
            Overriddencreatedon = overriddencreatedon;
            AdoxioSelfdeclaredtiedhouse = adoxioSelfdeclaredtiedhouse;
            AdoxioFirstname = adoxioFirstname;
            Versionnumber = versionnumber;
            this._adoxioRelatedlicenceValue = _adoxioRelatedlicenceValue;
            AdoxioPosition = adoxioPosition;
            AdoxioIncorporationdate = adoxioIncorporationdate;
            this._adoxioShareholderaccountidValue = _adoxioShareholderaccountidValue;
            AdoxioPhonenumber = adoxioPhonenumber;
            AdoxioCommonvotingshares = adoxioCommonvotingshares;
            this._adoxioProfilenameValue = _adoxioProfilenameValue;
            AdoxioExternalid = adoxioExternalid;
            AdoxioJobtitle = adoxioJobtitle;
            AdoxioDateofsharesissued = adoxioDateofsharesissued;
            AdoxioIsindividual = adoxioIsindividual;
            AdoxioIsapplicant = adoxioIsapplicant;
            AdoxioPreferrednonvotingshares = adoxioPreferrednonvotingshares;
            AdoxioIsofficer = adoxioIsofficer;
            Statuscode = statuscode;
            AdoxioBirthplace = adoxioBirthplace;
            AdoxioMiddlename = adoxioMiddlename;
            AdoxioIskeypersonnel = adoxioIskeypersonnel;
            Statecode = statecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._adoxioRelatedapplicationValue = _adoxioRelatedapplicationValue;
            AdoxioOtherlegalentitytype = adoxioOtherlegalentitytype;
            AdoxioLastname = adoxioLastname;
            this._createdbyValue = _createdbyValue;
            AdoxioIsdeemedassociate = adoxioIsdeemedassociate;
            AdoxioIsowner = adoxioIsowner;
            AdoxioCommonnonvotingshares = adoxioCommonnonvotingshares;
            Modifiedon = modifiedon;
            AdoxioSharepointanchor = adoxioSharepointanchor;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioSameasapplyingperson = adoxioSameasapplyingperson;
            AdoxioTotalcompanyshares = adoxioTotalcompanyshares;
            AdoxioDriverslicencenumber = adoxioDriverslicencenumber;
            AdoxioSelfdeclaredlicencecap = adoxioSelfdeclaredlicencecap;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioTotalshares = adoxioTotalshares;
            AdoxioAssociatedecisionby = adoxioAssociatedecisionby;
            AdoxioIsseniormanagement = adoxioIsseniormanagement;
            this._adoxioContactValue = _adoxioContactValue;
            this._adoxioAccountValue = _adoxioAccountValue;
            AdoxioEmail = adoxioEmail;
            AdoxioIswithdrawn = adoxioIswithdrawn;
            this._owningteamValue = _owningteamValue;
            AdoxioDateofbirth = adoxioDateofbirth;
            this._owneridValue = _owneridValue;
            AdoxioLegalentityid = adoxioLegalentityid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioLegalentitySyncErrors = adoxioLegalentitySyncErrors;
            AdoxioLegalentityDuplicateMatchingRecord = adoxioLegalentityDuplicateMatchingRecord;
            AdoxioLegalentityDuplicateBaseRecord = adoxioLegalentityDuplicateBaseRecord;
            AdoxioLegalentitySharePointDocumentLocations = adoxioLegalentitySharePointDocumentLocations;
            AdoxioLegalentityAsyncOperations = adoxioLegalentityAsyncOperations;
            AdoxioLegalentityMailboxTrackingFolders = adoxioLegalentityMailboxTrackingFolders;
            AdoxioLegalentityProcessSession = adoxioLegalentityProcessSession;
            AdoxioLegalentityBulkDeleteFailures = adoxioLegalentityBulkDeleteFailures;
            AdoxioLegalentityPrincipalObjectAttributeAccesses = adoxioLegalentityPrincipalObjectAttributeAccesses;
            AdoxioAccount = adoxioAccount;
            AdoxioProfileNameAccount = adoxioProfileNameAccount;
            AdoxioShareholderAccountID = adoxioShareholderAccountID;
            AdoxioRelatedApplication = adoxioRelatedApplication;
            AdoxioLegalEntityOwned = adoxioLegalEntityOwned;
            AdoxioAdoxioLegalentityAdoxioLegalentityLegalEntityOwned = adoxioAdoxioLegalentityAdoxioLegalentityLegalEntityOwned;
            AdoxioRelatedLicence = adoxioRelatedLicence;
            AdoxioCorrespondingPersonalHistorySummary = adoxioCorrespondingPersonalHistorySummary;
            AdoxioContact = adoxioContact;
            AdoxioProfileNameContact = adoxioProfileNameContact;
            AdoxioLegalentityAdoxioPreviousaddressLegalEntityId = adoxioLegalentityAdoxioPreviousaddressLegalEntityId;
            AdoxioLegalentityAliases = adoxioLegalentityAliases;
            AdoxioLegalentityPersonalhistorysummaries = adoxioLegalentityPersonalhistorysummaries;
            AdoxioParentlegalentityChangelogs = adoxioParentlegalentityChangelogs;
            AdoxioLegalentityChangelogs = adoxioLegalentityChangelogs;
            AdoxioLegalentityTaskLegalEntity = adoxioLegalentityTaskLegalEntity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_istrustee")]
        public bool? AdoxioIstrustee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_legalentityowned_value")]
        public string _adoxioLegalentityownedValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_gendercode")]
        public int? AdoxioGendercode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interestpercentage")]
        public decimal? AdoxioInterestpercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_partnertype")]
        public int? AdoxioPartnertype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofappointment")]
        public System.DateTimeOffset? AdoxioDateofappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_bcidcardnumber")]
        public string AdoxioBcidcardnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isdirector")]
        public bool? AdoxioIsdirector { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualmembershipfee")]
        public decimal? AdoxioAnnualmembershipfee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isdonotsendtospd")]
        public bool? AdoxioIsdonotsendtospd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_instructionsoninsertform")]
        public string AdoxioInstructionsoninsertform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshareholder")]
        public bool? AdoxioIsshareholder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdisclosure")]
        public int? AdoxioSelfdisclosure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_correspondingpersonalhistorysummary_value")]
        public string _adoxioCorrespondingpersonalhistorysummaryValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_preferredvotingshares")]
        public int? AdoxioPreferredvotingshares { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ispartner")]
        public bool? AdoxioIspartner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateemailsent")]
        public System.DateTimeOffset? AdoxioDateemailsent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdeclaredlicencecapdate")]
        public System.DateTimeOffset? AdoxioSelfdeclaredlicencecapdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdeclaredtiedhousedate")]
        public System.DateTimeOffset? AdoxioSelfdeclaredtiedhousedate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentitytype")]
        public int? AdoxioLegalentitytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sameastheapplyingperson")]
        public bool? AdoxioSameastheapplyingperson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_numberofmembers")]
        public int? AdoxioNumberofmembers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdeclaredtiedhouse")]
        public int? AdoxioSelfdeclaredtiedhouse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstname")]
        public string AdoxioFirstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_relatedlicence_value")]
        public string _adoxioRelatedlicenceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_position")]
        public int? AdoxioPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_incorporationdate")]
        public System.DateTimeOffset? AdoxioIncorporationdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_shareholderaccountid_value")]
        public string _adoxioShareholderaccountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phonenumber")]
        public string AdoxioPhonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_commonvotingshares")]
        public int? AdoxioCommonvotingshares { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_profilename_value")]
        public string _adoxioProfilenameValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_externalid")]
        public string AdoxioExternalid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_jobtitle")]
        public string AdoxioJobtitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofsharesissued")]
        public System.DateTimeOffset? AdoxioDateofsharesissued { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isindividual")]
        public int? AdoxioIsindividual { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isapplicant")]
        public bool? AdoxioIsapplicant { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_preferrednonvotingshares")]
        public int? AdoxioPreferrednonvotingshares { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isofficer")]
        public bool? AdoxioIsofficer { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_middlename")]
        public string AdoxioMiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iskeypersonnel")]
        public bool? AdoxioIskeypersonnel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_relatedapplication_value")]
        public string _adoxioRelatedapplicationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_otherlegalentitytype")]
        public string AdoxioOtherlegalentitytype { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_isdeemedassociate")]
        public bool? AdoxioIsdeemedassociate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isowner")]
        public bool? AdoxioIsowner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_commonnonvotingshares")]
        public int? AdoxioCommonnonvotingshares { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sharepointanchor")]
        public string AdoxioSharepointanchor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sameasapplyingperson")]
        public int? AdoxioSameasapplyingperson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_totalcompanyshares")]
        public int? AdoxioTotalcompanyshares { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_driverslicencenumber")]
        public string AdoxioDriverslicencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdeclaredlicencecap")]
        public int? AdoxioSelfdeclaredlicencecap { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_totalshares")]
        public int? AdoxioTotalshares { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_associatedecisionby")]
        public int? AdoxioAssociatedecisionby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isseniormanagement")]
        public bool? AdoxioIsseniormanagement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contact_value")]
        public string _adoxioContactValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_account_value")]
        public string _adoxioAccountValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_email")]
        public string AdoxioEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iswithdrawn")]
        public bool? AdoxioIswithdrawn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofbirth")]
        public System.DateTimeOffset? AdoxioDateofbirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentityid")]
        public string AdoxioLegalentityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_legalentity_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioLegalentitySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLegalentityDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLegalentityDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> AdoxioLegalentitySharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioLegalentityAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioLegalentityMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioLegalentityProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioLegalentityBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioLegalentityPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Account")]
        public MicrosoftDynamicsCRMaccount AdoxioAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ProfileName_account")]
        public MicrosoftDynamicsCRMaccount AdoxioProfileNameAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ShareholderAccountID")]
        public MicrosoftDynamicsCRMaccount AdoxioShareholderAccountID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RelatedApplication")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioRelatedApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LegalEntityOwned")]
        public MicrosoftDynamicsCRMadoxioLegalentity AdoxioLegalEntityOwned { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_legalentity_adoxio_legalentity_LegalEntityOwned")]
        public IList<MicrosoftDynamicsCRMadoxioLegalentity> AdoxioAdoxioLegalentityAdoxioLegalentityLegalEntityOwned { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RelatedLicence")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioRelatedLicence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_CorrespondingPersonalHistorySummary")]
        public MicrosoftDynamicsCRMadoxioPersonalhistorysummary AdoxioCorrespondingPersonalHistorySummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Contact")]
        public MicrosoftDynamicsCRMcontact AdoxioContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ProfileName_contact")]
        public MicrosoftDynamicsCRMcontact AdoxioProfileNameContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_adoxio_previousaddress_LegalEntityId")]
        public IList<MicrosoftDynamicsCRMadoxioPreviousaddress> AdoxioLegalentityAdoxioPreviousaddressLegalEntityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_aliases")]
        public IList<MicrosoftDynamicsCRMadoxioAlias> AdoxioLegalentityAliases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_personalhistorysummaries")]
        public IList<MicrosoftDynamicsCRMadoxioPersonalhistorysummary> AdoxioLegalentityPersonalhistorysummaries { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_parentlegalentity_changelogs")]
        public IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> AdoxioParentlegalentityChangelogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_changelogs")]
        public IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> AdoxioLegalentityChangelogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_task_LegalEntity")]
        public IList<MicrosoftDynamicsCRMtask> AdoxioLegalentityTaskLegalEntity { get; set; }

    }
}
