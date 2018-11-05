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
    /// leadaddress
    /// </summary>
    public partial class MicrosoftDynamicsCRMleadaddress
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMleadaddress
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMleadaddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMleadaddress
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMleadaddress(string _parentidValue = default(string), string upszone = default(string), object exchangerate = default(object), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string line1 = default(string), string stateorprovince = default(string), string _modifiedbyValue = default(string), string name = default(string), long? versionnumber = default(long?), int? addressnumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string country = default(string), string telephone2 = default(string), string line2 = default(string), string _createdonbehalfbyValue = default(string), double? latitude = default(double?), string postofficebox = default(string), string _createdbyValue = default(string), string telephone3 = default(string), string telephone1 = default(string), string fax = default(string), string composite = default(string), string leadaddressid = default(string), string line3 = default(string), int? addresstypecode = default(int?), int? shippingmethodcode = default(int?), string county = default(string), string _transactioncurrencyidValue = default(string), string _modifiedonbehalfbyValue = default(string), double? longitude = default(double?), string city = default(string), string postalcode = default(string), int? utcoffset = default(int?), IList<MicrosoftDynamicsCRMsyncerror> leadAddressSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMlead parentid = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            this._parentidValue = _parentidValue;
            Upszone = upszone;
            Exchangerate = exchangerate;
            Createdon = createdon;
            Line1 = line1;
            Stateorprovince = stateorprovince;
            this._modifiedbyValue = _modifiedbyValue;
            Name = name;
            Versionnumber = versionnumber;
            Addressnumber = addressnumber;
            Modifiedon = modifiedon;
            Country = country;
            Telephone2 = telephone2;
            Line2 = line2;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Latitude = latitude;
            Postofficebox = postofficebox;
            this._createdbyValue = _createdbyValue;
            Telephone3 = telephone3;
            Telephone1 = telephone1;
            Fax = fax;
            Composite = composite;
            Leadaddressid = leadaddressid;
            Line3 = line3;
            Addresstypecode = addresstypecode;
            Shippingmethodcode = shippingmethodcode;
            County = county;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Longitude = longitude;
            City = city;
            Postalcode = postalcode;
            Utcoffset = utcoffset;
            LeadAddressSyncErrors = leadAddressSyncErrors;
            Parentid = parentid;
            Modifiedby = modifiedby;
            Createdonbehalfby = createdonbehalfby;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentid_value")]
        public string _parentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "upszone")]
        public string Upszone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stateorprovince")]
        public string Stateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressnumber")]
        public int? Addressnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telephone2")]
        public string Telephone2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postofficebox")]
        public string Postofficebox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telephone3")]
        public string Telephone3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telephone1")]
        public string Telephone1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "composite")]
        public string Composite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadaddressid")]
        public string Leadaddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "line3")]
        public string Line3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addresstypecode")]
        public int? Addresstypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "county")]
        public string County { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postalcode")]
        public string Postalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcoffset")]
        public int? Utcoffset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LeadAddress_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> LeadAddressSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentid")]
        public MicrosoftDynamicsCRMlead Parentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
