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
    /// RequiredResource
    /// </summary>
    public partial class MicrosoftDynamicsCRMRequiredResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRequiredResource class.
        /// </summary>
        public MicrosoftDynamicsCRMRequiredResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRequiredResource class.
        /// </summary>
        public MicrosoftDynamicsCRMRequiredResource(string resourceId = default(string), string resourceSpecId = default(string))
        {
            ResourceId = resourceId;
            ResourceSpecId = resourceSpecId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceSpecId")]
        public string ResourceSpecId { get; set; }

    }
}
