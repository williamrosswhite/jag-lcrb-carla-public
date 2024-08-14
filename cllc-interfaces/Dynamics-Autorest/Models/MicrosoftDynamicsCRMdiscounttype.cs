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
    /// Microsoft.Dynamics.CRM.discounttype
    /// </summary>
    public partial class MicrosoftDynamicsCRMdiscounttype
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMdiscounttype
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMdiscounttype()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMdiscounttype
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMdiscounttype(int? utcconversiontimezonecode = default(int?), int? statuscode = default(int?), string _modifiedbyValue = default(string), string versionnumber = default(string), string discounttypeid = default(string), string description = default(string), string _createdonbehalfbyValue = default(string), string name = default(string), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? statecode = default(int?), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _organizationidValue = default(string), bool? isamounttype = default(bool?), IList<MicrosoftDynamicsCRMteam> discounttypeTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> discounttypeMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> discounttypePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> discountTypeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> discountTypeSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMbulkdeletefailure> discountTypeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprocesssession> discountTypeProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMdiscount> discountTypeDiscounts = default(IList<MicrosoftDynamicsCRMdiscount>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMproductpricelevel> discountTypeProductPriceLevels = default(IList<MicrosoftDynamicsCRMproductpricelevel>))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statuscode = statuscode;
            this._modifiedbyValue = _modifiedbyValue;
            Versionnumber = versionnumber;
            Discounttypeid = discounttypeid;
            Description = description;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Name = name;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            Statecode = statecode;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Overriddencreatedon = overriddencreatedon;
            this._organizationidValue = _organizationidValue;
            Isamounttype = isamounttype;
            DiscounttypeTeams = discounttypeTeams;
            DiscounttypeMailboxTrackingFolders = discounttypeMailboxTrackingFolders;
            DiscounttypePrincipalObjectAttributeAccesses = discounttypePrincipalObjectAttributeAccesses;
            Createdonbehalfby = createdonbehalfby;
            Createdby = createdby;
            DiscountTypeAsyncOperations = discountTypeAsyncOperations;
            Modifiedonbehalfby = modifiedonbehalfby;
            DiscountTypeSyncErrors = discountTypeSyncErrors;
            DiscountTypeBulkDeleteFailures = discountTypeBulkDeleteFailures;
            DiscountTypeProcessSessions = discountTypeProcessSessions;
            Organizationid = organizationid;
            DiscountTypeDiscounts = discountTypeDiscounts;
            Modifiedby = modifiedby;
            Transactioncurrencyid = transactioncurrencyid;
            DiscountTypeProductPriceLevels = discountTypeProductPriceLevels;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

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
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discounttypeid")]
        public string Discounttypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isamounttype")]
        public bool? Isamounttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discounttype_Teams")]
        public IList<MicrosoftDynamicsCRMteam> DiscounttypeTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discounttype_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> DiscounttypeMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discounttype_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> DiscounttypePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DiscountType_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> DiscountTypeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DiscountType_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> DiscountTypeSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DiscountType_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> DiscountTypeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DiscountType_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> DiscountTypeProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discount_type_discounts")]
        public IList<MicrosoftDynamicsCRMdiscount> DiscountTypeDiscounts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discount_type_product_price_levels")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> DiscountTypeProductPriceLevels { get; set; }

    }
}
