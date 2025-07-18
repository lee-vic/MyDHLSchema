﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyDHLSchema
{
    /// <summary>
    /// 业务方类型代码
    /// </summary>
    [System.Flags]
    public enum PartyDetailsTypeCode
    {
        /// <summary>企业</summary>
        [Display(Name = "企业")]
        [System.Runtime.Serialization.EnumMember(Value = @"business")]
        Business = 1,
        /// <summary>直客</summary>
        [Display(Name = "直客")]
        [System.Runtime.Serialization.EnumMember(Value = @"direct_consumer")]
        Direct_consumer = 2,
        /// <summary>政府</summary>
        [Display(Name = "政府")]
        [System.Runtime.Serialization.EnumMember(Value = @"government")]
        Government = 4,
        /// <summary>其他</summary>
        [Display(Name = "其他")]
        [System.Runtime.Serialization.EnumMember(Value = @"other")]
        Other = 8,
        /// <summary>私人</summary>
        [Display(Name = "私人")]
        [System.Runtime.Serialization.EnumMember(Value = @"private")]
        Private = 16,
        /// <summary>经销商</summary>
        [Display(Name = "经销商")]
        [System.Runtime.Serialization.EnumMember(Value = @"reseller")]
        Reseller = 32,
    }

    /// <summary>
    /// DHL账号类型代码
    /// </summary>
    [System.Flags]
    public enum SupermodelIoLogisticsExpressAccountTypeCode
    {
        /// <summary>发货方账号</summary>
        [Display(Name = "发货方账号")]
        [System.Runtime.Serialization.EnumMember(Value = @"shipper")]
        Shipper = 1,
        /// <summary>付款方账号</summary>
        [Display(Name = "付款方账号")]
        [System.Runtime.Serialization.EnumMember(Value = @"payer")]
        Payer = 2,
        /// <summary>关税税费账号</summary>
        [Display(Name = "关税税费账号")]
        [System.Runtime.Serialization.EnumMember(Value = @"duties-taxes")]
        DutiesTaxes = 4,
    }

    /// <summary>
    /// 输出图片文件格式
    /// </summary>
    [System.Flags]
    public enum OutputImagePropertiesEncodingFormat
    {
        /// <summary>PDF格式</summary>
        [Display(Name = "PDF格式")]
        [System.Runtime.Serialization.EnumMember(Value = @"pdf")]
        Pdf = 1,
        /// <summary>ZPL热敏格式</summary>
        [Display(Name = "ZPL热敏格式")]
        [System.Runtime.Serialization.EnumMember(Value = @"zpl")]
        Zpl = 2,
        /// <summary>LP2热敏格式</summary>
        [Display(Name = "LP2热敏格式")]
        [System.Runtime.Serialization.EnumMember(Value = @"lp2")]
        Lp2 = 4,
        /// <summary>EPL热敏格式</summary>
        [Display(Name = "EPL热敏格式")]
        [System.Runtime.Serialization.EnumMember(Value = @"epl")]
        Epl = 8,
    }

    /// <summary>
    /// 客户参考类型代码（运单级别）
    /// </summary>
    [System.Flags]
    public enum SupermodelIoLogisticsExpressReferenceTypeCode
    {
        /// <summary>收件人货件参考号</summary>
        [Display(Name = "收件人货件参考号")]
        [System.Runtime.Serialization.EnumMember(Value = @"AAO")]
        AAO = 1,
        /// <summary>发货人参考号</summary>
        [Display(Name = "发货人参考号")]
        [System.Runtime.Serialization.EnumMember(Value = @"CU")]
        CU = 2,
        /// <summary>货运代理参考号</summary>
        [Display(Name = "货运代理参考号")]
        [System.Runtime.Serialization.EnumMember(Value = @"FF")]
        FF = 4,
        /// <summary>运费单号（出厂发票号）</summary>
        [Display(Name = "运费单号（出厂发票号）")]
        [System.Runtime.Serialization.EnumMember(Value = @"FN")]
        FN = 8,
        /// <summary>入站中心参考号</summary>
        [Display(Name = "入站中心参考号")]
        [System.Runtime.Serialization.EnumMember(Value = @"IBC")]
        IBC = 16,
        /// <summary>装载清单参考（10位货件ID）</summary>
        [Display(Name = "装载清单参考（10位货件ID）")]
        [System.Runtime.Serialization.EnumMember(Value = @"LLR")]
        LLR = 32,
        /// <summary>出站中心参考号（原产国货件标识）</summary>
        [Display(Name = "出站中心参考号（原产国货件标识）")]
        [System.Runtime.Serialization.EnumMember(Value = @"OBC")]
        OBC = 64,
        /// <summary>揽件请求号（预订参考号）</summary>
        [Display(Name = "揽件请求号（预订参考号）")]
        [System.Runtime.Serialization.EnumMember(Value = @"PRN")]
        PRN = 128,
        /// <summary>本地付款方账号</summary>
        [Display(Name = "本地付款方账号")]
        [System.Runtime.Serialization.EnumMember(Value = @"ACP")]
        ACP = 256,
        /// <summary>本地发货人账号</summary>
        [Display(Name = "本地发货人账号")]
        [System.Runtime.Serialization.EnumMember(Value = @"ACS")]
        ACS = 512,
        /// <summary>本地收件人账号</summary>
        [Display(Name = "本地收件人账号")]
        [System.Runtime.Serialization.EnumMember(Value = @"ACR")]
        ACR = 1024,
        /// <summary>海关申报号</summary>
        [Display(Name = "海关申报号")]
        [System.Runtime.Serialization.EnumMember(Value = @"CDN")]
        CDN = 2048,
        /// <summary>欧陆15位货件ID</summary>
        [Display(Name = "欧陆15位货件ID")]
        [System.Runtime.Serialization.EnumMember(Value = @"STD")]
        STD = 4096,
        /// <summary>买方订单号</summary>
        [Display(Name = "买方订单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"CO")]
        CO = 8192,
    }

    /// <summary>
    /// 标识符类型代码
    /// </summary>
    [System.Flags]
    public enum SupermodelIoLogisticsExpressIdentifierTypeCode
    {
        /// <summary>母运单号</summary>
        [Display(Name = "母运单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"parentId")]
        ParentId = 1,
        /// <summary>运单号</summary>
        [Display(Name = "运单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"shipmentId")]
        ShipmentId = 2,
        /// <summary>包裹ID</summary>
        [Display(Name = "包裹ID")]
        [System.Runtime.Serialization.EnumMember(Value = @"pieceId")]
        PieceId = 4,
    }

    /// <summary>
    /// 国际贸易术语解释通则
    /// </summary>
    [System.Flags]
    public enum IncotermTypeCode
    {
        /// <summary>工厂交货</summary>
        [Display(Name = "工厂交货")]
        [System.Runtime.Serialization.EnumMember(Value = @"EXW")]
        EXW = 1,
        /// <summary>自由承运人交货</summary>
        [Display(Name = "自由承运人交货")]
        [System.Runtime.Serialization.EnumMember(Value = @"FCA")]
        FCA = 2,
        /// <summary>运费付至</summary>
        [Display(Name = "运费付至")]
        [System.Runtime.Serialization.EnumMember(Value = @"CPT")]
        CPT = 4,
        /// <summary>运费和保险费付至</summary>
        [Display(Name = "运费和保险费付至")]
        [System.Runtime.Serialization.EnumMember(Value = @"CIP")]
        CIP = 8,
        /// <summary>卸货后交货至指定地点</summary>
        [Display(Name = "卸货后交货至指定地点")]
        [System.Runtime.Serialization.EnumMember(Value = @"DPU")]
        DPU = 16,
        /// <summary>交货至指定地点</summary>
        [Display(Name = "交货至指定地点")]
        [System.Runtime.Serialization.EnumMember(Value = @"DAP")]
        DAP = 32,
        /// <summary>完税后交货</summary>
        [Display(Name = "完税后交货")]
        [System.Runtime.Serialization.EnumMember(Value = @"DDP")]
        DDP = 64,
        /// <summary>装船港船边交货</summary>
        [Display(Name = "装船港船边交货")]
        [System.Runtime.Serialization.EnumMember(Value = @"FAS")]
        FAS = 128,
        /// <summary>装船港船上交货</summary>
        [Display(Name = "装船港船上交货")]
        [System.Runtime.Serialization.EnumMember(Value = @"FOB")]
        FOB = 256,
        /// <summary>成本加运费</summary>
        [Display(Name = "成本加运费")]
        [System.Runtime.Serialization.EnumMember(Value = @"CFR")]
        CFR = 512,
        /// <summary>成本、保险加运费</summary>
        [Display(Name = "成本、保险加运费")]
        [System.Runtime.Serialization.EnumMember(Value = @"CIF")]
        CIF = 1024,
        /// <summary>边境交货</summary>
        [Display(Name = "边境交货")]
        [System.Runtime.Serialization.EnumMember(Value = @"DAF")]
        DAF = 2048,
        /// <summary>终端交货</summary>
        [Display(Name = "终端交货")]
        [System.Runtime.Serialization.EnumMember(Value = @"DAT")]
        DAT = 4096,
        /// <summary>未完税交货</summary>
        [Display(Name = "未完税交货")]
        [System.Runtime.Serialization.EnumMember(Value = @"DDU")]
        DDU = 8192,
        /// <summary>码头交货</summary>
        [Display(Name = "码头交货")]
        [System.Runtime.Serialization.EnumMember(Value = @"DEQ")]
        DEQ = 16384,
        /// <summary>装船交货</summary>
        [Display(Name = "装船交货")]
        [System.Runtime.Serialization.EnumMember(Value = @"DES")]
        DES = 32768,
    }

    /// <summary>
    /// 计量单位类型代码
    /// </summary>
    [System.Flags]
    public enum UnitOfMeasurementTypeCode
    {
        /// <summary>公制</summary>
        [Display(Name = "公制")]
        [System.Runtime.Serialization.EnumMember(Value = @"metric")]
        Metric = 1,
        /// <summary>英制</summary>
        [Display(Name = "英制")]
        [System.Runtime.Serialization.EnumMember(Value = @"imperial")]
        Imperial = 2,
    }

    /// <summary>
    /// 文件图像类型代码
    /// </summary>
    [System.Flags]
    public enum DocumentImageTypeCode
    {
        /// <summary>发票</summary>
        [Display(Name = "发票")]
        [System.Runtime.Serialization.EnumMember(Value = @"INV")]
        INV = 1,
        /// <summary>Proforma</summary>
        [Display(Name = "Proforma")]
        [System.Runtime.Serialization.EnumMember(Value = @"PNV")]
        PNV = 2,
        /// <summary>原产地证</summary>
        [Display(Name = "原产地证")]
        [System.Runtime.Serialization.EnumMember(Value = @"COO")]
        COO = 4,
        /// <summary>商业发票</summary>
        [Display(Name = "商业发票")]
        [System.Runtime.Serialization.EnumMember(Value = @"CIN")]
        CIN = 8,
        /// <summary>报关单</summary>
        [Display(Name = "报关单")]
        [System.Runtime.Serialization.EnumMember(Value = @"DCL")]
        DCL = 16,
        /// <summary>空运提单和运单文件</summary>
        [Display(Name = "空运提单和运单文件")]
        [System.Runtime.Serialization.EnumMember(Value = @"AWB")]
        AWB = 32,
        /// <summary>北美自贸协定证书</summary>
        [Display(Name = "北美自贸协定证书")]
        [System.Runtime.Serialization.EnumMember(Value = @"NAF")]
        NAF = 64,
    }

    /// <summary>
    /// 图片格式类型代码
    /// </summary>
    [System.Flags]
    public enum ImageFormatTypeCode
    {
        /// <summary>PDF</summary>
        [Display(Name = "PDF")]
        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 1,
        /// <summary>PNG</summary>
        [Display(Name = "PNG")]
        [System.Runtime.Serialization.EnumMember(Value = @"PNG")]
        PNG = 2,
        /// <summary>GIF</summary>
        [Display(Name = "GIF")]
        [System.Runtime.Serialization.EnumMember(Value = @"GIF")]
        GIF = 4,
        /// <summary>TIFF</summary>
        [Display(Name = "TIFF")]
        [System.Runtime.Serialization.EnumMember(Value = @"TIFF")]
        TIFF = 8,
        /// <summary>JPEG</summary>
        [Display(Name = "JPEG")]
        [System.Runtime.Serialization.EnumMember(Value = @"JPEG")]
        JPEG = 16,
    }

    /// <summary>
    /// 按需派送放置位置
    /// </summary>
    [System.Flags]
    public enum OnDemandDeliveryWhereToLeave
    {
        /// <summary>门卫/前台</summary>
        [Display(Name = "门卫/前台")]
        [System.Runtime.Serialization.EnumMember(Value = @"concierge")]
        Concierge = 1,
        /// <summary>邻居</summary>
        [Display(Name = "邻居")]
        [System.Runtime.Serialization.EnumMember(Value = @"neighbour")]
        Neighbour = 2,
    }

    /// <summary>
    /// 运单通知类型代码
    /// </summary>
    [System.Flags]
    public enum ShipmentNotificationTypeCode
    {
        /// <summary>邮件</summary>
        [Display(Name = "邮件")]
        [System.Runtime.Serialization.EnumMember(Value = @"email")]
        Email = 1,
    }

    /// <summary>
    /// 预付费类型代码
    /// </summary>
    [System.Flags]
    public enum PrepaidChargesTypeCode
    {
        /// <summary>运费</summary>
        [Display(Name = "运费")]
        [System.Runtime.Serialization.EnumMember(Value = @"freight")]
        Freight = 1,
    }

    /// <summary>
    /// 预付费方式
    /// </summary>
    [System.Flags]
    public enum PrepaidChargesMethod
    {
        /// <summary>现金</summary>
        [Display(Name = "现金")]
        [System.Runtime.Serialization.EnumMember(Value = @"cash")]
        Cash = 1,
    }

    /// <summary>
    /// 预计送达日期类型代码
    /// </summary>
    [System.Flags]
    public enum EstimatedDeliveryDateTypeCode
    {
        /// <summary>QDDC: 包含清关时间等，代表DHL服务承诺</summary>
        [Display(Name = "QDDC: 包含清关时间等，代表DHL服务承诺")]
        [System.Runtime.Serialization.EnumMember(Value = @"QDDC")]
        QDDC = 1,
        /// <summary>QDDF: 最快运输时间，不代表DHL服务承诺</summary>
        [Display(Name = "QDDF: 最快运输时间，不代表DHL服务承诺")]
        [System.Runtime.Serialization.EnumMember(Value = @"QDDF")]
        QDDF = 2,
    }

    /// <summary>
    /// 客户条码符号代码
    /// </summary>
    [System.Flags]
    public enum CustomerBarcodesSymbologyCode
    {
        /// <summary>Code 93</summary>
        [Display(Name = "Code 93")]
        [System.Runtime.Serialization.EnumMember(Value = @"93")]
        _93 = 1,
        /// <summary>Code 39</summary>
        [Display(Name = "Code 39")]
        [System.Runtime.Serialization.EnumMember(Value = @"39")]
        _39 = 2,
        /// <summary>Code 128</summary>
        [Display(Name = "Code 128")]
        [System.Runtime.Serialization.EnumMember(Value = @"128")]
        _128 = 4,
    }

    /// <summary>
    /// 客户Logo文件格式
    /// </summary>
    [System.Flags]
    public enum CustomerLogoFileFormat
    {
        /// <summary>PNG</summary>
        [Display(Name = "PNG")]
        [System.Runtime.Serialization.EnumMember(Value = @"PNG")]
        PNG = 1,
        /// <summary>GIF</summary>
        [Display(Name = "GIF")]
        [System.Runtime.Serialization.EnumMember(Value = @"GIF")]
        GIF = 2,
        /// <summary>JPEG</summary>
        [Display(Name = "JPEG")]
        [System.Runtime.Serialization.EnumMember(Value = @"JPEG")]
        JPEG = 4,
        /// <summary>JPG</summary>
        [Display(Name = "JPG")]
        [System.Runtime.Serialization.EnumMember(Value = @"JPG")]
        JPG = 8,
    }

    /// <summary>
    /// 附加信息类型代码
    /// </summary>
    [System.Flags]
    public enum GetAdditionalInformationTypeCode
    {
        /// <summary>取件信息</summary>
        [Display(Name = "取件信息")]
        [System.Runtime.Serialization.EnumMember(Value = @"pickupDetails")]
        PickupDetails = 1,
        /// <summary>可选运单数据</summary>
        [Display(Name = "可选运单数据")]
        [System.Runtime.Serialization.EnumMember(Value = @"optionalShipmentData")]
        OptionalShipmentData = 2,
        /// <summary>条码信息</summary>
        [Display(Name = "条码信息")]
        [System.Runtime.Serialization.EnumMember(Value = @"barcodeInformation")]
        BarcodeInformation = 4,
        /// <summary>按包裹关联标签</summary>
        [Display(Name = "按包裹关联标签")]
        [System.Runtime.Serialization.EnumMember(Value = @"linkLabelsByPieces")]
        LinkLabelsByPieces = 8,
    }

    /// <summary>
    /// 注册号类型代码
    /// </summary>
    [System.Flags]
    public enum SupermodelIoLogisticsExpressRegistrationNumbersTypeCode
    {
        /// <summary>增值税号</summary>
        [Display(Name = "增值税号")]
        [System.Runtime.Serialization.EnumMember(Value = @"VAT")]
        VAT = 1,
        /// <summary>雇主识别号</summary>
        [Display(Name = "雇主识别号")]
        [System.Runtime.Serialization.EnumMember(Value = @"EIN")]
        EIN = 2,
        /// <summary>商品与服务税</summary>
        [Display(Name = "商品与服务税")]
        [System.Runtime.Serialization.EnumMember(Value = @"GST")]
        GST = 4,
        /// <summary>社会保障号</summary>
        [Display(Name = "社会保障号")]
        [System.Runtime.Serialization.EnumMember(Value = @"SSN")]
        SSN = 8,
        /// <summary>欧盟注册与识别</summary>
        [Display(Name = "欧盟注册与识别")]
        [System.Runtime.Serialization.EnumMember(Value = @"EOR")]
        EOR = 16,
        /// <summary>数据通用编号系统</summary>
        [Display(Name = "数据通用编号系统")]
        [System.Runtime.Serialization.EnumMember(Value = @"DUN")]
        DUN = 32,
        /// <summary>联邦税号</summary>
        [Display(Name = "联邦税号")]
        [System.Runtime.Serialization.EnumMember(Value = @"FED")]
        FED = 64,
        /// <summary>州税号</summary>
        [Display(Name = "州税号")]
        [System.Runtime.Serialization.EnumMember(Value = @"STA")]
        STA = 128,
        /// <summary>巴西CNPJ/CPF联邦税号</summary>
        [Display(Name = "巴西CNPJ/CPF联邦税号")]
        [System.Runtime.Serialization.EnumMember(Value = @"CNP")]
        CNP = 256,
        /// <summary>巴西IE/RG联邦税号</summary>
        [Display(Name = "巴西IE/RG联邦税号")]
        [System.Runtime.Serialization.EnumMember(Value = @"IE")]
        IE = 512,
        /// <summary>俄罗斯银行详细信息INN</summary>
        [Display(Name = "俄罗斯银行详细信息INN")]
        [System.Runtime.Serialization.EnumMember(Value = @"INN")]
        INN = 1024,
        /// <summary>俄罗斯银行详细信息KPP</summary>
        [Display(Name = "俄罗斯银行详细信息KPP")]
        [System.Runtime.Serialization.EnumMember(Value = @"KPP")]
        KPP = 2048,
        /// <summary>俄罗斯银行详细信息OGRN</summary>
        [Display(Name = "俄罗斯银行详细信息OGRN")]
        [System.Runtime.Serialization.EnumMember(Value = @"OGR")]
        OGR = 4096,
        /// <summary>俄罗斯银行详细信息OKPO</summary>
        [Display(Name = "俄罗斯银行详细信息OKPO")]
        [System.Runtime.Serialization.EnumMember(Value = @"OKP")]
        OKP = 8192,
        /// <summary>MRN号</summary>
        [Display(Name = "MRN号")]
        [System.Runtime.Serialization.EnumMember(Value = @"MRN")]
        MRN = 16384,
        /// <summary>海外注册供应商/进口一站式商店/英国增值税（外国）注册/澳大利亚GST注册/电子商务增值税</summary>
        [Display(Name = "海外注册供应商/进口一站式商店/英国增值税（外国）注册/澳大利亚GST注册/电子商务增值税")]
        [System.Runtime.Serialization.EnumMember(Value = @"SDT")]
        SDT = 32768,
        /// <summary>自由贸易区ID</summary>
        [Display(Name = "自由贸易区ID")]
        [System.Runtime.Serialization.EnumMember(Value = @"FTZ")]
        FTZ = 65536,
        /// <summary>延期账户关税</summary>
        [Display(Name = "延期账户关税")]
        [System.Runtime.Serialization.EnumMember(Value = @"DAN")]
        DAN = 131072,
        /// <summary>延期账户税收</summary>
        [Display(Name = "延期账户税收")]
        [System.Runtime.Serialization.EnumMember(Value = @"TAN")]
        TAN = 262144,
        /// <summary>延期账户关税、税收和费用</summary>
        [Display(Name = "延期账户关税、税收和费用")]
        [System.Runtime.Serialization.EnumMember(Value = @"DTF")]
        DTF = 524288,
        /// <summary>欧盟注册出口商注册ID</summary>
        [Display(Name = "欧盟注册出口商注册ID")]
        [System.Runtime.Serialization.EnumMember(Value = @"RGP")]
        RGP = 1048576,
        /// <summary>驾驶证</summary>
        [Display(Name = "驾驶证")]
        [System.Runtime.Serialization.EnumMember(Value = @"DLI")]
        DLI = 2097152,
        /// <summary>国家身份证</summary>
        [Display(Name = "国家身份证")]
        [System.Runtime.Serialization.EnumMember(Value = @"NID")]
        NID = 4194304,
        /// <summary>护照</summary>
        [Display(Name = "护照")]
        [System.Runtime.Serialization.EnumMember(Value = @"PAS")]
        PAS = 8388608,
        /// <summary>制造商ID</summary>
        [Display(Name = "制造商ID")]
        [System.Runtime.Serialization.EnumMember(Value = @"MID")]
        MID = 16777216,
        /// <summary>英国内部市场计划</summary>
        [Display(Name = "英国内部市场计划")]
        [System.Runtime.Serialization.EnumMember(Value = @"IMS")]
        IMS = 33554432,
        /// <summary>电子发票承运人</summary>
        [Display(Name = "电子发票承运人")]
        [System.Runtime.Serialization.EnumMember(Value = @"EIC")]
        EIC = 67108864,
        /// <summary>外国税号</summary>
        [Display(Name = "外国税号")]
        [System.Runtime.Serialization.EnumMember(Value = @"FTN")]
        FTN = 134217728,
    }

    /// <summary>
    /// 图片选项类型代码
    /// </summary>
    [System.Flags]
    public enum ImageOptionTypeCode
    {
        /// <summary>运输标签</summary>
        [Display(Name = "运输标签")]
        [System.Runtime.Serialization.EnumMember(Value = @"label")]
        Label = 1,
        /// <summary>运单文件</summary>
        [Display(Name = "运单文件")]
        [System.Runtime.Serialization.EnumMember(Value = @"waybillDoc")]
        WaybillDoc = 2,
        /// <summary>发票</summary>
        [Display(Name = "发票")]
        [System.Runtime.Serialization.EnumMember(Value = @"invoice")]
        Invoice = 4,
        /// <summary>二维码</summary>
        [Display(Name = "二维码")]
        [System.Runtime.Serialization.EnumMember(Value = @"qr-code")]
        QrCode = 8,
        /// <summary>发货回执</summary>
        [Display(Name = "发货回执")]
        [System.Runtime.Serialization.EnumMember(Value = @"shipmentReceipt")]
        ShipmentReceipt = 16,
    }

    /// <summary>
    /// 发票类型
    /// </summary>
    [System.Flags]
    public enum ImageOptionInvoiceType
    {
        /// <summary>商业发票</summary>
        [Display(Name = "商业发票")]
        [System.Runtime.Serialization.EnumMember(Value = @"commercial")]
        Commercial = 1,
        /// <summary>形式发票</summary>
        [Display(Name = "形式发票")]
        [System.Runtime.Serialization.EnumMember(Value = @"proforma")]
        Proforma = 2,
        /// <summary>退货发票</summary>
        [Display(Name = "退货发票")]
        [System.Runtime.Serialization.EnumMember(Value = @"returns")]
        Returns = 4,
    }

    /// <summary>
    /// 图片选项编码格式
    /// </summary>
    [System.Flags]
    public enum ImageOptionEncodingFormat
    {
        /// <summary>PNG格式</summary>
        [Display(Name = "PNG格式")]
        [System.Runtime.Serialization.EnumMember(Value = @"png")]
        Png = 1,
    }

    /// <summary>
    /// 包裹类型代码（MyDHL API中的枚举值）
    /// </summary>
    [System.Flags]
    public enum SupermodelIoLogisticsExpressPackageTypeCode
    {
        /// <summary>3BX - 3号纸箱</summary>
        [Display(Name = "3BX - 3号纸箱")]
        [System.Runtime.Serialization.EnumMember(Value = @"3BX")]
        _3BX = 1,
        /// <summary>2BC - 2号信封</summary>
        [Display(Name = "2BC - 2号信封")]
        [System.Runtime.Serialization.EnumMember(Value = @"2BC")]
        _2BC = 2,
        /// <summary>2BP - 2号塑料袋</summary>
        [Display(Name = "2BP - 2号塑料袋")]
        [System.Runtime.Serialization.EnumMember(Value = @"2BP")]
        _2BP = 4,
        /// <summary>CE1 - CE1号信封</summary>
        [Display(Name = "CE1 - CE1号信封")]
        [System.Runtime.Serialization.EnumMember(Value = @"CE1")]
        CE1 = 8,
        /// <summary>7BX - 7号纸箱</summary>
        [Display(Name = "7BX - 7号纸箱")]
        [System.Runtime.Serialization.EnumMember(Value = @"7BX")]
        _7BX = 16,
        /// <summary>6BX - 6号纸箱</summary>
        [Display(Name = "6BX - 6号纸箱")]
        [System.Runtime.Serialization.EnumMember(Value = @"6BX")]
        _6BX = 32,
        /// <summary>4BX - 4号纸箱</summary>
        [Display(Name = "4BX - 4号纸箱")]
        [System.Runtime.Serialization.EnumMember(Value = @"4BX")]
        _4BX = 64,
        /// <summary>2BX - 2号纸箱</summary>
        [Display(Name = "2BX - 2号纸箱")]
        [System.Runtime.Serialization.EnumMember(Value = @"2BX")]
        _2BX = 128,
        /// <summary>1CE - 1号信封</summary>
        [Display(Name = "1CE - 1号信封")]
        [System.Runtime.Serialization.EnumMember(Value = @"1CE")]
        _1CE = 256,
        /// <summary>WB1 - 1号袋</summary>
        [Display(Name = "WB1 - 1号袋")]
        [System.Runtime.Serialization.EnumMember(Value = @"WB1")]
        WB1 = 512,
        /// <summary>WB3 - 3号袋</summary>
        [Display(Name = "WB3 - 3号袋")]
        [System.Runtime.Serialization.EnumMember(Value = @"WB3")]
        WB3 = 1024,
        /// <summary>XPD - XPD包装</summary>
        [Display(Name = "XPD - XPD包装")]
        [System.Runtime.Serialization.EnumMember(Value = @"XPD")]
        XPD = 2048,
        /// <summary>8BX - 8号纸箱</summary>
        [Display(Name = "8BX - 8号纸箱")]
        [System.Runtime.Serialization.EnumMember(Value = @"8BX")]
        _8BX = 4096,
        /// <summary>5BX - 5号纸箱</summary>
        [Display(Name = "5BX - 5号纸箱")]
        [System.Runtime.Serialization.EnumMember(Value = @"5BX")]
        _5BX = 8192,
        /// <summary>WB6 - 6号袋</summary>
        [Display(Name = "WB6 - 6号袋")]
        [System.Runtime.Serialization.EnumMember(Value = @"WB6")]
        WB6 = 16384,
        /// <summary>TBL - TBL包装</summary>
        [Display(Name = "TBL - TBL包装")]
        [System.Runtime.Serialization.EnumMember(Value = @"TBL")]
        TBL = 32768,
        /// <summary>TBS - TBS包装</summary>
        [Display(Name = "TBS - TBS包装")]
        [System.Runtime.Serialization.EnumMember(Value = @"TBS")]
        TBS = 65536,
        /// <summary>WB2 - 2号袋</summary>
        [Display(Name = "WB2 - 2号袋")]
        [System.Runtime.Serialization.EnumMember(Value = @"WB2")]
        WB2 = 131072,
    }

    /// <summary>
    /// 按需派送选项
    /// </summary>
    [System.Flags]
    public enum OnDemandDeliveryDeliveryOption
    {
        /// <summary>服务点</summary>
        [Display(Name = "服务点")]
        [System.Runtime.Serialization.EnumMember(Value = @"servicepoint")]
        Servicepoint = 1,
        /// <summary>邻居</summary>
        [Display(Name = "邻居")]
        [System.Runtime.Serialization.EnumMember(Value = @"neighbour")]
        Neighbour = 2,
        /// <summary>签名释放</summary>
        [Display(Name = "签名释放")]
        [System.Runtime.Serialization.EnumMember(Value = @"signatureRelease")]
        SignatureRelease = 4,
    }

    /// <summary>
    /// 出口原因类型
    /// </summary>
    [System.Flags]
    public enum ExportDeclarationExportReasonType
    {
        /// <summary>永久出口</summary>
        [Display(Name = "永久出口")]
        [System.Runtime.Serialization.EnumMember(Value = @"permanent")]
        Permanent = 1,
        /// <summary>临时出口</summary>
        [Display(Name = "临时出口")]
        [System.Runtime.Serialization.EnumMember(Value = @"temporary")]
        Temporary = 2,
        /// <summary>退货</summary>
        [Display(Name = "退货")]
        [System.Runtime.Serialization.EnumMember(Value = @"return")]
        Return = 4,
        /// <summary>展会物品返回原产地</summary>
        [Display(Name = "展会物品返回原产地")]
        [System.Runtime.Serialization.EnumMember(Value = @"used_exhibition_goods_to_origin")]
        Used_exhibition_goods_to_origin = 8,
        /// <summary>公司内部使用</summary>
        [Display(Name = "公司内部使用")]
        [System.Runtime.Serialization.EnumMember(Value = @"intercompany_use")]
        Intercompany_use = 16,
        /// <summary>商业用途或销售</summary>
        [Display(Name = "商业用途或销售")]
        [System.Runtime.Serialization.EnumMember(Value = @"commercial_purpose_or_sale")]
        Commercial_purpose_or_sale = 32,
        /// <summary>个人物品或个人用途</summary>
        [Display(Name = "个人物品或个人用途")]
        [System.Runtime.Serialization.EnumMember(Value = @"personal_belongings_or_personal_use")]
        Personal_belongings_or_personal_use = 64,
        /// <summary>样品</summary>
        [Display(Name = "样品")]
        [System.Runtime.Serialization.EnumMember(Value = @"sample")]
        Sample = 128,
        /// <summary>礼品</summary>
        [Display(Name = "礼品")]
        [System.Runtime.Serialization.EnumMember(Value = @"gift")]
        Gift = 256,
        /// <summary>退回原产地</summary>
        [Display(Name = "退回原产地")]
        [System.Runtime.Serialization.EnumMember(Value = @"return_to_origin")]
        Return_to_origin = 512,
        /// <summary>保修更换</summary>
        [Display(Name = "保修更换")]
        [System.Runtime.Serialization.EnumMember(Value = @"warranty_replacement")]
        Warranty_replacement = 1024,
        /// <summary>外交物品</summary>
        [Display(Name = "外交物品")]
        [System.Runtime.Serialization.EnumMember(Value = @"diplomatic_goods")]
        Diplomatic_goods = 2048,
        /// <summary>国防物资</summary>
        [Display(Name = "国防物资")]
        [System.Runtime.Serialization.EnumMember(Value = @"defence_material")]
        Defence_material = 4096,
    }

    /// <summary>
    /// 出口申报货件类型
    /// </summary>
    [System.Flags]
    public enum ExportDeclarationShipmentType
    {
        /// <summary>个人（礼品）</summary>
        [Display(Name = "个人（礼品）")]
        [System.Runtime.Serialization.EnumMember(Value = @"personal")]
        Personal = 1,
        /// <summary>商业（销售）</summary>
        [Display(Name = "商业（销售）")]
        [System.Runtime.Serialization.EnumMember(Value = @"commercial")]
        Commercial = 2,
    }

    /// <summary>
    /// 包裹参考类型代码
    /// </summary>
    [System.Flags]
    public enum SupermodelIoLogisticsExpressPackageReferenceTypeCode
    {
        /// <summary>收件人货件参考号</summary>
        [Display(Name = "收件人货件参考号")]
        [System.Runtime.Serialization.EnumMember(Value = @"AAO")]
        AAO = 1,
        /// <summary>发货人参考号</summary>
        [Display(Name = "发货人参考号")]
        [System.Runtime.Serialization.EnumMember(Value = @"CU")]
        CU = 2,
        /// <summary>货运代理参考号</summary>
        [Display(Name = "货运代理参考号")]
        [System.Runtime.Serialization.EnumMember(Value = @"FF")]
        FF = 4,
        /// <summary>运费单号（出厂发票号）</summary>
        [Display(Name = "运费单号（出厂发票号）")]
        [System.Runtime.Serialization.EnumMember(Value = @"FN")]
        FN = 8,
        /// <summary>入站中心参考号</summary>
        [Display(Name = "入站中心参考号")]
        [System.Runtime.Serialization.EnumMember(Value = @"IBC")]
        IBC = 16,
        /// <summary>装载清单参考（10位货件ID）</summary>
        [Display(Name = "装载清单参考（10位货件ID）")]
        [System.Runtime.Serialization.EnumMember(Value = @"LLR")]
        LLR = 32,
        /// <summary>出站中心参考号（原产国货件标识）</summary>
        [Display(Name = "出站中心参考号（原产国货件标识）")]
        [System.Runtime.Serialization.EnumMember(Value = @"OBC")]
        OBC = 64,
        /// <summary>揽件请求号（预订参考号）</summary>
        [Display(Name = "揽件请求号（预订参考号）")]
        [System.Runtime.Serialization.EnumMember(Value = @"PRN")]
        PRN = 128,
        /// <summary>本地付款方账号</summary>
        [Display(Name = "本地付款方账号")]
        [System.Runtime.Serialization.EnumMember(Value = @"ACP")]
        ACP = 256,
        /// <summary>本地发货人账号</summary>
        [Display(Name = "本地发货人账号")]
        [System.Runtime.Serialization.EnumMember(Value = @"ACS")]
        ACS = 512,
        /// <summary>本地收件人账号</summary>
        [Display(Name = "本地收件人账号")]
        [System.Runtime.Serialization.EnumMember(Value = @"ACR")]
        ACR = 1024,
        /// <summary>海关申报号</summary>
        [Display(Name = "海关申报号")]
        [System.Runtime.Serialization.EnumMember(Value = @"CDN")]
        CDN = 2048,
        /// <summary>欧陆15位货件ID</summary>
        [Display(Name = "欧陆15位货件ID")]
        [System.Runtime.Serialization.EnumMember(Value = @"STD")]
        STD = 4096,
        /// <summary>买方订单号</summary>
        [Display(Name = "买方订单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"CO")]
        CO = 8192,
    }

    /// <summary>
    /// 标签条码位置
    /// </summary>
    [System.Flags]
    public enum LabelBarcodePosition
    {
        /// <summary>左侧</summary>
        [Display(Name = "左侧")]
        [System.Runtime.Serialization.EnumMember(Value = @"left")]
        Left = 1,
        /// <summary>右侧</summary>
        [Display(Name = "右侧")]
        [System.Runtime.Serialization.EnumMember(Value = @"right")]
        Right = 2,
    }

    /// <summary>
    /// 标签条码符号代码
    /// </summary>
    [System.Flags]
    public enum LabelBarcodeSymbologyCode
    {
        /// <summary>Code 93</summary>
        [Display(Name = "Code 93")]
        [System.Runtime.Serialization.EnumMember(Value = @"93")]
        _93 = 1,
        /// <summary>Code 39</summary>
        [Display(Name = "Code 39")]
        [System.Runtime.Serialization.EnumMember(Value = @"39")]
        _39 = 2,
        /// <summary>Code 128</summary>
        [Display(Name = "Code 128")]
        [System.Runtime.Serialization.EnumMember(Value = @"128")]
        _128 = 4,
    }

    /// <summary>
    /// 附加费用类型代码
    /// </summary>
    [System.Flags]
    public enum AdditionalChargeTypeCode
    {
        /// <summary>管理费</summary>
        [Display(Name = "管理费")]
        [System.Runtime.Serialization.EnumMember(Value = @"admin")]
        Admin = 1,
        /// <summary>送货费</summary>
        [Display(Name = "送货费")]
        [System.Runtime.Serialization.EnumMember(Value = @"delivery")]
        Delivery = 2,
        /// <summary>文件费</summary>
        [Display(Name = "文件费")]
        [System.Runtime.Serialization.EnumMember(Value = @"documentation")]
        Documentation = 4,
        /// <summary>加急费</summary>
        [Display(Name = "加急费")]
        [System.Runtime.Serialization.EnumMember(Value = @"expedite")]
        Expedite = 8,
        /// <summary>出口费</summary>
        [Display(Name = "出口费")]
        [System.Runtime.Serialization.EnumMember(Value = @"export")]
        Export = 16,
        /// <summary>运费</summary>
        [Display(Name = "运费")]
        [System.Runtime.Serialization.EnumMember(Value = @"freight")]
        Freight = 32,
        /// <summary>燃油附加费</summary>
        [Display(Name = "燃油附加费")]
        [System.Runtime.Serialization.EnumMember(Value = @"fuel_surcharge")]
        Fuel_surcharge = 64,
        /// <summary>物流费</summary>
        [Display(Name = "物流费")]
        [System.Runtime.Serialization.EnumMember(Value = @"logistic")]
        Logistic = 128,
        /// <summary>其他费用</summary>
        [Display(Name = "其他费用")]
        [System.Runtime.Serialization.EnumMember(Value = @"other")]
        Other = 256,
        /// <summary>包装费</summary>
        [Display(Name = "包装费")]
        [System.Runtime.Serialization.EnumMember(Value = @"packaging")]
        Packaging = 512,
        /// <summary>揽件费</summary>
        [Display(Name = "揽件费")]
        [System.Runtime.Serialization.EnumMember(Value = @"pickup")]
        Pickup = 1024,
        /// <summary>操作费</summary>
        [Display(Name = "操作费")]
        [System.Runtime.Serialization.EnumMember(Value = @"handling")]
        Handling = 2048,
        /// <summary>增值税</summary>
        [Display(Name = "增值税")]
        [System.Runtime.Serialization.EnumMember(Value = @"vat")]
        Vat = 4096,
        /// <summary>保险费</summary>
        [Display(Name = "保险费")]
        [System.Runtime.Serialization.EnumMember(Value = @"insurance")]
        Insurance = 8192,
        /// <summary>反向收费</summary>
        [Display(Name = "反向收费")]
        [System.Runtime.Serialization.EnumMember(Value = @"reverse_charge")]
        Reverse_charge = 16384,
    }

    /// <summary>
    /// 许可证类型代码
    /// </summary>
    [System.Flags]
    public enum LicenseTypeCode
    {
        /// <summary>出口许可证</summary>
        [Display(Name = "出口许可证")]
        [System.Runtime.Serialization.EnumMember(Value = @"export")]
        Export = 1,
        /// <summary>进口许可证</summary>
        [Display(Name = "进口许可证")]
        [System.Runtime.Serialization.EnumMember(Value = @"import")]
        Import = 2,
    }

    /// <summary>
    /// 海关文件类型代码
    /// </summary>
    [System.Flags]
    public enum CustomsDocumentTypeCode
    {
        /// <summary>972文件</summary>
        [Display(Name = "972文件")]
        [System.Runtime.Serialization.EnumMember(Value = @"972")]
        _972 = 1,
        /// <summary>动物健康证书</summary>
        [Display(Name = "动物健康证书")]
        [System.Runtime.Serialization.EnumMember(Value = @"AHC")]
        AHC = 2,
        /// <summary>植物健康证书</summary>
        [Display(Name = "植物健康证书")]
        [System.Runtime.Serialization.EnumMember(Value = @"ALC")]
        ALC = 4,
        /// <summary>ATA单证册</summary>
        [Display(Name = "ATA单证册")]
        [System.Runtime.Serialization.EnumMember(Value = @"ATA")]
        ATA = 8,
        /// <summary>ATR运输证明</summary>
        [Display(Name = "ATR运输证明")]
        [System.Runtime.Serialization.EnumMember(Value = @"ATR")]
        ATR = 16,
        /// <summary>出口申报单</summary>
        [Display(Name = "出口申报单")]
        [System.Runtime.Serialization.EnumMember(Value = @"BEX")]
        BEX = 32,
        /// <summary>海关代理协议</summary>
        [Display(Name = "海关代理协议")]
        [System.Runtime.Serialization.EnumMember(Value = @"CHA")]
        CHA = 64,
        /// <summary>海关申报单</summary>
        [Display(Name = "海关申报单")]
        [System.Runtime.Serialization.EnumMember(Value = @"CHD")]
        CHD = 128,
        /// <summary>海关付款证明</summary>
        [Display(Name = "海关付款证明")]
        [System.Runtime.Serialization.EnumMember(Value = @"CHP")]
        CHP = 256,
        /// <summary>进口许可证</summary>
        [Display(Name = "进口许可证")]
        [System.Runtime.Serialization.EnumMember(Value = @"CIT")]
        CIT = 512,
        /// <summary>商业发票</summary>
        [Display(Name = "商业发票")]
        [System.Runtime.Serialization.EnumMember(Value = @"CIV")]
        CIV = 1024,
        /// <summary>商业发票副本</summary>
        [Display(Name = "商业发票副本")]
        [System.Runtime.Serialization.EnumMember(Value = @"CI2")]
        CI2 = 2048,
        /// <summary>原产地证书</summary>
        [Display(Name = "原产地证书")]
        [System.Runtime.Serialization.EnumMember(Value = @"COO")]
        COO = 4096,
        /// <summary>产品分析证书</summary>
        [Display(Name = "产品分析证书")]
        [System.Runtime.Serialization.EnumMember(Value = @"CPA")]
        CPA = 8192,
        /// <summary>信用证</summary>
        [Display(Name = "信用证")]
        [System.Runtime.Serialization.EnumMember(Value = @"CRL")]
        CRL = 16384,
        /// <summary>安全声明</summary>
        [Display(Name = "安全声明")]
        [System.Runtime.Serialization.EnumMember(Value = @"CSD")]
        CSD = 32768,
        /// <summary>出口报关单</summary>
        [Display(Name = "出口报关单")]
        [System.Runtime.Serialization.EnumMember(Value = @"DEX")]
        DEX = 65536,
        /// <summary>危险品声明</summary>
        [Display(Name = "危险品声明")]
        [System.Runtime.Serialization.EnumMember(Value = @"DGD")]
        DGD = 131072,
        /// <summary>驾驶证</summary>
        [Display(Name = "驾驶证")]
        [System.Runtime.Serialization.EnumMember(Value = @"DLI")]
        DLI = 262144,
        /// <summary>货物价值声明</summary>
        [Display(Name = "货物价值声明")]
        [System.Runtime.Serialization.EnumMember(Value = @"DOV")]
        DOV = 524288,
        /// <summary>出口许可证</summary>
        [Display(Name = "出口许可证")]
        [System.Runtime.Serialization.EnumMember(Value = @"ELP")]
        ELP = 1048576,
        /// <summary>欧盟1号表格</summary>
        [Display(Name = "欧盟1号表格")]
        [System.Runtime.Serialization.EnumMember(Value = @"EU1")]
        EU1 = 2097152,
        /// <summary>欧盟2号表格</summary>
        [Display(Name = "欧盟2号表格")]
        [System.Runtime.Serialization.EnumMember(Value = @"EU2")]
        EU2 = 4194304,
        /// <summary>欧盟供应声明</summary>
        [Display(Name = "欧盟供应声明")]
        [System.Runtime.Serialization.EnumMember(Value = @"EUS")]
        EUS = 8388608,
        /// <summary>出口许可证副本</summary>
        [Display(Name = "出口许可证副本")]
        [System.Runtime.Serialization.EnumMember(Value = @"EXL")]
        EXL = 16777216,
        /// <summary>原材料分析报告</summary>
        [Display(Name = "原材料分析报告")]
        [System.Runtime.Serialization.EnumMember(Value = @"FMA")]
        FMA = 33554432,
        /// <summary>健康证书</summary>
        [Display(Name = "健康证书")]
        [System.Runtime.Serialization.EnumMember(Value = @"HLC")]
        HLC = 67108864,
        /// <summary>运单副本</summary>
        [Display(Name = "运单副本")]
        [System.Runtime.Serialization.EnumMember(Value = @"HWB")]
        HWB = 134217728,
        /// <summary>发票</summary>
        [Display(Name = "发票")]
        [System.Runtime.Serialization.EnumMember(Value = @"INV")]
        INV = 268435456,
        /// <summary>进口许可证副本</summary>
        [Display(Name = "进口许可证副本")]
        [System.Runtime.Serialization.EnumMember(Value = @"IPA")]
        IPA = 536870912,
        /// <summary>日本原产地证书</summary>
        [Display(Name = "日本原产地证书")]
        [System.Runtime.Serialization.EnumMember(Value = @"JLC")]
        JLC = 1073741824,
        /// <summary>许可证</summary>
        [Display(Name = "许可证")]
        [System.Runtime.Serialization.EnumMember(Value = @"LIC")]
        LIC = -2147483648,
        /// <summary>物流通知单</summary>
        [Display(Name = "物流通知单")]
        [System.Runtime.Serialization.EnumMember(Value = @"LNP")]
        LNP = 1,
        /// <summary>国家身份证</summary>
        [Display(Name = "国家身份证")]
        [System.Runtime.Serialization.EnumMember(Value = @"NID")]
        NID = 2,
        /// <summary>护照</summary>
        [Display(Name = "护照")]
        [System.Runtime.Serialization.EnumMember(Value = @"PAS")]
        PAS = 4,
        /// <summary>形式发票</summary>
        [Display(Name = "形式发票")]
        [System.Runtime.Serialization.EnumMember(Value = @"PFI")]
        PFI = 8,
        /// <summary>物理分析报告</summary>
        [Display(Name = "物理分析报告")]
        [System.Runtime.Serialization.EnumMember(Value = @"PHY")]
        PHY = 16,
        /// <summary>装箱单</summary>
        [Display(Name = "装箱单")]
        [System.Runtime.Serialization.EnumMember(Value = @"PLI")]
        PLI = 32,
        /// <summary>授权书</summary>
        [Display(Name = "授权书")]
        [System.Runtime.Serialization.EnumMember(Value = @"POA")]
        POA = 64,
        /// <summary>采购合同</summary>
        [Display(Name = "采购合同")]
        [System.Runtime.Serialization.EnumMember(Value = @"PCH")]
        PCH = 128,
        /// <summary>收据</summary>
        [Display(Name = "收据")]
        [System.Runtime.Serialization.EnumMember(Value = @"ROD")]
        ROD = 256,
        /// <summary>T2M表格</summary>
        [Display(Name = "T2M表格")]
        [System.Runtime.Serialization.EnumMember(Value = @"T2M")]
        T2M = 512,
        /// <summary>TAD表格</summary>
        [Display(Name = "TAD表格")]
        [System.Runtime.Serialization.EnumMember(Value = @"TAD")]
        TAD = 1024,
        /// <summary>TCS表格</summary>
        [Display(Name = "TCS表格")]
        [System.Runtime.Serialization.EnumMember(Value = @"TCS")]
        TCS = 2048,
        /// <summary>兽医证书</summary>
        [Display(Name = "兽医证书")]
        [System.Runtime.Serialization.EnumMember(Value = @"VET")]
        VET = 4096,
        /// <summary>出口证书</summary>
        [Display(Name = "出口证书")]
        [System.Runtime.Serialization.EnumMember(Value = @"VEX")]
        VEX = 8192,
    }

    /// <summary>
    /// 客户参考类型代码（明细行/发票级别）
    /// </summary>
    [System.Flags]
    public enum CustomerReferenceTypeCode
    {
        /// <summary>AFE费用代码</summary>
        [Display(Name = "AFE费用代码")]
        [System.Runtime.Serialization.EnumMember(Value = @"AFE")]
        AFE = 1,
        /// <summary>BRD装运单号</summary>
        [Display(Name = "BRD装运单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"BRD")]
        BRD = 2,
        /// <summary>DGC危险品代码</summary>
        [Display(Name = "DGC危险品代码")]
        [System.Runtime.Serialization.EnumMember(Value = @"DGC")]
        DGC = 4,
        /// <summary>AAJ附加条款</summary>
        [Display(Name = "AAJ附加条款")]
        [System.Runtime.Serialization.EnumMember(Value = @"AAJ")]
        AAJ = 8,
        /// <summary>INB内部编号</summary>
        [Display(Name = "INB内部编号")]
        [System.Runtime.Serialization.EnumMember(Value = @"INB")]
        INB = 16,
        /// <summary>MAK制造商代码</summary>
        [Display(Name = "MAK制造商代码")]
        [System.Runtime.Serialization.EnumMember(Value = @"MAK")]
        MAK = 32,
        /// <summary>ALX分销商代码</summary>
        [Display(Name = "ALX分销商代码")]
        [System.Runtime.Serialization.EnumMember(Value = @"ALX")]
        ALX = 64,
        /// <summary>PAN采购分析号</summary>
        [Display(Name = "PAN采购分析号")]
        [System.Runtime.Serialization.EnumMember(Value = @"PAN")]
        PAN = 128,
        /// <summary>PON采购订单号</summary>
        [Display(Name = "PON采购订单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"PON")]
        PON = 256,
        /// <summary>ABW空运提单号</summary>
        [Display(Name = "ABW空运提单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"ABW")]
        ABW = 512,
        /// <summary>SE销售订单号</summary>
        [Display(Name = "SE销售订单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"SE")]
        SE = 1024,
        /// <summary>SON供应商订单号</summary>
        [Display(Name = "SON供应商订单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"SON")]
        SON = 2048,
        /// <summary>OID订单ID</summary>
        [Display(Name = "OID订单ID")]
        [System.Runtime.Serialization.EnumMember(Value = @"OID")]
        OID = 4096,
        /// <summary>DTC交货条款代码</summary>
        [Display(Name = "DTC交货条款代码")]
        [System.Runtime.Serialization.EnumMember(Value = @"DTC")]
        DTC = 8192,
        /// <summary>DTM交货时间</summary>
        [Display(Name = "DTM交货时间")]
        [System.Runtime.Serialization.EnumMember(Value = @"DTM")]
        DTM = 16384,
        /// <summary>DTQ交货数量</summary>
        [Display(Name = "DTQ交货数量")]
        [System.Runtime.Serialization.EnumMember(Value = @"DTQ")]
        DTQ = 32768,
        /// <summary>DTR交货路线</summary>
        [Display(Name = "DTR交货路线")]
        [System.Runtime.Serialization.EnumMember(Value = @"DTR")]
        DTR = 65536,
        /// <summary>ITR内部运输参考</summary>
        [Display(Name = "ITR内部运输参考")]
        [System.Runtime.Serialization.EnumMember(Value = @"ITR")]
        ITR = 131072,
        /// <summary>MID制造商识别码</summary>
        [Display(Name = "MID制造商识别码")]
        [System.Runtime.Serialization.EnumMember(Value = @"MID")]
        MID = 262144,
        /// <summary>OED出口订单号</summary>
        [Display(Name = "OED出口订单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"OED")]
        OED = 524288,
        /// <summary>OET出口运输单号</summary>
        [Display(Name = "OET出口运输单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"OET")]
        OET = 1048576,
        /// <summary>OOR原产地订单号</summary>
        [Display(Name = "OOR原产地订单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"OOR")]
        OOR = 2097152,
        /// <summary>SME发货人参考</summary>
        [Display(Name = "SME发货人参考")]
        [System.Runtime.Serialization.EnumMember(Value = @"SME")]
        SME = 4194304,
        /// <summary>USM收货人参考</summary>
        [Display(Name = "USM收货人参考")]
        [System.Runtime.Serialization.EnumMember(Value = @"USM")]
        USM = 8388608,
        /// <summary>AAM附加管理代码</summary>
        [Display(Name = "AAM附加管理代码")]
        [System.Runtime.Serialization.EnumMember(Value = @"AAM")]
        AAM = 16777216,
        /// <summary>CFR成本加运费</summary>
        [Display(Name = "CFR成本加运费")]
        [System.Runtime.Serialization.EnumMember(Value = @"CFR")]
        CFR = 33554432,
        /// <summary>DOM国内订单号</summary>
        [Display(Name = "DOM国内订单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"DOM")]
        DOM = 67108864,
        /// <summary>FOR国外订单号</summary>
        [Display(Name = "FOR国外订单号")]
        [System.Runtime.Serialization.EnumMember(Value = @"FOR")]
        FOR = 134217728,
        /// <summary>USG美国政府编号</summary>
        [Display(Name = "USG美国政府编号")]
        [System.Runtime.Serialization.EnumMember(Value = @"USG")]
        USG = 268435456,
        /// <summary>MAT物料号</summary>
        [Display(Name = "MAT物料号")]
        [System.Runtime.Serialization.EnumMember(Value = @"MAT")]
        MAT = 536870912,
        /// <summary>NLR非限制物品</summary>
        [Display(Name = "NLR非限制物品")]
        [System.Runtime.Serialization.EnumMember(Value = @"NLR")]
        NLR = 1073741824,
        /// <summary>DDS直达发货</summary>
        [Display(Name = "DDS直达发货")]
        [System.Runtime.Serialization.EnumMember(Value = @"DDS")]
        DDS = -2147483648,
    }

    /// <summary>
    /// 商品编码类型代码
    /// </summary>
    [System.Flags]
    public enum CommodityCodeTypeCode
    {
        /// <summary>出口</summary>
        [Display(Name = "出口")]
        [System.Runtime.Serialization.EnumMember(Value = @"outbound")]
        Outbound = 1,
        /// <summary>进口</summary>
        [Display(Name = "进口")]
        [System.Runtime.Serialization.EnumMember(Value = @"inbound")]
        Inbound = 2,
    }

    /// <summary>
    /// 标签文本位置
    /// </summary>
    [System.Flags]
    public enum LabelTextPosition
    {
        /// <summary>左1</summary>
        [Display(Name = "左1")]
        [System.Runtime.Serialization.EnumMember(Value = @"left1")]
        Left1 = 1,
        /// <summary>左2</summary>
        [Display(Name = "左2")]
        [System.Runtime.Serialization.EnumMember(Value = @"left2")]
        Left2 = 2,
        /// <summary>左3</summary>
        [Display(Name = "左3")]
        [System.Runtime.Serialization.EnumMember(Value = @"left3")]
        Left3 = 4,
        /// <summary>右1</summary>
        [Display(Name = "右1")]
        [System.Runtime.Serialization.EnumMember(Value = @"right1")]
        Right1 = 8,
        /// <summary>右2</summary>
        [Display(Name = "右2")]
        [System.Runtime.Serialization.EnumMember(Value = @"right2")]
        Right2 = 16,
        /// <summary>右3</summary>
        [Display(Name = "右3")]
        [System.Runtime.Serialization.EnumMember(Value = @"right3")]
        Right3 = 32,
    }

    /// <summary>
    /// 明细行出口原因类型
    /// </summary>
    [System.Flags]
    public enum LineItemExportReasonType
    {
        /// <summary>永久出口</summary>
        [Display(Name = "永久出口")]
        [System.Runtime.Serialization.EnumMember(Value = @"permanent")]
        Permanent = 1,
        /// <summary>临时出口</summary>
        [Display(Name = "临时出口")]
        [System.Runtime.Serialization.EnumMember(Value = @"temporary")]
        Temporary = 2,
        /// <summary>退货</summary>
        [Display(Name = "退货")]
        [System.Runtime.Serialization.EnumMember(Value = @"return")]
        Return = 4,
        /// <summary>展会物品返回原产地</summary>
        [Display(Name = "展会物品返回原产地")]
        [System.Runtime.Serialization.EnumMember(Value = @"used_exhibition_goods_to_origin")]
        Used_exhibition_goods_to_origin = 8,
        /// <summary>公司内部使用</summary>
        [Display(Name = "公司内部使用")]
        [System.Runtime.Serialization.EnumMember(Value = @"intercompany_use")]
        Intercompany_use = 16,
        /// <summary>商业用途或销售</summary>
        [Display(Name = "商业用途或销售")]
        [System.Runtime.Serialization.EnumMember(Value = @"commercial_purpose_or_sale")]
        Commercial_purpose_or_sale = 32,
        /// <summary>个人物品或个人用途</summary>
        [Display(Name = "个人物品或个人用途")]
        [System.Runtime.Serialization.EnumMember(Value = @"personal_belongings_or_personal_use")]
        Personal_belongings_or_personal_use = 64,
        /// <summary>样品</summary>
        [Display(Name = "样品")]
        [System.Runtime.Serialization.EnumMember(Value = @"sample")]
        Sample = 128,
        /// <summary>礼品</summary>
        [Display(Name = "礼品")]
        [System.Runtime.Serialization.EnumMember(Value = @"gift")]
        Gift = 256,
        /// <summary>退回原产地</summary>
        [Display(Name = "退回原产地")]
        [System.Runtime.Serialization.EnumMember(Value = @"return_to_origin")]
        Return_to_origin = 512,
        /// <summary>保修更换</summary>
        [Display(Name = "保修更换")]
        [System.Runtime.Serialization.EnumMember(Value = @"warranty_replacement")]
        Warranty_replacement = 1024,
        /// <summary>外交物品</summary>
        [Display(Name = "外交物品")]
        [System.Runtime.Serialization.EnumMember(Value = @"diplomatic_goods")]
        Diplomatic_goods = 2048,
        /// <summary>国防物资</summary>
        [Display(Name = "国防物资")]
        [System.Runtime.Serialization.EnumMember(Value = @"defence_material")]
        Defence_material = 4096,
    }
    /// <summary>
    /// 数量计量单位类型代码
    /// </summary>
    [System.Flags]
    public enum QuantityUnitOfMeasurementTypeCode
    {
        /// <summary>箱</summary>
        [Display(Name = "箱")]
        [System.Runtime.Serialization.EnumMember(Value = @"BOX")]
        BOX = 1,

        /// <summary>2克</summary>
        [Display(Name = "2克")]
        [System.Runtime.Serialization.EnumMember(Value = @"2GM")]
        _2GM = 2,

        /// <summary>立方米</summary>
        [Display(Name = "立方米")]
        [System.Runtime.Serialization.EnumMember(Value = @"M3")]
        M3 = 4,

        /// <summary>打</summary>
        [Display(Name = "打")]
        [System.Runtime.Serialization.EnumMember(Value = @"DPR")]
        DPR = 8,

        /// <summary>打（12个）</summary>
        [Display(Name = "打（12个）")]
        [System.Runtime.Serialization.EnumMember(Value = @"DOZ")]
        DOZ = 16,

        /// <summary>件</summary>
        [Display(Name = "件")]
        [System.Runtime.Serialization.EnumMember(Value = @"PCS")]
        PCS = 32,

        /// <summary>克</summary>
        [Display(Name = "克")]
        [System.Runtime.Serialization.EnumMember(Value = @"GM")]
        GM = 64,

        /// <summary>格罗斯（144个）</summary>
        [Display(Name = "格罗斯（144个）")]
        [System.Runtime.Serialization.EnumMember(Value = @"GRS")]
        GRS = 128,

        /// <summary>千克</summary>
        [Display(Name = "千克")]
        [System.Runtime.Serialization.EnumMember(Value = @"KG")]
        KG = 256,

        /// <summary>米</summary>
        [Display(Name = "米")]
        [System.Runtime.Serialization.EnumMember(Value = @"M")]
        M = 512,

        /// <summary>3克</summary>
        [Display(Name = "3克")]
        [System.Runtime.Serialization.EnumMember(Value = @"3GM")]
        _3GM = 1024,

        /// <summary>未知单位X</summary>
        [Display(Name = "未知单位X")]
        [System.Runtime.Serialization.EnumMember(Value = @"X")]
        X = 2048,

        /// <summary>个</summary>
        [Display(Name = "个")]
        [System.Runtime.Serialization.EnumMember(Value = @"NO")]
        NO = 4096,

        /// <summary>双</summary>
        [Display(Name = "双")]
        [System.Runtime.Serialization.EnumMember(Value = @"PRS")]
        PRS = 8192,

        /// <summary>平方厘米</summary>
        [Display(Name = "平方厘米")]
        [System.Runtime.Serialization.EnumMember(Value = @"CM2")]
        CM2 = 16384,

        /// <summary>2平方米</summary>
        [Display(Name = "2平方米")]
        [System.Runtime.Serialization.EnumMember(Value = @"2M2")]
        _2M2 = 32768,

        /// <summary>3平方米</summary>
        [Display(Name = "3平方米")]
        [System.Runtime.Serialization.EnumMember(Value = @"3M2")]
        _3M2 = 65536,

        /// <summary>平方米</summary>
        [Display(Name = "平方米")]
        [System.Runtime.Serialization.EnumMember(Value = @"M2")]
        M2 = 131072,

        /// <summary>4平方米</summary>
        [Display(Name = "4平方米")]
        [System.Runtime.Serialization.EnumMember(Value = @"4M2")]
        _4M2 = 262144,

        /// <summary>厘米</summary>
        [Display(Name = "厘米")]
        [System.Runtime.Serialization.EnumMember(Value = @"CM")]
        CM = 524288,

        /// <summary>锥形体</summary>
        [Display(Name = "锥形体")]
        [System.Runtime.Serialization.EnumMember(Value = @"CONE")]
        CONE = 1048576,

        /// <summary>克拉</summary>
        [Display(Name = "克拉")]
        [System.Runtime.Serialization.EnumMember(Value = @"CT")]
        CT = 2097152,

        /// <summary>每件</summary>
        [Display(Name = "每件")]
        [System.Runtime.Serialization.EnumMember(Value = @"EA")]
        EA = 4194304,

        /// <summary>磅</summary>
        [Display(Name = "磅")]
        [System.Runtime.Serialization.EnumMember(Value = @"LBS")]
        LBS = 8388608,

        /// <summary>卷芯</summary>
        [Display(Name = "卷芯")]
        [System.Runtime.Serialization.EnumMember(Value = @"RILL")]
        RILL = 16777216,

        /// <summary>卷</summary>
        [Display(Name = "卷")]
        [System.Runtime.Serialization.EnumMember(Value = @"ROLL")]
        ROLL = 33554432,

        /// <summary>套</summary>
        [Display(Name = "套")]
        [System.Runtime.Serialization.EnumMember(Value = @"SET")]
        SET = 67108864,

        /// <summary>托盘</summary>
        [Display(Name = "托盘")]
        [System.Runtime.Serialization.EnumMember(Value = @"TU")]
        TU = 134217728,

        /// <summary>千米</summary>
        [Display(Name = "千米")]
        [System.Runtime.Serialization.EnumMember(Value = @"KM")]
        KM = 268435456,

        /// <summary>英寸</summary>
        [Display(Name = "英寸")]
        [System.Runtime.Serialization.EnumMember(Value = @"IN")]
        IN = 536870912,

        /// <summary>英尺</summary>
        [Display(Name = "英尺")]
        [System.Runtime.Serialization.EnumMember(Value = @"FT")]
        FT = 1073741824,

        /// <summary>码</summary>
        [Display(Name = "码")]
        [System.Runtime.Serialization.EnumMember(Value = @"YD")]
        YD = -2147483648,

        /// <summary>英里</summary>
        [Display(Name = "英里")]
        [System.Runtime.Serialization.EnumMember(Value = @"MI")]
        MI = 1,

        /// <summary>升</summary>
        [Display(Name = "升")]
        [System.Runtime.Serialization.EnumMember(Value = @"LTR")]
        LTR = 2,

        /// <summary>立方毫米</summary>
        [Display(Name = "立方毫米")]
        [System.Runtime.Serialization.EnumMember(Value = @"MMQ")]
        MMQ = 4,

        /// <summary>立方厘米</summary>
        [Display(Name = "立方厘米")]
        [System.Runtime.Serialization.EnumMember(Value = @"CM3")]
        CM3 = 8,

        /// <summary>立方分米</summary>
        [Display(Name = "立方分米")]
        [System.Runtime.Serialization.EnumMember(Value = @"DMQ")]
        DMQ = 16,

        /// <summary>毫升</summary>
        [Display(Name = "毫升")]
        [System.Runtime.Serialization.EnumMember(Value = @"MLT")]
        MLT = 32,

        /// <summary>厘升</summary>
        [Display(Name = "厘升")]
        [System.Runtime.Serialization.EnumMember(Value = @"CLT")]
        CLT = 64,

        /// <summary>分升</summary>
        [Display(Name = "分升")]
        [System.Runtime.Serialization.EnumMember(Value = @"DLT")]
        DLT = 128,

        /// <summary>立方英寸</summary>
        [Display(Name = "立方英寸")]
        [System.Runtime.Serialization.EnumMember(Value = @"INQ")]
        INQ = 256,

        /// <summary>立方英尺</summary>
        [Display(Name = "立方英尺")]
        [System.Runtime.Serialization.EnumMember(Value = @"FT3")]
        FT3 = 512,

        /// <summary>立方码</summary>
        [Display(Name = "立方码")]
        [System.Runtime.Serialization.EnumMember(Value = @"YD3")]
        YD3 = 1024,

        /// <summary>英国加仑</summary>
        [Display(Name = "英国加仑")]
        [System.Runtime.Serialization.EnumMember(Value = @"GLI")]
        GLI = 2048,

        /// <summary>美制加仑</summary>
        [Display(Name = "美制加仑")]
        [System.Runtime.Serialization.EnumMember(Value = @"GLL")]
        GLL = 4096,

        /// <summary>品脱</summary>
        [Display(Name = "品脱")]
        [System.Runtime.Serialization.EnumMember(Value = @"PT")]
        PT = 8192,

        /// <summary>英制品脱</summary>
        [Display(Name = "英制品脱")]
        [System.Runtime.Serialization.EnumMember(Value = @"PTI")]
        PTI = 16384,

        /// <summary>英制夸脱</summary>
        [Display(Name = "英制夸脱")]
        [System.Runtime.Serialization.EnumMember(Value = @"QTI")]
        QTI = 32768,

        /// <summary>美制品脱</summary>
        [Display(Name = "美制品脱")]
        [System.Runtime.Serialization.EnumMember(Value = @"PTL")]
        PTL = 65536,

        /// <summary>美制夸脱</summary>
        [Display(Name = "美制夸脱")]
        [System.Runtime.Serialization.EnumMember(Value = @"QTL")]
        QTL = 131072,

        /// <summary>美制干品脱</summary>
        [Display(Name = "美制干品脱")]
        [System.Runtime.Serialization.EnumMember(Value = @"PTD")]
        PTD = 262144,

        /// <summary>英制盎司</summary>
        [Display(Name = "英制盎司")]
        [System.Runtime.Serialization.EnumMember(Value = @"OZI")]
        OZI = 524288,

        /// <summary>J57单位</summary>
        [Display(Name = "J57单位")]
        [System.Runtime.Serialization.EnumMember(Value = @"J57")]
        J57 = 1048576,

        /// <summary>标准立方米</summary>
        [Display(Name = "标准立方米")]
        [System.Runtime.Serialization.EnumMember(Value = @"NM3")]
        NM3 = 2097152,

        /// <summary>标准立方米（SM3）</summary>
        [Display(Name = "标准立方米（SM3）")]
        [System.Runtime.Serialization.EnumMember(Value = @"SM3")]
        SM3 = 4194304,

        /// <summary>公吨</summary>
        [Display(Name = "公吨")]
        [System.Runtime.Serialization.EnumMember(Value = @"TNE")]
        TNE = 8388608,

        /// <summary>磅（LB）</summary>
        [Display(Name = "磅（LB）")]
        [System.Runtime.Serialization.EnumMember(Value = @"LB")]
        LB = 16777216,

        /// <summary>盎司</summary>
        [Display(Name = "盎司")]
        [System.Runtime.Serialization.EnumMember(Value = @"ONZ")]
        ONZ = 33554432,

        /// <summary>摄氏度</summary>
        [Display(Name = "摄氏度")]
        [System.Runtime.Serialization.EnumMember(Value = @"CEL")]
        CEL = 67108864,
    }
}
