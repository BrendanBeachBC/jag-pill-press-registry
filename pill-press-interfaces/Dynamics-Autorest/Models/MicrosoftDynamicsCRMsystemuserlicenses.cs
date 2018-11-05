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
    /// systemuserlicenses
    /// </summary>
    public partial class MicrosoftDynamicsCRMsystemuserlicenses
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsystemuserlicenses class.
        /// </summary>
        public MicrosoftDynamicsCRMsystemuserlicenses()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsystemuserlicenses class.
        /// </summary>
        public MicrosoftDynamicsCRMsystemuserlicenses(string systemuserid = default(string), string licenseid = default(string), string systemuserlicenseid = default(string))
        {
            Systemuserid = systemuserid;
            Licenseid = licenseid;
            Systemuserlicenseid = systemuserlicenseid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemuserid")]
        public string Systemuserid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "licenseid")]
        public string Licenseid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemuserlicenseid")]
        public string Systemuserlicenseid { get; set; }

    }
}
