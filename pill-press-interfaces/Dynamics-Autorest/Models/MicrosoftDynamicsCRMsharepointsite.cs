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
    /// sharepointsite
    /// </summary>
    public partial class MicrosoftDynamicsCRMsharepointsite
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsharepointsite class.
        /// </summary>
        public MicrosoftDynamicsCRMsharepointsite()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsharepointsite class.
        /// </summary>
        public MicrosoftDynamicsCRMsharepointsite(string userid = default(string), int? statecode = default(int?), int? validationstatus = default(int?), string _modifiedonbehalfbyValue = default(string), string absoluteurl = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string sitecollectionid = default(string), string _modifiedbyValue = default(string), object exchangerate = default(object), string _createdonbehalfbyValue = default(string), int? statuscode = default(int?), bool? isgridpresent = default(bool?), string _parentsiteValue = default(string), int? validationstatuserrorcode = default(int?), int? servicetype = default(int?), string _createdbyValue = default(string), string _owningteamValue = default(string), string _transactioncurrencyidValue = default(string), int? timezoneruleversionnumber = default(int?), string relativeurl = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), string description = default(string), System.DateTimeOffset? lastvalidated = default(System.DateTimeOffset?), bool? isdefault = default(bool?), int? utcconversiontimezonecode = default(int?), bool? ispowerbisite = default(bool?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), long? versionnumber = default(long?), string sharepointsiteid = default(string), int? importsequencenumber = default(int?), string folderstructureentity = default(string), string name = default(string), string _owninguserValue = default(string), string _owneridValue = default(string), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> sharePointSiteDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMsharepointsite parentsite = default(MicrosoftDynamicsCRMsharepointsite), IList<MicrosoftDynamicsCRMsharepointsite> sharepointsiteParentsiteSharepointsite = default(IList<MicrosoftDynamicsCRMsharepointsite>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMduplicaterecord> sharePointSiteDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> sharepointdocumentlocationParentSharepointsite = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> sharePointSiteAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsyncerror> sharePointSiteSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            Userid = userid;
            Statecode = statecode;
            Validationstatus = validationstatus;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Absoluteurl = absoluteurl;
            Modifiedon = modifiedon;
            Sitecollectionid = sitecollectionid;
            this._modifiedbyValue = _modifiedbyValue;
            Exchangerate = exchangerate;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statuscode = statuscode;
            Isgridpresent = isgridpresent;
            this._parentsiteValue = _parentsiteValue;
            Validationstatuserrorcode = validationstatuserrorcode;
            Servicetype = servicetype;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Relativeurl = relativeurl;
            Createdon = createdon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Description = description;
            Lastvalidated = lastvalidated;
            Isdefault = isdefault;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Ispowerbisite = ispowerbisite;
            Overriddencreatedon = overriddencreatedon;
            Versionnumber = versionnumber;
            Sharepointsiteid = sharepointsiteid;
            Importsequencenumber = importsequencenumber;
            Folderstructureentity = folderstructureentity;
            Name = name;
            this._owninguserValue = _owninguserValue;
            this._owneridValue = _owneridValue;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            SharePointSiteDuplicateMatchingRecord = sharePointSiteDuplicateMatchingRecord;
            Parentsite = parentsite;
            SharepointsiteParentsiteSharepointsite = sharepointsiteParentsiteSharepointsite;
            Owningbusinessunit = owningbusinessunit;
            SharePointSiteDuplicateBaseRecord = sharePointSiteDuplicateBaseRecord;
            SharepointdocumentlocationParentSharepointsite = sharepointdocumentlocationParentSharepointsite;
            Modifiedonbehalfby = modifiedonbehalfby;
            SharePointSiteAsyncOperations = sharePointSiteAsyncOperations;
            Transactioncurrencyid = transactioncurrencyid;
            SharePointSiteSyncErrors = sharePointSiteSyncErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userid")]
        public string Userid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validationstatus")]
        public int? Validationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "absoluteurl")]
        public string Absoluteurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sitecollectionid")]
        public string Sitecollectionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isgridpresent")]
        public bool? Isgridpresent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentsite_value")]
        public string _parentsiteValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validationstatuserrorcode")]
        public int? Validationstatuserrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicetype")]
        public int? Servicetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relativeurl")]
        public string Relativeurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastvalidated")]
        public System.DateTimeOffset? Lastvalidated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispowerbisite")]
        public bool? Ispowerbisite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharepointsiteid")]
        public string Sharepointsiteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "folderstructureentity")]
        public string Folderstructureentity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SharePointSite_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SharePointSiteDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentsite")]
        public MicrosoftDynamicsCRMsharepointsite Parentsite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharepointsite_parentsite_sharepointsite")]
        public IList<MicrosoftDynamicsCRMsharepointsite> SharepointsiteParentsiteSharepointsite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SharePointSite_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SharePointSiteDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharepointdocumentlocation_parent_sharepointsite")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> SharepointdocumentlocationParentSharepointsite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SharePointSite_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SharePointSiteAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SharePointSite_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SharePointSiteSyncErrors { get; set; }

    }
}
