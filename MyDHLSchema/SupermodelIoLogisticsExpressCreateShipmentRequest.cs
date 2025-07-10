using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public OutputImageProperty OutputImageProperties { get; set; } = default!;

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
        public System.Collections.Generic.ICollection<PrepaidCharge> PrepaidCharges { get; set; } = default!;

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
        public System.Collections.Generic.ICollection<SpecialInstruction> SpecialInstructions { get; set; } = default!;

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
    public partial class SpecialInstruction
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
        /// The DangerousGoods section indicates if there is dangerous good content within the shipment. <BR> The ContentID node contains the Content ID for Dangerous Good classification. <BR> It is required to provide the dangerous good Content ID for every dangerous good special service provided, and vice versa. <BR>
        /// <br/>For the complete list of dangerous goods Content IDs and dangerous goods special services combinations, refer to Reference Data Guide section 5. valueAddedServicesDefinition\dangerousGoods. <BR> Note: Please contact your DHL Express IT representative if additional assistance is required.<BR><BR>
        /// <br/>For dangerous goods shipment with Dry Ice example: UN1845 (Content ID: 901), additional node must be populated 'dryIceTotalNetWeight.'<BR>
        /// <br/>For dangerous goods shipment with 'Excepted Quantities', additional node must be populated 'unCodes'. Few scenarios guideline to prepare a Dangerous Goods shipment for:<BR><BR>
        /// <br/>A) Dry Ice: <BR> 1.'serviceCode' element must contain value of 'HC'<BR> 2.'contentID' element consists of '901'<BR> 3.'dryIceTotalNetWeight' element consists of the total net weight of the dry ice in 'unitofMeasurement' <BR><BR>
        /// <br/>B) Lithium Battery: <BR> 1.'serviceType' element must contain value of 'HD', 'HM', 'HV' or 'HW'<BR> 2.'contentID' element consists of '966', '969', '967', '970' respectively<BR><BR>
        /// <br/>C) Excepted Quantities:<BR> 1.'serviceCode' element must contain value of 'HH'<BR> 2.'contentID' element consists of 'E01<BR> 3.'unCodes' element consists of the UN code associate with it.<BR>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("dangerousGoods")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<DangerousGoods> DangerousGoods { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OutputImageProperty
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
        public System.Collections.Generic.ICollection<CustomerBarcode> CustomerBarcodes { get; set; } = default!;

        /// <summary>
        /// Customer Logo Image to be printed on transport label
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerLogos")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<CustomerLogo> CustomerLogos { get; set; } = default!;

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
        /// Please provide reference type
        /// <BR>      <BR>      AAO, shipment reference number of receiver
        /// <BR>      CU, reference number of consignor - default
        /// <BR>      FF, reference number of freight forwarder
        /// <BR>      FN, freight bill number for <ex works invoice number>
        /// <BR>      IBC, inbound center reference number
        /// <BR>      LLR, load list reference for <10-digit Shipment ID>
        /// <BR>      OBC, outbound center reference number for <SHIPMEN IDENTIFIER (COUNTRY OF ORIGIN)>
        /// <BR>      PRN, pickup request number for <BOOKINGREFERENCE NUMBER>
        /// <BR>      ACP, local payer account number
        /// <BR>      ACS, local shipper account number
        /// <BR>      ACR, local receiver account number
        /// <BR>      CDN, customs declaration number
        /// <BR>      STD, eurolog 15-digit shipment id
        /// <BR>      CO, buyers order number
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
        /// The Incoterms rules are a globally-recognized set of standards, used worldwide in international and domestic contracts for the delivery of goods, illustrating responsibilities between buyer and seller for costs and risk, as well as cargo insurance.
        /// <BR>          EXW ExWorks
        /// <BR>          FCA Free Carrier
        /// <BR>          CPT Carriage Paid To
        /// <BR>          CIP Carriage and Insurance Paid To
        /// <BR>          DPU Delivered at Place Unloaded
        /// <BR>          DAP Delivered at Place
        /// <BR>          DDP Delivered Duty Paid
        /// <BR>          FAS Free Alongside Ship
        /// <BR>          FOB Free on Board
        /// <BR>          CFR Cost and Freight
        /// <BR>          CIF Cost, Insurance and Freight
        /// <BR>          DAF Delivered at Frontier
        /// <BR>          DAT Delivered at Terminal
        /// <BR>          DDU Delivered Duty Unpaid
        /// <BR>          DEQ Delivery ex Quay
        /// <BR>          DES Delivered ex Ship
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("incoterm")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public IncotermTypeCode Incoterm { get; set; } = default!;

        /// <summary>
        /// Please enter Unit of measurement - metric,imperial
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurement")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public UnitOfMeasurementTypeCode UnitOfMeasurement { get; set; } = default!;

    }
   
    /// <summary>
    /// This section is to support multiple base64 encoded string with the image of export documentation for Paperless Trade images. When an invalid base64 encoded string is provided, an error message will be returned
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressDocumentImage
    {
        /// <summary>
        /// Please provide correct document type you wish to upload
        /// <BR>        <BR>        Possible values:
        /// <BR>        INV, Invoice
        /// <BR>        PNV, Proforma
        /// <BR>        COO, Certificate of Origin
        /// <BR>        NAF, Nafta Certificate of Origin
        /// <BR>        CIN, Commercial Invoice
        /// <BR>        DCL, Custom Declaration
        /// <BR>        AWB, Air Waybill and Waybill Document
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public DocumentImageTypeCode TypeCode { get; set; } = DocumentImageTypeCode.INV;

        /// <summary>
        /// Please provide the image file format for the document you want to upload
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("imageFormat")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ImageFormatTypeCode ImageFormat { get; set; } = ImageFormatTypeCode.PDF;

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
    public partial class PrepaidCharge
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
        /// VAT: Value-Added tax<BR>      EIN: Employer Identification Number<BR>      GST: Goods and Service Tax<BR>      SSN: Social Security Number<BR>      EOR: European Union Registration and Identification<BR>      DUN: Data Universal Numberin System<BR>      FED: Federal Tax ID<BR>      STA: State Tax ID<BR>      CNP: Brazil CNPJ/CPF Federal Tax<BR>      IE: Brazil type IE/RG Federal Tax<BR>      INN: Russia bank details section INN<BR>      KPP: Russia bank details section KPP<BR>      OGR: Russia bank details section OGRN<BR>      OKP: Russia bank details section OKPO<BR>      SDT: Overseas Registered Supplier or Import One-Stop-Shop or GB VAT (foreign) registration or AUSid GST Registration or VAT on E-Commerce<BR>      FTZ: Free Trade Zone ID<BR>      DAN: Deferment Account Duties Only<BR>      TAN: Deferment Account Tax Only<BR>      DTF: Deferment Account Duties, Taxes and Fees Only<BR>      RGP: EU Registered Exporters registration ID<BR>       DLI: Driver's License <BR>      NID: National Identity Card<BR> PAS: Passport<BR> MID: Manufacturer ID<BR>IMS: UK Internal Market Scheme<BR> Note: 'IMS' code will be available in Production by the end of March 2025.<BR> EIC: eInvoice Carrier <BR> FTN: Foreign Tax Identification Number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressRegistrationNumbersTypeCode TypeCode { get; set; } = SupermodelIoLogisticsExpressRegistrationNumbersTypeCode.VAT;

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
        /// Please enter valid DHL Express Dangerous good content id (please contact your DHL Express IT representative for the relevant content ID code if you are shipping Dangerous Goods)
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
        /// The customDescription node contains the customized Dangerous Goods statement to declare contents accurately. The customDescription node value will be displayed in the Transport Label and Waybill Document, replacing the default IATA Dangerous Goods statement constructed based on contentId node.
        /// <BR>            Multiple customDescription nodes from multiple dangerousGoods nodes will be concatenated using comma separator with combined maximum limit of 200 characters.
        /// <BR>            <BR>            It is recommended to use customDescription for entire shipment for each dangerousGoods to fully utilize customDescription printout in Transport Label and Waybill Document.
        /// <BR>            <BR>            Note: For 'customDescription' usage, ensure all 'dangerousGoods' segments are including the 'customDescription' field value. Any of the dangerousGoods does not provide with customDescription field value will be ignored from printing in Transport Label and Waybill Document.
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
    public partial class CustomerBarcode
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
    public partial class CustomerLogo
    {
        /// <summary>
        /// Please specify image file format
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fileFormat")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public CustomerLogoFileFormat FileFormat { get; set; } = default!;

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
        public ImageOptionTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// Please enter DHL Express document template name. <BR>                Sample Transport label templates:<BR>                ECOM26_84_A4_001 <BR>                ECOM26_84_001 - default<BR>                ECOM_TC_A4<BR>                ECOM26_A6_002<BR>                ECOM26_84CI_001<BR>                ECOM26_84CI_002 - supported single customer barcode<BR>                ECOM26_84CI_003 - to be used if customer barcodes are used<BR>                ECOM_A4_RU_002<BR> ECOM26_84_LBBX_001 - supported for loose BBX shipment<BR> ECOM26_64_LBBX_001 - supported for loose BBX shipment<BR>Sample WaybillDoc templates<BR>                ARCH_8X4_A4_002<BR>                ARCH_8X4 - default<BR>                ARCH_6X4<BR>                ARCH_A4_RU_002<BR>                <BR>                Sample Commercial invoice templates:<BR>                COMMERCIAL_INVOICE_04 - This template can print the Shipper, Recipient, and Buyer and Importer address details and is on portrait orientation, exclusive use for preparing Loose BBX shipment.<BR>                COMMERCIAL_INVOICE_P_10 - (default) This template can print the Shipper, Recipient and upto two more additional address details in portrait orientation. Note: If customer provided more than four address roles in the request message and this template is selected, the rendered invoice will only contain four address roles based on order of priority: Shipper, Recipient, Seller, Importer, Exporter, Buyer. <BR>                COMMERCIAL_INVOICE_L_10 - This template can print the Shipper,Recipient, Buyer, and Importer and Exporter address details and is on landscape orientation..<BR>                RET_COM_INVOICE_A4_01 - This template can print the Shipper, Recipient and Importer of record address details and is on landscape orientation. This template is for exclusive use for certain shipment where the goods are actual 'returns'. The Shipper is the party that earlier has received the goods, but now wishes to return the goods to its originating party. The Recipient in this shipment scenario will receive the 'returned goods'. Therefore such request of shipment with an invoice rendering may utilize the specific invoice template for 'Returns Invoice'.<BR>                <BR>                Sample Shipment Receipt template<BR>                SHIP_RECPT_A4_RU_002<BR> SHIPRCPT_EN_001 - default <BR> <BR> Sample QR Code template template<BR>  QR_1_00_LL_PNG_001 - default
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
        public ImageOptionInvoiceType InvoiceType { get; set; } = default!;

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
        public ImageOptionEncodingFormat EncodingFormat { get; set; } = default!;

        /// <summary>
        /// DHL Logo to be printed in Transport Label or Waybill Document
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("renderDHLLogo")]
        public bool RenderDHLLogo { get; set; } = default!;

        /// <summary>
        /// To print respective Transport Label and Waybill document into A4 margin PDF.
        /// <BR>                Note: ECOM26_A6_002,ECOM26_84CI_001,ECOM26_84CI_002,ARCH_6X4,ARCH_8X4 template. 
        /// <BR>                This option is applicable only for PDF encodingFormat selection.
        /// <BR>                false: Transport Label and Waybill document will use default margin settings (default behavior) 
        /// <BR>                true: Transport Label and Waybill document will print into A4 margin PDF
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
    /// <summary>
    /// Package definition for /shipments
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressPackage
    {
        /// <summary>
        /// Please contact your DHL Express representative if you wish to use a DHL specific package otherwise ignore this element.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 2)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressPackageTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// The weight of the package.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("weight")]
        [System.ComponentModel.DataAnnotations.Range(0.001D, 999999999999D)]
        public double Weight { get; set; } = default!;

        /// <summary>
        /// Dimensions of the package
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [System.ComponentModel.DataAnnotations.Required]
        public Dimensions Dimensions { get; set; } = new Dimensions();

        /// <summary>
        /// Here you can declare your customer references for each package
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerReferences")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(99)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressPackageReference> CustomerReferences { get; set; } = default!;

        /// <summary>
        /// Identifiers section is on the package level where you can optionaly provide a DHL Express waybill number. This has to be enabled by your DHL Express IT contact.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressIdentifier> Identifiers { get; set; } = default!;

        /// <summary>
        /// Please enter description of content for each package
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.StringLength(70, MinimumLength = 1)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// This allows you to define up to two bespoke barcodes on the DHL Express Tranport label. To use this feature please set outputImageProperties/imageOptions/templateName as ECOM26_84CI_003 for typeCode=label
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labelBarcodes")]
        [System.ComponentModel.DataAnnotations.MaxLength(2)]
        public System.Collections.Generic.ICollection<LabelBarcodes> LabelBarcodes { get; set; } = default!;

        /// <summary>
        /// This allows you to enter up to two bespoke texts on the DHL Express Tranport label. To use this feature please set outputImageProperties/imageOptions/templateName as ECOM26_84CI_003 for typeCode=label
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labelText")]
        [System.ComponentModel.DataAnnotations.MaxLength(6)]
        public System.Collections.Generic.ICollection<LabelText> LabelText { get; set; } = default!;

        /// <summary>
        /// Please enter additional customer description
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labelDescription")]
        [System.ComponentModel.DataAnnotations.StringLength(80, MinimumLength = 1)]
        public string LabelDescription { get; set; } = default!;

        /// <summary>
        /// Please enter package reference number. If package reference number is provided for at least one package, then package reference number must be provided for all packages.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("referenceNumber")]
        [System.ComponentModel.DataAnnotations.Range(1D, 999D)]
        public double ReferenceNumber { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ExportDeclaration
    {
        /// <summary>
        /// Please enter details for each export line item
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("lineItems")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(999)]
        public System.Collections.Generic.ICollection<LineItem> LineItems { get; set; } = new System.Collections.ObjectModel.Collection<LineItem>();

        /// <summary>
        /// Please provide invoice related information
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("invoice")]
        public Invoice Invoice { get; set; } = default!;

        /// <summary>
        /// Please enter up to three remarks. 
        /// <BR>              If using Customs Invoice template COMMERCIAL_INVOICE_04, the invoice can only print the first remarks field. The recommended max length is 20 characters. 
        /// <BR>              If using Customs Invoice template COMMERCIAL_INVOICE_L_10 or COMMERCIAL_INVOICE_P_10, the invoice can print all three remraks fields.  The recommended max length is 45 characters.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("remarks")]
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public System.Collections.Generic.ICollection<Remark> Remarks { get; set; } = default!;

        /// <summary>
        /// Please enter additional charge to appear on the invoice
        /// <BR>              admin, Administration Charge
        /// <BR>              delivery, Delivery Charge
        /// <BR>              documentation, Documentation Charge
        /// <BR>              expedite, Expedite Charge
        /// <BR>              export, Export Charge
        /// <BR>              freight, Freight Charge
        /// <BR>              fuel_surcharge, Fuel Surcharge
        /// <BR>              logistic, Logistic Charge
        /// <BR>              other, Other Charge
        /// <BR>              packaging, Packaging Charge
        /// <BR>              pickup, Pickup Charge
        /// <BR>              handling, Handling Charge
        /// <BR>              vat, VAT Charge
        /// <BR>              insurance, Insurance Cost
        /// <BR>              reverse_charge, Reverse Charge
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("additionalCharges")]
        [System.ComponentModel.DataAnnotations.MaxLength(5)]
        public System.Collections.Generic.ICollection<AdditionalCharge> AdditionalCharges { get; set; } = default!;

        /// <summary>
        /// Please provide destination port details
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("destinationPortName")]
        public string DestinationPortName { get; set; } = default!;

        /// <summary>
        /// Name of port of departure, shipment or destination as required under the applicable delivery term.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("placeOfIncoterm")]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 1)]
        public string PlaceOfIncoterm { get; set; } = default!;

        /// <summary>
        /// Please provide Payer VAT number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("payerVATNumber")]
        public string PayerVATNumber { get; set; } = default!;

        /// <summary>
        /// Please enter recipient reference
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("recipientReference")]
        public string RecipientReference { get; set; } = default!;

        /// <summary>
        /// Exporter related details
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("exporter")]
        public Exporter Exporter { get; set; } = default!;

        /// <summary>
        /// Please enter package marks
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("packageMarks")]
        public string PackageMarks { get; set; } = default!;

        /// <summary>
        /// Please provide up to three declaration notes
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("declarationNotes")]
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public System.Collections.Generic.ICollection<DeclarationNote> DeclarationNotes { get; set; } = default!;

        /// <summary>
        /// Please enter export reference
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("exportReference")]
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string ExportReference { get; set; } = default!;

        /// <summary>
        /// Please enter export reason
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("exportReason")]
        [System.ComponentModel.DataAnnotations.StringLength(30, MinimumLength = 1)]
        public string ExportReason { get; set; } = default!;

        /// <summary>
        /// Please provide the reason for export
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("exportReasonType")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ExportDeclarationExportReasonType ExportReasonType { get; set; } = default!;

        /// <summary>
        /// Please provide details about export and import licenses
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("licenses")]
        [System.ComponentModel.DataAnnotations.MaxLength(2)]
        public System.Collections.Generic.ICollection<License> Licenses { get; set; } = default!;

        /// <summary>
        /// Please provide the shipment was sent for Personal (Gift) or Commercial (Sale) reasons
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shipmentType")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ExportDeclarationShipmentType ShipmentType { get; set; } = default!;

        /// <summary>
        /// Please provide the Customs Documents at invoice level
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customsDocuments")]
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        public System.Collections.Generic.ICollection<CustomsDocument> CustomsDocuments { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Dimensions
    {
        /// <summary>
        /// Length of the package
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("length")]
        [System.ComponentModel.DataAnnotations.Range(0.001D, 9999999D)]
        public double Length { get; set; } = default!;

        /// <summary>
        /// Width of the package
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("width")]
        [System.ComponentModel.DataAnnotations.Range(0.001D, 9999999D)]
        public double Width { get; set; } = default!;

        /// <summary>
        /// Height of the package
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("height")]
        [System.ComponentModel.DataAnnotations.Range(0.001D, 9999999D)]
        public double Height { get; set; } = default!;

    }
    /// <summary>
    /// Package Reference model description
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupermodelIoLogisticsExpressPackageReference
    {
        /// <summary>
        /// Please provide reference
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Please provide reference type
        /// <BR>      <BR>      AAO, shipment reference number of receiver
        /// <BR>      CU, reference number of consignor - default
        /// <BR>      FF, reference number of freight forwarder
        /// <BR>      FN, freight bill number for <ex works invoice number>
        /// <BR>      IBC, inbound center reference number
        /// <BR>      LLR, load list reference for <10-digit Shipment ID>
        /// <BR>      OBC, outbound center reference number for <SHIPMEN IDENTIFIER (COUNTRY OF ORIGIN)>
        /// <BR>      PRN, pickup request number for <BOOKINGREFERENCE NUMBER>
        /// <BR>      ACP, local payer account number
        /// <BR>      ACS, local shipper account number
        /// <BR>      ACR, local receiver account number
        /// <BR>      CDN, customs declaration number
        /// <BR>      STD, eurolog 15-digit shipment id
        /// <BR>      CO, buyers order number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 2)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressPackageReferenceTypeCode TypeCode { get; set; } = SupermodelIoLogisticsExpressPackageReferenceTypeCode.CU;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LabelBarcodes
    {
        /// <summary>
        /// Position of the bespoke barcode
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("position")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public LabelBarcodePosition Position { get; set; } = default!;

        /// <summary>
        /// Please enter valid Symbology code
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("symbologyCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public LabelBarcodeSymbologyCode SymbologyCode { get; set; } = default!;

        /// <summary>
        /// Please enter barcode content
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Please enter text below customer barcode
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("textBelowBarcode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string TextBelowBarcode { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LabelText
    {
        /// <summary>
        /// Position of the bespoke text
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("position")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public LabelTextPosition Position { get; set; } = default!;

        /// <summary>
        /// Please enter caption to be printed in the tag value
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("caption")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string Caption { get; set; } = default!;

        /// <summary>
        /// Please enter value to be printed for the respective tag in caption
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string Value { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LineItem
    {
        /// <summary>
        /// Please provide line item number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("number")]
        [System.ComponentModel.DataAnnotations.Range(1, 999)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// Please provide description of the line item
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 1)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Please provide unit or article price line item value
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("price")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double Price { get; set; } = default!;

        /// <summary>
        /// Please enter information about quantity for this line item
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [System.ComponentModel.DataAnnotations.Required]
        public Quantity Quantity { get; set; } = new Quantity();

        /// <summary>
        /// Please provide Commodity codes for the shipment at item line level
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("commodityCodes")]
        [System.ComponentModel.DataAnnotations.MaxLength(2)]
        public System.Collections.Generic.ICollection<CommodityCode> CommodityCodes { get; set; } = default!;

        /// <summary>
        /// Please provide the reason for export
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("exportReasonType")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public LineItemExportReasonType ExportReasonType { get; set; } = default!;

        /// <summary>
        /// Please enter two letter ISO manufacturer country code
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("manufacturerCountry")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string ManufacturerCountry { get; set; } = default!;

        /// <summary>
        /// Please enter the total weight value for line item for gross weight or net weight. There is no auto calculation for number multiply with weight.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("weight")]
        [System.ComponentModel.DataAnnotations.Required]
        public Weight Weight { get; set; } = new Weight();

        /// <summary>
        /// Please provide if the Taxes is paid for the line item
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("isTaxesPaid")]
        public bool IsTaxesPaid { get; set; } = default!;

        /// <summary>
        /// Please provide the additional information
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("additionalInformation")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(8)]
        public System.Collections.Generic.ICollection<string> AdditionalInformation { get; set; } = default!;

        /// <summary>
        /// Please provide the Customer References for the line item
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerReferences")]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public System.Collections.Generic.ICollection<CustomerReference> CustomerReferences { get; set; } = default!;

        /// <summary>
        /// Please provide the customs documents details
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customsDocuments")]
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        public System.Collections.Generic.ICollection<CustomsDocument> CustomsDocuments { get; set; } = default!;

        /// <summary>
        /// Please provide monetary value of the line item x quantity
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("preCalculatedLineItemTotalValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double PreCalculatedLineItemTotalValue { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Invoice
    {
        /// <summary>
        /// Please enter commercial invoice number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("number")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Number { get; set; } = default!;

        /// <summary>
        /// Please enter accurate date when the invoice was issued at as that is what drives the exchange rate calculation during customs clearance process (where applicable).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset Date { get; set; } = default!;

        /// <summary>
        /// Please enter who has signed the invoce
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("signatureName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string SignatureName { get; set; } = default!;

        /// <summary>
        /// Please provide title of person who has signed the invoice
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("signatureTitle")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string SignatureTitle { get; set; } = default!;

        /// <summary>
        /// Please provide the signature image
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("signatureImage")]
        [System.ComponentModel.DataAnnotations.StringLength(1048576)]
        public string SignatureImage { get; set; } = default!;

        /// <summary>
        /// Shipment instructions for customs invoice printing purposes. Printed only when using Customs Invoice template COMMERCIAL_INVOICE_04. If using Customs Invoice template 			COMMERCIAL_INVOICE_04, recommended max length is 120 characters.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<string> Instructions { get; set; } = default!;

        /// <summary>
        /// Customer data text to be printed in
        /// customs invoice.
        /// Printed only when using Customs
        /// Invoice template
        /// COMMERCIAL_INVOICE_04.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerDataTextEntries")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(6)]
        public System.Collections.Generic.ICollection<string> CustomerDataTextEntries { get; set; } = default!;

        /// <summary>
        /// Please provide the total net weight
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("totalNetWeight")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999D)]
        public double TotalNetWeight { get; set; } = default!;

        /// <summary>
        /// Please provide the total gross weight
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("totalGrossWeight")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999D)]
        public double TotalGrossWeight { get; set; } = default!;

        /// <summary>
        /// Please provide the customer references at invoice level. It is recommended to provide less than 20 customer references of 'MRN' type code.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerReferences")]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public System.Collections.Generic.ICollection<CustomerReference> CustomerReferences { get; set; } = default!;

        /// <summary>
        /// Please provide the terms of payment
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("termsOfPayment")]
        public string TermsOfPayment { get; set; } = default!;

        /// <summary>
        /// indicativeCustomsValues contains child nodes importCustomsDutyValue and importTaxesValue.<BR>                  <BR>                  These 2 child elements are only applicable for Commercial Invoice printing purpose in Customs Invoice template*: COMMERCIAL_INVOICE_P_10 and COMMERCIAL_INVOICE_L_10.<BR>                  If any of this child nodes are present, it will only be able to display up to three OtherCharges. <BR>                  <BR>                  Nonetheless, the ShipmentRequest can still contain up to five additionalCharges.<BR>                  If there are more than three additionalCharges, the third additionalCharges onwards will be combined and displayed under one single caption of 'Other Charges'.<BR>                  <BR>                  Note: If either first or second additionalCharges has typeCode of 'other', and there are more than three additionalCharges provided in the request, the additionalCharges with typeCode of 'other' will be consolidated under the combined 'Other Charges' caption as well.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("indicativeCustomsValues")]
        public IndicativeCustomsValues IndicativeCustomsValues { get; set; } = default!;

        /// <summary>
        /// Please provide pre-calculated total values for total goods value and total invoice value.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("preCalculatedTotalValues")]
        public PreCalculatedTotalValues PreCalculatedTotalValues { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Remark
    {
        /// <summary>
        /// Please enter remark text
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Value { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdditionalCharge
    {
        /// <summary>
        /// Please provide the charge value
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Range(0.001D, 999999999999999D)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Please enter charge caption
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string Caption { get; set; } = default!;

        /// <summary>
        /// Please enter charge type
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public AdditionalChargeTypeCode TypeCode { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DeclarationNote
    {

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(700)]
        public string Value { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Exporter
    {
        /// <summary>
        /// Please provide exporter Id
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Please provide exporter code
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class License
    {
        /// <summary>
        /// Please provide type of the license
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public LicenseTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// Please provide the license
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(16)]
        public string Value { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CustomsDocument
    {
        /// <summary>
        /// Please provide the Customs Document type code at invoice level
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public CustomsDocumentTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// Please provide the Customs Document ID at invoice level
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Value { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    [System.Flags]
    public enum LabelTextPosition
    {

        [System.Runtime.Serialization.EnumMember(Value = @"left1")]
        Left1 = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"left2")]
        Left2 = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"left3")]
        Left3 = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"right1")]
        Right1 = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"right2")]
        Right2 = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"right3")]
        Right3 = 32,

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Quantity
    {
        /// <summary>
        /// Please enter number of pieces in the line item
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Range(1, 1000000000)]
        public int Value { get; set; } = default!;

        /// <summary>
        /// Please provide correct unit of measurement
        /// 
        /// Possible values:
        /// <br/>  BOX Boxes
        /// <br/> 2GM Centigram
        /// <br/>  M3 Cubic Meters
        /// <br/>  DPR Dozen Pairs
        /// <br/>  DOZ Dozen
        /// <br/>  PCS Pieces
        /// <br/>  GM Grams
        /// <br/>  GRS Gross
        /// <br/>  KG Kilograms
        /// <br/>  M Meters
        /// <br/>  3GM Milligrams
        /// <br/>  X No Unit Required
        /// <br/>  NO Number
        /// <br/>  PRS Pairs
        /// <br/>  CM2 Square Centimeters
        /// <br/>  2M2 Square Feet
        /// <br/>  3M2 Square Inches
        /// <br/>  M2 Square Meters
        /// <br/>  4M2 Square Yards
        /// <br/>  CM Centimeters
        /// <br/>  CONE Cone
        /// <br/>  CT Carat
        /// <br/>  EA Each
        /// <br/>  LBS Pounds
        /// <br/>  RILL Rill
        /// <br/>  ROLL Roll
        /// <br/>  SET Set
        /// <br/>  TU Time Unit
        /// <br/>  KM kilometre
        /// <br/>  IN inch
        /// <br/>  FT foot
        /// <br/>  YD yard
        /// <br/>  MI mile (statute mile)
        /// <br/>  LTR litre
        /// <br/>  MMQ cubic millimetre
        /// <br/>  CM3 cubic centimetre
        /// <br/>  DMQ cubic decimetre
        /// <br/>  MLT millilitre
        /// <br/>  CLT centilitre
        /// <br/>  DLT decilitre
        /// <br/>  INQ cubic inch
        /// <br/>  FT3 cubic foot
        /// <br/>  YD3 cubic yard
        /// <br/>  GLI gallon (UK)
        /// <br/>  GLL gallon (US)
        /// <br/>  PT pint (US)
        /// <br/>  PTI pint (UK)
        /// <br/>  QTI quart (UK)
        /// <br/>  PTL liquid pint (US)
        /// <br/>  QTL liquid quart (US)
        /// <br/>  PTD dry pint (US)
        /// <br/>  OZI fluid ounce (UK)
        /// <br/>  J57 barrel (UK petroleum)
        /// <br/>  NM3 Normalised cubic metre
        /// <br/>  SM3 Standard cubic metre
        /// <br/>  TNE tonne (metric ton)
        /// <br/>  LB pound
        /// <br/>  ONZ ounce (avoirdupois)
        /// <br/>  CEL degree Celsius                              
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurement")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(8)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public UnitOfMeasurementTypeCode UnitOfMeasurement { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CommodityCode
    {
        /// <summary>
        /// Please provide type of the commodity code
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public CommodityCodeTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// Please provide the commodity code
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(18, MinimumLength = 2)]
        public string Value { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    [System.Flags]
    public enum LineItemExportReasonType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"permanent")]
        Permanent = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"temporary")]
        Temporary = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"return")]
        Return = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"used_exhibition_goods_to_origin")]
        Used_exhibition_goods_to_origin = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"intercompany_use")]
        Intercompany_use = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"commercial_purpose_or_sale")]
        Commercial_purpose_or_sale = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"personal_belongings_or_personal_use")]
        Personal_belongings_or_personal_use = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"sample")]
        Sample = 128,

        [System.Runtime.Serialization.EnumMember(Value = @"gift")]
        Gift = 256,

        [System.Runtime.Serialization.EnumMember(Value = @"return_to_origin")]
        Return_to_origin = 512,

        [System.Runtime.Serialization.EnumMember(Value = @"warranty_replacement")]
        Warranty_replacement = 1024,

        [System.Runtime.Serialization.EnumMember(Value = @"diplomatic_goods")]
        Diplomatic_goods = 2048,

        [System.Runtime.Serialization.EnumMember(Value = @"defence_material")]
        Defence_material = 4096,

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Weight
    {
        /// <summary>
        /// Please enter the total net weight value
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("netValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999D)]
        public double NetValue { get; set; } = default!;

        /// <summary>
        /// Please enter the total gross weight value
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("grossValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999D)]
        public double GrossValue { get; set; } = default!;

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CustomerReference
    {
        /// <summary>
        /// Please provide the line item reference type code. Please refer to the YAML Reference Data Guide PDF file for valid enumeration values.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public CustomerReferenceTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// Please provide the line item reference
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Value { get; set; } = default!;
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    internal class DateFormatConverter : System.Text.Json.Serialization.JsonConverter<System.DateTimeOffset>
    {
        public override System.DateTimeOffset Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
        {
            var dateTime = reader.GetString();
            if (dateTime == null)
            {
                throw new System.Text.Json.JsonException("Unexpected JsonTokenType.Null");
            }

            return System.DateTimeOffset.Parse(dateTime);
        }

        public override void Write(System.Text.Json.Utf8JsonWriter writer, System.DateTimeOffset value, System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-dd"));
        }
    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class IndicativeCustomsValues
    {
        /// <summary>
        /// Please provide the pre-calculated import customs duties value for the shipment
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("importCustomsDutyValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double ImportCustomsDutyValue { get; set; } = default!;

        /// <summary>
        /// Please provide the pre-calculated import taxes (VAT/GST) value for the shipment
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("importTaxesValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double ImportTaxesValue { get; set; } = default!;

        /// <summary>
        /// Please provide pre-calculated total of all line items plus additional charges plus indicativeCustomsValues
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("totalWithImportDutiesAndTaxes")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double TotalWithImportDutiesAndTaxes { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PreCalculatedTotalValues
    {
        /// <summary>
        /// Please provide the pre-calculated total value of all line items. preCalculatedTotalGoodsValue indicates pre-calculated sum of all Export Line Items’ Subtotal in Export Declaration. This field value will be rendered in Commercial Invoice output and manifest message.
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("preCalculatedTotalGoodsValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double PreCalculatedTotalGoodsValue { get; set; } = default!;

        /// <summary>
        /// Please provide the total value of all line items plus additional charges if any. preCalculatedTotalInvoiceValue indicates pre-calculated sum of all Export Line Items’ Subtotal  amount plus all Other Charges amount.  This field value will be used in rendered Commercial Invoice output, Waybill document and manifest message.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("preCalculatedTotalInvoiceValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double PreCalculatedTotalInvoiceValue { get; set; } = default!;

    }
    
    
}
