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
    /// Microsoft.Dynamics.CRM.quoteclose
    /// </summary>
    public partial class MicrosoftDynamicsCRMquoteclose
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMquoteclose
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMquoteclose()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMquoteclose
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMquoteclose(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string subcategory = default(string), string category = default(string), int? importsequencenumber = default(int?), int? revision = default(int?), string quotenumber = default(string), string _quoteidValue = default(string), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyQuoteclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemailQuoteclose = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementQuoteclose = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateQuoteclose = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingQuoteclose = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderQuoteclose = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordQuoteclose = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMsite regardingobjectidSiteQuoteclose = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMaccount regardingobjectidAccountQuoteclose = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMmailbox sendermailboxidQuoteclose = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidQuoteclose = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMprincipal owneridQuoteclose = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityQuoteclose = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMsla slaActivitypointerSlaQuoteclose = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleQuoteclose = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMquote regardingobjectidQuoteQuoteclose = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMlead regardingobjectidLeadQuoteclose = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationQuoteclose = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMincident regardingobjectidIncidentQuoteclose = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignQuoteclose = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityQuoteclose = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSlaQuoteclose = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMcampaignresponse> campaignResponseQuoteCloses = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMteam> quotecloseTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> quotecloseMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> quoteclosePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMservice serviceidQuoteclose = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMquote quoteid = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMsystemuser createdonbehalfbyQuoteclose = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> quoteCloseSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> quoteCloseAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMannotation> quoteCloseAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMactivityparty> quotecloseActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMbulkdeletefailure> quoteCloseBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMbusinessunit owningbusinessunitQuoteclose = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser owninguserQuoteclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteamQuoteclose = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser createdbyQuoteclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyQuoteclose = default(MicrosoftDynamicsCRMsystemuser))
        {
            Overriddencreatedon = overriddencreatedon;
            Subcategory = subcategory;
            Category = category;
            Importsequencenumber = importsequencenumber;
            Revision = revision;
            Quotenumber = quotenumber;
            this._quoteidValue = _quoteidValue;
            ModifiedonbehalfbyQuoteclose = modifiedonbehalfbyQuoteclose;
            RegardingobjectidNewInteractionforemailQuoteclose = regardingobjectidNewInteractionforemailQuoteclose;
            RegardingobjectidEntitlementQuoteclose = regardingobjectidEntitlementQuoteclose;
            RegardingobjectidEntitlementtemplateQuoteclose = regardingobjectidEntitlementtemplateQuoteclose;
            RegardingobjectidBookableresourcebookingQuoteclose = regardingobjectidBookableresourcebookingQuoteclose;
            RegardingobjectidBookableresourcebookingheaderQuoteclose = regardingobjectidBookableresourcebookingheaderQuoteclose;
            RegardingobjectidKnowledgebaserecordQuoteclose = regardingobjectidKnowledgebaserecordQuoteclose;
            RegardingobjectidSiteQuoteclose = regardingobjectidSiteQuoteclose;
            RegardingobjectidAccountQuoteclose = regardingobjectidAccountQuoteclose;
            SendermailboxidQuoteclose = sendermailboxidQuoteclose;
            TransactioncurrencyidQuoteclose = transactioncurrencyidQuoteclose;
            OwneridQuoteclose = owneridQuoteclose;
            RegardingobjectidOpportunityQuoteclose = regardingobjectidOpportunityQuoteclose;
            SlaActivitypointerSlaQuoteclose = slaActivitypointerSlaQuoteclose;
            RegardingobjectidKnowledgearticleQuoteclose = regardingobjectidKnowledgearticleQuoteclose;
            RegardingobjectidQuoteQuoteclose = regardingobjectidQuoteQuoteclose;
            RegardingobjectidLeadQuoteclose = regardingobjectidLeadQuoteclose;
            RegardingobjectidBulkoperationQuoteclose = regardingobjectidBulkoperationQuoteclose;
            RegardingobjectidIncidentQuoteclose = regardingobjectidIncidentQuoteclose;
            RegardingobjectidCampaignQuoteclose = regardingobjectidCampaignQuoteclose;
            RegardingobjectidCampaignactivityQuoteclose = regardingobjectidCampaignactivityQuoteclose;
            SlainvokedidActivitypointerSlaQuoteclose = slainvokedidActivitypointerSlaQuoteclose;
            CampaignResponseQuoteCloses = campaignResponseQuoteCloses;
            QuotecloseTeams = quotecloseTeams;
            QuotecloseMailboxTrackingFolders = quotecloseMailboxTrackingFolders;
            QuoteclosePrincipalObjectAttributeAccesses = quoteclosePrincipalObjectAttributeAccesses;
            ServiceidQuoteclose = serviceidQuoteclose;
            Quoteid = quoteid;
            ActivityidActivitypointer = activityidActivitypointer;
            CreatedonbehalfbyQuoteclose = createdonbehalfbyQuoteclose;
            QuoteCloseSyncErrors = quoteCloseSyncErrors;
            QuoteCloseAsyncOperations = quoteCloseAsyncOperations;
            QuoteCloseAnnotation = quoteCloseAnnotation;
            QuotecloseActivityParties = quotecloseActivityParties;
            QuoteCloseBulkDeleteFailures = quoteCloseBulkDeleteFailures;
            OwningbusinessunitQuoteclose = owningbusinessunitQuoteclose;
            OwninguserQuoteclose = owninguserQuoteclose;
            OwningteamQuoteclose = owningteamQuoteclose;
            CreatedbyQuoteclose = createdbyQuoteclose;
            ModifiedbyQuoteclose = modifiedbyQuoteclose;
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
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotenumber")]
        public string Quotenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_quoteid_value")]
        public string _quoteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_new_interactionforemail_quoteclose")]
        public MicrosoftDynamicsCRMinteractionforemail RegardingobjectidNewInteractionforemailQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_quoteclose")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_quoteclose")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_quoteclose")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_quoteclose")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_quoteclose")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_site_quoteclose")]
        public MicrosoftDynamicsCRMsite RegardingobjectidSiteQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_quoteclose")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendermailboxid_quoteclose")]
        public MicrosoftDynamicsCRMmailbox SendermailboxidQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_quoteclose")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid_quoteclose")]
        public MicrosoftDynamicsCRMprincipal OwneridQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_quoteclose")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_activitypointer_sla_quoteclose")]
        public MicrosoftDynamicsCRMsla SlaActivitypointerSlaQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_quoteclose")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_quoteclose")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_quoteclose")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_quoteclose")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_quoteclose")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_quoteclose")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_quoteclose")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_activitypointer_sla_quoteclose")]
        public MicrosoftDynamicsCRMsla SlainvokedidActivitypointerSlaQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignResponse_QuoteCloses")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> CampaignResponseQuoteCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteclose_Teams")]
        public IList<MicrosoftDynamicsCRMteam> QuotecloseTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteclose_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> QuotecloseMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteclose_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> QuoteclosePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_quoteclose")]
        public MicrosoftDynamicsCRMservice ServiceidQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteid")]
        public MicrosoftDynamicsCRMquote Quoteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteClose_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> QuoteCloseSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteClose_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> QuoteCloseAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteClose_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> QuoteCloseAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteclose_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> QuotecloseActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteClose_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> QuoteCloseBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_quoteclose")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser OwninguserQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_quoteclose")]
        public MicrosoftDynamicsCRMteam OwningteamQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyQuoteclose { get; set; }

    }
}
