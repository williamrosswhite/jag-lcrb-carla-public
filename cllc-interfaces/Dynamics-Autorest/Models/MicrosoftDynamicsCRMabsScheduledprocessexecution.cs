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
    /// Microsoft.Dynamics.CRM.abs_scheduledprocessexecution
    /// </summary>
    public partial class MicrosoftDynamicsCRMabsScheduledprocessexecution
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMabsScheduledprocessexecution class.
        /// </summary>
        public MicrosoftDynamicsCRMabsScheduledprocessexecution()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMabsScheduledprocessexecution class.
        /// </summary>
        public MicrosoftDynamicsCRMabsScheduledprocessexecution(int? importsequencenumber = default(int?), int? absRecordsprocessed = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemailAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMmsdynPostalbum regardingobjectidMsdynPostalbumAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMmsdynPostalbum), MicrosoftDynamicsCRMabsScheduledprocess regardingobjectidAbsScheduledprocessAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMabsScheduledprocess), MicrosoftDynamicsCRMaccount regardingobjectidAccountAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontract regardingobjectidContractAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMsystemuser createdbyAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact regardingobjectidContactAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMmailbox sendermailboxidAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMprincipal owneridAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMsystemuser owninguserAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaActivitypointerSlaAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMbusinessunit owningbusinessunitAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMquote regardingobjectidQuoteAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMlead regardingobjectidLeadAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMservice serviceidAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMincident regardingobjectidIncidentAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMteam owningteamAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSlaAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMactivitypointer activityidAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMactivityparty> absScheduledprocessexecutionActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMcampaignresponse> campaignResponseAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMactioncard> absScheduledprocessexecutionActionCards = default(IList<MicrosoftDynamicsCRMactioncard>), IList<MicrosoftDynamicsCRMsyncerror> absScheduledprocessexecutionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMconnection> absScheduledprocessexecutionConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> absScheduledprocessexecutionConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMqueueitem> absScheduledprocessexecutionQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMannotation> absScheduledprocessexecutionAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMfeedback> absScheduledprocessexecutionFeedback = default(IList<MicrosoftDynamicsCRMfeedback>), IList<MicrosoftDynamicsCRMasyncoperation> absScheduledprocessexecutionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> absScheduledprocessexecutionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> absScheduledprocessexecutionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> absScheduledprocessexecutionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> absScheduledprocessexecutionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplicationAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaintAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigationAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicencesAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioWorker regardingobjectidAdoxioWorkerAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMadoxioWorker), MicrosoftDynamicsCRMadoxioComplianceinvestigation regardingobjectidAdoxioComplianceinvestigationAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation), MicrosoftDynamicsCRMsite regardingobjectidSiteAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMadoxioEvent regardingobjectidAdoxioEventAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMadoxioEvent))
        {
            Importsequencenumber = importsequencenumber;
            AbsRecordsprocessed = absRecordsprocessed;
            Overriddencreatedon = overriddencreatedon;
            RegardingobjectidNewInteractionforemailAbsScheduledprocessexecution = regardingobjectidNewInteractionforemailAbsScheduledprocessexecution;
            RegardingobjectidEntitlementAbsScheduledprocessexecution = regardingobjectidEntitlementAbsScheduledprocessexecution;
            RegardingobjectidEntitlementtemplateAbsScheduledprocessexecution = regardingobjectidEntitlementtemplateAbsScheduledprocessexecution;
            RegardingobjectidBookableresourcebookingAbsScheduledprocessexecution = regardingobjectidBookableresourcebookingAbsScheduledprocessexecution;
            RegardingobjectidBookableresourcebookingheaderAbsScheduledprocessexecution = regardingobjectidBookableresourcebookingheaderAbsScheduledprocessexecution;
            RegardingobjectidKnowledgebaserecordAbsScheduledprocessexecution = regardingobjectidKnowledgebaserecordAbsScheduledprocessexecution;
            RegardingobjectidMsdynPostalbumAbsScheduledprocessexecution = regardingobjectidMsdynPostalbumAbsScheduledprocessexecution;
            RegardingobjectidAbsScheduledprocessAbsScheduledprocessexecution = regardingobjectidAbsScheduledprocessAbsScheduledprocessexecution;
            RegardingobjectidAccountAbsScheduledprocessexecution = regardingobjectidAccountAbsScheduledprocessexecution;
            RegardingobjectidContractAbsScheduledprocessexecution = regardingobjectidContractAbsScheduledprocessexecution;
            CreatedbyAbsScheduledprocessexecution = createdbyAbsScheduledprocessexecution;
            RegardingobjectidContactAbsScheduledprocessexecution = regardingobjectidContactAbsScheduledprocessexecution;
            SendermailboxidAbsScheduledprocessexecution = sendermailboxidAbsScheduledprocessexecution;
            TransactioncurrencyidAbsScheduledprocessexecution = transactioncurrencyidAbsScheduledprocessexecution;
            RegardingobjectidSalesorderAbsScheduledprocessexecution = regardingobjectidSalesorderAbsScheduledprocessexecution;
            OwneridAbsScheduledprocessexecution = owneridAbsScheduledprocessexecution;
            RegardingobjectidOpportunityAbsScheduledprocessexecution = regardingobjectidOpportunityAbsScheduledprocessexecution;
            OwninguserAbsScheduledprocessexecution = owninguserAbsScheduledprocessexecution;
            SlaActivitypointerSlaAbsScheduledprocessexecution = slaActivitypointerSlaAbsScheduledprocessexecution;
            RegardingobjectidInvoiceAbsScheduledprocessexecution = regardingobjectidInvoiceAbsScheduledprocessexecution;
            OwningbusinessunitAbsScheduledprocessexecution = owningbusinessunitAbsScheduledprocessexecution;
            RegardingobjectidKnowledgearticleAbsScheduledprocessexecution = regardingobjectidKnowledgearticleAbsScheduledprocessexecution;
            RegardingobjectidQuoteAbsScheduledprocessexecution = regardingobjectidQuoteAbsScheduledprocessexecution;
            RegardingobjectidLeadAbsScheduledprocessexecution = regardingobjectidLeadAbsScheduledprocessexecution;
            ModifiedonbehalfbyAbsScheduledprocessexecution = modifiedonbehalfbyAbsScheduledprocessexecution;
            CreatedonbehalfbyAbsScheduledprocessexecution = createdonbehalfbyAbsScheduledprocessexecution;
            ModifiedbyAbsScheduledprocessexecution = modifiedbyAbsScheduledprocessexecution;
            RegardingobjectidBulkoperationAbsScheduledprocessexecution = regardingobjectidBulkoperationAbsScheduledprocessexecution;
            ServiceidAbsScheduledprocessexecution = serviceidAbsScheduledprocessexecution;
            RegardingobjectidIncidentAbsScheduledprocessexecution = regardingobjectidIncidentAbsScheduledprocessexecution;
            RegardingobjectidCampaignAbsScheduledprocessexecution = regardingobjectidCampaignAbsScheduledprocessexecution;
            OwningteamAbsScheduledprocessexecution = owningteamAbsScheduledprocessexecution;
            RegardingobjectidCampaignactivityAbsScheduledprocessexecution = regardingobjectidCampaignactivityAbsScheduledprocessexecution;
            SlainvokedidActivitypointerSlaAbsScheduledprocessexecution = slainvokedidActivitypointerSlaAbsScheduledprocessexecution;
            ActivityidAbsScheduledprocessexecution = activityidAbsScheduledprocessexecution;
            AbsScheduledprocessexecutionActivityParties = absScheduledprocessexecutionActivityParties;
            CampaignResponseAbsScheduledprocessexecutions = campaignResponseAbsScheduledprocessexecutions;
            AbsScheduledprocessexecutionActionCards = absScheduledprocessexecutionActionCards;
            AbsScheduledprocessexecutionSyncErrors = absScheduledprocessexecutionSyncErrors;
            AbsScheduledprocessexecutionConnections1 = absScheduledprocessexecutionConnections1;
            AbsScheduledprocessexecutionConnections2 = absScheduledprocessexecutionConnections2;
            AbsScheduledprocessexecutionQueueItems = absScheduledprocessexecutionQueueItems;
            AbsScheduledprocessexecutionAnnotations = absScheduledprocessexecutionAnnotations;
            AbsScheduledprocessexecutionFeedback = absScheduledprocessexecutionFeedback;
            AbsScheduledprocessexecutionAsyncOperations = absScheduledprocessexecutionAsyncOperations;
            AbsScheduledprocessexecutionMailboxTrackingFolders = absScheduledprocessexecutionMailboxTrackingFolders;
            AbsScheduledprocessexecutionProcessSession = absScheduledprocessexecutionProcessSession;
            AbsScheduledprocessexecutionBulkDeleteFailures = absScheduledprocessexecutionBulkDeleteFailures;
            AbsScheduledprocessexecutionPrincipalObjectAttributeAccesses = absScheduledprocessexecutionPrincipalObjectAttributeAccesses;
            RegardingobjectidAdoxioApplicationAbsScheduledprocessexecution = regardingobjectidAdoxioApplicationAbsScheduledprocessexecution;
            RegardingobjectidAdoxioComplaintAbsScheduledprocessexecution = regardingobjectidAdoxioComplaintAbsScheduledprocessexecution;
            RegardingobjectidAdoxioInvestigationAbsScheduledprocessexecution = regardingobjectidAdoxioInvestigationAbsScheduledprocessexecution;
            RegardingobjectidAdoxioLicencesAbsScheduledprocessexecution = regardingobjectidAdoxioLicencesAbsScheduledprocessexecution;
            RegardingobjectidAdoxioWorkerAbsScheduledprocessexecution = regardingobjectidAdoxioWorkerAbsScheduledprocessexecution;
            RegardingobjectidAdoxioComplianceinvestigationAbsScheduledprocessexecution = regardingobjectidAdoxioComplianceinvestigationAbsScheduledprocessexecution;
            RegardingobjectidSiteAbsScheduledprocessexecution = regardingobjectidSiteAbsScheduledprocessexecution;
            RegardingobjectidAdoxioEventAbsScheduledprocessexecution = regardingobjectidAdoxioEventAbsScheduledprocessexecution;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_recordsprocessed")]
        public int? AbsRecordsprocessed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_new_interactionforemail_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMinteractionforemail RegardingobjectidNewInteractionforemailAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_msdyn_postalbum_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMmsdynPostalbum RegardingobjectidMsdynPostalbumAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_abs_scheduledprocess_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMabsScheduledprocess RegardingobjectidAbsScheduledprocessAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendermailboxid_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMmailbox SendermailboxidAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMprincipal OwneridAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMsystemuser OwninguserAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_activitypointer_sla_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMsla SlaActivitypointerSlaAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMservice ServiceidAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMteam OwningteamAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_activitypointer_sla_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMsla SlainvokedidActivitypointerSlaAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> AbsScheduledprocessexecutionActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignResponse_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> CampaignResponseAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_ActionCards")]
        public IList<MicrosoftDynamicsCRMactioncard> AbsScheduledprocessexecutionActionCards { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AbsScheduledprocessexecutionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> AbsScheduledprocessexecutionConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> AbsScheduledprocessexecutionConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> AbsScheduledprocessexecutionQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> AbsScheduledprocessexecutionAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_Feedback")]
        public IList<MicrosoftDynamicsCRMfeedback> AbsScheduledprocessexecutionFeedback { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AbsScheduledprocessexecutionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AbsScheduledprocessexecutionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AbsScheduledprocessexecutionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AbsScheduledprocessexecutionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AbsScheduledprocessexecutionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_application_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMadoxioApplication RegardingobjectidAdoxioApplicationAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complaint_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMadoxioComplaint RegardingobjectidAdoxioComplaintAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigation_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMadoxioInvestigation RegardingobjectidAdoxioInvestigationAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_licences_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMadoxioLicences RegardingobjectidAdoxioLicencesAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_worker_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMadoxioWorker RegardingobjectidAdoxioWorkerAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complianceinvestigation_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation RegardingobjectidAdoxioComplianceinvestigationAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_site_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMsite RegardingobjectidSiteAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_event_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMadoxioEvent RegardingobjectidAdoxioEventAbsScheduledprocessexecution { get; set; }

    }
}
