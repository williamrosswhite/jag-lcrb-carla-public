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
    /// Microsoft.Dynamics.CRM.position
    /// </summary>
    public partial class MicrosoftDynamicsCRMposition
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMposition
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMposition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMposition
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMposition(string _createdonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string name = default(string), string _modifiedbyValue = default(string), string _parentpositionidValue = default(string), decimal? exchangerate = default(decimal?), string _organizationidValue = default(string), string _createdbyValue = default(string), int? utcconversiontimezonecode = default(int?), string positionid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? statuscode = default(int?), string _transactioncurrencyidValue = default(string), string versionnumber = default(string), string description = default(string), int? statecode = default(int?), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMasyncoperation> positionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMprocesssession> positionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMsystemuser> positionUsers = default(IList<MicrosoftDynamicsCRMsystemuser>), MicrosoftDynamicsCRMposition parentpositionid = default(MicrosoftDynamicsCRMposition), IList<MicrosoftDynamicsCRMposition> positionParentPosition = default(IList<MicrosoftDynamicsCRMposition>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> positionPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMconnection> positionConnection1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> positionConnection2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMsyncerror> positionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdon = createdon;
            Name = name;
            this._modifiedbyValue = _modifiedbyValue;
            this._parentpositionidValue = _parentpositionidValue;
            Exchangerate = exchangerate;
            this._organizationidValue = _organizationidValue;
            this._createdbyValue = _createdbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Positionid = positionid;
            Overriddencreatedon = overriddencreatedon;
            Statuscode = statuscode;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Versionnumber = versionnumber;
            Description = description;
            Statecode = statecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            PositionAsyncOperations = positionAsyncOperations;
            PositionProcessSession = positionProcessSession;
            PositionUsers = positionUsers;
            Parentpositionid = parentpositionid;
            PositionParentPosition = positionParentPosition;
            PositionPrincipalobjectattributeaccess = positionPrincipalobjectattributeaccess;
            Transactioncurrencyid = transactioncurrencyid;
            PositionConnection1 = positionConnection1;
            PositionConnection2 = positionConnection2;
            PositionSyncErrors = positionSyncErrors;
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
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentpositionid_value")]
        public string _parentpositionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "positionid")]
        public string Positionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> PositionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> PositionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position_users")]
        public IList<MicrosoftDynamicsCRMsystemuser> PositionUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentpositionid")]
        public MicrosoftDynamicsCRMposition Parentpositionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position_parent_position")]
        public IList<MicrosoftDynamicsCRMposition> PositionParentPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PositionPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position_connection1")]
        public IList<MicrosoftDynamicsCRMconnection> PositionConnection1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position_connection2")]
        public IList<MicrosoftDynamicsCRMconnection> PositionConnection2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Position_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> PositionSyncErrors { get; set; }

    }
}
