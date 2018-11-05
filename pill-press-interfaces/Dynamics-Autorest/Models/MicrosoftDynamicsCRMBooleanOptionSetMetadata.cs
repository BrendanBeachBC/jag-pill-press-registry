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
    /// BooleanOptionSetMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMBooleanOptionSetMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBooleanOptionSetMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMBooleanOptionSetMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBooleanOptionSetMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMBooleanOptionSetMetadata(MicrosoftDynamicsCRMOptionMetadata trueOption = default(MicrosoftDynamicsCRMOptionMetadata), MicrosoftDynamicsCRMOptionMetadata falseOption = default(MicrosoftDynamicsCRMOptionMetadata))
        {
            TrueOption = trueOption;
            FalseOption = falseOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TrueOption")]
        public MicrosoftDynamicsCRMOptionMetadata TrueOption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FalseOption")]
        public MicrosoftDynamicsCRMOptionMetadata FalseOption { get; set; }

    }
}
