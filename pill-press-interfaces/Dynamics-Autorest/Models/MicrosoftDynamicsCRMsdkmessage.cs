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
    /// sdkmessage
    /// </summary>
    public partial class MicrosoftDynamicsCRMsdkmessage
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsdkmessage
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsdkmessage
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessage(bool? autotransact = default(bool?), bool? workflowsdkstepenabled = default(bool?), long? versionnumber = default(long?), string _organizationidValue = default(string), bool? isreadonly = default(bool?), int? customizationlevel = default(int?), int? availability = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string categoryname = default(string), bool? isactive = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string sdkmessageid = default(string), string name = default(string), string _modifiedonbehalfbyValue = default(string), bool? isprivate = default(bool?), bool? isvalidforexecuteasync = default(bool?), string sdkmessageidunique = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), bool? template = default(bool?), string throttlesettings = default(string), bool? expand = default(bool?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> sdkmessageidSdkmessageprocessingstep = default(IList<MicrosoftDynamicsCRMsdkmessageprocessingstep>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsdkmessagefilter> sdkmessageidSdkmessagefilter = default(IList<MicrosoftDynamicsCRMsdkmessagefilter>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Autotransact = autotransact;
            Workflowsdkstepenabled = workflowsdkstepenabled;
            Versionnumber = versionnumber;
            this._organizationidValue = _organizationidValue;
            Isreadonly = isreadonly;
            Customizationlevel = customizationlevel;
            Availability = availability;
            Createdon = createdon;
            Categoryname = categoryname;
            Isactive = isactive;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            Sdkmessageid = sdkmessageid;
            Name = name;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Isprivate = isprivate;
            Isvalidforexecuteasync = isvalidforexecuteasync;
            Sdkmessageidunique = sdkmessageidunique;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Template = template;
            Throttlesettings = throttlesettings;
            Expand = expand;
            Createdby = createdby;
            SdkmessageidSdkmessageprocessingstep = sdkmessageidSdkmessageprocessingstep;
            Createdonbehalfby = createdonbehalfby;
            Organizationid = organizationid;
            SdkmessageidSdkmessagefilter = sdkmessageidSdkmessagefilter;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "autotransact")]
        public bool? Autotransact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowsdkstepenabled")]
        public bool? Workflowsdkstepenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isreadonly")]
        public bool? Isreadonly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customizationlevel")]
        public int? Customizationlevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "availability")]
        public int? Availability { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "categoryname")]
        public string Categoryname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isactive")]
        public bool? Isactive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageid")]
        public string Sdkmessageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isprivate")]
        public bool? Isprivate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isvalidforexecuteasync")]
        public bool? Isvalidforexecuteasync { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageidunique")]
        public string Sdkmessageidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public bool? Template { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "throttlesettings")]
        public string Throttlesettings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expand")]
        public bool? Expand { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageid_sdkmessageprocessingstep")]
        public IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> SdkmessageidSdkmessageprocessingstep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageid_sdkmessagefilter")]
        public IList<MicrosoftDynamicsCRMsdkmessagefilter> SdkmessageidSdkmessagefilter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
