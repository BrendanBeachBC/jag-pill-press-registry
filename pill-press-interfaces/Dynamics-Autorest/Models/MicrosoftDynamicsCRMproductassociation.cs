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
    /// productassociation
    /// </summary>
    public partial class MicrosoftDynamicsCRMproductassociation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMproductassociation class.
        /// </summary>
        public MicrosoftDynamicsCRMproductassociation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMproductassociation class.
        /// </summary>
        public MicrosoftDynamicsCRMproductassociation(string _uomidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? productisrequired = default(int?), string productassociationid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? dmtimportstate = default(int?), int? statuscode = default(int?), object exchangerate = default(object), string _associatedproductValue = default(string), int? statecode = default(int?), long? versionnumber = default(long?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), object quantity = default(object), string _organizationidValue = default(string), string _transactioncurrencyidValue = default(string), int? propertycustomizationstatus = default(int?), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _productidValue = default(string), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMproduct associatedproduct = default(MicrosoftDynamicsCRMproduct), IList<MicrosoftDynamicsCRMinvoicedetail> productAssociationInvoiceDetails = default(IList<MicrosoftDynamicsCRMinvoicedetail>), IList<MicrosoftDynamicsCRMsyncerror> productAssociationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMdynamicpropertyassociation> productAssociationDynamicPropertyAssociation = default(IList<MicrosoftDynamicsCRMdynamicpropertyassociation>), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMdynamicproperty> productAssociationDynamicProperty = default(IList<MicrosoftDynamicsCRMdynamicproperty>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsalesorderdetail> productAssociationSalesorderDetails = default(IList<MicrosoftDynamicsCRMsalesorderdetail>), IList<MicrosoftDynamicsCRMasyncoperation> productAssociationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), IList<MicrosoftDynamicsCRMquotedetail> productAssociationQuoteDetails = default(IList<MicrosoftDynamicsCRMquotedetail>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMopportunityproduct> productAssociationOpportunityProduct = default(IList<MicrosoftDynamicsCRMopportunityproduct>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._uomidValue = _uomidValue;
            Modifiedon = modifiedon;
            Productisrequired = productisrequired;
            Productassociationid = productassociationid;
            Overriddencreatedon = overriddencreatedon;
            Dmtimportstate = dmtimportstate;
            Statuscode = statuscode;
            Exchangerate = exchangerate;
            this._associatedproductValue = _associatedproductValue;
            Statecode = statecode;
            Versionnumber = versionnumber;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Quantity = quantity;
            this._organizationidValue = _organizationidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Propertycustomizationstatus = propertycustomizationstatus;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._productidValue = _productidValue;
            Importsequencenumber = importsequencenumber;
            Organizationid = organizationid;
            Associatedproduct = associatedproduct;
            ProductAssociationInvoiceDetails = productAssociationInvoiceDetails;
            ProductAssociationSyncErrors = productAssociationSyncErrors;
            ProductAssociationDynamicPropertyAssociation = productAssociationDynamicPropertyAssociation;
            Productid = productid;
            Transactioncurrencyid = transactioncurrencyid;
            ProductAssociationDynamicProperty = productAssociationDynamicProperty;
            Modifiedonbehalfby = modifiedonbehalfby;
            ProductAssociationSalesorderDetails = productAssociationSalesorderDetails;
            ProductAssociationAsyncOperations = productAssociationAsyncOperations;
            Uomid = uomid;
            ProductAssociationQuoteDetails = productAssociationQuoteDetails;
            Createdby = createdby;
            ProductAssociationOpportunityProduct = productAssociationOpportunityProduct;
            Modifiedby = modifiedby;
            Createdonbehalfby = createdonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productisrequired")]
        public int? Productisrequired { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid")]
        public string Productassociationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dmtimportstate")]
        public int? Dmtimportstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_associatedproduct_value")]
        public string _associatedproductValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public object Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "propertycustomizationstatus")]
        public int? Propertycustomizationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "associatedproduct")]
        public MicrosoftDynamicsCRMproduct Associatedproduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productAssociation_invoice_details")]
        public IList<MicrosoftDynamicsCRMinvoicedetail> ProductAssociationInvoiceDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ProductAssociationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_DynamicPropertyAssociation")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyassociation> ProductAssociationDynamicPropertyAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_DynamicProperty")]
        public IList<MicrosoftDynamicsCRMdynamicproperty> ProductAssociationDynamicProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productAssociation_salesorder_details")]
        public IList<MicrosoftDynamicsCRMsalesorderdetail> ProductAssociationSalesorderDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ProductAssociationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productAssociation_quote_details")]
        public IList<MicrosoftDynamicsCRMquotedetail> ProductAssociationQuoteDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productAssociation_opportunity_product")]
        public IList<MicrosoftDynamicsCRMopportunityproduct> ProductAssociationOpportunityProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

    }
}
