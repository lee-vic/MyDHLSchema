using System.Collections.Generic;

namespace MyDHLSchema
{
    /// <summary>
    /// 创建DHL快递运单请求体
    /// </summary>
    
    public  class SupermodelIoLogisticsExpressCreateShipmentRequest
    {
        /// <summary>
        /// 包裹交付的日期和时间。日期和时间均为必填，日期不能早于当前时间且不能超过未来10天。时间为发货地本地时间，格式为：YYYY-MM-DDTHH:MM:SS GMT+时区（如2025-01-18T17:00:00 GMT+01:00）。
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("plannedShippingDateAndTime")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(29, MinimumLength = 1)]
        public string PlannedShippingDateAndTime { get; set; } = default!;

        /// <summary>
        /// 取件信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("pickup")]
        [System.ComponentModel.DataAnnotations.Required]
        public Pickup Pickup { get; set; } = new Pickup();

        /// <summary>
        /// DHL全球产品代码
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("productCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(6, MinimumLength = 1)]
        public string ProductCode { get; set; } = default!;

        /// <summary>
        /// DHL本地产品代码（国内运输时必填）
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("localProductCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 1)]
        public string LocalProductCode { get; set; } = default!;

        /// <summary>
        /// 是否获取运费预估
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("getRateEstimates")]
        public bool GetRateEstimates { get; set; } = false;

        /// <summary>
        /// 运单涉及的所有DHL账号及类型
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("accounts")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressAccount> Accounts { get; set; } = new System.Collections.ObjectModel.Collection<SupermodelIoLogisticsExpressAccount>();

        /// <summary>
        /// 额外增值服务，如保险（或货物价值保护）
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("valueAddedServices")]
        [System.ComponentModel.DataAnnotations.MaxLength(99)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressValueAddedServices> ValueAddedServices { get; set; } = default!;

        /// <summary>
        /// 标签、运单文件、发票和运输收据属性设置
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("outputImageProperties")]
        public OutputImageProperty OutputImageProperties { get; set; } = default!;

        /// <summary>
        /// 客户参考信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerReferences")]
        [System.ComponentModel.DataAnnotations.MaxLength(999)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressReference> CustomerReferences { get; set; } = default!;

        /// <summary>
        /// 运单级别的标识符，可选填DHL快递运单号。需经DHL快递IT部门启用。
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        [System.ComponentModel.DataAnnotations.MaxLength(5)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressIdentifier> Identifiers { get; set; } = default!;

        /// <summary>
        /// 发货方、收货方及其他相关方信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerDetails")]
        [System.ComponentModel.DataAnnotations.Required]
        public CustomerDetails CustomerDetails { get; set; } = new CustomerDetails();

        /// <summary>
        /// 包裹内容相关属性
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required]
        public Content Content { get; set; } = new Content();

        /// <summary>
        /// 附加的文件图像，如发票、装箱单等
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("documentImages")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(999)]
        public List<SupermodelIoLogisticsExpressDocumentImage> DocumentImages { get; set; } = default!;

        /// <summary>
        /// DHL快递按需派送服务相关信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("onDemandDelivery")]
        public OnDemandDelivery OnDemandDelivery { get; set; } = default!;

        /// <summary>
        /// 是否请求按需派送链接
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("requestOndemandDeliveryURL")]
        public bool RequestOndemandDeliveryURL { get; set; } = default!;

        /// <summary>
        /// 运单创建后发送邮件通知
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("shipmentNotification")]
        [System.ComponentModel.DataAnnotations.MaxLength(5)]
        public System.Collections.Generic.ICollection<ShipmentNotification> ShipmentNotification { get; set; } = default!;

        /// <summary>
        /// 已支付的运费等费用
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("prepaidCharges")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<PrepaidCharge> PrepaidCharges { get; set; } = default!;

        /// <summary>
        /// 是否返回发件人和收件人信息的音译文本
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("getTransliteratedResponse")]
        public bool GetTransliteratedResponse { get; set; } = default!;

        /// <summary>
        /// QDDF或QDDC的预计送达日期选项
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("estimatedDeliveryDate")]
        public EstimatedDeliveryDate EstimatedDeliveryDate { get; set; } = default!;

        /// <summary>
        /// 返回附加信息，如服务区域详情、路线代码和取件相关信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("getAdditionalInformation")]
        [System.ComponentModel.DataAnnotations.MaxLength(5)]
        public System.Collections.Generic.ICollection<GetAdditionalInformation> GetAdditionalInformation { get; set; } = default!;

        /// <summary>
        /// 母运单信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("parentShipment")]
        public ParentShipment ParentShipment { get; set; } = default!;

    }
    
    public  class Pickup
    {
        /// <summary>
        /// 是否需要取件
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("isRequested")]
        public bool IsRequested { get; set; } = false;

        /// <summary>
        /// 最晚取件时间（HH:MM）
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("closeTime")]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"([0-1][0-9]|2[0-3]):([0-5][0-9])")]
        public string CloseTime { get; set; } = default!;

        /// <summary>
        /// 包裹由DHL快递员取件的地点
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("location")]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        public string Location { get; set; } = default!;

        /// <summary>
        /// 取件时的特殊说明
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("specialInstructions")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<SpecialInstruction> SpecialInstructions { get; set; } = default!;

        /// <summary>
        /// 取件地址和联系人信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("pickupDetails")]
        public PartyDetails PickupDetails { get; set; } = default!;

        /// <summary>
        /// 请求取件的个人地址和联系人信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("pickupRequestorDetails")]
        public PartyDetails PickupRequestorDetails { get; set; } = default!;

    }
    
    public  class SpecialInstruction
    {
        /// <summary>
        /// 发给快递员的特殊取件指示
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(75)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// 预留字段
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 2)]
        public string TypeCode { get; set; } = default!;

    }
    
    public  class PartyDetails
    {

        /// <summary>
        /// 地址信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("postalAddress")]
        [System.ComponentModel.DataAnnotations.Required]
        public SupermodelIoLogisticsExpressAddressCreateShipmentRequest PostalAddress { get; set; } = new SupermodelIoLogisticsExpressAddressCreateShipmentRequest();

        /// <summary>
        /// 联系人信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("contactInformation")]
        [System.ComponentModel.DataAnnotations.Required]
        public SupermodelIoLogisticsExpressContact ContactInformation { get; set; } = new SupermodelIoLogisticsExpressContact();

        /// <summary>
        /// 注册号
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("registrationNumbers")]
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressRegistrationNumbers> RegistrationNumbers { get; set; } = default!;

        /// <summary>
        /// 银行信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("bankDetails")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public List<SupermodelIoLogisticsExpressBankDetails> BankDetails { get; set; } = default!;

        /// <summary>
        /// 业务方类型
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public PartyDetailsTypeCode TypeCode { get; set; } = default!;

    }
    
    public  class SupermodelIoLogisticsExpressAccount
    {
        /// <summary>
        /// DHL快递账号类型
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(15, MinimumLength = 1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressAccountTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// DHL快递账号
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("number")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(12, MinimumLength = 1)]
        public string Number { get; set; } = default!;

    }
    
    public  class SupermodelIoLogisticsExpressValueAddedServices
    {
        /// <summary>
        /// DHL快递增值服务代码
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("serviceCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(6, MinimumLength = 1)]
        public string ServiceCode { get; set; } = default!;

        /// <summary>
        /// 服务的货币金额（如保险金额）
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// 货币代码（如保险金额的货币代码）
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// 付款方式代码（如现金）
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("method")]
        public string Method { get; set; } = default!;

        /// <summary>
        /// 危险品相关信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("dangerousGoods")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<DangerousGoods> DangerousGoods { get; set; } = default!;

    }
    
    public  class OutputImageProperty
    {
        /// <summary>
        /// 标签和运单文件的打印分辨率（DPI）
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("printerDPI")]
        public double PrinterDPI { get; set; } = default!;

        /// <summary>
        /// 客户条形码设置
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerBarcodes")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<CustomerBarcode> CustomerBarcodes { get; set; } = default!;

        /// <summary>
        /// 客户logo设置
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerLogos")]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<CustomerLogo> CustomerLogos { get; set; } = default!;

        /// <summary>
        /// 输出文件格式，发票和运输收据始终为PDF格式
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("encodingFormat")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public OutputImagePropertiesEncodingFormat EncodingFormat { get; set; } = OutputImagePropertiesEncodingFormat.Pdf;

        /// <summary>
        /// 标签、运单文件、发票、二维码和运输收据的图像选项
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("imageOptions")]
        [System.ComponentModel.DataAnnotations.MaxLength(20)]
        public System.Collections.Generic.ICollection<ImageOptions> ImageOptions { get; set; } = default!;

        /// <summary>
        /// 是否将运输标签和运单文件分开生成PDF或热敏输出文件
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("splitTransportAndWaybillDocLabels")]
        public bool SplitTransportAndWaybillDocLabels { get; set; } = default!;

        /// <summary>
        /// 是否将运输标签、运单文件、运输收据和商业发票合并为一个PDF或热敏输出文件
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("allDocumentsInOneImage")]
        public bool AllDocumentsInOneImage { get; set; } = default!;

        /// <summary>
        /// 是否为运输标签和运单文件的每一页生成单独的PDF或热敏输出文件
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("splitDocumentsByPages")]
        public bool SplitDocumentsByPages { get; set; } = default!;

        /// <summary>
        /// 是否将发票和收据分开生成输出文件
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("splitInvoiceAndReceipt")]
        public bool SplitInvoiceAndReceipt { get; set; } = default!;

        /// <summary>
        /// 是否将运输标签、运单文件和运输收据合并为一个PDF文件
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("receiptAndLabelsInOneImage")]
        public bool ReceiptAndLabelsInOneImage { get; set; } = default!;

    }
    /// <summary>
    /// Reference model description
    /// </summary>
    
    public  class SupermodelIoLogisticsExpressReference
    {
        /// <summary>
        /// 请提供参考值
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// 请提供参考类型
        /// AAO, 收件人运单参考
        /// CU, 发件人参考 - 默认
        /// FF, 货运代理参考
        /// FN, 运费账单号
        /// IBC, 入境中心参考
        /// LLR, 装载清单参考
        /// OBC, 出境中心参考
        /// PRN, 取件请求号
        /// ACP, 本地付款账号
        /// ACS, 本地发件人账号
        /// ACR, 本地收件人账号
        /// CDN, 报关单号
        /// STD, eurolog 15位运单ID
        /// CO, 买方订单号
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 2)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressReferenceTypeCode TypeCode { get; set; } = SupermodelIoLogisticsExpressReferenceTypeCode.CU;

    }
    
    public  class SupermodelIoLogisticsExpressIdentifier
    {
        /// <summary>
        /// 请提供标识符类型
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressIdentifierTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// 请提供标识符值（运单号、包裹ID）
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// 请提供包裹数据标识符。注意：同一运单内所有包裹的标识数据应一致。
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("dataIdentifier")]
        [System.ComponentModel.DataAnnotations.StringLength(4, MinimumLength = 1)]
        public string DataIdentifier { get; set; } = default!;

    }
    
    public  class CustomerDetails
    {
        /// <summary>
        /// 发件人信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("shipperDetails")]
        [System.ComponentModel.DataAnnotations.Required]
        public PartyDetails ShipperDetails { get; set; } = new PartyDetails();

        /// <summary>
        /// 收件人信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("receiverDetails")]
        [System.ComponentModel.DataAnnotations.Required]
        public PartyDetails ReceiverDetails { get; set; } = new PartyDetails();

        /// <summary>
        /// 买方信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("buyerDetails")]
        public PartyDetails BuyerDetails { get; set; } = default!;

        /// <summary>
        /// 进口商信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("importerDetails")]
        public PartyDetails ImporterDetails { get; set; } = default!;

        /// <summary>
        /// 出口商信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("exporterDetails")]
        public PartyDetails ExporterDetails { get; set; } = default!;

        /// <summary>
        /// 卖方信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("sellerDetails")]
        public PartyDetails SellerDetails { get; set; } = default!;

        /// <summary>
        /// 付款方信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("payerDetails")]
        public PartyDetails PayerDetails { get; set; } = default!;

        /// <summary>
        /// 制造商信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("manufacturerDetails")]
        public PartyDetails ManufacturerDetails { get; set; } = default!;

        /// <summary>
        /// 最终收货人信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("ultimateConsigneeDetails")]
        public PartyDetails UltimateConsigneeDetails { get; set; } = default!;

        /// <summary>
        /// 报关行信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("brokerDetails")]
        public PartyDetails BrokerDetails { get; set; } = default!;

    }
    
    public  class Content
    {
        /// <summary>
        /// 包裹信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("packages")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(999)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressPackage> Packages { get; set; } = new System.Collections.ObjectModel.Collection<SupermodelIoLogisticsExpressPackage>();

        /// <summary>
        /// 报关相关信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("isCustomsDeclarable")]
        public bool IsCustomsDeclarable { get; set; } = default!;

        /// <summary>
        /// 报关价值
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("declaredValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double DeclaredValue { get; set; } = default!;

        /// <summary>
        /// 报关价值货币代码
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("declaredValueCurrency")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        public string DeclaredValueCurrency { get; set; } = default!;

        /// <summary>
        /// 出口声明信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("exportDeclaration")]
        public ExportDeclaration ExportDeclaration { get; set; } = default!;

        /// <summary>
        /// 货物描述
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(70, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[^\s]")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 用于美国AES4、FTR和ITN号码的运输标签打印
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("USFilingTypeValue")]
        [System.ComponentModel.DataAnnotations.StringLength(20, MinimumLength = 1)]
        public string USFilingTypeValue { get; set; } = default!;

        /// <summary>
        /// 国际贸易术语解释通则
        /// EXW 工厂交货
        /// FCA 自由承运人交货
        /// CPT 运费付至
        /// CIP 运费和保险费付至
        /// DPU 卸货后交货至指定地点
        /// DAP 交货至指定地点
        /// DDP 完税后交货
        /// FAS 装船港船边交货
        /// FOB 装船港船上交货
        /// CFR 成本加运费
        /// CIF 成本、保险加运费
        /// DAF 边境交货
        /// DAT 终端交货
        /// DDU 未完税交货
        /// DEQ 码头交货
        /// DES 装船交货
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("incoterm")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public IncotermTypeCode Incoterm { get; set; } = default!;

        /// <summary>
        /// 计量单位 - 公制或英制
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurement")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public UnitOfMeasurementTypeCode UnitOfMeasurement { get; set; } = default!;

    }
   
    /// <summary>
    /// 此部分支持多个base64编码的出口文件图像，用于无纸化贸易。提供无效的base64编码字符串时，将返回错误信息。
    /// </summary>
    
    public  class SupermodelIoLogisticsExpressDocumentImage
    {
        /// <summary>
        /// 请提供正确的文件类型
        /// INV, 发票
        /// PNV, Proforma
        /// COO, 原产地证
        /// NAF, 北美自贸协定证书
        /// CIN, 商业发票
        /// DCL, 报关单
        /// AWB, 空运提单和运单文件
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public DocumentImageTypeCode TypeCode { get; set; } = DocumentImageTypeCode.INV;

        /// <summary>
        /// 请提供要上传的文件的图像文件格式
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("imageFormat")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ImageFormatTypeCode ImageFormat { get; set; } = ImageFormatTypeCode.PDF;

        /// <summary>
        /// 请提供base64编码的文件内容
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Content { get; set; } = default!;

    }
    
    public  class OnDemandDelivery : object
    {
        /// <summary>
        /// 请从可用的派送选项中选择
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("deliveryOption")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public OnDemandDeliveryDeliveryOption DeliveryOption { get; set; } = default!;

        /// <summary>
        /// 如果选择了签名派送，请指定放置包裹的位置
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("location")]
        [System.ComponentModel.DataAnnotations.StringLength(15, MinimumLength = 1)]
        public string Location { get; set; } = default!;

        /// <summary>
        /// 请提供对DHL快递员有用的附加信息。如果选择的位置是“其他”，则此字段为必填项。
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("specialInstructions")]
        [System.ComponentModel.DataAnnotations.StringLength(110, MinimumLength = 1)]
        public string SpecialInstructions { get; set; } = default!;

        /// <summary>
        /// 请提供进入公寓大楼或门禁的密码
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("gateCode")]
        [System.ComponentModel.DataAnnotations.StringLength(10, MinimumLength = 1)]
        public string GateCode { get; set; } = default!;

        /// <summary>
        /// 如果选择了“邻居”派送，请指定放置包裹的位置
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("whereToLeave")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public OnDemandDeliveryWhereToLeave WhereToLeave { get; set; } = default!;

        /// <summary>
        /// 如果选择了“邻居”派送，请提供邻居的姓名
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("neighbourName")]
        [System.ComponentModel.DataAnnotations.StringLength(20, MinimumLength = 1)]
        public string NeighbourName { get; set; } = default!;

        /// <summary>
        /// 如果选择了“邻居”派送，请提供邻居的门牌号
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("neighbourHouseNumber")]
        [System.ComponentModel.DataAnnotations.StringLength(20, MinimumLength = 1)]
        public string NeighbourHouseNumber { get; set; } = default!;

        /// <summary>
        /// 如果选择了“签名释放”派送，请提供有权签字和接收包裹的人的姓名
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("authorizerName")]
        [System.ComponentModel.DataAnnotations.StringLength(20, MinimumLength = 1)]
        public string AuthorizerName { get; set; } = default!;

        /// <summary>
        /// 如果选择了“服务点”派送，请提供DHL快递服务点的唯一ID
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("servicePointId")]
        [System.ComponentModel.DataAnnotations.StringLength(6, MinimumLength = 1)]
        public string ServicePointId { get; set; } = default!;

        /// <summary>
        /// 预留字段
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("requestedDeliveryDate")]
        [System.ComponentModel.DataAnnotations.StringLength(29, MinimumLength = 1)]
        public string RequestedDeliveryDate { get; set; } = default!;

    }
    
    public  class ShipmentNotification
    {
        /// <summary>
        /// 通知渠道类型，目前仅支持邮件
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ShipmentNotificationTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// 通知接收者的邮件地址
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("receiverId")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string ReceiverId { get; set; } = default!;

        /// <summary>
        /// 邮件通知的语言代码
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        public string LanguageCode { get; set; } = "eng";

        /// <summary>
        /// 邮件通知的国家语言代码
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("languageCountryCode")]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string LanguageCountryCode { get; set; } = "UK";

        /// <summary>
        /// 附加在DHL快递通知邮件上的自定义信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("bespokeMessage")]
        [System.ComponentModel.DataAnnotations.StringLength(250)]
        public string BespokeMessage { get; set; } = default!;

    }
    
    public  class PrepaidCharge
    {
        /// <summary>
        /// 预付费类型，目前仅支持运费
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public PrepaidChargesTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// 货币代码
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// 与费用相关的名义金额
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Range(0.01D, 9999999999D)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// 支付方式，目前仅支持现金
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("method")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public PrepaidChargesMethod Method { get; set; } = default!;

    }
    
    public  class EstimatedDeliveryDate
    {
        /// <summary>
        /// 是否请求预计送达日期
        /// QDDF: 最快运输时间，不代表DHL服务承诺
        /// QDDC: 包含清关时间等，代表DHL服务承诺
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("isRequested")]
        public bool IsRequested { get; set; } = false;

        /// <summary>
        /// 预计送达日期类型
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public EstimatedDeliveryDateTypeCode TypeCode { get; set; } = default!;

    }
    
    public  class GetAdditionalInformation
    {
        /// <summary>
        /// 响应中返回的数据类型代码。可选值：pickupDetails, optionalShipmentData, transliterateResponse, linkLabelsByPieces
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public GetAdditionalInformationTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// 是否请求该信息
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("isRequested")]
        public bool IsRequested { get; set; } = default!;

    }
    
    public  class ParentShipment
    {
        /// <summary>
        /// 母运单的产品代码
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("productCode")]
        [System.ComponentModel.DataAnnotations.StringLength(1, MinimumLength = 1)]
        public string ProductCode { get; set; } = default!;

        /// <summary>
        /// 母运单的包裹数量
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("packagesCount")]
        [System.ComponentModel.DataAnnotations.Range(1D, double.MaxValue)]
        public double PackagesCount { get; set; } = default!;

    }
    
    public  class SupermodelIoLogisticsExpressAddressCreateShipmentRequest
    {
        /// <summary>
        /// 请填写邮政编码，如地址没有邮政编码，请留空
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("postalCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string PostalCode { get; set; } = default!;

        /// <summary>
        /// 请填写城市名称
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("cityName")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string CityName { get; set; } = default!;

        /// <summary>
        /// 请填写ISO国家代码
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string CountryCode { get; set; } = default!;

        /// <summary>
        /// 请填写省或州的代码
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("provinceCode")]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 2)]
        public string ProvinceCode { get; set; } = default!;

        /// <summary>
        /// 请填写地址行1
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressLine1")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string AddressLine1 { get; set; } = default!;

        /// <summary>
        /// 请填写地址行2
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressLine2")]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string AddressLine2 { get; set; } = default!;

        /// <summary>
        /// 请填写地址行3
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressLine3")]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string AddressLine3 { get; set; } = default!;

        /// <summary>
        /// 请填写区或县的名称
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("countyName")]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string CountyName { get; set; } = default!;

        /// <summary>
        /// 请填写省或州的名称
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("provinceName")]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string ProvinceName { get; set; } = default!;

        /// <summary>
        /// 请填写国家名称
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("countryName")]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string CountryName { get; set; } = default!;

    }
    
    /// <summary>
    /// 联系人信息
    /// </summary>
    public  class SupermodelIoLogisticsExpressContact
    {
        /// <summary>
        /// 电子邮件地址
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        [System.ComponentModel.DataAnnotations.StringLength(70, MinimumLength = 1)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// 电话号码
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("phone")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(70, MinimumLength = 1)]
        public string Phone { get; set; } = default!;

        /// <summary>
        /// 手机号码
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("mobilePhone")]
        [System.ComponentModel.DataAnnotations.StringLength(70, MinimumLength = 1)]
        public string MobilePhone { get; set; } = default!;

        /// <summary>
        /// 公司名称
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("companyName")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength = 1)]
        public string CompanyName { get; set; } = default!;

        /// <summary>
        /// 联系人全名
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("fullName")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(255, MinimumLength = 1)]
        public string FullName { get; set; } = default!;

    }
}
