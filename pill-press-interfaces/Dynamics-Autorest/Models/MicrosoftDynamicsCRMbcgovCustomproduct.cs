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
    /// bcgov_customproduct
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovCustomproduct
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovCustomproduct class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovCustomproduct()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovCustomproduct class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovCustomproduct(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string emailaddress = default(string), string bcgovCustomproductid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? statecode = default(int?), string _createdbyValue = default(string), string _owningbusinessunitValue = default(string), int? importsequencenumber = default(int?), string _stageidValue = default(string), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), int? utcconversiontimezonecode = default(int?), int? statuscode = default(int?), string bcgovName = default(string), string _owninguserValue = default(string), string _bcgovRelatedapplicationValue = default(string), string _owningteamValue = default(string), string _owneridValue = default(string), string processid = default(string), string _createdonbehalfbyValue = default(string), string traversedpath = default(string), string bcgovProductdescriptionandintendeduse = default(string), long? versionnumber = default(long?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> bcgovCustomproductActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> bcgovCustomproductAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> bcgovCustomproductEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> bcgovCustomproductFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> bcgovCustomproductLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> bcgovCustomproductPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> bcgovCustomproductServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> bcgovCustomproductTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> bcgovCustomproductRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> bcgovCustomproductSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMsyncerror> bcgovCustomproductSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> bcgovCustomproductActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMconnection> bcgovCustomproductConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> bcgovCustomproductConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovCustomproductDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovCustomproductDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> bcgovCustomproductSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMqueueitem> bcgovCustomproductQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMteam> bcgovCustomproductTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMasyncoperation> bcgovCustomproductAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bcgovCustomproductBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMprocessstage stageid = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMincident bcgovRelatedApplication = default(MicrosoftDynamicsCRMincident))
        {
            Modifiedon = modifiedon;
            Emailaddress = emailaddress;
            BcgovCustomproductid = bcgovCustomproductid;
            Createdon = createdon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Overriddencreatedon = overriddencreatedon;
            Statecode = statecode;
            this._createdbyValue = _createdbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Importsequencenumber = importsequencenumber;
            this._stageidValue = _stageidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statuscode = statuscode;
            BcgovName = bcgovName;
            this._owninguserValue = _owninguserValue;
            this._bcgovRelatedapplicationValue = _bcgovRelatedapplicationValue;
            this._owningteamValue = _owningteamValue;
            this._owneridValue = _owneridValue;
            Processid = processid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Traversedpath = traversedpath;
            BcgovProductdescriptionandintendeduse = bcgovProductdescriptionandintendeduse;
            Versionnumber = versionnumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BcgovCustomproductActivityPointers = bcgovCustomproductActivityPointers;
            BcgovCustomproductAppointments = bcgovCustomproductAppointments;
            BcgovCustomproductEmails = bcgovCustomproductEmails;
            BcgovCustomproductFaxes = bcgovCustomproductFaxes;
            BcgovCustomproductLetters = bcgovCustomproductLetters;
            BcgovCustomproductPhoneCalls = bcgovCustomproductPhoneCalls;
            BcgovCustomproductServiceAppointments = bcgovCustomproductServiceAppointments;
            BcgovCustomproductTasks = bcgovCustomproductTasks;
            BcgovCustomproductRecurringAppointmentMasters = bcgovCustomproductRecurringAppointmentMasters;
            BcgovCustomproductSocialActivities = bcgovCustomproductSocialActivities;
            BcgovCustomproductSyncErrors = bcgovCustomproductSyncErrors;
            BcgovCustomproductActivityParties = bcgovCustomproductActivityParties;
            BcgovCustomproductConnections1 = bcgovCustomproductConnections1;
            BcgovCustomproductConnections2 = bcgovCustomproductConnections2;
            BcgovCustomproductDuplicateMatchingRecord = bcgovCustomproductDuplicateMatchingRecord;
            BcgovCustomproductDuplicateBaseRecord = bcgovCustomproductDuplicateBaseRecord;
            BcgovCustomproductSharePointDocumentLocations = bcgovCustomproductSharePointDocumentLocations;
            BcgovCustomproductQueueItems = bcgovCustomproductQueueItems;
            BcgovCustomproductTeams = bcgovCustomproductTeams;
            BcgovCustomproductAsyncOperations = bcgovCustomproductAsyncOperations;
            BcgovCustomproductBulkDeleteFailures = bcgovCustomproductBulkDeleteFailures;
            Stageid = stageid;
            BcgovRelatedApplication = bcgovRelatedApplication;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproductid")]
        public string BcgovCustomproductid { get; set; }

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
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_stageid_value")]
        public string _stageidValue { get; set; }

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
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_name")]
        public string BcgovName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_relatedapplication_value")]
        public string _bcgovRelatedapplicationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_productdescriptionandintendeduse")]
        public string BcgovProductdescriptionandintendeduse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

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
        [JsonProperty(PropertyName = "bcgov_customproduct_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> BcgovCustomproductActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> BcgovCustomproductAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_Emails")]
        public IList<MicrosoftDynamicsCRMemail> BcgovCustomproductEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> BcgovCustomproductFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_Letters")]
        public IList<MicrosoftDynamicsCRMletter> BcgovCustomproductLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> BcgovCustomproductPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> BcgovCustomproductServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> BcgovCustomproductTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> BcgovCustomproductRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> BcgovCustomproductSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BcgovCustomproductSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_ActivityParties")]
        public IList<MicrosoftDynamicsCRMactivityparty> BcgovCustomproductActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> BcgovCustomproductConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> BcgovCustomproductConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovCustomproductDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovCustomproductDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> BcgovCustomproductSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> BcgovCustomproductQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_Teams")]
        public IList<MicrosoftDynamicsCRMteam> BcgovCustomproductTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BcgovCustomproductAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customproduct_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BcgovCustomproductBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public MicrosoftDynamicsCRMprocessstage Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_RelatedApplication")]
        public MicrosoftDynamicsCRMincident BcgovRelatedApplication { get; set; }

    }
}
