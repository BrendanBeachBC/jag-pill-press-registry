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
    /// OptionMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMOptionMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMOptionMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMOptionMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMOptionMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMOptionMetadata(int? value = default(int?), MicrosoftDynamicsCRMLabel label = default(MicrosoftDynamicsCRMLabel), MicrosoftDynamicsCRMLabel description = default(MicrosoftDynamicsCRMLabel), string color = default(string), bool? isManaged = default(bool?), string metadataId = default(string), bool? hasChanged = default(bool?))
        {
            Value = value;
            Label = label;
            Description = description;
            Color = color;
            IsManaged = isManaged;
            MetadataId = metadataId;
            HasChanged = hasChanged;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public int? Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Label")]
        public MicrosoftDynamicsCRMLabel Label { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public MicrosoftDynamicsCRMLabel Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Color")]
        public string Color { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsManaged")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MetadataId")]
        public string MetadataId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasChanged")]
        public bool? HasChanged { get; set; }

    }
}
