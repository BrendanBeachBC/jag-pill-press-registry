// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// subscriptionsyncentryoffline
    /// </summary>
    public partial class MicrosoftDynamicsCRMsubscriptionsyncentryoffline
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsubscriptionsyncentryoffline class.
        /// </summary>
        public MicrosoftDynamicsCRMsubscriptionsyncentryoffline()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsubscriptionsyncentryoffline class.
        /// </summary>
        public MicrosoftDynamicsCRMsubscriptionsyncentryoffline(int? syncstate = default(int?), int? objecttypecode = default(int?), string objectid = default(string), string subscriptionid = default(string), long? versionnumber = default(long?))
        {
            Syncstate = syncstate;
            Objecttypecode = objecttypecode;
            Objectid = objectid;
            Subscriptionid = subscriptionid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "syncstate")]
        public int? Syncstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public int? Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid")]
        public string Objectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

    }
}
