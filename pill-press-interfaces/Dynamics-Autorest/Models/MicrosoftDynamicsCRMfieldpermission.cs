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
    /// Microsoft.Dynamics.CRM.fieldpermission
    /// </summary>
    public partial class MicrosoftDynamicsCRMfieldpermission
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfieldpermission class.
        /// </summary>
        public MicrosoftDynamicsCRMfieldpermission()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfieldpermission class.
        /// </summary>
        /// <param name="attributelogicalname">Attribute Name.</param>
        /// <param name="fieldpermissionid">Unique identifier of the Field
        /// Permission.</param>
        /// <param name="cancreate">Can this Profile create the
        /// attribute</param>
        /// <param name="componentstate">For internal use only.</param>
        /// <param name="overwritetime">For internal use only.</param>
        /// <param name="canupdate">Can this Profile update the
        /// attribute</param>
        /// <param name="_organizationidValue">Unique identifier for the
        /// organization</param>
        /// <param name="fieldpermissionidunique">For internal use
        /// only.</param>
        /// <param name="solutionid">Unique identifier of the associated
        /// solution.</param>
        /// <param name="_fieldsecurityprofileidValue">Unique identifier of
        /// profile to which this privilege belongs.</param>
        /// <param name="entityname">Entity name.</param>
        /// <param name="ismanaged">Indicates whether the solution component is
        /// part of a managed solution.</param>
        /// <param name="canread">Can this Profile read the attribute</param>
        public MicrosoftDynamicsCRMfieldpermission(string attributelogicalname = default(string), string fieldpermissionid = default(string), int? cancreate = default(int?), int? componentstate = default(int?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? canupdate = default(int?), string _organizationidValue = default(string), string fieldpermissionidunique = default(string), string solutionid = default(string), string _fieldsecurityprofileidValue = default(string), string versionnumber = default(string), string entityname = default(string), bool? ismanaged = default(bool?), int? canread = default(int?), IList<MicrosoftDynamicsCRMsyncerror> fieldPermissionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMfieldsecurityprofile fieldsecurityprofileid = default(MicrosoftDynamicsCRMfieldsecurityprofile))
        {
            Attributelogicalname = attributelogicalname;
            Fieldpermissionid = fieldpermissionid;
            Cancreate = cancreate;
            Componentstate = componentstate;
            Overwritetime = overwritetime;
            Canupdate = canupdate;
            this._organizationidValue = _organizationidValue;
            Fieldpermissionidunique = fieldpermissionidunique;
            Solutionid = solutionid;
            this._fieldsecurityprofileidValue = _fieldsecurityprofileidValue;
            Versionnumber = versionnumber;
            Entityname = entityname;
            Ismanaged = ismanaged;
            Canread = canread;
            FieldPermissionSyncErrors = fieldPermissionSyncErrors;
            Fieldsecurityprofileid = fieldsecurityprofileid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets attribute Name.
        /// </summary>
        [JsonProperty(PropertyName = "attributelogicalname")]
        public string Attributelogicalname { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the Field Permission.
        /// </summary>
        [JsonProperty(PropertyName = "fieldpermissionid")]
        public string Fieldpermissionid { get; set; }

        /// <summary>
        /// Gets or sets can this Profile create the attribute
        /// </summary>
        [JsonProperty(PropertyName = "cancreate")]
        public int? Cancreate { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// Gets or sets can this Profile update the attribute
        /// </summary>
        [JsonProperty(PropertyName = "canupdate")]
        public int? Canupdate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the organization
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "fieldpermissionidunique")]
        public string Fieldpermissionidunique { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of profile to which this privilege
        /// belongs.
        /// </summary>
        [JsonProperty(PropertyName = "_fieldsecurityprofileid_value")]
        public string _fieldsecurityprofileidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets entity name.
        /// </summary>
        [JsonProperty(PropertyName = "entityname")]
        public string Entityname { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the solution component is part of a
        /// managed solution.
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// Gets or sets can this Profile read the attribute
        /// </summary>
        [JsonProperty(PropertyName = "canread")]
        public int? Canread { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FieldPermission_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> FieldPermissionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fieldsecurityprofileid")]
        public MicrosoftDynamicsCRMfieldsecurityprofile Fieldsecurityprofileid { get; set; }

    }
}
