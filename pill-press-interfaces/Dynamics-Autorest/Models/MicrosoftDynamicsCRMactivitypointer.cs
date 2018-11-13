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
    /// activitypointer
    /// </summary>
    public partial class MicrosoftDynamicsCRMactivitypointer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMactivitypointer class.
        /// </summary>
        public MicrosoftDynamicsCRMactivitypointer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMactivitypointer class.
        /// </summary>
        public MicrosoftDynamicsCRMactivitypointer(string _owneridValue = default(string), string activityadditionalparams = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statuscode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _regardingobjectidValue = default(string), System.DateTimeOffset? scheduledstart = default(System.DateTimeOffset?), System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), bool? isbilled = default(bool?), string _transactioncurrencyidValue = default(string), int? prioritycode = default(int?), string _sendermailboxidValue = default(string), int? scheduleddurationminutes = default(int?), string _owninguserValue = default(string), string exchangeweblink = default(string), long? versionnumber = default(long?), string _owningbusinessunitValue = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? scheduledend = default(System.DateTimeOffset?), string _slainvokedidValue = default(string), System.DateTimeOffset? postponeactivityprocessinguntil = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? deliveryprioritycode = default(int?), string _owningteamValue = default(string), bool? ismapiprivate = default(bool?), string traversedpath = default(string), System.DateTimeOffset? actualend = default(System.DateTimeOffset?), int? actualdurationminutes = default(int?), string _serviceidValue = default(string), int? instancetypecode = default(int?), string _createdonbehalfbyValue = default(string), string seriesid = default(string), string activityid = default(string), string description = default(string), bool? leftvoicemail = default(bool?), bool? isworkflowcreated = default(bool?), System.DateTimeOffset? senton = default(System.DateTimeOffset?), string processid = default(string), int? community = default(int?), string _modifiedbyValue = default(string), string exchangeitemid = default(string), int? statecode = default(int?), string activitytypecode = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? actualstart = default(System.DateTimeOffset?), string subject = default(string), System.DateTimeOffset? deliverylastattemptedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string stageid = default(string), int? onholdtime = default(int?), System.DateTimeOffset? sortdate = default(System.DateTimeOffset?), bool? isregularactivity = default(bool?), object exchangerate = default(object), string _slaidValue = default(string), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemail = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlement = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplate = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebooking = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheader = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecord = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontract regardingobjectidContract = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMbulkoperationlog> createdActivityBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), IList<MicrosoftDynamicsCRMsocialactivity> activityPointerSocialactivity = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> activityPointerRecurringappointmentmaster = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMemail> activityPointerEmail = default(IList<MicrosoftDynamicsCRMemail>), MicrosoftDynamicsCRMmailbox sendermailboxid = default(MicrosoftDynamicsCRMmailbox), IList<MicrosoftDynamicsCRMquoteclose> activityPointerQuoteClose = default(IList<MicrosoftDynamicsCRMquoteclose>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMqueueitem> activityPointerQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorder = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkoperation> activityPointerBulkOperation = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMcampaignactivityitem> activityPointerCampaignActivityItems = default(IList<MicrosoftDynamicsCRMcampaignactivityitem>), MicrosoftDynamicsCRMsla slaActivitypointerSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMinvoice regardingobjectidInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMquote regardingobjectidQuote = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead), IList<MicrosoftDynamicsCRMcampaignresponse> activityPointerCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMserviceappointment> activityPointerServiceAppointment = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMactivitymimeattachment> activityPointerActivityMimeAttachment = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), IList<MicrosoftDynamicsCRMfax> activityPointerFax = default(IList<MicrosoftDynamicsCRMfax>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkoperationlog> activityPointerBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperation = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMservice serviceid = default(MicrosoftDynamicsCRMservice), IList<MicrosoftDynamicsCRMtask> activityPointerTask = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMopportunityclose> activityPointerOpportunityClose = default(IList<MicrosoftDynamicsCRMopportunityclose>), MicrosoftDynamicsCRMincident regardingobjectidIncident = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMcampaignresponse> activityCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMcampaignactivity> activityPointerCampaignactivity = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMphonecall> activityPointerPhonecall = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMappointment> activityPointerAppointment = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMorderclose> activityPointerOrderClose = default(IList<MicrosoftDynamicsCRMorderclose>), MicrosoftDynamicsCRMcampaign regardingobjectidCampaign = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMincidentresolution> activityPointerIncidentResolution = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMletter> activityPointerLetter = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceActivitypointer = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), IList<MicrosoftDynamicsCRMbulkdeletefailure> activityPointerBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMasyncoperation> activityPointerAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMactivityparty> activitypointerActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMbcgovCustomaddress regardingobjectidBcgovCustomaddress = default(MicrosoftDynamicsCRMbcgovCustomaddress), MicrosoftDynamicsCRMbcgovCustomproduct regardingobjectidBcgovCustomproduct = default(MicrosoftDynamicsCRMbcgovCustomproduct))
        {
            this._owneridValue = _owneridValue;
            Activityadditionalparams = activityadditionalparams;
            Createdon = createdon;
            Statuscode = statuscode;
            Modifiedon = modifiedon;
            this._regardingobjectidValue = _regardingobjectidValue;
            Scheduledstart = scheduledstart;
            Lastonholdtime = lastonholdtime;
            Isbilled = isbilled;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Prioritycode = prioritycode;
            this._sendermailboxidValue = _sendermailboxidValue;
            Scheduleddurationminutes = scheduleddurationminutes;
            this._owninguserValue = _owninguserValue;
            Exchangeweblink = exchangeweblink;
            Versionnumber = versionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Scheduledend = scheduledend;
            this._slainvokedidValue = _slainvokedidValue;
            Postponeactivityprocessinguntil = postponeactivityprocessinguntil;
            this._createdbyValue = _createdbyValue;
            Deliveryprioritycode = deliveryprioritycode;
            this._owningteamValue = _owningteamValue;
            Ismapiprivate = ismapiprivate;
            Traversedpath = traversedpath;
            Actualend = actualend;
            Actualdurationminutes = actualdurationminutes;
            this._serviceidValue = _serviceidValue;
            Instancetypecode = instancetypecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Seriesid = seriesid;
            Activityid = activityid;
            Description = description;
            Leftvoicemail = leftvoicemail;
            Isworkflowcreated = isworkflowcreated;
            Senton = senton;
            Processid = processid;
            Community = community;
            this._modifiedbyValue = _modifiedbyValue;
            Exchangeitemid = exchangeitemid;
            Statecode = statecode;
            Activitytypecode = activitytypecode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Actualstart = actualstart;
            Subject = subject;
            Deliverylastattemptedon = deliverylastattemptedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Stageid = stageid;
            Onholdtime = onholdtime;
            Sortdate = sortdate;
            Isregularactivity = isregularactivity;
            Exchangerate = exchangerate;
            this._slaidValue = _slaidValue;
            RegardingobjectidNewInteractionforemail = regardingobjectidNewInteractionforemail;
            RegardingobjectidEntitlement = regardingobjectidEntitlement;
            RegardingobjectidEntitlementtemplate = regardingobjectidEntitlementtemplate;
            RegardingobjectidBookableresourcebooking = regardingobjectidBookableresourcebooking;
            RegardingobjectidBookableresourcebookingheader = regardingobjectidBookableresourcebookingheader;
            RegardingobjectidKnowledgebaserecord = regardingobjectidKnowledgebaserecord;
            RegardingobjectidAccount = regardingobjectidAccount;
            RegardingobjectidContract = regardingobjectidContract;
            Createdby = createdby;
            RegardingobjectidContact = regardingobjectidContact;
            CreatedActivityBulkOperationLogs = createdActivityBulkOperationLogs;
            ActivityPointerSocialactivity = activityPointerSocialactivity;
            ActivityPointerRecurringappointmentmaster = activityPointerRecurringappointmentmaster;
            ActivityPointerEmail = activityPointerEmail;
            Sendermailboxid = sendermailboxid;
            ActivityPointerQuoteClose = activityPointerQuoteClose;
            Transactioncurrencyid = transactioncurrencyid;
            ActivityPointerQueueItem = activityPointerQueueItem;
            RegardingobjectidSalesorder = regardingobjectidSalesorder;
            Ownerid = ownerid;
            RegardingobjectidOpportunity = regardingobjectidOpportunity;
            Owninguser = owninguser;
            ActivityPointerBulkOperation = activityPointerBulkOperation;
            ActivityPointerCampaignActivityItems = activityPointerCampaignActivityItems;
            SlaActivitypointerSla = slaActivitypointerSla;
            RegardingobjectidInvoice = regardingobjectidInvoice;
            Owningbusinessunit = owningbusinessunit;
            RegardingobjectidKnowledgearticle = regardingobjectidKnowledgearticle;
            RegardingobjectidQuote = regardingobjectidQuote;
            RegardingobjectidLead = regardingobjectidLead;
            ActivityPointerCampaignresponse = activityPointerCampaignresponse;
            Modifiedonbehalfby = modifiedonbehalfby;
            ActivityPointerServiceAppointment = activityPointerServiceAppointment;
            ActivityPointerActivityMimeAttachment = activityPointerActivityMimeAttachment;
            ActivityPointerFax = activityPointerFax;
            Createdonbehalfby = createdonbehalfby;
            ActivityPointerBulkOperationLogs = activityPointerBulkOperationLogs;
            Modifiedby = modifiedby;
            RegardingobjectidBulkoperation = regardingobjectidBulkoperation;
            Serviceid = serviceid;
            ActivityPointerTask = activityPointerTask;
            ActivityPointerOpportunityClose = activityPointerOpportunityClose;
            RegardingobjectidIncident = regardingobjectidIncident;
            ActivityCampaignresponse = activityCampaignresponse;
            ActivityPointerCampaignactivity = activityPointerCampaignactivity;
            ActivityPointerPhonecall = activityPointerPhonecall;
            ActivityPointerAppointment = activityPointerAppointment;
            ActivityPointerOrderClose = activityPointerOrderClose;
            RegardingobjectidCampaign = regardingobjectidCampaign;
            ActivityPointerIncidentResolution = activityPointerIncidentResolution;
            ActivityPointerLetter = activityPointerLetter;
            ActivitypointerConnections2 = activitypointerConnections2;
            SlakpiinstanceActivitypointer = slakpiinstanceActivitypointer;
            Owningteam = owningteam;
            RegardingobjectidCampaignactivity = regardingobjectidCampaignactivity;
            ActivityPointerBulkDeleteFailures = activityPointerBulkDeleteFailures;
            SlainvokedidActivitypointerSla = slainvokedidActivitypointerSla;
            ActivitypointerConnections1 = activitypointerConnections1;
            ActivityPointerAsyncOperations = activityPointerAsyncOperations;
            ActivitypointerActivityParties = activitypointerActivityParties;
            RegardingobjectidBcgovCustomaddress = regardingobjectidBcgovCustomaddress;
            RegardingobjectidBcgovCustomproduct = regardingobjectidBcgovCustomproduct;
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
        [JsonProperty(PropertyName = "activityadditionalparams")]
        public string Activityadditionalparams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheduledstart")]
        public System.DateTimeOffset? Scheduledstart { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastonholdtime")]
        public System.DateTimeOffset? Lastonholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isbilled")]
        public bool? Isbilled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "prioritycode")]
        public int? Prioritycode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_sendermailboxid_value")]
        public string _sendermailboxidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheduleddurationminutes")]
        public int? Scheduleddurationminutes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangeweblink")]
        public string Exchangeweblink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheduledend")]
        public System.DateTimeOffset? Scheduledend { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slainvokedid_value")]
        public string _slainvokedidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postponeactivityprocessinguntil")]
        public System.DateTimeOffset? Postponeactivityprocessinguntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deliveryprioritycode")]
        public int? Deliveryprioritycode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismapiprivate")]
        public bool? Ismapiprivate { get; set; }

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
        [JsonProperty(PropertyName = "actualdurationminutes")]
        public int? Actualdurationminutes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_serviceid_value")]
        public string _serviceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "instancetypecode")]
        public int? Instancetypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "seriesid")]
        public string Seriesid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid")]
        public string Activityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leftvoicemail")]
        public bool? Leftvoicemail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isworkflowcreated")]
        public bool? Isworkflowcreated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "senton")]
        public System.DateTimeOffset? Senton { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "community")]
        public int? Community { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangeitemid")]
        public string Exchangeitemid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitytypecode")]
        public string Activitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualstart")]
        public System.DateTimeOffset? Actualstart { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deliverylastattemptedon")]
        public System.DateTimeOffset? Deliverylastattemptedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "onholdtime")]
        public int? Onholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sortdate")]
        public System.DateTimeOffset? Sortdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isregularactivity")]
        public bool? Isregularactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_new_interactionforemail")]
        public MicrosoftDynamicsCRMinteractionforemail RegardingobjectidNewInteractionforemail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebooking { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheader { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContract { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedActivity_BulkOperationLogs")]
        public IList<MicrosoftDynamicsCRMbulkoperationlog> CreatedActivityBulkOperationLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_socialactivity")]
        public IList<MicrosoftDynamicsCRMsocialactivity> ActivityPointerSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_recurringappointmentmaster")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> ActivityPointerRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_email")]
        public IList<MicrosoftDynamicsCRMemail> ActivityPointerEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendermailboxid")]
        public MicrosoftDynamicsCRMmailbox Sendermailboxid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_quote_close")]
        public IList<MicrosoftDynamicsCRMquoteclose> ActivityPointerQuoteClose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityPointer_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> ActivityPointerQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_BulkOperation")]
        public IList<MicrosoftDynamicsCRMbulkoperation> ActivityPointerBulkOperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityPointer_CampaignActivityItems")]
        public IList<MicrosoftDynamicsCRMcampaignactivityitem> ActivityPointerCampaignActivityItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_activitypointer_sla")]
        public MicrosoftDynamicsCRMsla SlaActivitypointerSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_campaignresponse")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> ActivityPointerCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_service_appointment")]
        public IList<MicrosoftDynamicsCRMserviceappointment> ActivityPointerServiceAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_activity_mime_attachment")]
        public IList<MicrosoftDynamicsCRMactivitymimeattachment> ActivityPointerActivityMimeAttachment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_fax")]
        public IList<MicrosoftDynamicsCRMfax> ActivityPointerFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_BulkOperation_logs")]
        public IList<MicrosoftDynamicsCRMbulkoperationlog> ActivityPointerBulkOperationLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid")]
        public MicrosoftDynamicsCRMservice Serviceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_task")]
        public IList<MicrosoftDynamicsCRMtask> ActivityPointerTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_opportunity_close")]
        public IList<MicrosoftDynamicsCRMopportunityclose> ActivityPointerOpportunityClose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_campaignresponse")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> ActivityCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_campaignactivity")]
        public IList<MicrosoftDynamicsCRMcampaignactivity> ActivityPointerCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_phonecall")]
        public IList<MicrosoftDynamicsCRMphonecall> ActivityPointerPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_appointment")]
        public IList<MicrosoftDynamicsCRMappointment> ActivityPointerAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_order_close")]
        public IList<MicrosoftDynamicsCRMorderclose> ActivityPointerOrderClose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaign { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_incident_resolution")]
        public IList<MicrosoftDynamicsCRMincidentresolution> ActivityPointerIncidentResolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activity_pointer_letter")]
        public IList<MicrosoftDynamicsCRMletter> ActivityPointerLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitypointer_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ActivitypointerConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_activitypointer")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityPointer_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ActivityPointerBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_activitypointer_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidActivitypointerSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitypointer_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ActivitypointerConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityPointer_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ActivityPointerAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitypointer_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> ActivitypointerActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_customaddress")]
        public MicrosoftDynamicsCRMbcgovCustomaddress RegardingobjectidBcgovCustomaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_customproduct")]
        public MicrosoftDynamicsCRMbcgovCustomproduct RegardingobjectidBcgovCustomproduct { get; set; }

    }
}
