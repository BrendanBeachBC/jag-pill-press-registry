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
    /// FindParentResourceGroupResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMFindParentResourceGroupResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMFindParentResourceGroupResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMFindParentResourceGroupResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMFindParentResourceGroupResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMFindParentResourceGroupResponse(bool? result = default(bool?))
        {
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public bool? Result { get; set; }

    }
}
