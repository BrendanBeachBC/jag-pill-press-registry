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
    /// CascadeConfiguration
    /// </summary>
    public partial class MicrosoftDynamicsCRMCascadeConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCascadeConfiguration class.
        /// </summary>
        public MicrosoftDynamicsCRMCascadeConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCascadeConfiguration class.
        /// </summary>
        /// <param name="assign">Possible values include: 'NoCascade',
        /// 'Cascade', 'Active', 'UserOwned', 'RemoveLink', 'Restrict'</param>
        /// <param name="delete">Possible values include: 'NoCascade',
        /// 'Cascade', 'Active', 'UserOwned', 'RemoveLink', 'Restrict'</param>
        /// <param name="merge">Possible values include: 'NoCascade',
        /// 'Cascade', 'Active', 'UserOwned', 'RemoveLink', 'Restrict'</param>
        /// <param name="reparent">Possible values include: 'NoCascade',
        /// 'Cascade', 'Active', 'UserOwned', 'RemoveLink', 'Restrict'</param>
        /// <param name="share">Possible values include: 'NoCascade',
        /// 'Cascade', 'Active', 'UserOwned', 'RemoveLink', 'Restrict'</param>
        /// <param name="unshare">Possible values include: 'NoCascade',
        /// 'Cascade', 'Active', 'UserOwned', 'RemoveLink', 'Restrict'</param>
        /// <param name="rollupView">Possible values include: 'NoCascade',
        /// 'Cascade', 'Active', 'UserOwned', 'RemoveLink', 'Restrict'</param>
        public MicrosoftDynamicsCRMCascadeConfiguration(string assign = default(string), string delete = default(string), string merge = default(string), string reparent = default(string), string share = default(string), string unshare = default(string), string rollupView = default(string))
        {
            Assign = assign;
            Delete = delete;
            Merge = merge;
            Reparent = reparent;
            Share = share;
            Unshare = unshare;
            RollupView = rollupView;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'NoCascade', 'Cascade',
        /// 'Active', 'UserOwned', 'RemoveLink', 'Restrict'
        /// </summary>
        [JsonProperty(PropertyName = "Assign")]
        public string Assign { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NoCascade', 'Cascade',
        /// 'Active', 'UserOwned', 'RemoveLink', 'Restrict'
        /// </summary>
        [JsonProperty(PropertyName = "Delete")]
        public string Delete { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NoCascade', 'Cascade',
        /// 'Active', 'UserOwned', 'RemoveLink', 'Restrict'
        /// </summary>
        [JsonProperty(PropertyName = "Merge")]
        public string Merge { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NoCascade', 'Cascade',
        /// 'Active', 'UserOwned', 'RemoveLink', 'Restrict'
        /// </summary>
        [JsonProperty(PropertyName = "Reparent")]
        public string Reparent { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NoCascade', 'Cascade',
        /// 'Active', 'UserOwned', 'RemoveLink', 'Restrict'
        /// </summary>
        [JsonProperty(PropertyName = "Share")]
        public string Share { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NoCascade', 'Cascade',
        /// 'Active', 'UserOwned', 'RemoveLink', 'Restrict'
        /// </summary>
        [JsonProperty(PropertyName = "Unshare")]
        public string Unshare { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NoCascade', 'Cascade',
        /// 'Active', 'UserOwned', 'RemoveLink', 'Restrict'
        /// </summary>
        [JsonProperty(PropertyName = "RollupView")]
        public string RollupView { get; set; }

    }
}
