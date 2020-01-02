// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.kbarticle
    /// </summary>
    public partial class MicrosoftDynamicsCRMkbarticle
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMkbarticle
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMkbarticle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMkbarticle
        /// class.
        /// </summary>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="_transactioncurrencyidValue">Choose the local currency
        /// for the record to make sure budgets are reported in the correct
        /// currency.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization associated with the article.</param>
        /// <param name="_kbarticletemplateidValue">Choose the template that
        /// you want to use as a base for creating the new article.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the article.</param>
        /// <param name="title">Type a subject or descriptive name for the
        /// article to assist with article searches.</param>
        /// <param name="entityimageid">For internal use only.</param>
        /// <param name="versionnumber">Title of the knowledge base
        /// article.</param>
        /// <param name="_subjectidValue">Choose the subject of the article to
        /// assist with article searches. You can configure subjects under
        /// Business Management in the Settings area.</param>
        /// <param name="exchangerate">Shows the conversion rate of the
        /// record's currency. The exchange rate is used to convert all money
        /// fields in the record from the local currency to the system's
        /// default currency.</param>
        /// <param name="keywords">Keywords to be used for searches in
        /// knowledge base articles.</param>
        /// <param name="statuscode">Select the article's status.</param>
        /// <param name="number">Knowledge base article number.</param>
        /// <param name="modifiedon">Date and time when the knowledge base
        /// article was last modified.</param>
        /// <param name="kbarticleid">Shows the ID of the article.</param>
        /// <param name="comments">Comments regarding the knowledge base
        /// article.</param>
        /// <param name="content">Description of the content of the knowledge
        /// base article.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the knowledge base article.</param>
        /// <param name="entityimage">The default image for the entity.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the kbarticle.</param>
        /// <param name="createdon">Date and time when the knowledge base
        /// article was created.</param>
        /// <param name="languagecode">Select which language the article must
        /// be available in. This list is based on the list of language packs
        /// that are installed in your Microsoft Dynamics 365
        /// environment.</param>
        /// <param name="articlexml">Shows the article content and formatting,
        /// stored as XML.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="statecode">Shows whether the knowledge base article is
        /// in draft, unapproved, or published status. Published articles are
        /// read-only and can't be edited unless they are unpublished.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the knowledge base article.</param>
        /// <param name="description">Type additional information that
        /// describes the knowledge base article.</param>
        public MicrosoftDynamicsCRMkbarticle(string entityimageUrl = default(string), int? importsequencenumber = default(int?), string _transactioncurrencyidValue = default(string), string _organizationidValue = default(string), string _kbarticletemplateidValue = default(string), string _createdonbehalfbyValue = default(string), long? entityimageTimestamp = default(long?), string title = default(string), string entityimageid = default(string), string versionnumber = default(string), string _subjectidValue = default(string), decimal? exchangerate = default(decimal?), string keywords = default(string), int? statuscode = default(int?), string number = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string kbarticleid = default(string), string comments = default(string), string content = default(string), string _createdbyValue = default(string), byte[] entityimage = default(byte[]), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? languagecode = default(int?), string articlexml = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? statecode = default(int?), string _modifiedbyValue = default(string), string description = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMannotation> kbArticleAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> kbArticleBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMasyncoperation> kbArticleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMduplicaterecord> kbArticleDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMkbarticletemplate kbarticletemplateid = default(MicrosoftDynamicsCRMkbarticletemplate), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> kbArticleDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> kbArticleSharepointDocumentLocation = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMkbarticlecomment> kbarticleComments = default(IList<MicrosoftDynamicsCRMkbarticlecomment>), IList<MicrosoftDynamicsCRMsyncerror> kbArticleSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsubject subjectid = default(MicrosoftDynamicsCRMsubject), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMincident> kbarticleIncidents = default(IList<MicrosoftDynamicsCRMincident>))
        {
            EntityimageUrl = entityimageUrl;
            Importsequencenumber = importsequencenumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._organizationidValue = _organizationidValue;
            this._kbarticletemplateidValue = _kbarticletemplateidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            EntityimageTimestamp = entityimageTimestamp;
            Title = title;
            Entityimageid = entityimageid;
            Versionnumber = versionnumber;
            this._subjectidValue = _subjectidValue;
            Exchangerate = exchangerate;
            Keywords = keywords;
            Statuscode = statuscode;
            Number = number;
            Modifiedon = modifiedon;
            Kbarticleid = kbarticleid;
            Comments = comments;
            Content = content;
            this._createdbyValue = _createdbyValue;
            Entityimage = entityimage;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdon = createdon;
            Languagecode = languagecode;
            Articlexml = articlexml;
            Overriddencreatedon = overriddencreatedon;
            Statecode = statecode;
            this._modifiedbyValue = _modifiedbyValue;
            Description = description;
            Createdonbehalfby = createdonbehalfby;
            KbArticleAnnotation = kbArticleAnnotation;
            KbArticleBulkDeleteFailures = kbArticleBulkDeleteFailures;
            KbArticleAsyncOperations = kbArticleAsyncOperations;
            KbArticleDuplicateMatchingRecord = kbArticleDuplicateMatchingRecord;
            Kbarticletemplateid = kbarticletemplateid;
            Createdby = createdby;
            KbArticleDuplicateBaseRecord = kbArticleDuplicateBaseRecord;
            KbArticleSharepointDocumentLocation = kbArticleSharepointDocumentLocation;
            Organizationid = organizationid;
            KbarticleComments = kbarticleComments;
            KbArticleSyncErrors = kbArticleSyncErrors;
            Subjectid = subjectid;
            Transactioncurrencyid = transactioncurrencyid;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            KbarticleIncidents = kbarticleIncidents;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets choose the local currency for the record to make sure
        /// budgets are reported in the correct currency.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization associated with
        /// the article.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets choose the template that you want to use as a base for
        /// creating the new article.
        /// </summary>
        [JsonProperty(PropertyName = "_kbarticletemplateid_value")]
        public string _kbarticletemplateidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// article.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// Gets or sets type a subject or descriptive name for the article to
        /// assist with article searches.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// Gets or sets title of the knowledge base article.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets choose the subject of the article to assist with
        /// article searches. You can configure subjects under Business
        /// Management in the Settings area.
        /// </summary>
        [JsonProperty(PropertyName = "_subjectid_value")]
        public string _subjectidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the conversion rate of the record's currency.
        /// The exchange rate is used to convert all money fields in the record
        /// from the local currency to the system's default currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets keywords to be used for searches in knowledge base
        /// articles.
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or sets select the article's status.
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets knowledge base article number.
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets date and time when the knowledge base article was last
        /// modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets shows the ID of the article.
        /// </summary>
        [JsonProperty(PropertyName = "kbarticleid")]
        public string Kbarticleid { get; set; }

        /// <summary>
        /// Gets or sets comments regarding the knowledge base article.
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets description of the content of the knowledge base
        /// article.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the
        /// knowledge base article.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets the default image for the entity.
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the kbarticle.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the knowledge base article was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets select which language the article must be available
        /// in. This list is based on the list of language packs that are
        /// installed in your Microsoft Dynamics 365 environment.
        /// </summary>
        [JsonProperty(PropertyName = "languagecode")]
        public int? Languagecode { get; set; }

        /// <summary>
        /// Gets or sets shows the article content and formatting, stored as
        /// XML.
        /// </summary>
        [JsonProperty(PropertyName = "articlexml")]
        public string Articlexml { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets shows whether the knowledge base article is in draft,
        /// unapproved, or published status. Published articles are read-only
        /// and can't be edited unless they are unpublished.
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// knowledge base article.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets type additional information that describes the
        /// knowledge base article.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KbArticle_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> KbArticleAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KbArticle_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> KbArticleBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KbArticle_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> KbArticleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KbArticle_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> KbArticleDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kbarticletemplateid")]
        public MicrosoftDynamicsCRMkbarticletemplate Kbarticletemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KbArticle_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> KbArticleDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KbArticle_SharepointDocumentLocation")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> KbArticleSharepointDocumentLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kbarticle_comments")]
        public IList<MicrosoftDynamicsCRMkbarticlecomment> KbarticleComments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KbArticle_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> KbArticleSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subjectid")]
        public MicrosoftDynamicsCRMsubject Subjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kbarticle_incidents")]
        public IList<MicrosoftDynamicsCRMincident> KbarticleIncidents { get; set; }

    }
}
