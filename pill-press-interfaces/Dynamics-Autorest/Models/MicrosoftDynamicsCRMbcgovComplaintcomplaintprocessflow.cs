// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.bcgov_complaintcomplaintprocessflow
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovComplaintcomplaintprocessflow
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovComplaintcomplaintprocessflow class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovComplaintcomplaintprocessflow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovComplaintcomplaintprocessflow class.
        /// </summary>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="statuscode">Reason for the status of the Complaint:
        /// Complaint Process Flow</param>
        /// <param name="businessprocessflowinstanceid">Unique identifier for
        /// entity instances</param>
        /// <param name="bpfDuration">Duration of Business Process Flow</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="activestagestartedon">Date and time when current
        /// active stage is started</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="_activestageidValue">Unique identifier of the active
        /// stage for the Business Process Flow instance.</param>
        /// <param name="_processidValue">Unique identifier of the workflow
        /// associated to the Business Process Flow instance.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="statecode">Status of the Complaint: Complaint Process
        /// Flow</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="traversedpath">Comma delimited string of process stage
        /// ids that represent visited stages of the Business Process Flow
        /// instance.</param>
        /// <param name="_organizationidValue">Unique identifier for the
        /// organization</param>
        /// <param name="completedon">Date and time when Business Process Flow
        /// instance is completed.</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="bpfName">Description</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        public MicrosoftDynamicsCRMbcgovComplaintcomplaintprocessflow(string _createdonbehalfbyValue = default(string), int? statuscode = default(int?), string businessprocessflowinstanceid = default(string), int? bpfDuration = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? activestagestartedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), int? importsequencenumber = default(int?), string _activestageidValue = default(string), string _processidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), int? statecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string traversedpath = default(string), string _organizationidValue = default(string), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), string versionnumber = default(string), string bpfName = default(string), int? utcconversiontimezonecode = default(int?), string _createdbyValue = default(string), string _bpfBcgovComplaintidValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMprocessstage activestageidname = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMworkflow processidname = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMsyncerror> bcgovComplaintcomplaintprocessflowSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> bcgovComplaintcomplaintprocessflowAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMworkflowlog> bcgovComplaintcomplaintprocessflowWorkflowLogs = default(IList<MicrosoftDynamicsCRMworkflowlog>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bcgovComplaintcomplaintprocessflowBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMbcgovComplaint bpfBcgovComplaintid = default(MicrosoftDynamicsCRMbcgovComplaint))
        {
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statuscode = statuscode;
            Businessprocessflowinstanceid = businessprocessflowinstanceid;
            BpfDuration = bpfDuration;
            Modifiedon = modifiedon;
            Activestagestartedon = activestagestartedon;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            this._activestageidValue = _activestageidValue;
            this._processidValue = _processidValue;
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statecode = statecode;
            Createdon = createdon;
            Traversedpath = traversedpath;
            this._organizationidValue = _organizationidValue;
            Completedon = completedon;
            Versionnumber = versionnumber;
            BpfName = bpfName;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdbyValue = _createdbyValue;
            this._bpfBcgovComplaintidValue = _bpfBcgovComplaintidValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Organizationid = organizationid;
            Activestageidname = activestageidname;
            Processidname = processidname;
            BcgovComplaintcomplaintprocessflowSyncErrors = bcgovComplaintcomplaintprocessflowSyncErrors;
            BcgovComplaintcomplaintprocessflowAsyncOperations = bcgovComplaintcomplaintprocessflowAsyncOperations;
            BcgovComplaintcomplaintprocessflowWorkflowLogs = bcgovComplaintcomplaintprocessflowWorkflowLogs;
            BcgovComplaintcomplaintprocessflowBulkDeleteFailures = bcgovComplaintcomplaintprocessflowBulkDeleteFailures;
            BpfBcgovComplaintid = bpfBcgovComplaintid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Complaint: Complaint
        /// Process Flow
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "businessprocessflowinstanceid")]
        public string Businessprocessflowinstanceid { get; set; }

        /// <summary>
        /// Gets or sets duration of Business Process Flow
        /// </summary>
        [JsonProperty(PropertyName = "bpf_duration")]
        public int? BpfDuration { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets date and time when current active stage is started
        /// </summary>
        [JsonProperty(PropertyName = "activestagestartedon")]
        public System.DateTimeOffset? Activestagestartedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the active stage for the Business
        /// Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "_activestageid_value")]
        public string _activestageidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the workflow associated to the
        /// Business Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets status of the Complaint: Complaint Process Flow
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets comma delimited string of process stage ids that
        /// represent visited stages of the Business Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the organization
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when Business Process Flow instance is
        /// completed.
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets description
        /// </summary>
        [JsonProperty(PropertyName = "bpf_name")]
        public string BpfName { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bpf_bcgov_complaintid_value")]
        public string _bpfBcgovComplaintidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestageidname")]
        public MicrosoftDynamicsCRMprocessstage Activestageidname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processidname")]
        public MicrosoftDynamicsCRMworkflow Processidname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaintcomplaintprocessflow_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BcgovComplaintcomplaintprocessflowSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaintcomplaintprocessflow_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BcgovComplaintcomplaintprocessflowAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaintcomplaintprocessflow_WorkflowLogs")]
        public IList<MicrosoftDynamicsCRMworkflowlog> BcgovComplaintcomplaintprocessflowWorkflowLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaintcomplaintprocessflow_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BcgovComplaintcomplaintprocessflowBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_bcgov_complaintid")]
        public MicrosoftDynamicsCRMbcgovComplaint BpfBcgovComplaintid { get; set; }

    }
}
