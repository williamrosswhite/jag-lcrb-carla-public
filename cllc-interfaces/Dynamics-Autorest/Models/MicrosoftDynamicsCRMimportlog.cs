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
    /// Microsoft.Dynamics.CRM.importlog
    /// </summary>
    public partial class MicrosoftDynamicsCRMimportlog
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimportlog
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMimportlog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimportlog
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMimportlog(string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owneridValue = default(string), int? statecode = default(int?), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string headercolumn = default(string), string _owningteamValue = default(string), string errordescription = default(string), int? sequencenumber = default(int?), string _importfileidValue = default(string), string _createdbyValue = default(string), string additionalinfo = default(string), string _owninguserValue = default(string), int? linenumber = default(int?), string importlogid = default(string), int? errornumber = default(int?), int? statuscode = default(int?), string columnvalue = default(string), int? logphasecode = default(int?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _importdataidValue = default(string), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> importLogBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMimportdata importdataid = default(MicrosoftDynamicsCRMimportdata), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMasyncoperation> importLogAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMimportfile importfileid = default(MicrosoftDynamicsCRMimportfile), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            this._owneridValue = _owneridValue;
            Statecode = statecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Headercolumn = headercolumn;
            this._owningteamValue = _owningteamValue;
            Errordescription = errordescription;
            Sequencenumber = sequencenumber;
            this._importfileidValue = _importfileidValue;
            this._createdbyValue = _createdbyValue;
            Additionalinfo = additionalinfo;
            this._owninguserValue = _owninguserValue;
            Linenumber = linenumber;
            Importlogid = importlogid;
            Errornumber = errornumber;
            Statuscode = statuscode;
            Columnvalue = columnvalue;
            Logphasecode = logphasecode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Createdon = createdon;
            this._importdataidValue = _importdataidValue;
            Owningbusinessunit = owningbusinessunit;
            Owninguser = owninguser;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            ImportLogBulkDeleteFailures = importLogBulkDeleteFailures;
            Importdataid = importdataid;
            Modifiedby = modifiedby;
            Owningteam = owningteam;
            ImportLogAsyncOperations = importLogAsyncOperations;
            Importfileid = importfileid;
            Ownerid = ownerid;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

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
        [JsonProperty(PropertyName = "headercolumn")]
        public string Headercolumn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errordescription")]
        public string Errordescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequencenumber")]
        public int? Sequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_importfileid_value")]
        public string _importfileidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalinfo")]
        public string Additionalinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "linenumber")]
        public int? Linenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importlogid")]
        public string Importlogid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errornumber")]
        public int? Errornumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columnvalue")]
        public string Columnvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logphasecode")]
        public int? Logphasecode { get; set; }

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
        [JsonProperty(PropertyName = "_importdataid_value")]
        public string _importdataidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

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
        [JsonProperty(PropertyName = "ImportLog_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ImportLogBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importdataid")]
        public MicrosoftDynamicsCRMimportdata Importdataid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImportLog_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ImportLogAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importfileid")]
        public MicrosoftDynamicsCRMimportfile Importfileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
