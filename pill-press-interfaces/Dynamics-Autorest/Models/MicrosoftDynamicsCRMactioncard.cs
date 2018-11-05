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
    /// actioncard
    /// </summary>
    public partial class MicrosoftDynamicsCRMactioncard
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMactioncard
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMactioncard()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMactioncard
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMactioncard(string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? source = default(int?), int? state = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? priority = default(int?), string _regardingobjectidValue = default(string), string data = default(string), string _owninguserValue = default(string), string description = default(string), string referencetokens = default(string), string _createdbyValue = default(string), int? cardtype = default(int?), string _cardtypeidValue = default(string), string _owneridValue = default(string), System.DateTimeOffset? startdate = default(System.DateTimeOffset?), long? versionnumber = default(long?), string _modifiedonbehalfbyValue = default(string), object exchangerate = default(object), System.DateTimeOffset? expirydate = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), string actioncardid = default(string), string _transactioncurrencyidValue = default(string), bool? visibility = default(bool?), int? importsequencenumber = default(int?), string _recordidValue = default(string), string _owningteamValue = default(string), string title = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMletter regardingobjectidLetterActioncard = default(MicrosoftDynamicsCRMletter), MicrosoftDynamicsCRMphonecall regardingobjectidPhonecallActioncard = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMincident regardingobjectidIncidentActioncard = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMlead regardingobjectidLeadActioncard = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMfax regardingobjectidFaxActioncard = default(MicrosoftDynamicsCRMfax), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMcontact regardingobjectidContactActioncard = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMactioncarduserstate> actionCardUserStateActionCard = default(IList<MicrosoftDynamicsCRMactioncarduserstate>), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityActioncard = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMserviceappointment regardingobjectidServiceappointmentActioncard = default(MicrosoftDynamicsCRMserviceappointment), MicrosoftDynamicsCRMemail regardingobjectidEmailActioncard = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMappointment regardingobjectidAppointmentActioncard = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMrecurringappointmentmaster regardingobjectidRecurringappointmentmasterActioncard = default(MicrosoftDynamicsCRMrecurringappointmentmaster), MicrosoftDynamicsCRMaccount regardingobjectidAccountActioncard = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtask regardingobjectidTaskActioncard = default(MicrosoftDynamicsCRMtask))
        {
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            Source = source;
            State = state;
            Overriddencreatedon = overriddencreatedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Priority = priority;
            this._regardingobjectidValue = _regardingobjectidValue;
            Data = data;
            this._owninguserValue = _owninguserValue;
            Description = description;
            Referencetokens = referencetokens;
            this._createdbyValue = _createdbyValue;
            Cardtype = cardtype;
            this._cardtypeidValue = _cardtypeidValue;
            this._owneridValue = _owneridValue;
            Startdate = startdate;
            Versionnumber = versionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Exchangerate = exchangerate;
            Expirydate = expirydate;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Actioncardid = actioncardid;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Visibility = visibility;
            Importsequencenumber = importsequencenumber;
            this._recordidValue = _recordidValue;
            this._owningteamValue = _owningteamValue;
            Title = title;
            Modifiedon = modifiedon;
            RegardingobjectidLetterActioncard = regardingobjectidLetterActioncard;
            RegardingobjectidPhonecallActioncard = regardingobjectidPhonecallActioncard;
            RegardingobjectidIncidentActioncard = regardingobjectidIncidentActioncard;
            RegardingobjectidLeadActioncard = regardingobjectidLeadActioncard;
            RegardingobjectidFaxActioncard = regardingobjectidFaxActioncard;
            Owningbusinessunit = owningbusinessunit;
            Transactioncurrencyid = transactioncurrencyid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Ownerid = ownerid;
            RegardingobjectidContactActioncard = regardingobjectidContactActioncard;
            ActionCardUserStateActionCard = actionCardUserStateActionCard;
            RegardingobjectidOpportunityActioncard = regardingobjectidOpportunityActioncard;
            Createdonbehalfby = createdonbehalfby;
            RegardingobjectidServiceappointmentActioncard = regardingobjectidServiceappointmentActioncard;
            RegardingobjectidEmailActioncard = regardingobjectidEmailActioncard;
            RegardingobjectidAppointmentActioncard = regardingobjectidAppointmentActioncard;
            Createdby = createdby;
            RegardingobjectidRecurringappointmentmasterActioncard = regardingobjectidRecurringappointmentmasterActioncard;
            RegardingobjectidAccountActioncard = regardingobjectidAccountActioncard;
            Modifiedby = modifiedby;
            RegardingobjectidTaskActioncard = regardingobjectidTaskActioncard;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public int? Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public int? State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "referencetokens")]
        public string Referencetokens { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cardtype")]
        public int? Cardtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_cardtypeid_value")]
        public string _cardtypeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startdate")]
        public System.DateTimeOffset? Startdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expirydate")]
        public System.DateTimeOffset? Expirydate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actioncardid")]
        public string Actioncardid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "visibility")]
        public bool? Visibility { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_recordid_value")]
        public string _recordidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_letter_actioncard")]
        public MicrosoftDynamicsCRMletter RegardingobjectidLetterActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_phonecall_actioncard")]
        public MicrosoftDynamicsCRMphonecall RegardingobjectidPhonecallActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_actioncard")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_actioncard")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_fax_actioncard")]
        public MicrosoftDynamicsCRMfax RegardingobjectidFaxActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_actioncard")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActionCardUserState_ActionCard")]
        public IList<MicrosoftDynamicsCRMactioncarduserstate> ActionCardUserStateActionCard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_actioncard")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_serviceappointment_actioncard")]
        public MicrosoftDynamicsCRMserviceappointment RegardingobjectidServiceappointmentActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_email_actioncard")]
        public MicrosoftDynamicsCRMemail RegardingobjectidEmailActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_appointment_actioncard")]
        public MicrosoftDynamicsCRMappointment RegardingobjectidAppointmentActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_recurringappointmentmaster_actioncard")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster RegardingobjectidRecurringappointmentmasterActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_actioncard")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_task_actioncard")]
        public MicrosoftDynamicsCRMtask RegardingobjectidTaskActioncard { get; set; }

    }
}
