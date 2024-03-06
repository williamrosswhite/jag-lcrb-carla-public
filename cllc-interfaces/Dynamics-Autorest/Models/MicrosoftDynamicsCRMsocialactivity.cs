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
    /// Microsoft.Dynamics.CRM.socialactivity
    /// </summary>
    public partial class MicrosoftDynamicsCRMsocialactivity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsocialactivity class.
        /// </summary>
        public MicrosoftDynamicsCRMsocialactivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsocialactivity class.
        /// </summary>
        public MicrosoftDynamicsCRMsocialactivity(bool? directioncode = default(bool?), string posturl = default(string), System.DateTimeOffset? postedon = default(System.DateTimeOffset?), string _postfromprofileidValue = default(string), string postid = default(string), decimal? sentimentvalue = default(decimal?), string posttoprofileid = default(string), string _postauthoraccountValue = default(string), int? postmessagetype = default(int?), string threadid = default(string), string _postauthorValue = default(string), string inresponseto = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string socialadditionalparams = default(string), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingSocialactivity = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderSocialactivity = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordSocialactivity = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMmsdynPostalbum regardingobjectidMsdynPostalbumSocialactivity = default(MicrosoftDynamicsCRMmsdynPostalbum), MicrosoftDynamicsCRMabsScheduledprocess regardingobjectidAbsScheduledprocessSocialactivity = default(MicrosoftDynamicsCRMabsScheduledprocess), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplicationSocialactivity = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaintSocialactivity = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigationSocialactivity = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicencesSocialactivity = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioWorker regardingobjectidAdoxioWorkerSocialactivity = default(MicrosoftDynamicsCRMadoxioWorker), MicrosoftDynamicsCRMadoxioComplianceinvestigation regardingobjectidAdoxioComplianceinvestigationSocialactivity = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation), MicrosoftDynamicsCRMsite regardingobjectidSiteSocialactivity = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMadoxioEvent regardingobjectidAdoxioEventSocialactivity = default(MicrosoftDynamicsCRMadoxioEvent), MicrosoftDynamicsCRMadoxioEnforcementaction regardingobjectidAdoxioEnforcementactionSocialactivity = default(MicrosoftDynamicsCRMadoxioEnforcementaction), MicrosoftDynamicsCRMadoxioSpecialevent regardingobjectidAdoxioSpecialeventSocialactivity = default(MicrosoftDynamicsCRMadoxioSpecialevent), IList<MicrosoftDynamicsCRMconnection> socialactivityConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementSocialactivity = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbySocialactivity = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMincident regardingobjectidIncidentSocialactivity = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMcontact regardingobjectidContactSocialactivity = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMasyncoperation regardingobjectidAsyncoperation = default(MicrosoftDynamicsCRMasyncoperation), MicrosoftDynamicsCRMcontact postauthorContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationSocialactivity = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMsystemuser createdonbehalfbySocialactivity = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidSocialactivity = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMprocesssession> socialActivityProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderSocialactivity = default(MicrosoftDynamicsCRMsalesorder), IList<MicrosoftDynamicsCRMasyncoperation> socialActivityAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleSocialactivity = default(MicrosoftDynamicsCRMknowledgearticle), IList<MicrosoftDynamicsCRMactivityparty> socialactivityActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMquote regardingobjectidQuoteSocialactivity = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMteam owningteamSocialactivity = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMsyncerror> socialActivitySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMaccount regardingobjectidAccountSocialactivity = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMaccount postauthoraccountAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMservice serviceidSocialactivity = default(MicrosoftDynamicsCRMservice), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceSocialactivity = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateSocialactivity = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMcontact postauthoraccountContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMsystemuser createdbySocialactivity = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaSocialactivitySla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMbulkdeletefailure> socialActivityBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsocialprofile postfromprofileid = default(MicrosoftDynamicsCRMsocialprofile), MicrosoftDynamicsCRMaccount postauthorAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMlead regardingobjectidLeadSocialactivity = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMcontract regardingobjectidContractSocialactivity = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMsystemuser modifiedbySocialactivity = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMconnection> socialactivityConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMannotation> socialActivityAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMsla slainvokedidSocialactivitySla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMduplicaterecord> socialActivityDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMsystemuser owninguserSocialactivity = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> socialActivityDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMqueueitem> socialActivityQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceSocialactivity = default(MicrosoftDynamicsCRMinvoice), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> socialactivityPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMbusinessunit owningbusinessunitSocialactivity = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunitySocialactivity = default(MicrosoftDynamicsCRMopportunity))
        {
            Directioncode = directioncode;
            Posturl = posturl;
            Postedon = postedon;
            this._postfromprofileidValue = _postfromprofileidValue;
            Postid = postid;
            Sentimentvalue = sentimentvalue;
            Posttoprofileid = posttoprofileid;
            this._postauthoraccountValue = _postauthoraccountValue;
            Postmessagetype = postmessagetype;
            Threadid = threadid;
            this._postauthorValue = _postauthorValue;
            Inresponseto = inresponseto;
            Overriddencreatedon = overriddencreatedon;
            Importsequencenumber = importsequencenumber;
            Socialadditionalparams = socialadditionalparams;
            RegardingobjectidBookableresourcebookingSocialactivity = regardingobjectidBookableresourcebookingSocialactivity;
            RegardingobjectidBookableresourcebookingheaderSocialactivity = regardingobjectidBookableresourcebookingheaderSocialactivity;
            RegardingobjectidKnowledgebaserecordSocialactivity = regardingobjectidKnowledgebaserecordSocialactivity;
            RegardingobjectidMsdynPostalbumSocialactivity = regardingobjectidMsdynPostalbumSocialactivity;
            RegardingobjectidAbsScheduledprocessSocialactivity = regardingobjectidAbsScheduledprocessSocialactivity;
            RegardingobjectidAdoxioApplicationSocialactivity = regardingobjectidAdoxioApplicationSocialactivity;
            RegardingobjectidAdoxioComplaintSocialactivity = regardingobjectidAdoxioComplaintSocialactivity;
            RegardingobjectidAdoxioInvestigationSocialactivity = regardingobjectidAdoxioInvestigationSocialactivity;
            RegardingobjectidAdoxioLicencesSocialactivity = regardingobjectidAdoxioLicencesSocialactivity;
            RegardingobjectidAdoxioWorkerSocialactivity = regardingobjectidAdoxioWorkerSocialactivity;
            RegardingobjectidAdoxioComplianceinvestigationSocialactivity = regardingobjectidAdoxioComplianceinvestigationSocialactivity;
            RegardingobjectidSiteSocialactivity = regardingobjectidSiteSocialactivity;
            RegardingobjectidAdoxioEventSocialactivity = regardingobjectidAdoxioEventSocialactivity;
            RegardingobjectidAdoxioEnforcementactionSocialactivity = regardingobjectidAdoxioEnforcementactionSocialactivity;
            RegardingobjectidAdoxioSpecialeventSocialactivity = regardingobjectidAdoxioSpecialeventSocialactivity;
            SocialactivityConnections2 = socialactivityConnections2;
            RegardingobjectidEntitlementSocialactivity = regardingobjectidEntitlementSocialactivity;
            ModifiedonbehalfbySocialactivity = modifiedonbehalfbySocialactivity;
            RegardingobjectidIncidentSocialactivity = regardingobjectidIncidentSocialactivity;
            RegardingobjectidContactSocialactivity = regardingobjectidContactSocialactivity;
            RegardingobjectidAsyncoperation = regardingobjectidAsyncoperation;
            PostauthorContact = postauthorContact;
            RegardingobjectidBulkoperationSocialactivity = regardingobjectidBulkoperationSocialactivity;
            ActivityidActivitypointer = activityidActivitypointer;
            CreatedonbehalfbySocialactivity = createdonbehalfbySocialactivity;
            TransactioncurrencyidSocialactivity = transactioncurrencyidSocialactivity;
            SocialActivityProcessSessions = socialActivityProcessSessions;
            RegardingobjectidSalesorderSocialactivity = regardingobjectidSalesorderSocialactivity;
            SocialActivityAsyncOperations = socialActivityAsyncOperations;
            RegardingobjectidKnowledgearticleSocialactivity = regardingobjectidKnowledgearticleSocialactivity;
            SocialactivityActivityParties = socialactivityActivityParties;
            RegardingobjectidQuoteSocialactivity = regardingobjectidQuoteSocialactivity;
            OwningteamSocialactivity = owningteamSocialactivity;
            SocialActivitySyncErrors = socialActivitySyncErrors;
            RegardingobjectidAccountSocialactivity = regardingobjectidAccountSocialactivity;
            PostauthoraccountAccount = postauthoraccountAccount;
            ServiceidSocialactivity = serviceidSocialactivity;
            SlakpiinstanceSocialactivity = slakpiinstanceSocialactivity;
            RegardingobjectidEntitlementtemplateSocialactivity = regardingobjectidEntitlementtemplateSocialactivity;
            PostauthoraccountContact = postauthoraccountContact;
            CreatedbySocialactivity = createdbySocialactivity;
            SlaSocialactivitySla = slaSocialactivitySla;
            SocialActivityBulkDeleteFailures = socialActivityBulkDeleteFailures;
            Postfromprofileid = postfromprofileid;
            PostauthorAccount = postauthorAccount;
            RegardingobjectidLeadSocialactivity = regardingobjectidLeadSocialactivity;
            RegardingobjectidContractSocialactivity = regardingobjectidContractSocialactivity;
            ModifiedbySocialactivity = modifiedbySocialactivity;
            SocialactivityConnections1 = socialactivityConnections1;
            SocialActivityAnnotation = socialActivityAnnotation;
            SlainvokedidSocialactivitySla = slainvokedidSocialactivitySla;
            SocialActivityDuplicateBaseRecord = socialActivityDuplicateBaseRecord;
            OwninguserSocialactivity = owninguserSocialactivity;
            SocialActivityDuplicateMatchingRecord = socialActivityDuplicateMatchingRecord;
            SocialActivityQueueItem = socialActivityQueueItem;
            RegardingobjectidInvoiceSocialactivity = regardingobjectidInvoiceSocialactivity;
            SocialactivityPrincipalobjectattributeaccess = socialactivityPrincipalobjectattributeaccess;
            OwningbusinessunitSocialactivity = owningbusinessunitSocialactivity;
            RegardingobjectidOpportunitySocialactivity = regardingobjectidOpportunitySocialactivity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "directioncode")]
        public bool? Directioncode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "posturl")]
        public string Posturl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postedon")]
        public System.DateTimeOffset? Postedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_postfromprofileid_value")]
        public string _postfromprofileidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postid")]
        public string Postid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sentimentvalue")]
        public decimal? Sentimentvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "posttoprofileid")]
        public string Posttoprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_postauthoraccount_value")]
        public string _postauthoraccountValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postmessagetype")]
        public int? Postmessagetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "threadid")]
        public string Threadid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_postauthor_value")]
        public string _postauthorValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inresponseto")]
        public string Inresponseto { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "socialadditionalparams")]
        public string Socialadditionalparams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_socialactivity")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_socialactivity")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_socialactivity")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_msdyn_postalbum_socialactivity")]
        public MicrosoftDynamicsCRMmsdynPostalbum RegardingobjectidMsdynPostalbumSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_abs_scheduledprocess_socialactivity")]
        public MicrosoftDynamicsCRMabsScheduledprocess RegardingobjectidAbsScheduledprocessSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_application_socialactivity")]
        public MicrosoftDynamicsCRMadoxioApplication RegardingobjectidAdoxioApplicationSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complaint_socialactivity")]
        public MicrosoftDynamicsCRMadoxioComplaint RegardingobjectidAdoxioComplaintSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigation_socialactivity")]
        public MicrosoftDynamicsCRMadoxioInvestigation RegardingobjectidAdoxioInvestigationSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_licences_socialactivity")]
        public MicrosoftDynamicsCRMadoxioLicences RegardingobjectidAdoxioLicencesSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_worker_socialactivity")]
        public MicrosoftDynamicsCRMadoxioWorker RegardingobjectidAdoxioWorkerSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complianceinvestigation_socialactivity")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation RegardingobjectidAdoxioComplianceinvestigationSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_site_socialactivity")]
        public MicrosoftDynamicsCRMsite RegardingobjectidSiteSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_event_socialactivity")]
        public MicrosoftDynamicsCRMadoxioEvent RegardingobjectidAdoxioEventSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_enforcementaction_socialactivity")]
        public MicrosoftDynamicsCRMadoxioEnforcementaction RegardingobjectidAdoxioEnforcementactionSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_specialevent_socialactivity")]
        public MicrosoftDynamicsCRMadoxioSpecialevent RegardingobjectidAdoxioSpecialeventSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "socialactivity_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> SocialactivityConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_socialactivity")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_socialactivity")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbySocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_socialactivity")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_socialactivity")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_asyncoperation")]
        public MicrosoftDynamicsCRMasyncoperation RegardingobjectidAsyncoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postauthor_contact")]
        public MicrosoftDynamicsCRMcontact PostauthorContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_socialactivity")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_socialactivity")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbySocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_socialactivity")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SocialActivity_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> SocialActivityProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_socialactivity")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SocialActivity_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SocialActivityAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_socialactivity")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "socialactivity_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> SocialactivityActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_socialactivity")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_socialactivity")]
        public MicrosoftDynamicsCRMteam OwningteamSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SocialActivity_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SocialActivitySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_socialactivity")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postauthoraccount_account")]
        public MicrosoftDynamicsCRMaccount PostauthoraccountAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_socialactivity")]
        public MicrosoftDynamicsCRMservice ServiceidSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_socialactivity")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_socialactivity")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postauthoraccount_contact")]
        public MicrosoftDynamicsCRMcontact PostauthoraccountContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_socialactivity")]
        public MicrosoftDynamicsCRMsystemuser CreatedbySocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_socialactivity_sla")]
        public MicrosoftDynamicsCRMsla SlaSocialactivitySla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SocialActivity_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SocialActivityBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postfromprofileid")]
        public MicrosoftDynamicsCRMsocialprofile Postfromprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postauthor_account")]
        public MicrosoftDynamicsCRMaccount PostauthorAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_socialactivity")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_socialactivity")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_socialactivity")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbySocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "socialactivity_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> SocialactivityConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SocialActivity_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> SocialActivityAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_socialactivity_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidSocialactivitySla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SocialActivity_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SocialActivityDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_socialactivity")]
        public MicrosoftDynamicsCRMsystemuser OwninguserSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SocialActivity_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SocialActivityDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SocialActivity_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> SocialActivityQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_socialactivity")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "socialactivity_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SocialactivityPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_socialactivity")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_socialactivity")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunitySocialactivity { get; set; }

    }
}
