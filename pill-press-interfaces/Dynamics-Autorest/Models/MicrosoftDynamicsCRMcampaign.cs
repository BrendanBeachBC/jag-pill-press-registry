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
    /// campaign
    /// </summary>
    public partial class MicrosoftDynamicsCRMcampaign
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcampaign
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcampaign()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcampaign
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcampaign(string _owneridValue = default(string), string campaignid = default(string), long? entityimageTimestamp = default(long?), string promotioncodename = default(string), string _modifiedonbehalfbyValue = default(string), long? versionnumber = default(long?), bool? istemplate = default(bool?), System.DateTimeOffset? actualstart = default(System.DateTimeOffset?), object totalcampaignactivityactualcostBase = default(object), string name = default(string), int? statecode = default(int?), string traversedpath = default(string), System.DateTimeOffset? actualend = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _pricelistidValue = default(string), string _transactioncurrencyidValue = default(string), int? utcconversiontimezonecode = default(int?), string _modifiedbyValue = default(string), System.DateTimeOffset? proposedstart = default(System.DateTimeOffset?), int? typecode = default(int?), string entityimageid = default(string), object budgetedcostBase = default(object), string _owningbusinessunitValue = default(string), string description = default(string), System.DateTimeOffset? proposedend = default(System.DateTimeOffset?), object totalcampaignactivityactualcost = default(object), object totalactualcost = default(object), int? timezoneruleversionnumber = default(int?), string codename = default(string), string entityimageUrl = default(string), string _owningteamValue = default(string), string objective = default(string), string message = default(string), object othercostBase = default(object), object expectedrevenueBase = default(object), object entityimage = default(object), object totalactualcostBase = default(object), object exchangerate = default(object), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), object budgetedcost = default(object), int? expectedresponse = default(int?), int? statuscode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string stageid = default(string), object expectedrevenue = default(object), string processid = default(string), int? importsequencenumber = default(int?), object othercost = default(object), string _createdonbehalfbyValue = default(string), IList<MicrosoftDynamicsCRMlist> campaignlistAssociation = default(IList<MicrosoftDynamicsCRMlist>), IList<MicrosoftDynamicsCRMcampaign> campaigncampaignAssociation = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMcampaign> campaigncampaignAssociationReferenced = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMsalesliterature> campaignsalesliteratureAssociation = default(IList<MicrosoftDynamicsCRMsalesliterature>), IList<MicrosoftDynamicsCRMproduct> campaignproductAssociation = default(IList<MicrosoftDynamicsCRMproduct>), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMopportunity> campaignOpportunities = default(IList<MicrosoftDynamicsCRMopportunity>), IList<MicrosoftDynamicsCRMcampaignactivity> campaignCampaignActivities = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMduplicaterecord> campaignDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMbulkdeletefailure> campaignBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMletter> campaignLetters = default(IList<MicrosoftDynamicsCRMletter>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> campaignRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsyncerror> campaignSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsalesorder> campaignOrders = default(IList<MicrosoftDynamicsCRMsalesorder>), IList<MicrosoftDynamicsCRMappointment> campaignAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMcampaignresponse> campaignCampaignResponses = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMconnection> campaignConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMduplicaterecord> campaignDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> campaignAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMtask> campaignTasks = default(IList<MicrosoftDynamicsCRMtask>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMemail> campaignEmails = default(IList<MicrosoftDynamicsCRMemail>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMannotation> campaignAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMserviceappointment> campaignServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMfax> campaignFaxes = default(IList<MicrosoftDynamicsCRMfax>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMactivitypointer> campaignActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMactivityparty> campaignActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMphonecall> campaignPhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMlead> campaignLeads = default(IList<MicrosoftDynamicsCRMlead>), MicrosoftDynamicsCRMpricelevel pricelistid = default(MicrosoftDynamicsCRMpricelevel), IList<MicrosoftDynamicsCRMconnection> campaignConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMquote> campaignQuotes = default(IList<MicrosoftDynamicsCRMquote>))
        {
            this._owneridValue = _owneridValue;
            Campaignid = campaignid;
            EntityimageTimestamp = entityimageTimestamp;
            Promotioncodename = promotioncodename;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Versionnumber = versionnumber;
            Istemplate = istemplate;
            Actualstart = actualstart;
            TotalcampaignactivityactualcostBase = totalcampaignactivityactualcostBase;
            Name = name;
            Statecode = statecode;
            Traversedpath = traversedpath;
            Actualend = actualend;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            this._pricelistidValue = _pricelistidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedbyValue = _modifiedbyValue;
            Proposedstart = proposedstart;
            Typecode = typecode;
            Entityimageid = entityimageid;
            BudgetedcostBase = budgetedcostBase;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Description = description;
            Proposedend = proposedend;
            Totalcampaignactivityactualcost = totalcampaignactivityactualcost;
            Totalactualcost = totalactualcost;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Codename = codename;
            EntityimageUrl = entityimageUrl;
            this._owningteamValue = _owningteamValue;
            Objective = objective;
            Message = message;
            OthercostBase = othercostBase;
            ExpectedrevenueBase = expectedrevenueBase;
            Entityimage = entityimage;
            TotalactualcostBase = totalactualcostBase;
            Exchangerate = exchangerate;
            Modifiedon = modifiedon;
            this._owninguserValue = _owninguserValue;
            Budgetedcost = budgetedcost;
            Expectedresponse = expectedresponse;
            Statuscode = statuscode;
            Overriddencreatedon = overriddencreatedon;
            Stageid = stageid;
            Expectedrevenue = expectedrevenue;
            Processid = processid;
            Importsequencenumber = importsequencenumber;
            Othercost = othercost;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            CampaignlistAssociation = campaignlistAssociation;
            CampaigncampaignAssociation = campaigncampaignAssociation;
            CampaigncampaignAssociationReferenced = campaigncampaignAssociationReferenced;
            CampaignsalesliteratureAssociation = campaignsalesliteratureAssociation;
            CampaignproductAssociation = campaignproductAssociation;
            Owninguser = owninguser;
            CampaignOpportunities = campaignOpportunities;
            CampaignCampaignActivities = campaignCampaignActivities;
            CampaignDuplicateBaseRecord = campaignDuplicateBaseRecord;
            Transactioncurrencyid = transactioncurrencyid;
            CampaignBulkDeleteFailures = campaignBulkDeleteFailures;
            CampaignLetters = campaignLetters;
            Owningteam = owningteam;
            CampaignRecurringAppointmentMasters = campaignRecurringAppointmentMasters;
            CampaignSyncErrors = campaignSyncErrors;
            Createdby = createdby;
            CampaignOrders = campaignOrders;
            CampaignAppointments = campaignAppointments;
            CampaignCampaignResponses = campaignCampaignResponses;
            Modifiedby = modifiedby;
            CampaignConnections1 = campaignConnections1;
            CampaignDuplicateMatchingRecord = campaignDuplicateMatchingRecord;
            Modifiedonbehalfby = modifiedonbehalfby;
            CampaignAsyncOperations = campaignAsyncOperations;
            Owningbusinessunit = owningbusinessunit;
            CampaignTasks = campaignTasks;
            Ownerid = ownerid;
            CampaignEmails = campaignEmails;
            Createdonbehalfby = createdonbehalfby;
            CampaignAnnotation = campaignAnnotation;
            CampaignServiceAppointments = campaignServiceAppointments;
            CampaignFaxes = campaignFaxes;
            StageidProcessstage = stageidProcessstage;
            CampaignActivityPointers = campaignActivityPointers;
            CampaignActivityParties = campaignActivityParties;
            CampaignPhonecalls = campaignPhonecalls;
            CampaignLeads = campaignLeads;
            Pricelistid = pricelistid;
            CampaignConnections2 = campaignConnections2;
            CampaignQuotes = campaignQuotes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignid")]
        public string Campaignid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "promotioncodename")]
        public string Promotioncodename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "istemplate")]
        public bool? Istemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualstart")]
        public System.DateTimeOffset? Actualstart { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalcampaignactivityactualcost_base")]
        public object TotalcampaignactivityactualcostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualend")]
        public System.DateTimeOffset? Actualend { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_pricelistid_value")]
        public string _pricelistidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "proposedstart")]
        public System.DateTimeOffset? Proposedstart { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "typecode")]
        public int? Typecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "budgetedcost_base")]
        public object BudgetedcostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "proposedend")]
        public System.DateTimeOffset? Proposedend { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalcampaignactivityactualcost")]
        public object Totalcampaignactivityactualcost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalactualcost")]
        public object Totalactualcost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "codename")]
        public string Codename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objective")]
        public string Objective { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "othercost_base")]
        public object OthercostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expectedrevenue_base")]
        public object ExpectedrevenueBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        public object Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalactualcost_base")]
        public object TotalactualcostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "budgetedcost")]
        public object Budgetedcost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expectedresponse")]
        public int? Expectedresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expectedrevenue")]
        public object Expectedrevenue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "othercost")]
        public object Othercost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignlist_association")]
        public IList<MicrosoftDynamicsCRMlist> CampaignlistAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaigncampaign_association")]
        public IList<MicrosoftDynamicsCRMcampaign> CampaigncampaignAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaigncampaign_association_referenced")]
        public IList<MicrosoftDynamicsCRMcampaign> CampaigncampaignAssociationReferenced { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignsalesliterature_association")]
        public IList<MicrosoftDynamicsCRMsalesliterature> CampaignsalesliteratureAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignproduct_association")]
        public IList<MicrosoftDynamicsCRMproduct> CampaignproductAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaign_opportunities")]
        public IList<MicrosoftDynamicsCRMopportunity> CampaignOpportunities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_CampaignActivities")]
        public IList<MicrosoftDynamicsCRMcampaignactivity> CampaignCampaignActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CampaignDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CampaignBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_Letters")]
        public IList<MicrosoftDynamicsCRMletter> CampaignLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> CampaignRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CampaignSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaign_orders")]
        public IList<MicrosoftDynamicsCRMsalesorder> CampaignOrders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> CampaignAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_CampaignResponses")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> CampaignCampaignResponses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaign_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> CampaignConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CampaignDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CampaignAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> CampaignTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_Emails")]
        public IList<MicrosoftDynamicsCRMemail> CampaignEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> CampaignAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> CampaignServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> CampaignFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> CampaignActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaign_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> CampaignActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Campaign_Phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> CampaignPhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaign_leads")]
        public IList<MicrosoftDynamicsCRMlead> CampaignLeads { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelistid")]
        public MicrosoftDynamicsCRMpricelevel Pricelistid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaign_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> CampaignConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaign_quotes")]
        public IList<MicrosoftDynamicsCRMquote> CampaignQuotes { get; set; }

    }
}
