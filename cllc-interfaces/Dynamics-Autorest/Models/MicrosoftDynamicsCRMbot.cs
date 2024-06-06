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
    /// Microsoft.Dynamics.CRM.bot
    /// </summary>
    public partial class MicrosoftDynamicsCRMbot
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMbot class.
        /// </summary>
        public MicrosoftDynamicsCRMbot()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMbot class.
        /// </summary>
        public MicrosoftDynamicsCRMbot(int? utcconversiontimezonecode = default(int?), int? importsequencenumber = default(int?), bool? ismanaged = default(bool?), string _owneridValue = default(string), string versionnumber = default(string), string iconbase64 = default(string), string schemaname = default(string), string name = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string applicationmanifestinformation = default(string), int? accesscontrolpolicy = default(int?), int? statuscode = default(int?), System.DateTimeOffset? publishedon = default(System.DateTimeOffset?), string _owningteamValue = default(string), string componentidunique = default(string), string solutionid = default(string), string botid = default(string), int? language = default(int?), string _modifiedbyValue = default(string), string iscustomizable = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statecode = default(int?), string _publishedbyValue = default(string), int? authenticationmode = default(int?), int? authenticationtrigger = default(int?), string _modifiedonbehalfbyValue = default(string), string configuration = default(string), int? componentstate = default(int?), string _owninguserValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string authorizedsecuritygroupids = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> botSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> botAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> botMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> botProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> botBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> botPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMbotcomponent> botBotcomponent = default(IList<MicrosoftDynamicsCRMbotcomponent>), IList<MicrosoftDynamicsCRMconversationtranscript> botConversationtranscript = default(IList<MicrosoftDynamicsCRMconversationtranscript>), MicrosoftDynamicsCRMsystemuser publishedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Importsequencenumber = importsequencenumber;
            Ismanaged = ismanaged;
            this._owneridValue = _owneridValue;
            Versionnumber = versionnumber;
            Iconbase64 = iconbase64;
            Schemaname = schemaname;
            Name = name;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Createdon = createdon;
            Applicationmanifestinformation = applicationmanifestinformation;
            Accesscontrolpolicy = accesscontrolpolicy;
            Statuscode = statuscode;
            Publishedon = publishedon;
            this._owningteamValue = _owningteamValue;
            Componentidunique = componentidunique;
            Solutionid = solutionid;
            Botid = botid;
            Language = language;
            this._modifiedbyValue = _modifiedbyValue;
            Iscustomizable = iscustomizable;
            Modifiedon = modifiedon;
            Statecode = statecode;
            this._publishedbyValue = _publishedbyValue;
            Authenticationmode = authenticationmode;
            Authenticationtrigger = authenticationtrigger;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Configuration = configuration;
            Componentstate = componentstate;
            this._owninguserValue = _owninguserValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Authorizedsecuritygroupids = authorizedsecuritygroupids;
            Overwritetime = overwritetime;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BotSyncErrors = botSyncErrors;
            BotAsyncOperations = botAsyncOperations;
            BotMailboxTrackingFolders = botMailboxTrackingFolders;
            BotProcessSession = botProcessSession;
            BotBulkDeleteFailures = botBulkDeleteFailures;
            BotPrincipalObjectAttributeAccesses = botPrincipalObjectAttributeAccesses;
            BotBotcomponent = botBotcomponent;
            BotConversationtranscript = botConversationtranscript;
            Publishedby = publishedby;
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
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iconbase64")]
        public string Iconbase64 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemaname")]
        public string Schemaname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicationmanifestinformation")]
        public string Applicationmanifestinformation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accesscontrolpolicy")]
        public int? Accesscontrolpolicy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publishedon")]
        public System.DateTimeOffset? Publishedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentidunique")]
        public string Componentidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "botid")]
        public string Botid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public int? Language { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_publishedby_value")]
        public string _publishedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authenticationmode")]
        public int? Authenticationmode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authenticationtrigger")]
        public int? Authenticationtrigger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public string Configuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authorizedsecuritygroupids")]
        public string Authorizedsecuritygroupids { get; set; }

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
        [JsonProperty(PropertyName = "bot_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BotSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bot_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BotAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bot_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> BotMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bot_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> BotProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bot_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BotBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bot_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> BotPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bot_botcomponent")]
        public IList<MicrosoftDynamicsCRMbotcomponent> BotBotcomponent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bot_conversationtranscript")]
        public IList<MicrosoftDynamicsCRMconversationtranscript> BotConversationtranscript { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publishedby")]
        public MicrosoftDynamicsCRMsystemuser Publishedby { get; set; }

    }
}
