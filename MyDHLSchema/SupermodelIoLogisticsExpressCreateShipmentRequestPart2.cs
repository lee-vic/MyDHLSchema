namespace MyDHLSchema
{
    /// <summary>
    /// 如果您的国家/地区需要注册号（如增值税、EOR 等），请在此处声明
    /// </summary>
    
    public  class SupermodelIoLogisticsExpressRegistrationNumbers
    {
        /// <summary>
        /// VAT: 增值税
        /// EIN: 雇主识别号
        /// GST: 商品与服务税
        /// SSN: 社会保障号
        /// EOR: 欧盟注册与识别
        /// DUN: 数据通用编号系统
        /// FED: 联邦税号
        /// STA: 州税号
        /// CNP: 巴西 CNPJ/CPF 联邦税号
        /// IE: 巴西 IE/RG 联邦税号
        /// INN: 俄罗斯银行详细信息 INN
        /// KPP: 俄罗斯银行详细信息 KPP
        /// OGR: 俄罗斯银行详细信息 OGRN
        /// OKP: 俄罗斯银行详细信息 OKPO
        /// SDT: 海外注册供应商或进口一站式商店或英国增值税（外国）注册或澳大利亚 GST 注册或电子商务增值税
        /// FTZ: 自由贸易区 ID
        /// DAN: 仅限延期账户关税
        /// TAN: 仅限延期账户税收
        /// DTF: 仅限延期账户关税、税收和费用
        /// RGP: 欧盟注册出口商注册 ID
        /// DLI: 驾驶证 
        /// NID: 国家身份证
        /// PAS: 护照
        /// MID: 制造商 ID
        /// IMS: 英国内部市场计划
        /// 注意：“IMS”代码将于 2025 年 3 月底在生产环境中可用。
        /// EIC: 电子发票承运人 
        /// FTN: 外国税号
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressRegistrationNumbersTypeCode TypeCode { get; set; } = SupermodelIoLogisticsExpressRegistrationNumbersTypeCode.VAT;

        /// <summary>
        /// 请输入注册号
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("number")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Number { get; set; } = default!;

        /// <summary>
        /// 请输入注册号签发国家的 2 位字符代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("issuerCountryCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string IssuerCountryCode { get; set; } = default!;

    }
    /// <summary>
    /// 俄罗斯银行详细信息
    /// </summary>
    
    public  class SupermodelIoLogisticsExpressBankDetails
    {
        /// <summary>
        /// 用于商业发票 - 俄罗斯银行名称字段
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.StringLength(60)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 用于商业发票 - 俄罗斯银行本币结算账户字段
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("settlementLocalCurrency")]
        public string SettlementLocalCurrency { get; set; } = default!;

        /// <summary>
        /// 用于商业发票 - 俄罗斯银行外币结算账户字段
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("settlementForeignCurrency")]
        public string SettlementForeignCurrency { get; set; } = default!;

    }
    /// <summary>
    /// 危险品信息
    /// </summary>
    
    public  class DangerousGoods
    {
        /// <summary>
        /// 请输入有效的 DHL Express 危险品内容 ID（如需运输危险品，请联系 DHL Express IT 代表获取相关内容 ID 代码）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("contentId")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(5, MinimumLength = 1)]
        public string ContentId { get; set; } = default!;

        /// <summary>
        /// 如运输干冰，请输入干冰总净重
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("dryIceTotalNetWeight")]
        public double DryIceTotalNetWeight { get; set; } = default!;

        /// <summary>
        /// customDescription 节点包含自定义危险品声明，用于准确申报内容。customDescription 节点值将显示在运输标签和运单文件中，替换基于 contentId 节点构建的默认 IATA 危险品声明。
        /// 多个 dangerousGoods 节点的 customDescription 节点将用逗号分隔，合并最大限制为 200 个字符。
        /// 
        /// 建议为每个 dangerousGoods 使用 customDescription，以充分利用运输标签和运单文件中的自定义说明打印。
        /// 
        /// 注意：如使用 customDescription，确保所有 dangerousGoods 段均包含 customDescription 字段值。若有 dangerousGoods 未提供 customDescription 字段值，则不会在运输标签和运单文件中打印。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customDescription")]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string CustomDescription { get; set; } = default!;

        /// <summary>
        /// 请输入 UN 编码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unCodes")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(10)]
        public System.Collections.Generic.ICollection<string> UnCodes { get; set; } = default!;

    }
    /// <summary>
    /// 客户条码信息
    /// </summary>
    
    public  class CustomerBarcode
    {
        /// <summary>
        /// 请输入条码内容
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(25, MinimumLength = 1)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 请输入客户条码下方文本
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("textBelowBarcode")]
        public string TextBelowBarcode { get; set; } = default!;

        /// <summary>
        /// 请输入有效的符号代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("symbologyCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public CustomerBarcodesSymbologyCode SymbologyCode { get; set; } = default!;

    }
    /// <summary>
    /// 客户 Logo 信息
    /// </summary>
    
    public  class CustomerLogo
    {
        /// <summary>
        /// 指定图片文件格式
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fileFormat")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public CustomerLogoFileFormat FileFormat { get; set; } = default!;

        /// <summary>
        /// 提供 base64 编码的 logo 图片
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(1048576)]
        public string Content { get; set; } = default!;

    }
    /// <summary>
    /// 图片选项设置
    /// </summary>
    
    public  class ImageOptions : object
    {
        /// <summary>
        /// 请输入要设置属性的文档类型
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ImageOptionTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// 请输入 DHL Express 文档模板名称。
        /// 示例运输标签模板：
        /// ECOM26_84_A4_001 
        /// ECOM26_84_001 - 默认
        /// ECOM_TC_A4
        /// ECOM26_A6_002
        /// ECOM26_84CI_001
        /// ECOM26_84CI_002 - 支持单一客户条码
        /// ECOM26_84CI_003 - 如使用客户条码请使用
        /// ECOM_A4_RU_002
        /// ECOM26_84_LBBX_001 - 支持散装 BBX 货件
        /// ECOM26_64_LBBX_001 - 支持散装 BBX 货件
        /// 示例运单模板
        /// ARCH_8X4_A4_002
        /// ARCH_8X4 - 默认
        /// ARCH_6X4
        /// ARCH_A4_RU_002
        /// 
        /// 示例商业发票模板：
        /// COMMERCIAL_INVOICE_04 - 可打印发货人、收件人、买方和进口商地址，纵向，仅用于准备散装 BBX 货件。
        /// COMMERCIAL_INVOICE_P_10 -（默认）可打印发货人、收件人及最多两个附加地址，纵向。如客户提供超过四个地址角色，仅按优先顺序打印四个：发货人、收件人、卖方、进口商、出口商、买方。 
        /// COMMERCIAL_INVOICE_L_10 - 可打印发货人、收件人、买方、进口商和出口商地址，横向。
        /// RET_COM_INVOICE_A4_01 - 可打印发货人、收件人和进口方地址，横向。仅用于“退货”货件。
        /// 
        /// 示例发货回执模板
        /// SHIP_RECPT_A4_RU_002
        /// SHIPRCPT_EN_001 - 默认 
        /// 
        /// 示例二维码模板
        /// QR_1_00_LL_PNG_001 - 默认
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("templateName")]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public string TemplateName { get; set; } = default!;

        /// <summary>
        /// 用于运单、发票、发货回执和二维码。如果为 true，则提供文档，否则不提供
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("isRequested")]
        public bool IsRequested { get; set; } = default!;

        /// <summary>
        /// 用于运单。如果为 true，则运单上不打印账户信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("hideAccountNumber")]
        public bool HideAccountNumber { get; set; } = default!;

        /// <summary>
        /// 可要求最多 2 份运单副本
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("numberOfCopies")]
        [System.ComponentModel.DataAnnotations.Range(1D, 2D)]
        public double NumberOfCopies { get; set; } = default!;

        /// <summary>
        /// 请告知需要哪种类型的海关文件
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("invoiceType")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ImageOptionInvoiceType InvoiceType { get; set; } = default!;

        /// <summary>
        /// 请输入发票或发货回执的 ISO 3 位语言代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        public string LanguageCode { get; set; } = default!;

        /// <summary>
        /// 请输入发票或发货回执的 ISO 2 位国家代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("languageCountryCode")]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string LanguageCountryCode { get; set; } = default!;

        /// <summary>
        /// 请输入发货回执的 ISO 4 位语言脚本代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("languageScriptCode")]
        [System.ComponentModel.DataAnnotations.StringLength(4, MinimumLength = 4)]
        public string LanguageScriptCode { get; set; } = default!;

        /// <summary>
        /// 提供二维码输出格式
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("encodingFormat")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ImageOptionEncodingFormat EncodingFormat { get; set; } = default!;

        /// <summary>
        /// 在运输标签或运单上打印 DHL Logo
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("renderDHLLogo")]
        public bool RenderDHLLogo { get; set; } = default!;

        /// <summary>
        /// 将运输标签和运单打印到 A4 边距 PDF。<BR>                注意：仅适用于 PDF 格式。<BR>                false：使用默认边距（默认行为） <BR>                true：打印到 A4 边距 PDF
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fitLabelsToA4")]
        public bool FitLabelsToA4 { get; set; } = default!;

        /// <summary>
        /// 可在特定标签上打印的附加客户标签自由文本。仅适用于 ECOM26_A6_002、ECOM_TC_A4 和 ECOM26_84CI_001。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labelFreeText")]
        [System.ComponentModel.DataAnnotations.StringLength(150)]
        public string LabelFreeText { get; set; } = default!;

        /// <summary>
        /// 可在特定标签上打印的附加客户标签文本。仅适用于 ECOM26_84_A4_001、ECOM_TC_A4 和 ECOM26_84CI_001
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labelCustomerDataText")]
        [System.ComponentModel.DataAnnotations.StringLength(250, MinimumLength = 1)]
        public string LabelCustomerDataText { get; set; } = default!;

        /// <summary>
        /// 可在特定发货回执模板上打印的声明文本
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shipmentReceiptCustomerDataText")]
        [System.ComponentModel.DataAnnotations.StringLength(700, MinimumLength = 1)]
        public string ShipmentReceiptCustomerDataText { get; set; } = default!;

    }
    /// <summary>
    /// /shipments 的包裹定义
    /// </summary>
    
    public  class SupermodelIoLogisticsExpressPackage
    {
        /// <summary>
        /// 如需使用 DHL 专用包裹，请联系 DHL Express 代表，否则忽略此元素。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 2)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressPackageTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// 包裹重量
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("weight")]
        [System.ComponentModel.DataAnnotations.Range(0.001D, 999999999999D)]
        public double Weight { get; set; } = default!;

        /// <summary>
        /// 包裹尺寸
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [System.ComponentModel.DataAnnotations.Required]
        public Dimensions Dimensions { get; set; } = new Dimensions();

        /// <summary>
        /// 可为每个包裹声明客户参考信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerReferences")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(99)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressPackageReference> CustomerReferences { get; set; } = default!;

        /// <summary>
        /// 标识符部分位于包裹级别，可选提供 DHL 运单号。需由 DHL IT 联系人启用。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public System.Collections.Generic.ICollection<SupermodelIoLogisticsExpressIdentifier> Identifiers { get; set; } = default!;

        /// <summary>
        /// 请输入每个包裹的内容描述
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.StringLength(70, MinimumLength = 1)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 可在 DHL 运输标签上定义最多两个自定义条码。需设置 outputImageProperties/imageOptions/templateName 为 ECOM26_84CI_003，typeCode=label
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labelBarcodes")]
        [System.ComponentModel.DataAnnotations.MaxLength(2)]
        public System.Collections.Generic.ICollection<LabelBarcodes> LabelBarcodes { get; set; } = default!;

        /// <summary>
        /// 可在 DHL 运输标签上定义最多两个自定义文本。需设置 outputImageProperties/imageOptions/templateName 为 ECOM26_84CI_003，typeCode=label
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labelText")]
        [System.ComponentModel.DataAnnotations.MaxLength(6)]
        public System.Collections.Generic.ICollection<LabelText> LabelText { get; set; } = default!;

        /// <summary>
        /// 请输入附加客户描述
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labelDescription")]
        [System.ComponentModel.DataAnnotations.StringLength(80, MinimumLength = 1)]
        public string LabelDescription { get; set; } = default!;

        /// <summary>
        /// 请输入包裹参考号。如至少一个包裹提供了参考号，则所有包裹都必须提供。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("referenceNumber")]
        [System.ComponentModel.DataAnnotations.Range(1D, 999D)]
        public double ReferenceNumber { get; set; } = default!;

    }
    /// <summary>
    /// 出口申报信息
    /// </summary>
    
    public  class ExportDeclaration
    {
        /// <summary>
        /// 请输入每个出口明细行项目
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("lineItems")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(999)]
        public System.Collections.Generic.ICollection<LineItem> LineItems { get; set; } = new System.Collections.ObjectModel.Collection<LineItem>();

        /// <summary>
        /// 提供发票相关信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("invoice")]
        public Invoice Invoice { get; set; } = default!;

        /// <summary>
        /// 请输入最多三条备注。
        /// 如使用 COMMERCIAL_INVOICE_04 模板，发票仅能打印第一条备注，建议最大长度 20 字符。
        /// 如使用 COMMERCIAL_INVOICE_L_10 或 COMMERCIAL_INVOICE_P_10 模板，发票可打印全部三条备注，建议最大长度 45 字符。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("remarks")]
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public System.Collections.Generic.ICollection<Remark> Remarks { get; set; } = default!;

        /// <summary>
        /// 请输入要显示在发票上的附加费用
        /// admin 管理费
        /// delivery 送货费
        /// documentation 文件费
        /// expedite 加急费
        /// export 出口费
        /// freight 运费
        /// fuel_surcharge 燃油附加费
        /// logistic 物流费
        /// other 其他费用
        /// packaging 包装费
        /// pickup 揽件费
        /// handling 操作费
        /// vat 增值税
        /// insurance 保险费
        /// reverse_charge 反向收费
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("additionalCharges")]
        [System.ComponentModel.DataAnnotations.MaxLength(5)]
        public System.Collections.Generic.ICollection<AdditionalCharge> AdditionalCharges { get; set; } = default!;

        /// <summary>
        /// 提供目的港信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("destinationPortName")]
        public string DestinationPortName { get; set; } = default!;

        /// <summary>
        /// 按适用交货条款要求，填写发货、装运或目的港名称。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("placeOfIncoterm")]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 1)]
        public string PlaceOfIncoterm { get; set; } = default!;

        /// <summary>
        /// 提供付款方增值税号
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("payerVATNumber")]
        public string PayerVATNumber { get; set; } = default!;

        /// <summary>
        /// 请输入收件人参考信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("recipientReference")]
        public string RecipientReference { get; set; } = default!;

        /// <summary>
        /// 出口商相关信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("exporter")]
        public Exporter Exporter { get; set; } = default!;

        /// <summary>
        /// 请输入包裹标记
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("packageMarks")]
        public string PackageMarks { get; set; } = default!;

        /// <summary>
        /// 最多可提供三条声明说明
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("declarationNotes")]
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public System.Collections.Generic.ICollection<DeclarationNote> DeclarationNotes { get; set; } = default!;

        /// <summary>
        /// 请输入出口参考号
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("exportReference")]
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string ExportReference { get; set; } = default!;

        /// <summary>
        /// 请输入出口原因
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("exportReason")]
        [System.ComponentModel.DataAnnotations.StringLength(30, MinimumLength = 1)]
        public string ExportReason { get; set; } = default!;

        /// <summary>
        /// 提供出口原因类型
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("exportReasonType")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ExportDeclarationExportReasonType ExportReasonType { get; set; } = default!;

        /// <summary>
        /// 提供出口和进口许可证信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("licenses")]
        [System.ComponentModel.DataAnnotations.MaxLength(2)]
        public System.Collections.Generic.ICollection<License> Licenses { get; set; } = default!;

        /// <summary>
        /// 提供货件为个人（礼品）或商业（销售）原因
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shipmentType")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ExportDeclarationShipmentType ShipmentType { get; set; } = default!;

        /// <summary>
        /// 提供发票级别的海关文件
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customsDocuments")]
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        public System.Collections.Generic.ICollection<CustomsDocument> CustomsDocuments { get; set; } = default!;

    }
    /// <summary>
    /// 包裹尺寸信息
    /// </summary>
    
    public  class Dimensions
    {
        /// <summary>
        /// 包裹长度
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("length")]
        [System.ComponentModel.DataAnnotations.Range(0.001D, 9999999D)]
        public double Length { get; set; } = default!;

        /// <summary>
        /// 包裹宽度
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("width")]
        [System.ComponentModel.DataAnnotations.Range(0.001D, 9999999D)]
        public double Width { get; set; } = default!;

        /// <summary>
        /// 包裹高度
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("height")]
        [System.ComponentModel.DataAnnotations.Range(0.001D, 9999999D)]
        public double Height { get; set; } = default!;

    }
    /// <summary>
    /// 包裹参考信息模型描述
    /// </summary>
    
    public  class SupermodelIoLogisticsExpressPackageReference
    {
        /// <summary>
        /// 提供参考信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// 提供参考类型
        /// AAO 收件人货件参考号
        /// CU 发货人参考号 - 默认
        /// FF 货运代理参考号
        /// FN 运费单号（出厂发票号）
        /// IBC 入站中心参考号
        /// LLR 装载清单参考（10 位货件 ID）
        /// OBC 出站中心参考号（原产国货件标识）
        /// PRN 揽件请求号（预订参考号）
        /// ACP 本地付款方账号
        /// ACS 本地发货人账号
        /// ACR 本地收件人账号
        /// CDN 海关申报号
        /// STD 欧陆 15 位货件 ID
        /// CO 买方订单号
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 2)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public SupermodelIoLogisticsExpressPackageReferenceTypeCode TypeCode { get; set; } = SupermodelIoLogisticsExpressPackageReferenceTypeCode.CU;

    }
    /// <summary>
    /// 标签条码信息
    /// </summary>
    
    public  class LabelBarcodes
    {
        /// <summary>
        /// 自定义条码位置
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("position")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public LabelBarcodePosition Position { get; set; } = default!;

        /// <summary>
        /// 请输入有效的符号代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("symbologyCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public LabelBarcodeSymbologyCode SymbologyCode { get; set; } = default!;

        /// <summary>
        /// 请输入条码内容
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 请输入客户条码下方文本
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("textBelowBarcode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string TextBelowBarcode { get; set; } = default!;

    }
    /// <summary>
    /// 标签文本信息
    /// </summary>
    
    public  class LabelText
    {
        /// <summary>
        /// 自定义文本位置
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("position")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public LabelTextPosition Position { get; set; } = default!;

        /// <summary>
        /// 请输入要打印在标签上的标题
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("caption")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string Caption { get; set; } = default!;

        /// <summary>
        /// 请输入要打印在标签标题下的值
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string Value { get; set; } = default!;

    }
    /// <summary>
    /// 明细行项目
    /// </summary>
    
    public  class LineItem
    {
        /// <summary>
        /// 提供明细行项目编号
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("number")]
        [System.ComponentModel.DataAnnotations.Range(1, 999)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 提供明细行项目描述
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 1)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 提供单价或物品价格
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("price")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double Price { get; set; } = default!;

        /// <summary>
        /// 输入该明细行项目的数量信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [System.ComponentModel.DataAnnotations.Required]
        public Quantity Quantity { get; set; } = new Quantity();

        /// <summary>
        /// 提供该明细行项目的商品编码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("commodityCodes")]
        [System.ComponentModel.DataAnnotations.MaxLength(2)]
        public System.Collections.Generic.ICollection<CommodityCode> CommodityCodes { get; set; } = default!;

        /// <summary>
        /// 提供出口原因类型
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("exportReasonType")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public LineItemExportReasonType ExportReasonType { get; set; } = default!;

        /// <summary>
        /// 输入制造商国家的两位 ISO 代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("manufacturerCountry")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string ManufacturerCountry { get; set; } = default!;

        /// <summary>
        /// 输入明细行项目的总重量（毛重或净重），不会自动计算数量乘以重量
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("weight")]
        [System.ComponentModel.DataAnnotations.Required]
        public Weight Weight { get; set; } = new Weight();

        /// <summary>
        /// 提供该明细行项目是否已缴税
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("isTaxesPaid")]
        public bool IsTaxesPaid { get; set; } = default!;

        /// <summary>
        /// 提供附加信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("additionalInformation")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(8)]
        public System.Collections.Generic.ICollection<string> AdditionalInformation { get; set; } = default!;

        /// <summary>
        /// 提供明细行项目的客户参考信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerReferences")]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public System.Collections.Generic.ICollection<CustomerReference> CustomerReferences { get; set; } = default!;

        /// <summary>
        /// 提供海关文件详情
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customsDocuments")]
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        public System.Collections.Generic.ICollection<CustomsDocument> CustomsDocuments { get; set; } = default!;

        /// <summary>
        /// 提供明细行项目的预计算总价值（单价 x 数量）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("preCalculatedLineItemTotalValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double PreCalculatedLineItemTotalValue { get; set; } = default!;

    }
    /// <summary>
    /// 发票信息
    /// </summary>
    
    public  class Invoice
    {
        /// <summary>
        /// 请输入商业发票号
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("number")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Number { get; set; } = default!;

        /// <summary>
        /// 请输入发票开具的准确日期，该日期用于海关清关时的汇率计算（如适用）。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset Date { get; set; } = default!;

        /// <summary>
        /// 请输入签署发票的人
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("signatureName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string SignatureName { get; set; } = default!;

        /// <summary>
        /// 提供签署发票人的职位
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("signatureTitle")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string SignatureTitle { get; set; } = default!;

        /// <summary>
        /// 提供签名图片
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("signatureImage")]
        [System.ComponentModel.DataAnnotations.StringLength(1048576)]
        public string SignatureImage { get; set; } = default!;

        /// <summary>
        /// 海关发票打印用的货件说明，仅 COMMERCIAL_INVOICE_04 模板打印。建议最大长度 120 字符。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.ICollection<string> Instructions { get; set; } = default!;

        /// <summary>
        /// 打印在海关发票上的客户数据文本，仅 COMMERCIAL_INVOICE_04 模板打印。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerDataTextEntries")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(6)]
        public System.Collections.Generic.ICollection<string> CustomerDataTextEntries { get; set; } = default!;

        /// <summary>
        /// 提供总净重
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("totalNetWeight")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999D)]
        public double TotalNetWeight { get; set; } = default!;

        /// <summary>
        /// 提供总毛重
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("totalGrossWeight")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999D)]
        public double TotalGrossWeight { get; set; } = default!;

        /// <summary>
        /// 提供发票级别的客户参考信息。建议提供少于 20 个类型为 'MRN' 的客户参考。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerReferences")]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public System.Collections.Generic.ICollection<CustomerReference> CustomerReferences { get; set; } = default!;

        /// <summary>
        /// 提供付款条款
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("termsOfPayment")]
        public string TermsOfPayment { get; set; } = default!;

        /// <summary>
        /// indicativeCustomsValues 包含 importCustomsDutyValue 和 importTaxesValue 子节点。
        /// 
        /// 仅适用于 COMMERCIAL_INVOICE_P_10 和 COMMERCIAL_INVOICE_L_10 模板。
        /// 如有该子节点，仅能显示三项 OtherCharges。
        /// 
        /// 但 ShipmentRequest 仍可包含最多五项 additionalCharges。
        /// 超过三项时，第三项及以后合并为“Other Charges”。
        /// 
        /// 注意：如前三项中有类型为 'other' 的 additionalCharges，且超过三项，则类型为 'other' 的 additionalCharges 也会合并显示为“Other Charges”。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("indicativeCustomsValues")]
        public IndicativeCustomsValues IndicativeCustomsValues { get; set; } = default!;

        /// <summary>
        /// 提供预计算的总价值，包括商品总值和发票总值。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("preCalculatedTotalValues")]
        public PreCalculatedTotalValues PreCalculatedTotalValues { get; set; } = default!;

    }
    /// <summary>
    /// 备注信息
    /// </summary>
    
    public  class Remark
    {
        /// <summary>
        /// 请输入备注文本
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Value { get; set; } = default!;

    }
    /// <summary>
    /// 附加费用信息
    /// </summary>
    
    public  class AdditionalCharge
    {
        /// <summary>
        /// 提供费用金额
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Range(0.001D, 999999999999999D)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// 请输入费用说明
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string Caption { get; set; } = default!;

        /// <summary>
        /// 请输入费用类型
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public AdditionalChargeTypeCode TypeCode { get; set; } = default!;

    }
    /// <summary>
    /// 声明说明信息
    /// </summary>
    
    public  class DeclarationNote
    {
        /// <summary>
        /// 请输入声明说明内容
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(700)]
        public string Value { get; set; } = default!;

    }
    /// <summary>
    /// 出口商信息
    /// </summary>
    
    public  class Exporter
    {
        /// <summary>
        /// 提供出口商 ID
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 提供出口商代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = default!;

    }
    /// <summary>
    /// 许可证信息
    /// </summary>
    
    public  class License
    {
        /// <summary>
        /// 提供许可证类型
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public LicenseTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// 提供许可证编号
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(16)]
        public string Value { get; set; } = default!;

    }
    /// <summary>
    /// 海关文件信息
    /// </summary>
    
    public  class CustomsDocument
    {
        /// <summary>
        /// 提供发票级别的海关文件类型代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public CustomsDocumentTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// 提供发票级别的海关文件编号
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Value { get; set; } = default!;

    }
    /// <summary>
    /// 数量信息
    /// </summary>
    
    public  class Quantity
    {
        /// <summary>
        /// 请输入明细行项目的件数
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Range(1, 1000000000)]
        public int Value { get; set; } = default!;

        /// <summary>
        /// 提供正确的计量单位
        /// 可能的值：
        /// BOX 盒
        /// 2GM 厘克
        /// M3 立方米
        /// DPR 打对
        /// DOZ 打
        /// PCS 件
        /// GM 克
        /// GRS 罗
        /// KG 千克
        /// M 米
        /// 3GM 毫克
        /// X 无单位
        /// NO 数量
        /// PRS 对
        /// CM2 平方厘米
        /// 2M2 平方英尺
        /// 3M2 平方英寸
        /// M2 平方米
        /// 4M2 平方码
        /// CM 厘米
        /// CONE 锥形
        /// CT 克拉
        /// EA 每个
        /// LBS 磅
        /// RILL 卷
        /// ROLL 卷
        /// SET 套
        /// TU 时间单位
        /// KM 千米
        /// IN 英寸
        /// FT 英尺
        /// YD 码
        /// MI 英里
        /// LTR 升
        /// MMQ 立方毫米
        /// CM3 立方厘米
        /// DMQ 立方分米
        /// MLT 毫升
        /// CLT 厘升
        /// DLT 分升
        /// INQ 立方英寸
        /// FT3 立方英尺
        /// YD3 立方码
        /// GLI 英制加仑
        /// GLL 美制加仑
        /// PT 美制品脱
        /// PTI 英制品脱
        /// QTI 英制夸脱
        /// PTL 美制液体品脱
        /// QTL 美制液体夸脱
        /// PTD 美制干品脱
        /// OZI 英制液体盎司
        /// J57 英制石油桶
        /// NM3 标准立方米
        /// SM3 标准立方米
        /// TNE 公吨
        /// LB 磅
        /// ONZ 盎司
        /// CEL 摄氏度                              
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurement")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(8)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public UnitOfMeasurementTypeCode UnitOfMeasurement { get; set; } = default!;

    }
    /// <summary>
    /// 商品编码信息
    /// </summary>
    
    public  class CommodityCode
    {
        /// <summary>
        /// 提供商品编码类型
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public CommodityCodeTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// 提供商品编码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(18, MinimumLength = 2)]
        public string Value { get; set; } = default!;

    }
    /// <summary>
    /// 重量信息
    /// </summary>
    
    public  class Weight
    {
        /// <summary>
        /// 请输入净重
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("netValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999D)]
        public double NetValue { get; set; } = default!;

        /// <summary>
        /// 请输入毛重
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("grossValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999D)]
        public double GrossValue { get; set; } = default!;

    }
    /// <summary>
    /// 客户参考信息
    /// </summary>
    
    public  class CustomerReference
    {
        /// <summary>
        /// 提供明细行项目参考类型代码。有效枚举值请参考 YAML 参考数据指南 PDF。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public CustomerReferenceTypeCode TypeCode { get; set; } = default!;

        /// <summary>
        /// 提供明细行项目参考信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string Value { get; set; } = default!;
    }

    
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
    /// <summary>
    /// 预估海关价值信息
    /// </summary>
    
    public  class IndicativeCustomsValues
    {
        /// <summary>
        /// 提供货件的预计算进口关税金额
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("importCustomsDutyValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double ImportCustomsDutyValue { get; set; } = default!;

        /// <summary>
        /// 提供货件的预计算进口税（增值税/商品服务税）金额
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("importTaxesValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double ImportTaxesValue { get; set; } = default!;

        /// <summary>
        /// 提供所有明细行项目加附加费用加预估海关价值的总和
        /// </summary>
        /// 
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
    /// <summary>
    /// 预计算总价值信息
    /// </summary>
    
    public  class PreCalculatedTotalValues
    {
        /// <summary>
        /// 提供所有明细行项目的预计算总价值。preCalculatedTotalGoodsValue 表示出口申报中所有明细行项目小计的预计算总和。该字段值将显示在商业发票输出和清单消息中。
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("preCalculatedTotalGoodsValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double PreCalculatedTotalGoodsValue { get; set; } = default!;

        /// <summary>
        /// 提供所有明细行项目加附加费用的总价值。preCalculatedTotalInvoiceValue 表示所有明细行项目小计金额加所有其他费用金额的预计算总和。该字段值将用于商业发票输出、运单和清单消息。
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("preCalculatedTotalInvoiceValue")]
        [System.ComponentModel.DataAnnotations.Range(0D, 999999999999999D)]
        public double PreCalculatedTotalInvoiceValue { get; set; } = default!;

    }
}