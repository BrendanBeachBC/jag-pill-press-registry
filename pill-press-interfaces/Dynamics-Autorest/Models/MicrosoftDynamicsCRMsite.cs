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
    /// site
    /// </summary>
    public partial class MicrosoftDynamicsCRMsite
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsite class.
        /// </summary>
        public MicrosoftDynamicsCRMsite()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsite class.
        /// </summary>
        public MicrosoftDynamicsCRMsite(string _modifiedonbehalfbyValue = default(string), string address1Upszone = default(string), string address2Telephone1 = default(string), int? address2Shippingmethodcode = default(int?), string address1Name = default(string), string address2Upszone = default(string), string emailaddress = default(string), double? address2Latitude = default(double?), double? address1Longitude = default(double?), string organizationid = default(string), string _createdonbehalfbyValue = default(string), string address1Stateorprovince = default(string), string address1Telephone3 = default(string), int? address1Shippingmethodcode = default(int?), string name = default(string), string siteid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string address2City = default(string), string _createdbyValue = default(string), string address1Postalcode = default(string), long? versionnumber = default(long?), string address1Line2 = default(string), string address1Postofficebox = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string address2Country = default(string), int? address1Utcoffset = default(int?), string address2County = default(string), int? importsequencenumber = default(int?), int? timezonecode = default(int?), string address2Line1 = default(string), string address1Telephone1 = default(string), string address2Stateorprovince = default(string), int? address1Addresstypecode = default(int?), string address1City = default(string), string address2Postalcode = default(string), string address2Line3 = default(string), double? address1Latitude = default(double?), string address2Telephone3 = default(string), double? address2Longitude = default(double?), string address2Line2 = default(string), string address2Name = default(string), string _modifiedbyValue = default(string), int? address2Utcoffset = default(int?), string address1Country = default(string), string address1Line3 = default(string), string address2Postofficebox = default(string), string address2Telephone2 = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string address1Addressid = default(string), string address1Line1 = default(string), int? address2Addresstypecode = default(int?), string address2Fax = default(string), string address1County = default(string), string address1Telephone2 = default(string), string address2Addressid = default(string), string address1Fax = default(string), MicrosoftDynamicsCRMorganization organizationidOrganization = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> siteAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> siteBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMequipment> siteEquipment = default(IList<MicrosoftDynamicsCRMequipment>), IList<MicrosoftDynamicsCRMsystemuser> siteSystemUsers = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMsyncerror> siteSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMserviceappointment> siteServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMresource> siteResources = default(IList<MicrosoftDynamicsCRMresource>))
        {
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Address1Upszone = address1Upszone;
            Address2Telephone1 = address2Telephone1;
            Address2Shippingmethodcode = address2Shippingmethodcode;
            Address1Name = address1Name;
            Address2Upszone = address2Upszone;
            Emailaddress = emailaddress;
            Address2Latitude = address2Latitude;
            Address1Longitude = address1Longitude;
            Organizationid = organizationid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Address1Stateorprovince = address1Stateorprovince;
            Address1Telephone3 = address1Telephone3;
            Address1Shippingmethodcode = address1Shippingmethodcode;
            Name = name;
            Siteid = siteid;
            Overriddencreatedon = overriddencreatedon;
            Address2City = address2City;
            this._createdbyValue = _createdbyValue;
            Address1Postalcode = address1Postalcode;
            Versionnumber = versionnumber;
            Address1Line2 = address1Line2;
            Address1Postofficebox = address1Postofficebox;
            Modifiedon = modifiedon;
            Address2Country = address2Country;
            Address1Utcoffset = address1Utcoffset;
            Address2County = address2County;
            Importsequencenumber = importsequencenumber;
            Timezonecode = timezonecode;
            Address2Line1 = address2Line1;
            Address1Telephone1 = address1Telephone1;
            Address2Stateorprovince = address2Stateorprovince;
            Address1Addresstypecode = address1Addresstypecode;
            Address1City = address1City;
            Address2Postalcode = address2Postalcode;
            Address2Line3 = address2Line3;
            Address1Latitude = address1Latitude;
            Address2Telephone3 = address2Telephone3;
            Address2Longitude = address2Longitude;
            Address2Line2 = address2Line2;
            Address2Name = address2Name;
            this._modifiedbyValue = _modifiedbyValue;
            Address2Utcoffset = address2Utcoffset;
            Address1Country = address1Country;
            Address1Line3 = address1Line3;
            Address2Postofficebox = address2Postofficebox;
            Address2Telephone2 = address2Telephone2;
            Createdon = createdon;
            Address1Addressid = address1Addressid;
            Address1Line1 = address1Line1;
            Address2Addresstypecode = address2Addresstypecode;
            Address2Fax = address2Fax;
            Address1County = address1County;
            Address1Telephone2 = address1Telephone2;
            Address2Addressid = address2Addressid;
            Address1Fax = address1Fax;
            OrganizationidOrganization = organizationidOrganization;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            SiteAsyncOperations = siteAsyncOperations;
            SiteBulkDeleteFailures = siteBulkDeleteFailures;
            SiteEquipment = siteEquipment;
            SiteSystemUsers = siteSystemUsers;
            SiteSyncErrors = siteSyncErrors;
            SiteServiceAppointments = siteServiceAppointments;
            Modifiedonbehalfby = modifiedonbehalfby;
            SiteResources = siteResources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_upszone")]
        public string Address1Upszone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_telephone1")]
        public string Address2Telephone1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_shippingmethodcode")]
        public int? Address2Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_name")]
        public string Address1Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_upszone")]
        public string Address2Upszone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_latitude")]
        public double? Address2Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_longitude")]
        public double? Address1Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_stateorprovince")]
        public string Address1Stateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_telephone3")]
        public string Address1Telephone3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_shippingmethodcode")]
        public int? Address1Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "siteid")]
        public string Siteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_city")]
        public string Address2City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_postalcode")]
        public string Address1Postalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_line2")]
        public string Address1Line2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_postofficebox")]
        public string Address1Postofficebox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_country")]
        public string Address2Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_utcoffset")]
        public int? Address1Utcoffset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_county")]
        public string Address2County { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezonecode")]
        public int? Timezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_line1")]
        public string Address2Line1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_telephone1")]
        public string Address1Telephone1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_stateorprovince")]
        public string Address2Stateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_addresstypecode")]
        public int? Address1Addresstypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_city")]
        public string Address1City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_postalcode")]
        public string Address2Postalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_line3")]
        public string Address2Line3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_latitude")]
        public double? Address1Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_telephone3")]
        public string Address2Telephone3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_longitude")]
        public double? Address2Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_line2")]
        public string Address2Line2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_name")]
        public string Address2Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_utcoffset")]
        public int? Address2Utcoffset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_country")]
        public string Address1Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_line3")]
        public string Address1Line3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_postofficebox")]
        public string Address2Postofficebox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_telephone2")]
        public string Address2Telephone2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_addressid")]
        public string Address1Addressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_line1")]
        public string Address1Line1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_addresstypecode")]
        public int? Address2Addresstypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_fax")]
        public string Address2Fax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_county")]
        public string Address1County { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_telephone2")]
        public string Address1Telephone2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_addressid")]
        public string Address2Addressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_fax")]
        public string Address1Fax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid_organization")]
        public MicrosoftDynamicsCRMorganization OrganizationidOrganization { get; set; }

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
        [JsonProperty(PropertyName = "Site_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SiteAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Site_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SiteBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_equipment")]
        public IList<MicrosoftDynamicsCRMequipment> SiteEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_system_users")]
        public IList<MicrosoftDynamicsCRMsystemuser> SiteSystemUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Site_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SiteSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_service_appointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> SiteServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_resources")]
        public IList<MicrosoftDynamicsCRMresource> SiteResources { get; set; }

    }
}
