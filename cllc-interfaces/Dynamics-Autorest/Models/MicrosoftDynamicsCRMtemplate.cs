// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.template
    /// </summary>
    public partial class MicrosoftDynamicsCRMtemplate
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtemplate
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMtemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtemplate
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMtemplate(int? openrate = default(int?), int? replyrate = default(int?), string subjectpresentationxml = default(string), bool? isrecommended = default(bool?), string solutionid = default(string), int? generationtypecode = default(int?), string _createdbyValue = default(string), string mimetype = default(string), string subjectsafehtml = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), bool? ismanaged = default(bool?), string safehtml = default(string), string _owningbusinessunitValue = default(string), string _owneridValue = default(string), string templateidunique = default(string), string body = default(string), string description = default(string), string _modifiedbyValue = default(string), string _owningteamValue = default(string), string templatetypecode = default(string), string entityimageid = default(string), bool? ispersonal = default(bool?), int? componentstate = default(int?), int? usedcount = default(int?), string title = default(string), int? importsequencenumber = default(int?), string _owninguserValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), long? entityimageTimestamp = default(long?), string introducedversion = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string templateid = default(string), int? replycount = default(int?), string presentationxml = default(string), string iscustomizable = default(string), string subject = default(string), byte[] entityimage = default(byte[]), string entityimageUrl = default(string), int? languagecode = default(int?), string versionnumber = default(string), int? opencount = default(int?), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> templateAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> templateBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMactivitymimeattachment> templateActivityMimeAttachments = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), IList<MicrosoftDynamicsCRMprocesssession> templateProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMsyncerror> templateSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMorganization> templateOrganization = default(IList<MicrosoftDynamicsCRMorganization>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMemail> emailEmailTemplate = default(IList<MicrosoftDynamicsCRMemail>))
        {
            Openrate = openrate;
            Replyrate = replyrate;
            Subjectpresentationxml = subjectpresentationxml;
            Isrecommended = isrecommended;
            Solutionid = solutionid;
            Generationtypecode = generationtypecode;
            this._createdbyValue = _createdbyValue;
            Mimetype = mimetype;
            Subjectsafehtml = subjectsafehtml;
            Modifiedon = modifiedon;
            Ismanaged = ismanaged;
            Safehtml = safehtml;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owneridValue = _owneridValue;
            Templateidunique = templateidunique;
            Body = body;
            Description = description;
            this._modifiedbyValue = _modifiedbyValue;
            this._owningteamValue = _owningteamValue;
            Templatetypecode = templatetypecode;
            Entityimageid = entityimageid;
            Ispersonal = ispersonal;
            Componentstate = componentstate;
            Usedcount = usedcount;
            Title = title;
            Importsequencenumber = importsequencenumber;
            this._owninguserValue = _owninguserValue;
            Overwritetime = overwritetime;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            EntityimageTimestamp = entityimageTimestamp;
            Introducedversion = introducedversion;
            Createdon = createdon;
            Templateid = templateid;
            Replycount = replycount;
            Presentationxml = presentationxml;
            Iscustomizable = iscustomizable;
            Subject = subject;
            Entityimage = entityimage;
            EntityimageUrl = entityimageUrl;
            Languagecode = languagecode;
            Versionnumber = versionnumber;
            Opencount = opencount;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdby = createdby;
            Owningbusinessunit = owningbusinessunit;
            Modifiedby = modifiedby;
            TemplateAsyncOperations = templateAsyncOperations;
            TemplateBulkDeleteFailures = templateBulkDeleteFailures;
            Createdonbehalfby = createdonbehalfby;
            Owningteam = owningteam;
            TemplateActivityMimeAttachments = templateActivityMimeAttachments;
            TemplateProcessSessions = templateProcessSessions;
            Ownerid = ownerid;
            TemplateSyncErrors = templateSyncErrors;
            Owninguser = owninguser;
            TemplateOrganization = templateOrganization;
            Modifiedonbehalfby = modifiedonbehalfby;
            EmailEmailTemplate = emailEmailTemplate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "openrate")]
        public int? Openrate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replyrate")]
        public int? Replyrate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subjectpresentationxml")]
        public string Subjectpresentationxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isrecommended")]
        public bool? Isrecommended { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "generationtypecode")]
        public int? Generationtypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subjectsafehtml")]
        public string Subjectsafehtml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "safehtml")]
        public string Safehtml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "templateidunique")]
        public string Templateidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "templatetypecode")]
        public string Templatetypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispersonal")]
        public bool? Ispersonal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "usedcount")]
        public int? Usedcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "templateid")]
        public string Templateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replycount")]
        public int? Replycount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "presentationxml")]
        public string Presentationxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languagecode")]
        public int? Languagecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opencount")]
        public int? Opencount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> TemplateAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> TemplateBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "template_activity_mime_attachments")]
        public IList<MicrosoftDynamicsCRMactivitymimeattachment> TemplateActivityMimeAttachments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> TemplateProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> TemplateSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_Organization")]
        public IList<MicrosoftDynamicsCRMorganization> TemplateOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email_EmailTemplate")]
        public IList<MicrosoftDynamicsCRMemail> EmailEmailTemplate { get; set; }

    }
}
