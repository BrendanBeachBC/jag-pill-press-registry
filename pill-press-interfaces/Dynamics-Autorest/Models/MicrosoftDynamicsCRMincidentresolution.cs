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
    /// incidentresolution
    /// </summary>
    public partial class MicrosoftDynamicsCRMincidentresolution
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMincidentresolution class.
        /// </summary>
        public MicrosoftDynamicsCRMincidentresolution()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMincidentresolution class.
        /// </summary>
        public MicrosoftDynamicsCRMincidentresolution(string subcategory = default(string), string _modifiedbyexternalpartyValue = default(string), string category = default(string), int? importsequencenumber = default(int?), string _incidentidValue = default(string), int? timespent = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdbyexternalpartyValue = default(string), MicrosoftDynamicsCRMservice serviceidIncidentresolution = default(MicrosoftDynamicsCRMservice), IList<MicrosoftDynamicsCRMasyncoperation> incidentResolutionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser createdonbehalfbyIncidentresolution = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMannotation> incidentResolutionAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> incidentResolutionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMincident incidentid = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMsystemuser owninguserIncidentresolution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyIncidentresolution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyIncidentresolution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMbusinessunit owningbusinessunitIncidentresolution = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteamIncidentresolution = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMsyncerror> incidentResolutionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> incidentresolutionActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMsystemuser createdbyIncidentresolution = default(MicrosoftDynamicsCRMsystemuser))
        {
            Subcategory = subcategory;
            this._modifiedbyexternalpartyValue = _modifiedbyexternalpartyValue;
            Category = category;
            Importsequencenumber = importsequencenumber;
            this._incidentidValue = _incidentidValue;
            Timespent = timespent;
            Overriddencreatedon = overriddencreatedon;
            this._createdbyexternalpartyValue = _createdbyexternalpartyValue;
            ServiceidIncidentresolution = serviceidIncidentresolution;
            IncidentResolutionAsyncOperations = incidentResolutionAsyncOperations;
            CreatedonbehalfbyIncidentresolution = createdonbehalfbyIncidentresolution;
            IncidentResolutionAnnotation = incidentResolutionAnnotation;
            IncidentResolutionBulkDeleteFailures = incidentResolutionBulkDeleteFailures;
            Incidentid = incidentid;
            OwninguserIncidentresolution = owninguserIncidentresolution;
            ModifiedonbehalfbyIncidentresolution = modifiedonbehalfbyIncidentresolution;
            ModifiedbyIncidentresolution = modifiedbyIncidentresolution;
            ActivityidActivitypointer = activityidActivitypointer;
            OwningbusinessunitIncidentresolution = owningbusinessunitIncidentresolution;
            OwningteamIncidentresolution = owningteamIncidentresolution;
            IncidentResolutionSyncErrors = incidentResolutionSyncErrors;
            IncidentresolutionActivityParties = incidentresolutionActivityParties;
            CreatedbyIncidentresolution = createdbyIncidentresolution;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedbyexternalparty_value")]
        public string _modifiedbyexternalpartyValue { get; set; }

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
        [JsonProperty(PropertyName = "_incidentid_value")]
        public string _incidentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timespent")]
        public int? Timespent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdbyexternalparty_value")]
        public string _createdbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_incidentresolution")]
        public MicrosoftDynamicsCRMservice ServiceidIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IncidentResolution_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> IncidentResolutionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_incidentresolution")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IncidentResolution_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> IncidentResolutionAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IncidentResolution_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> IncidentResolutionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentid")]
        public MicrosoftDynamicsCRMincident Incidentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_incidentresolution")]
        public MicrosoftDynamicsCRMsystemuser OwninguserIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_incidentresolution")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_incidentresolution")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_incidentresolution")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_incidentresolution")]
        public MicrosoftDynamicsCRMteam OwningteamIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IncidentResolution_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> IncidentResolutionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentresolution_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> IncidentresolutionActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_incidentresolution")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyIncidentresolution { get; set; }

    }
}
