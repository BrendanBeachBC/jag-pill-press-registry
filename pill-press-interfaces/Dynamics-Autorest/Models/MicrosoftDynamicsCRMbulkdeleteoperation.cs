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
    /// bulkdeleteoperation
    /// </summary>
    public partial class MicrosoftDynamicsCRMbulkdeleteoperation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbulkdeleteoperation class.
        /// </summary>
        public MicrosoftDynamicsCRMbulkdeleteoperation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbulkdeleteoperation class.
        /// </summary>
        public MicrosoftDynamicsCRMbulkdeleteoperation(int? successcount = default(int?), string _createdbyValue = default(string), string _modifiedbyValue = default(string), string _owningbusinessunitValue = default(string), int? statuscode = default(int?), bool? isrecurring = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? processingqeindex = default(int?), int? failurecount = default(int?), System.DateTimeOffset? nextrun = default(System.DateTimeOffset?), string _owninguserValue = default(string), string orderedquerysetxml = default(string), string _owneridValue = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string name = default(string), string bulkdeleteoperationid = default(string), string _asyncoperationidValue = default(string), string _modifiedonbehalfbyValue = default(string), int? statecode = default(int?), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMasyncoperation asyncoperationid = default(MicrosoftDynamicsCRMasyncoperation), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> bulkDeleteOperationBulkDeleteFailure = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Successcount = successcount;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Statuscode = statuscode;
            Isrecurring = isrecurring;
            Createdon = createdon;
            Processingqeindex = processingqeindex;
            Failurecount = failurecount;
            Nextrun = nextrun;
            this._owninguserValue = _owninguserValue;
            Orderedquerysetxml = orderedquerysetxml;
            this._owneridValue = _owneridValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Name = name;
            Bulkdeleteoperationid = bulkdeleteoperationid;
            this._asyncoperationidValue = _asyncoperationidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Statecode = statecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Owningbusinessunit = owningbusinessunit;
            Asyncoperationid = asyncoperationid;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            BulkDeleteOperationBulkDeleteFailure = bulkDeleteOperationBulkDeleteFailure;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "successcount")]
        public int? Successcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isrecurring")]
        public bool? Isrecurring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processingqeindex")]
        public int? Processingqeindex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failurecount")]
        public int? Failurecount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nextrun")]
        public System.DateTimeOffset? Nextrun { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderedquerysetxml")]
        public string Orderedquerysetxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

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
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkdeleteoperationid")]
        public string Bulkdeleteoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_asyncoperationid_value")]
        public string _asyncoperationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncoperationid")]
        public MicrosoftDynamicsCRMasyncoperation Asyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

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
        [JsonProperty(PropertyName = "BulkDeleteOperation_BulkDeleteFailure")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BulkDeleteOperationBulkDeleteFailure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
