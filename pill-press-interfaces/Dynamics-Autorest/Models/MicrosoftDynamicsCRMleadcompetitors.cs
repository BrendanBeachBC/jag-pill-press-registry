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
    /// leadcompetitors
    /// </summary>
    public partial class MicrosoftDynamicsCRMleadcompetitors
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMleadcompetitors class.
        /// </summary>
        public MicrosoftDynamicsCRMleadcompetitors()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMleadcompetitors class.
        /// </summary>
        public MicrosoftDynamicsCRMleadcompetitors(long? versionnumber = default(long?), string leadid = default(string), string competitorid = default(string), string leadcompetitorid = default(string))
        {
            Versionnumber = versionnumber;
            Leadid = leadid;
            Competitorid = competitorid;
            Leadcompetitorid = leadcompetitorid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadid")]
        public string Leadid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorid")]
        public string Competitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadcompetitorid")]
        public string Leadcompetitorid { get; set; }

    }
}
