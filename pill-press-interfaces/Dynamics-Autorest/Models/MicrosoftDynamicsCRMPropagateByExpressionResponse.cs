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
    /// PropagateByExpressionResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMPropagateByExpressionResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMPropagateByExpressionResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMPropagateByExpressionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMPropagateByExpressionResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMPropagateByExpressionResponse(string bulkOperationId = default(string))
        {
            BulkOperationId = bulkOperationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperationId")]
        public string BulkOperationId { get; set; }

    }
}
