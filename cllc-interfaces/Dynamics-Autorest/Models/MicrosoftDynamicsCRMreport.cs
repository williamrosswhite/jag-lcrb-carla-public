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
    /// Microsoft.Dynamics.CRM.report
    /// </summary>
    public partial class MicrosoftDynamicsCRMreport
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMreport class.
        /// </summary>
        public MicrosoftDynamicsCRMreport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMreport class.
        /// </summary>
        public MicrosoftDynamicsCRMreport(bool? isscheduledreport = default(bool?), int? signaturemajorversion = default(int?), string reportidunique = default(string), string solutionid = default(string), string description = default(string), string _owneridValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string reportnameonsrs = default(string), int? signaturelcid = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string iscustomizable = default(string), bool? ispersonal = default(bool?), string customreportxml = default(string), bool? iscustomreport = default(bool?), string schedulexml = default(string), string reportid = default(string), string _owningteamValue = default(string), string mimetype = default(string), int? signatureminorversion = default(int?), string filename = default(string), int? languagecode = default(int?), string signatureid = default(string), string bodyurl = default(string), string defaultfilter = default(string), string _owninguserValue = default(string), string _createdbyValue = default(string), string originalbodytext = default(string), string _createdonbehalfbyValue = default(string), int? filesize = default(int?), int? componentstate = default(int?), int? timezoneruleversionnumber = default(int?), int? rdlhash = default(int?), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? signaturedate = default(System.DateTimeOffset?), string queryinfo = default(string), string _modifiedbyValue = default(string), string introducedversion = default(string), string name = default(string), string versionnumber = default(string), string bodybinary = default(string), byte[] bodybinaryBinary = default(byte[]), int? reporttypecode = default(int?), string _owningbusinessunitValue = default(string), bool? ismanaged = default(bool?), string _parentreportidValue = default(string), int? utcconversiontimezonecode = default(int?), int? createdinmajorversion = default(int?), string bodytext = default(string), IList<MicrosoftDynamicsCRMasyncoperation> reportAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMreportcategory> reportReportcategories = default(IList<MicrosoftDynamicsCRMreportcategory>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMprocesssession> reportProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> reportSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMreport parentreportid = default(MicrosoftDynamicsCRMreport), IList<MicrosoftDynamicsCRMreport> reportParentReport = default(IList<MicrosoftDynamicsCRMreport>))
        {
            Isscheduledreport = isscheduledreport;
            Signaturemajorversion = signaturemajorversion;
            Reportidunique = reportidunique;
            Solutionid = solutionid;
            Description = description;
            this._owneridValue = _owneridValue;
            Overwritetime = overwritetime;
            Reportnameonsrs = reportnameonsrs;
            Signaturelcid = signaturelcid;
            Createdon = createdon;
            Modifiedon = modifiedon;
            Iscustomizable = iscustomizable;
            Ispersonal = ispersonal;
            Customreportxml = customreportxml;
            Iscustomreport = iscustomreport;
            Schedulexml = schedulexml;
            Reportid = reportid;
            this._owningteamValue = _owningteamValue;
            Mimetype = mimetype;
            Signatureminorversion = signatureminorversion;
            Filename = filename;
            Languagecode = languagecode;
            Signatureid = signatureid;
            Bodyurl = bodyurl;
            Defaultfilter = defaultfilter;
            this._owninguserValue = _owninguserValue;
            this._createdbyValue = _createdbyValue;
            Originalbodytext = originalbodytext;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Filesize = filesize;
            Componentstate = componentstate;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Rdlhash = rdlhash;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Signaturedate = signaturedate;
            Queryinfo = queryinfo;
            this._modifiedbyValue = _modifiedbyValue;
            Introducedversion = introducedversion;
            Name = name;
            Versionnumber = versionnumber;
            Bodybinary = bodybinary;
            BodybinaryBinary = bodybinaryBinary;
            Reporttypecode = reporttypecode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Ismanaged = ismanaged;
            this._parentreportidValue = _parentreportidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdinmajorversion = createdinmajorversion;
            Bodytext = bodytext;
            ReportAsyncOperations = reportAsyncOperations;
            ReportReportcategories = reportReportcategories;
            Modifiedonbehalfby = modifiedonbehalfby;
            ReportProcessSessions = reportProcessSessions;
            Createdonbehalfby = createdonbehalfby;
            ReportSyncErrors = reportSyncErrors;
            Ownerid = ownerid;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Owningbusinessunit = owningbusinessunit;
            Parentreportid = parentreportid;
            ReportParentReport = reportParentReport;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isscheduledreport")]
        public bool? Isscheduledreport { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signaturemajorversion")]
        public int? Signaturemajorversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reportidunique")]
        public string Reportidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reportnameonsrs")]
        public string Reportnameonsrs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signaturelcid")]
        public int? Signaturelcid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispersonal")]
        public bool? Ispersonal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customreportxml")]
        public string Customreportxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomreport")]
        public bool? Iscustomreport { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schedulexml")]
        public string Schedulexml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reportid")]
        public string Reportid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signatureminorversion")]
        public int? Signatureminorversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languagecode")]
        public int? Languagecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signatureid")]
        public string Signatureid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bodyurl")]
        public string Bodyurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultfilter")]
        public string Defaultfilter { get; set; }

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
        [JsonProperty(PropertyName = "originalbodytext")]
        public string Originalbodytext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesize")]
        public int? Filesize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rdlhash")]
        public int? Rdlhash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signaturedate")]
        public System.DateTimeOffset? Signaturedate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queryinfo")]
        public string Queryinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bodybinary")]
        public string Bodybinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "bodybinary_binary")]
        public byte[] BodybinaryBinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reporttypecode")]
        public int? Reporttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentreportid_value")]
        public string _parentreportidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdinmajorversion")]
        public int? Createdinmajorversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bodytext")]
        public string Bodytext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Report_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ReportAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "report_reportcategories")]
        public IList<MicrosoftDynamicsCRMreportcategory> ReportReportcategories { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Report_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> ReportProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Report_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ReportSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentreportid")]
        public MicrosoftDynamicsCRMreport Parentreportid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "report_parent_report")]
        public IList<MicrosoftDynamicsCRMreport> ReportParentReport { get; set; }

    }
}
