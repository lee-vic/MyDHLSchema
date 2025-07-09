using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDHLSchema
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressCreateShipmentRequest
    {
        /// <summary>
        /// Identifies the date and time the package is tendered. Both the date and time portions of the string are expected to be used. The date should not be in the past or more than 10 days in the future. The time represents the local time of the shipment origin coupled with corresponding time zone. The date component must be in the format: YYYY-MM-DD; the time component must be in the format: HH:MM:SS using a 24-hour clock. The date and time parts are separated by the letter T (e.g., 2025-01-18T17:00:00 GMT+01:00). It is not recommended to populate this field with current time, the time the request is sent to DHL Express as it may be evaluated as being in the past the time it is received.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("plannedShippingDateAndTime")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(29, MinimumLength = 1)]
        public string PlannedShippingDateAndTime { get; set; } = default!;

        [System.Text.Json.Serialization.JsonPropertyName("pickup")]
        [System.ComponentModel.DataAnnotations.Required]
        public Pickup Pickup { get; set; } = new Pickup();

        /// <summary>
        /// Please enter DHL Express Global Product code
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("productCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(6, MinimumLength = 1)]
        public string ProductCode { get; set; } = default!;

        /// <summary>
        /// Please enter DHL Express Local Product code. Important when shipping domestic products.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("localProductCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 1)]
        public string LocalProductCode { get; set; } = default!;

        /// <summary>
        /// Please advise if you want to get rate estimates for given shipment
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("getRateEstimates")]
        public bool GetRateEstimates { get; set; } = false;

        /// <summary>
        /// Please enter all the DHL Express accounts and types to be used for this shipment
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("accounts")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressAccount> Accounts { get; set; } = new System.Collections.ObjectModel.Collection<SupermodelIoLogisticsExpressAccount>();

        /// <summary>
        /// This section communicates additional shipping services, such as Insurance (or Shipment Value Protection).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("valueAddedServices")]
        [System.ComponentModel.DataAnnotations.MaxLength(99)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressValueAddedServices> ValueAddedServices { get; set; } = default!;

        /// <summary>
        /// Here you can modify label, waybillDoc, invoice and shipment receipt properties
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("outputImageProperties")]
        public OutputImageProperties OutputImageProperties { get; set; } = default!;

        /// <summary>
        /// Here you can declare your customer references
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerReferences")]
        [System.ComponentModel.DataAnnotations.MaxLength(999)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressReference> CustomerReferences { get; set; } = default!;

        /// <summary>
        /// Identifiers section is on the shipment level where you can optionaly provide a DHL Express waybill number. This has to be enabled by your DHL Express IT contact.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        [System.ComponentModel.DataAnnotations.MaxLength(5)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressIdentifier> Identifiers { get; set; } = default!;

        /// <summary>
        /// Here you need to define all the parties needed to ship the package
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerDetails")]
        [System.ComponentModel.DataAnnotations.Required]
        public CustomerDetails CustomerDetails { get; set; } = new CustomerDetails();

        /// <summary>
        /// Here you can define all the properties related to the content of the prospected shipment
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required]
        public Content Content { get; set; } = new Content();

        [System.Text.Json.Serialization.JsonPropertyName("documentImages")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(999)]
        public List<SupermodelIoLogisticsExpressDocumentImage> DocumentImages { get; set; } = default!;

        /// <summary>
        /// Here you can provide data in case you wish to use DHL Express On demand delivery service. Please note, that if using this segment then 'buyerDetails' customer role data also must be populated in the request message.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("onDemandDelivery")]
        public OnDemandDelivery OnDemandDelivery { get; set; } = default!;

        /// <summary>
        /// Determines whether to request the On Demand Delivery (ODD) link. When set to true it will provide an URL link for the specified Waybill Number, Shipper Account Number. The default value is false, no ODD link URL is provided in the response message.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("requestOndemandDeliveryURL")]
        public bool RequestOndemandDeliveryURL { get; set; } = default!;

        /// <summary>
        /// This is to support sending email notification once the shipment is created. The email will contain the basic information on the shipper, recipient, waybill number, and shipment information
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shipmentNotification")]
        [System.ComponentModel.DataAnnotations.MaxLength(5)]
        public System.Collections.Generic.ICollection<ShipmentNotification> ShipmentNotification { get; set; } = default!;

        /// <summary>
        /// Please provide any charges you have already paid for this shipment, like freight paid upfront. To allow using this section please contact your DHL Express representative
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("prepaidCharges")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<PrepaidCharges> PrepaidCharges { get; set; } = default!;

        /// <summary>
        /// If set to true, response will return transliterated text of shipper and receiver details.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("getTransliteratedResponse")]
        public bool GetTransliteratedResponse { get; set; } = default!;

        /// <summary>
        /// Estimated delivery date option for QDDF or QDDC.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("estimatedDeliveryDate")]
        public EstimatedDeliveryDate EstimatedDeliveryDate { get; set; } = default!;

        /// <summary>
        /// Provides additional information in the response like service area details, routing code and pickup-related information
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("getAdditionalInformation")]
        [System.ComponentModel.DataAnnotations.MaxLength(5)]
        public System.Collections.Generic.ICollection<GetAdditionalInformation> GetAdditionalInformation { get; set; } = default!;

        /// <summary>
        /// Please provide the parent (mother) shipment details
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("parentShipment")]
        public ParentShipment ParentShipment { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Pickup
    {
        /// <summary>
        /// Please advise if a pickup is needed for this shipment
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("isRequested")]
        public bool IsRequested { get; set; } = false;

        /// <summary>
        /// The latest time the location premises is available to dispatch the DHL Express shipment. (HH:MM) 
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("closeTime")]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"([0-1][0-9]|2[0-3]):([0-5][0-9])")]
        public string CloseTime { get; set; } = default!;

        /// <summary>
        /// Provides information on where the package should be picked up by DHL courier.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location")]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        public string Location { get; set; } = default!;

        /// <summary>
        /// Details special pickup instructions you may wish to send to the DHL Courier.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("specialInstructions")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<SpecialInstructions> SpecialInstructions { get; set; } = default!;

        /// <summary>
        /// Please enter address and contact details related to your pickup
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pickupDetails")]
        public PartyDetails PickupDetails { get; set; } = default!;

        /// <summary>
        /// Please enter address and contact details of the individual requesting the pickup
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pickupRequestorDetails")]
        public PartyDetails PickupRequestorDetails { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SpecialInstructions
    {
        /// <summary>
        /// Any special instructions user wish to send to the courier for the order pick-up.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(75)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// for future use
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 2)]
        public string TypeCode { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PartyDetails
    {

        [System.Text.Json.Serialization.JsonPropertyName("postalAddress")]
        [System.ComponentModel.DataAnnotations.Required]
        public SupermodelIoLogisticsExpressAddressCreateShipmentRequest PostalAddress { get; set; } = new SupermodelIoLogisticsExpressAddressCreateShipmentRequest();

        [System.Text.Json.Serialization.JsonPropertyName("contactInformation")]
        [System.ComponentModel.DataAnnotations.Required]
        public SupermodelIoLogisticsExpressContact ContactInformation { get; set; } = new SupermodelIoLogisticsExpressContact();

        [System.Text.Json.Serialization.JsonPropertyName("registrationNumbers")]
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressRegistrationNumbers> RegistrationNumbers { get; set; } = default!;

        [System.Text.Json.Serialization.JsonPropertyName("bankDetails")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public List<SupermodelIoLogisticsExpressBankDetails> BankDetails { get; set; } = default!;

        /// <summary>
        /// Please enter the business party type related to the pickup.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public PartyDetailsTypeCode TypeCode { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressAccount
    {
        /// <summary>
        /// Please enter DHL Express acount type
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(15, MinimumLength = 1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressAccountTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// Please enter DHL Express account number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("number")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(12, MinimumLength = 1)]
        public string Number { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressValueAddedServices
    {
        /// <summary>
        /// Please enter DHL Express value added service code. For detailed list of all available service codes for your prospect shipment please invoke GET /products or GET /rates
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("serviceCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(6, MinimumLength = 1)]
        public string ServiceCode { get; set; } = default!;

        /// <summary>
        /// Please enter monetary value of service (e.g. Insured Value)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Please enter currency code (e.g. Insured Value currency code)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// Payment method code (e.g. Cash)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("method")]
        public string Method { get; set; } = default!;

        /// <summary>
        /// The DangerousGoods section indicates if there is dangerous good content within the shipment. &lt;BR&gt; The ContentID node contains the Content ID for Dangerous Good classification. &lt;BR&gt; It is required to provide the dangerous good Content ID for every dangerous good special service provided, and vice versa. &lt;BR&gt;
        /// <br/>For the complete list of dangerous goods Content IDs and dangerous goods special services combinations, refer to Reference Data Guide section 5. valueAddedServicesDefinition\\dangerousGoods. &lt;BR&gt; Note: Please contact your DHL Express IT representative if additional assistance is required.&lt;BR&gt;&lt;BR&gt;
        /// <br/>For dangerous goods shipment with Dry Ice example: UN1845 (Content ID: 901), additional node must be populated 'dryIceTotalNetWeight.'&lt;BR&gt;
        /// <br/>For dangerous goods shipment with 'Excepted Quantities', additional node must be populated 'unCodes'. Few scenarios guideline to prepare a Dangerous Goods shipment for:&lt;BR&gt;&lt;BR&gt;
        /// <br/>A) Dry Ice: &lt;BR&gt; 1.'serviceCode' element must contain value of 'HC'&lt;BR&gt; 2.'contentID' element consists of '901'&lt;BR&gt; 3.'dryIceTotalNetWeight' element consists of the total net weight of the dry ice in 'unitofMeasurement' &lt;BR&gt;&lt;BR&gt;
        /// <br/>B) Lithium Battery: &lt;BR&gt; 1.'serviceType' element must contain value of 'HD', 'HM', 'HV' or 'HW'&lt;BR&gt; 2.'contentID' element consists of '966', '969', '967', '970' respectively&lt;BR&gt;&lt;BR&gt;
        /// <br/>C) Excepted Quantities:&lt;BR&gt; 1.'serviceCode' element must contain value of 'HH'&lt;BR&gt; 2.'contentID' element consists of 'E01&lt;BR&gt; 3.'unCodes' element consists of the UN code associate with it.&lt;BR&gt;
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("dangerousGoods")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<DangerousGoods> DangerousGoods { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OutputImageProperties
    {
        /// <summary>
        /// Printer DPI Resolution for X-axis and Y-axis (in DPI) for transport label and waybill document output
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("printerDPI")]
        public double PrinterDPI { get; set; } = default!;

        /// <summary>
        /// Customer barcodes to be printed on supported transport label templates
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerBarcodes")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<CustomerBarcodes> CustomerBarcodes { get; set; } = default!;

        /// <summary>
        /// Customer Logo Image to be printed on transport label
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerLogos")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<CustomerLogos> CustomerLogos { get; set; } = default!;

        /// <summary>
        /// Please provide the format of the output documents. Note that invoice and shipment receipt will always come back as PDF
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("encodingFormat")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public OutputImagePropertiesEncodingFormat EncodingFormat { get; set; } = OutputImagePropertiesEncodingFormat.Pdf;

        /// <summary>
        /// Here the image options are defined for label, waybillDoc, invoice, QRcode and shipment receipt
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("imageOptions")]
        [System.ComponentModel.DataAnnotations.MaxLength(20)]
        public System.Collections.Generic.ICollection<ImageOptions> ImageOptions { get; set; } = default!;

        /// <summary>
        /// When set to true it will generate a single PDF or thermal output file for the Transport Label, a single PDF or thermal output file for the Waybill document and a single PDF file consisting of Commercial Invoice and Shipment Receipt. The default value is false, a single PDF or thermal output image file consists of Transport Label and single PDF or thermal output image file for Waybill Document will be returned in create shipment response.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("splitTransportAndWaybillDocLabels")]
        public bool SplitTransportAndWaybillDocLabels { get; set; } = default!;

        /// <summary>
        /// When set to true it will generate a single PDF or thermal output image file consists of Transport Label, Waybill Document, Shipment Receipt and Commercial Invoice.&lt;BR&gt;          The default value is false, where a single PDF or thermal output image file consists of Transport Label + Waybill Document and single PDF or thermal output image file for Shipment Receipt and Customs Invoice will be returned.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("allDocumentsInOneImage")]
        public bool AllDocumentsInOneImage { get; set; } = default!;

        /// <summary>
        /// When set to true it will generate a single PDF or thermal output image file for each page for the Transport Label and single PDF or thermal output image file for Waybill Document will be returned in the create shipment response. The default value is false, a single PDF or thermal output image file for each page for Transport Label and single PDF or thermal output image file for Waybill Document will be returned in create shipment response.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("splitDocumentsByPages")]
        public bool SplitDocumentsByPages { get; set; } = default!;

        /// <summary>
        /// When set to true it will generate a single PDF or thermal output image file consisting of Transport Label + Waybill Document, a single file consist of Commercial Invoice and a single file consist of Shipment Receipt. The default value is false, a single PDF or thermal output image file consists of Transport Label + Waybill Document and single PDF or thermal output image file for Shipment Receipt and Customs Invoice will be returned in create shipment response.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("splitInvoiceAndReceipt")]
        public bool SplitInvoiceAndReceipt { get; set; } = default!;

        /// <summary>
        /// When set to true it will generate a single PDF file consisting of Transport Label, Waybill Document and Shipment Receipt. The default value is false, a single PDF or thermal output image file consists of Transport Label + Waybill Document and single PDF file for Shipment Receipt will be returned in create shipment response.  Applicable only when #/outputImageProperties/imageOptions/0/typeCode is 'receipt' and #/outputImageProperties/encodingFormat is PDF.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("receiptAndLabelsInOneImage")]
        public bool ReceiptAndLabelsInOneImage { get; set; } = default!;

    }
    /// <summary>
    /// Reference model description
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressReference
    {
        /// <summary>
        /// Please provide reference
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Please provide reference type&lt;BR&gt;      &lt;BR&gt;      AAO, shipment reference number of receiver&lt;BR&gt;      CU, reference number of consignor - default&lt;BR&gt;      FF, reference number of freight forwarder&lt;BR&gt;      FN, freight bill number for &lt;ex works invoice number&gt;&lt;BR&gt;      IBC, inbound center reference number&lt;BR&gt;      LLR, load list reference for &lt;10-digit Shipment ID&gt;&lt;BR&gt;      OBC, outbound center reference number for &lt;SHIPMEN IDENTIFIER (COUNTRY OF ORIGIN)&gt;&lt;BR&gt;      PRN, pickup request number for &lt;BOOKINGREFERENCE NUMBER&gt;&lt;BR&gt;      ACP, local payer account number&lt;BR&gt;      ACS, local shipper account number&lt;BR&gt;      ACR, local receiver account number&lt;BR&gt;      CDN, customs declaration number&lt;BR&gt;      STD, eurolog 15-digit shipment id&lt;BR&gt;      CO, buyers order number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 2)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressReferenceTypeCode TypeCode { get; set; } = SupermodelIoLogisticsExpressReferenceTypeCode.CU;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressIdentifier
    {
        /// <summary>
        /// Please provide type of the identifier you want to set value for
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressIdentifierTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// Please enter value of your identifier (WB number, PieceID)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Please enter value of Piece Data Identifier. Note: Piece identification data should be same for all the pieces provided in single shipment.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("dataIdentifier")]
        [System.ComponentModel.DataAnnotations.StringLength(4, MinimumLength = 1)]
        public string DataIdentifier { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CustomerDetails
    {
        /// <summary>
        /// Please enter address and contact details related to shipper
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shipperDetails")]
        [System.ComponentModel.DataAnnotations.Required]
        public PartyDetails ShipperDetails { get; set; } = new PartyDetails();

        /// <summary>
        /// Please enter address and contact details related to receiver
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("receiverDetails")]
        [System.ComponentModel.DataAnnotations.Required]
        public PartyDetails ReceiverDetails { get; set; } = new PartyDetails();

        /// <summary>
        /// Please enter address and contact details related to buyer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("buyerDetails")]
        public PartyDetails BuyerDetails { get; set; } = default!;

        /// <summary>
        /// Please enter address and contact details related to importer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("importerDetails")]
        public PartyDetails ImporterDetails { get; set; } = default!;

        /// <summary>
        /// Please enter address and contact details related to exporter
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("exporterDetails")]
        public PartyDetails ExporterDetails { get; set; } = default!;

        /// <summary>
        /// Please enter address and contact details related to seller
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sellerDetails")]
        public PartyDetails SellerDetails { get; set; } = default!;

        /// <summary>
        /// Please enter address and contact details related to payer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("payerDetails")]
        public PartyDetails PayerDetails { get; set; } = default!;

        /// <summary>
        /// Please enter address and contact details related to manufacturer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("manufacturerDetails")]
        public PartyDetails ManufacturerDetails { get; set; } = default!;

        /// <summary>
        /// Please enter address and contact details related to ultimate consignee
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ultimateConsigneeDetails")]
        public PartyDetails UltimateConsigneeDetails { get; set; } = default!;

        /// <summary>
        /// Please enter address and contact details related to broker
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("brokerDetails")]
        public PartyDetails BrokerDetails { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Content
    {
        /// <summary>
        /// Here you can define properties per package
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("packages")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(999)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressPackage> Packages { get; set; } = new System.Collections.ObjectModel.Collection<SupermodelIoLogisticsExpressPackage>();

        /// <summary>
        /// For customs purposes please advise if your shipment is dutiable (true) or non dutiable (false).Note:If the shipment is dutiable, exportDeclaration element must be provided.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("isCustomsDeclarable")]
        public bool IsCustomsDeclarable { get; set; } = default!;

        /// <summary>
        /// For customs purposes please advise on declared value of the shipment
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("declaredValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double DeclaredValue { get; set; } = default!;

        /// <summary>
        /// For customs purposes please advise on declared value currency code of the shipment
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("declaredValueCurrency")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        public string DeclaredValueCurrency { get; set; } = default!;

        /// <summary>
        /// Here you can find all details related to export declaration
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("exportDeclaration")]
        public ExportDeclaration ExportDeclaration { get; set; } = default!;

        /// <summary>
        /// Please enter description of your shipment
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(70, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[^\s]")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// This is used for the US AES4, FTR and ITN numbers to be printed on the Transport Label
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("USFilingTypeValue")]
        [System.ComponentModel.DataAnnotations.StringLength(20, MinimumLength = 1)]
        public string USFilingTypeValue { get; set; } = default!;

        /// <summary>
        /// The Incoterms rules are a globally-recognized set of standards, used worldwide in international and domestic contracts for the delivery of goods, illustrating responsibilities between buyer and seller for costs and risk, as well as cargo insurance.&lt;BR&gt;          EXW ExWorks&lt;BR&gt;          FCA Free Carrier&lt;BR&gt;          CPT Carriage Paid To&lt;BR&gt;          CIP Carriage and Insurance Paid To&lt;BR&gt;          DPU Delivered at Place Unloaded&lt;BR&gt;          DAP Delivered at Place&lt;BR&gt;          DDP Delivered Duty Paid&lt;BR&gt;          FAS Free Alongside Ship&lt;BR&gt;          FOB Free on Board&lt;BR&gt;          CFR Cost and Freight&lt;BR&gt;          CIF Cost, Insurance and Freight&lt;BR&gt;          DAF Delivered at Frontier&lt;BR&gt;          DAT Delivered at Terminal&lt;BR&gt;          DDU Delivered Duty Unpaid&lt;BR&gt;          DEQ Delivery ex Quay&lt;BR&gt;          DES Delivered ex Ship
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("incoterm")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Content2Incoterm Incoterm { get; set; } = default!;

        /// <summary>
        /// Please enter Unit of measurement - metric,imperial
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurement")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Content2UnitOfMeasurement UnitOfMeasurement { get; set; } = default!;

    }
   
    /// <summary>
    /// This section is to support multiple base64 encoded string with the image of export documentation for Paperless Trade images. When an invalid base64 encoded string is provided, an error message will be returned
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressDocumentImage
    {
        /// <summary>
        /// Please provide correct document type you wish to upload&lt;BR&gt;        &lt;BR&gt;        Possible values;&lt;BR&gt;        INV, Invoice&lt;BR&gt;        PNV, Proforma&lt;BR&gt;        COO, Certificate of Origin&lt;BR&gt;        NAF, Nafta Certificate of Origin&lt;BR&gt;        CIN, Commercial Invoice&lt;BR&gt;        DCL, Custom Declaration&lt;BR&gt;        AWB, Air Waybill and Waybill Document
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public TypeCode2 TypeCode { get; set; } = DHLAPIModelTestConsoleApp.TypeCode2.INV;

        /// <summary>
        /// Please provide the image file format for the document you want to upload
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("imageFormat")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ImageFormat ImageFormat { get; set; } = DHLAPIModelTestConsoleApp.ImageFormat.PDF;

        /// <summary>
        /// Please provide the base64 encoded document
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Content { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OnDemandDelivery : object
    {
        /// <summary>
        /// Please choose from one of the delivery options
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("deliveryOption")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public OnDemandDeliveryDeliveryOption DeliveryOption { get; set; } = default!;

        /// <summary>
        /// If delivery option is signatureDelivery please specify location where to leave the shipment
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location")]
        [System.ComponentModel.DataAnnotations.StringLength(15, MinimumLength = 1)]
        public string Location { get; set; } = default!;

        /// <summary>
        /// Please enter additional information that might be useful for the DHL Express courier. This field is conditionally mandatory if selected location is 'Other'.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("specialInstructions")]
        [System.ComponentModel.DataAnnotations.StringLength(110, MinimumLength = 1)]
        public string SpecialInstructions { get; set; } = default!;

        /// <summary>
        /// Please provide entry code to gain access to an apartment complex or gate
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("gateCode")]
        [System.ComponentModel.DataAnnotations.StringLength(10, MinimumLength = 1)]
        public string GateCode { get; set; } = default!;

        /// <summary>
        /// In ase your deliveryOption is 'neighbour' please specify where to leave the package 
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("whereToLeave")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public OnDemandDeliveryWhereToLeave WhereToLeave { get; set; } = default!;

        /// <summary>
        /// In case you wish to leave the package with neighbour please provide the neighbour's name
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("neighbourName")]
        [System.ComponentModel.DataAnnotations.StringLength(20, MinimumLength = 1)]
        public string NeighbourName { get; set; } = default!;

        /// <summary>
        /// In case you wish to leave the package with neighbour please provide the neighbour's house number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("neighbourHouseNumber")]
        [System.ComponentModel.DataAnnotations.StringLength(20, MinimumLength = 1)]
        public string NeighbourHouseNumber { get; set; } = default!;

        /// <summary>
        /// In case your delivery option is 'signatureRelease' please provide name of the person who is authorized to sign and receive the package
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("authorizerName")]
        [System.ComponentModel.DataAnnotations.StringLength(20, MinimumLength = 1)]
        public string AuthorizerName { get; set; } = default!;

        /// <summary>
        /// In case your delivery option is 'servicepoint' please provide unique DHL Express Service point location ID of where the parcel should be delieverd (please contact your local DHL Express Account Manager to obtain the list of the servicepoint IDs)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("servicePointId")]
        [System.ComponentModel.DataAnnotations.StringLength(6, MinimumLength = 1)]
        public string ServicePointId { get; set; } = default!;

        /// <summary>
        /// for future use
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("requestedDeliveryDate")]
        [System.ComponentModel.DataAnnotations.StringLength(29, MinimumLength = 1)]
        public string RequestedDeliveryDate { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ShipmentNotification
    {
        /// <summary>
        /// Please enter channel type to send the notification by. At this moment only email is supported
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ShipmentNotificationTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// Please enter notification receiver email address
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("receiverId")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string ReceiverId { get; set; } = default!;

        /// <summary>
        /// Please enter three letter lanuage code in which you wish to receive the notification in
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        public string LanguageCode { get; set; } = "eng";

        /// <summary>
        /// Please enter two letter language country code
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("languageCountryCode")]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string LanguageCountryCode { get; set; } = "UK";

        /// <summary>
        /// Please enter your message which will be added to the DHL Express notification email
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("bespokeMessage")]
        [System.ComponentModel.DataAnnotations.StringLength(250)]
        public string BespokeMessage { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PrepaidCharges
    {
        /// <summary>
        /// Please enter type of prepaid charge. At this moment only freight is supported
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public PrepaidChargesTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// Please enter currency for the value you have entered into value field
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// Please enter nominal value related to the charge
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Range(0.01D, 9999999999D)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Please enter method you have used to pay the charges. At this moment only cash is supported
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("method")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public PrepaidChargesMethod Method { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EstimatedDeliveryDate
    {
        /// <summary>
        /// Please indicate if requesting to get EDD for this shipment.
        /// <br/> Estimated Delivery Date Type. QDDF: is the fastest transit time as quoted to the customer at booking or shipment creation. When clearance or any other non-transport operational component is expected to impact transit time, QDDF does not constitute DHL's service commitment. QDDC: cconstitutes DHL's service commitment as quoted at booking or shipment creation. QDDC builds in clearance time, and potentially other special operational non-transport component(s), when relevant.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("isRequested")]
        public bool IsRequested { get; set; } = false;

        /// <summary>
        /// Please indicate the EDD type being requested
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public EstimatedDeliveryDateTypeCode TypeCode { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetAdditionalInformation
    {
        /// <summary>
        /// Provide type code of data that can be returned in response.  Values can be pickupDetails, optionalShipmentData, transliterateResponse and linkLabelsByPieces (link label image generated for each package level)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public GetAdditionalInformationTypeCode TypeCode { get; set; } = default!;

        [System.Text.Json.Serialization.JsonPropertyName("isRequested")]
        public bool IsRequested { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ParentShipment
    {
        /// <summary>
        /// Please provide the parent (mother) Product Code
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("productCode")]
        [System.ComponentModel.DataAnnotations.StringLength(1, MinimumLength = 1)]
        public string ProductCode { get; set; } = default!;

        /// <summary>
        /// Please provide the parent (mother) shipment's Number of Packages
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("packagesCount")]
        [System.ComponentModel.DataAnnotations.Range(1D, double.MaxValue)]
        public double PackagesCount { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressAddressCreateShipmentRequest
    {
        /// <summary>
        /// Please enter your postcode or leave empty if the address doesn't have a postcode
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("postalCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string PostalCode { get; set; } = default!;

        /// <summary>
        /// Please enter the city
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("cityName")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string CityName { get; set; } = default!;

        /// <summary>
        /// Please enter ISO country code
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string CountryCode { get; set; } = default!;

        /// <summary>
        /// Please enter your province or state code
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("provinceCode")]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 2)]
        public string ProvinceCode { get; set; } = default!;

        /// <summary>
        /// Please enter address line 1
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("addressLine1")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string AddressLine1 { get; set; } = default!;

        /// <summary>
        /// Please enter address line 2
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("addressLine2")]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string AddressLine2 { get; set; } = default!;

        /// <summary>
        /// Please enter address line 3
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("addressLine3")]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string AddressLine3 { get; set; } = default!;

        /// <summary>
        /// Please enter your suburb or county name
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("countyName")]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string CountyName { get; set; } = default!;

        /// <summary>
        /// Please enter your state or province name
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("provinceName")]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string ProvinceName { get; set; } = default!;

        /// <summary>
        /// Please enter your country name
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("countryName")]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string CountryName { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressContact
    {
        /// <summary>
        /// Please enter email address
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("email")]
        [System.ComponentModel.DataAnnotations.StringLength(70, MinimumLength = 1)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Please enter phone number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("phone")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(70, MinimumLength = 1)]
        public string Phone { get; set; } = default!;

        /// <summary>
        /// Please enter mobile phone number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("mobilePhone")]
        [System.ComponentModel.DataAnnotations.StringLength(70, MinimumLength = 1)]
        public string MobilePhone { get; set; } = default!;

        /// <summary>
        /// Please enter company name
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("companyName")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength = 1)]
        public string CompanyName { get; set; } = default!;

        /// <summary>
        /// Please enter full name
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fullName")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(255, MinimumLength = 1)]
        public string FullName { get; set; } = default!;

    }
    /// <summary>
    /// Should your country require registration numbers, such as VAT, EOR etc., please declare it here
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressRegistrationNumbers
    {
        /// <summary>
        /// VAT: Value-Added tax&lt;BR&gt;      EIN: Employer Identification Number&lt;BR&gt;      GST: Goods and Service Tax&lt;BR&gt;      SSN: Social Security Number&lt;BR&gt;      EOR: European Union Registration and Identification&lt;BR&gt;      DUN: Data Universal Numberin System&lt;BR&gt;      FED: Federal Tax ID&lt;BR&gt;      STA: State Tax ID&lt;BR&gt;      CNP: Brazil CNPJ/CPF Federal Tax&lt;BR&gt;      IE: Brazil type IE/RG Federal Tax&lt;BR&gt;      INN: Russia bank details section INN&lt;BR&gt;      KPP: Russia bank details section KPP&lt;BR&gt;      OGR: Russia bank details section OGRN&lt;BR&gt;      OKP: Russia bank details section OKPO&lt;BR&gt;      SDT: Overseas Registered Supplier or Import One-Stop-Shop or GB VAT (foreign) registration or AUSid GST Registration or VAT on E-Commerce&lt;BR&gt;      FTZ: Free Trade Zone ID&lt;BR&gt;      DAN: Deferment Account Duties Only&lt;BR&gt;      TAN: Deferment Account Tax Only&lt;BR&gt;      DTF: Deferment Account Duties, Taxes and Fees Only&lt;BR&gt;      RGP: EU Registered Exporters registration ID&lt;BR&gt;       DLI: Driver's License &lt;BR&gt;      NID: National Identity Card&lt;BR&gt; PAS: Passport&lt;BR&gt; MID: Manufacturer ID&lt;BR&gt;IMS: UK Internal Market Scheme&lt;BR&gt; Note: 'IMS' code will be available in Production by the end of March 2025.&lt;BR&gt; EIC: eInvoice Carrier &lt;BR&gt; FTN: Foreign Tax Identification Number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressRegistrationNumbersTypeCode TypeCode { get; set; } = DHLAPIModelTestConsoleApp.SupermodelIoLogisticsExpressRegistrationNumbersTypeCode.VAT;

        /// <summary>
        /// Please enter registration number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("number")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Number { get; set; } = default!;

        /// <summary>
        /// Please enter 2 character code of the country where the Registration Number has been issued by
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("issuerCountryCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string IssuerCountryCode { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressBankDetails
    {
        /// <summary>
        /// To be mapped in commercial Invoice - Russia Bank Name field
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.StringLength(60)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// To be mapped in commercial Invoice - Russia Bank Settlement Account Number in RUR field
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("settlementLocalCurrency")]
        public string SettlementLocalCurrency { get; set; } = default!;

        /// <summary>
        /// To be mapped in commercial Invoice - Russia Bank Settlement Account Number in RUR field
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("settlementForeignCurrency")]
        public string SettlementForeignCurrency { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DangerousGoods
    {
        /// <summary>
        /// Please enter valid DHL Express Dangerous good content id (please contact your DHL Express IT representative for the relevant content ID code if you are shipping Dan
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("contentId")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(5, MinimumLength = 1)]
        public string ContentId { get; set; } = default!;

        /// <summary>
        /// Please enter dry ice total net weight when shipping dry ice
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("dryIceTotalNetWeight")]
        public double DryIceTotalNetWeight { get; set; } = default!;

        /// <summary>
        /// The customDescription node contains the customized Dangerous Goods statement to declare contents accurately. The customDescription node value will be displayed in the Transport Label and Waybill Document, replacing the default IATA Dangerous Goods statement constructed based on contentId node.&lt;BR&gt;            Multiple customDescription nodes from multiple dangerousGoods nodes will be concatenated using comma separator with combined maximum limit of 200 characters.&lt;BR&gt;            &lt;BR&gt;            It is recommended to use customDescription for entire shipment for each dangerousGoods to fully utilize customDescription printout in Transport Label and Waybill Document.&lt;BR&gt;            &lt;BR&gt;            Note: For 'customDescription' usage, ensure all 'dangerousGoods' segments are including the 'customDescription' field value. Any of the dangerousGoods does not provide with customDescription field value will be ignored from printing in Transport Label and Waybill Document.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customDescription")]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string CustomDescription { get; set; } = default!;

        /// <summary>
        /// Please enter UN code(s)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unCodes")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(10)]
        public System.Collections.Generic.ICollection<string> UnCodes { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CustomerBarcodes
    {
        /// <summary>
        /// Please enter barcode content
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(25, MinimumLength = 1)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Please tner text below customer barcode
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("textBelowBarcode")]
        public string TextBelowBarcode { get; set; } = default!;

        /// <summary>
        /// Please enter valid Symbology code
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("symbologyCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public CustomerBarcodesSymbologyCode SymbologyCode { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CustomerLogos
    {
        /// <summary>
        /// Please specify image file format
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fileFormat")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public CustomerLogosFileFormat FileFormat { get; set; } = default!;

        /// <summary>
        /// Please provide base64 encoded logo image
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(1048576)]
        public string Content { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ImageOptions : object
    {
        /// <summary>
        /// Please enter the document type you want to wish set properties for
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ImageOptionsTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// Please enter DHL Express document template name. &lt;BR&gt;                Sample Transport label templates:&lt;BR&gt;                ECOM26_84_A4_001 &lt;BR&gt;                ECOM26_84_001 - default&lt;BR&gt;                ECOM_TC_A4&lt;BR&gt;                ECOM26_A6_002&lt;BR&gt;                ECOM26_84CI_001&lt;BR&gt;                ECOM26_84CI_002 - supported single customer barcode&lt;BR&gt;                ECOM26_84CI_003 - to be used if customer barcodes are used&lt;BR&gt;                ECOM_A4_RU_002&lt;BR&gt; ECOM26_84_LBBX_001 - supported for loose BBX shipment&lt;BR&gt; ECOM26_64_LBBX_001 - supported for loose BBX shipment&lt;BR&gt;Sample WaybillDoc templates&lt;BR&gt;                ARCH_8X4_A4_002&lt;BR&gt;                ARCH_8X4 - default&lt;BR&gt;                ARCH_6X4&lt;BR&gt;                ARCH_A4_RU_002&lt;BR&gt;                &lt;BR&gt;                Sample Commercial invoice templates:&lt;BR&gt;                COMMERCIAL_INVOICE_04 - This template can print the Shipper, Recipient, and Buyer and Importer address details and is on portrait orientation, exclusive use for preparing Loose BBX shipment.&lt;BR&gt;                COMMERCIAL_INVOICE_P_10 - (default) This template can print the Shipper, Recipient and upto two more additional address details in portrait orientation. Note: If customer provided more than four address roles in the request message and this template is selected, the rendered invoice will only contain four address roles based on order of priority: Shipper, Recipient, Seller, Importer, Exporter, Buyer. &lt;BR&gt;                COMMERCIAL_INVOICE_L_10 - This template can print the Shipper,Recipient, Buyer, and Importer and Exporter address details and is on landscape orientation..&lt;BR&gt;                RET_COM_INVOICE_A4_01 - This template can print the Shipper, Recipient and Importer of record address details and is on landscape orientation. This template is for exclusive use for certain shipment where the goods are actual 'returns'. The Shipper is the party that earlier has received the goods, but now wishes to return the goods to its originating party. The Recipient in this shipment scenario will receive the 'returned goods'. Therefore such request of shipment with an invoice rendering may utilize the specific invoice template for 'Returns Invoice'.&lt;BR&gt;                &lt;BR&gt;                Sample Shipment Receipt template&lt;BR&gt;                SHIP_RECPT_A4_RU_002&lt;BR&gt; SHIPRCPT_EN_001 - default &lt;BR&gt; &lt;BR&gt; Sample QR Code template template&lt;BR&gt;  QR_1_00_LL_PNG_001 - default
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("templateName")]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public string TemplateName { get; set; } = default!;

        /// <summary>
        /// To be used for waybillDoc, invoice, shipment receipt and QRcode. If set to true then the document is provided otherwise not
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("isRequested")]
        public bool IsRequested { get; set; } = default!;

        /// <summary>
        /// To be used for waybillDoc. If set to true then account information will not be printed on the waybillDoc
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("hideAccountNumber")]
        public bool HideAccountNumber { get; set; } = default!;

        /// <summary>
        /// You can ask up to 2 waybillDoc copies to be provided
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("numberOfCopies")]
        [System.ComponentModel.DataAnnotations.Range(1D, 2D)]
        public double NumberOfCopies { get; set; } = default!;

        /// <summary>
        /// Please advise what type of customs documentation is required
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("invoiceType")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ImageOptionsInvoiceType InvoiceType { get; set; } = default!;

        /// <summary>
        /// Please enter ISO 3 letters language code for invoice or shipment receipt
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        public string LanguageCode { get; set; } = default!;

        /// <summary>
        /// Please enter ISO 2 letters language country code for invoice or shipment receipt
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("languageCountryCode")]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string LanguageCountryCode { get; set; } = default!;

        /// <summary>
        /// Please enter ISO 4 letters language script code for shipment receipt
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("languageScriptCode")]
        [System.ComponentModel.DataAnnotations.StringLength(4, MinimumLength = 4)]
        public string LanguageScriptCode { get; set; } = default!;

        /// <summary>
        /// Please provide the format of the QR Code output format.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("encodingFormat")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ImageOptionsEncodingFormat EncodingFormat { get; set; } = default!;

        /// <summary>
        /// DHL Logo to be printed in Transport Label or Waybill Document
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("renderDHLLogo")]
        public bool RenderDHLLogo { get; set; } = default!;

        /// <summary>
        /// To print respective Transport Label and Waybill document into A4 margin PDF.&lt;BR&gt;                Note: ECOM26_A6_002,ECOM26_84CI_001,ECOM26_84CI_002,ARCH_6X4,ARCH_8X4 template. &lt;BR&gt;                This option is applicable only for PDF encodingFormat selection.&lt;BR&gt;                false: Transport Label and Waybill document will use default margin settings (default behavior) &lt;BR&gt;                true: Transport Label and Waybill document will print into A4 margin PDF
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fitLabelsToA4")]
        public bool FitLabelsToA4 { get; set; } = default!;

        /// <summary>
        /// Additional customer label free text that can be printed in certain label.Note: Applicable only to ECOM26_A6_002, ECOM_TC_A4 and ECOM26_84CI_001.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labelFreeText")]
        [System.ComponentModel.DataAnnotations.StringLength(150)]
        public string LabelFreeText { get; set; } = default!;

        /// <summary>
        /// Additional customer label text that can be printed in certain label.Note: Applicable only to ECOM26_84_A4_001, ECOM_TC_A4 and ECOM26_84CI_001
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labelCustomerDataText")]
        [System.ComponentModel.DataAnnotations.StringLength(250, MinimumLength = 1)]
        public string LabelCustomerDataText { get; set; } = default!;

        /// <summary>
        /// Declaration text that can be printed in certain shipment receipt template
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shipmentReceiptCustomerDataText")]
        [System.ComponentModel.DataAnnotations.StringLength(700, MinimumLength = 1)]
        public string ShipmentReceiptCustomerDataText { get; set; } = default!;

    }
}
