using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDHLSchema
{
    
    [System.Flags]
    public enum PartyDetailsTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"business")]
        Business = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"direct_consumer")]
        Direct_consumer = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"government")]
        Government = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"other")]
        Other = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"private")]
        Private = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"reseller")]
        Reseller = 32,

    }
    
    [System.Flags]
    public enum SupermodelIoLogisticsExpressAccountTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"shipper")]
        Shipper = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"payer")]
        Payer = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"duties-taxes")]
        DutiesTaxes = 4,

    }
    
    [System.Flags]
    public enum OutputImagePropertiesEncodingFormat
    {

        [System.Runtime.Serialization.EnumMember(Value = @"pdf")]
        Pdf = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"zpl")]
        Zpl = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"lp2")]
        Lp2 = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"epl")]
        Epl = 8,

    }
    
    [System.Flags]
    public enum SupermodelIoLogisticsExpressReferenceTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"AAO")]
        AAO = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"CU")]
        CU = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"FF")]
        FF = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"FN")]
        FN = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"IBC")]
        IBC = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"LLR")]
        LLR = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"OBC")]
        OBC = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"PRN")]
        PRN = 128,

        [System.Runtime.Serialization.EnumMember(Value = @"ACP")]
        ACP = 256,

        [System.Runtime.Serialization.EnumMember(Value = @"ACS")]
        ACS = 512,

        [System.Runtime.Serialization.EnumMember(Value = @"ACR")]
        ACR = 1024,

        [System.Runtime.Serialization.EnumMember(Value = @"CDN")]
        CDN = 2048,

        [System.Runtime.Serialization.EnumMember(Value = @"STD")]
        STD = 4096,

        [System.Runtime.Serialization.EnumMember(Value = @"CO")]
        CO = 8192,

    }
    
    [System.Flags]
    public enum SupermodelIoLogisticsExpressIdentifierTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"parentId")]
        ParentId = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"shipmentId")]
        ShipmentId = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"pieceId")]
        PieceId = 4,

    }
    
    [System.Flags]
    public enum IncotermTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"EXW")]
        EXW = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"FCA")]
        FCA = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CPT")]
        CPT = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"CIP")]
        CIP = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"DPU")]
        DPU = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"DAP")]
        DAP = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"DDP")]
        DDP = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"FAS")]
        FAS = 128,

        [System.Runtime.Serialization.EnumMember(Value = @"FOB")]
        FOB = 256,

        [System.Runtime.Serialization.EnumMember(Value = @"CFR")]
        CFR = 512,

        [System.Runtime.Serialization.EnumMember(Value = @"CIF")]
        CIF = 1024,

        [System.Runtime.Serialization.EnumMember(Value = @"DAF")]
        DAF = 2048,

        [System.Runtime.Serialization.EnumMember(Value = @"DAT")]
        DAT = 4096,

        [System.Runtime.Serialization.EnumMember(Value = @"DDU")]
        DDU = 8192,

        [System.Runtime.Serialization.EnumMember(Value = @"DEQ")]
        DEQ = 16384,

        [System.Runtime.Serialization.EnumMember(Value = @"DES")]
        DES = 32768,

    }
    
    [System.Flags]
    public enum UnitOfMeasurementTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"metric")]
        Metric = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"imperial")]
        Imperial = 2,

    }
    
    [System.Flags]
    public enum DocumentImageTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"INV")]
        INV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PNV")]
        PNV = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"COO")]
        COO = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"CIN")]
        CIN = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"DCL")]
        DCL = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"AWB")]
        AWB = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"NAF")]
        NAF = 64,

    }
    
    [System.Flags]
    public enum ImageFormatTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PNG")]
        PNG = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"GIF")]
        GIF = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"TIFF")]
        TIFF = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"JPEG")]
        JPEG = 16,

    }
    
    [System.Flags]
    public enum OnDemandDeliveryWhereToLeave
    {

        [System.Runtime.Serialization.EnumMember(Value = @"concierge")]
        Concierge = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"neighbour")]
        Neighbour = 2,

    }
    
    [System.Flags]
    public enum ShipmentNotificationTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"email")]
        Email = 1,

    }
    
    [System.Flags]
    public enum PrepaidChargesTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"freight")]
        Freight = 1,

    }
    
    [System.Flags]
    public enum PrepaidChargesMethod
    {

        [System.Runtime.Serialization.EnumMember(Value = @"cash")]
        Cash = 1,

    }
    
    [System.Flags]
    public enum EstimatedDeliveryDateTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"QDDC")]
        QDDC = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"QDDF")]
        QDDF = 2,

    }
    
    [System.Flags]
    public enum CustomerBarcodesSymbologyCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"93")]
        _93 = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"39")]
        _39 = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"128")]
        _128 = 4,

    }
    
    [System.Flags]
    public enum CustomerLogoFileFormat
    {

        [System.Runtime.Serialization.EnumMember(Value = @"PNG")]
        PNG = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"GIF")]
        GIF = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"JPEG")]
        JPEG = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"JPG")]
        JPG = 8,

    }
    
    [System.Flags]
    public enum GetAdditionalInformationTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"pickupDetails")]
        PickupDetails = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"optionalShipmentData")]
        OptionalShipmentData = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"barcodeInformation")]
        BarcodeInformation = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"linkLabelsByPieces")]
        LinkLabelsByPieces = 8,

    }
    
    [System.Flags]
    public enum SupermodelIoLogisticsExpressRegistrationNumbersTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"VAT")]
        VAT = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"EIN")]
        EIN = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"GST")]
        GST = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"SSN")]
        SSN = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"EOR")]
        EOR = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"DUN")]
        DUN = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"FED")]
        FED = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"STA")]
        STA = 128,

        [System.Runtime.Serialization.EnumMember(Value = @"CNP")]
        CNP = 256,

        [System.Runtime.Serialization.EnumMember(Value = @"IE")]
        IE = 512,

        [System.Runtime.Serialization.EnumMember(Value = @"INN")]
        INN = 1024,

        [System.Runtime.Serialization.EnumMember(Value = @"KPP")]
        KPP = 2048,

        [System.Runtime.Serialization.EnumMember(Value = @"OGR")]
        OGR = 4096,

        [System.Runtime.Serialization.EnumMember(Value = @"OKP")]
        OKP = 8192,

        [System.Runtime.Serialization.EnumMember(Value = @"MRN")]
        MRN = 16384,

        [System.Runtime.Serialization.EnumMember(Value = @"SDT")]
        SDT = 32768,

        [System.Runtime.Serialization.EnumMember(Value = @"FTZ")]
        FTZ = 65536,

        [System.Runtime.Serialization.EnumMember(Value = @"DAN")]
        DAN = 131072,

        [System.Runtime.Serialization.EnumMember(Value = @"TAN")]
        TAN = 262144,

        [System.Runtime.Serialization.EnumMember(Value = @"DTF")]
        DTF = 524288,

        [System.Runtime.Serialization.EnumMember(Value = @"RGP")]
        RGP = 1048576,

        [System.Runtime.Serialization.EnumMember(Value = @"DLI")]
        DLI = 2097152,

        [System.Runtime.Serialization.EnumMember(Value = @"NID")]
        NID = 4194304,

        [System.Runtime.Serialization.EnumMember(Value = @"PAS")]
        PAS = 8388608,

        [System.Runtime.Serialization.EnumMember(Value = @"MID")]
        MID = 16777216,

        [System.Runtime.Serialization.EnumMember(Value = @"IMS")]
        IMS = 33554432,

        [System.Runtime.Serialization.EnumMember(Value = @"EIC")]
        EIC = 67108864,

        [System.Runtime.Serialization.EnumMember(Value = @"FTN")]
        FTN = 134217728,

    }
    
    [System.Flags]
    public enum ImageOptionTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"label")]
        Label = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"waybillDoc")]
        WaybillDoc = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"invoice")]
        Invoice = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"qr-code")]
        QrCode = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"shipmentReceipt")]
        ShipmentReceipt = 16,

    }
    
    [System.Flags]
    public enum ImageOptionInvoiceType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"commercial")]
        Commercial = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"proforma")]
        Proforma = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"returns")]
        Returns = 4,

    }
    
    [System.Flags]
    public enum ImageOptionEncodingFormat
    {

        [System.Runtime.Serialization.EnumMember(Value = @"png")]
        Png = 1,

    }
    
    [System.Flags]
    public enum SupermodelIoLogisticsExpressPackageTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"3BX")]
        _3BX = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"2BC")]
        _2BC = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"2BP")]
        _2BP = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"CE1")]
        CE1 = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"7BX")]
        _7BX = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"6BX")]
        _6BX = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"4BX")]
        _4BX = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"2BX")]
        _2BX = 128,

        [System.Runtime.Serialization.EnumMember(Value = @"1CE")]
        _1CE = 256,

        [System.Runtime.Serialization.EnumMember(Value = @"WB1")]
        WB1 = 512,

        [System.Runtime.Serialization.EnumMember(Value = @"WB3")]
        WB3 = 1024,

        [System.Runtime.Serialization.EnumMember(Value = @"XPD")]
        XPD = 2048,

        [System.Runtime.Serialization.EnumMember(Value = @"8BX")]
        _8BX = 4096,

        [System.Runtime.Serialization.EnumMember(Value = @"5BX")]
        _5BX = 8192,

        [System.Runtime.Serialization.EnumMember(Value = @"WB6")]
        WB6 = 16384,

        [System.Runtime.Serialization.EnumMember(Value = @"TBL")]
        TBL = 32768,

        [System.Runtime.Serialization.EnumMember(Value = @"TBS")]
        TBS = 65536,

        [System.Runtime.Serialization.EnumMember(Value = @"WB2")]
        WB2 = 131072,

    }
    
    [System.Flags]
    public enum OnDemandDeliveryDeliveryOption
    {

        [System.Runtime.Serialization.EnumMember(Value = @"servicepoint")]
        Servicepoint = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"neighbour")]
        Neighbour = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"signatureRelease")]
        SignatureRelease = 4,

    }

    
    [System.Flags]
    public enum ExportDeclarationExportReasonType
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
    
    [System.Flags]
    public enum ExportDeclarationShipmentType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"personal")]
        Personal = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"commercial")]
        Commercial = 2,

    }
    
    [System.Flags]
    public enum SupermodelIoLogisticsExpressPackageReferenceTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"AAO")]
        AAO = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"CU")]
        CU = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"FF")]
        FF = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"FN")]
        FN = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"IBC")]
        IBC = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"LLR")]
        LLR = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"OBC")]
        OBC = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"PRN")]
        PRN = 128,

        [System.Runtime.Serialization.EnumMember(Value = @"ACP")]
        ACP = 256,

        [System.Runtime.Serialization.EnumMember(Value = @"ACS")]
        ACS = 512,

        [System.Runtime.Serialization.EnumMember(Value = @"ACR")]
        ACR = 1024,

        [System.Runtime.Serialization.EnumMember(Value = @"CDN")]
        CDN = 2048,

        [System.Runtime.Serialization.EnumMember(Value = @"STD")]
        STD = 4096,

        [System.Runtime.Serialization.EnumMember(Value = @"CO")]
        CO = 8192,

    }
    
    [System.Flags]
    public enum LabelBarcodePosition
    {

        [System.Runtime.Serialization.EnumMember(Value = @"left")]
        Left = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"right")]
        Right = 2,

    }
    
    [System.Flags]
    public enum LabelBarcodeSymbologyCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"93")]
        _93 = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"39")]
        _39 = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"128")]
        _128 = 4,

    }
    
    [System.Flags]
    public enum AdditionalChargeTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"admin")]
        Admin = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"delivery")]
        Delivery = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"documentation")]
        Documentation = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"expedite")]
        Expedite = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"export")]
        Export = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"freight")]
        Freight = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"fuel_surcharge")]
        Fuel_surcharge = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"logistic")]
        Logistic = 128,

        [System.Runtime.Serialization.EnumMember(Value = @"other")]
        Other = 256,

        [System.Runtime.Serialization.EnumMember(Value = @"packaging")]
        Packaging = 512,

        [System.Runtime.Serialization.EnumMember(Value = @"pickup")]
        Pickup = 1024,

        [System.Runtime.Serialization.EnumMember(Value = @"handling")]
        Handling = 2048,

        [System.Runtime.Serialization.EnumMember(Value = @"vat")]
        Vat = 4096,

        [System.Runtime.Serialization.EnumMember(Value = @"insurance")]
        Insurance = 8192,

        [System.Runtime.Serialization.EnumMember(Value = @"reverse_charge")]
        Reverse_charge = 16384,

    }
    
    [System.Flags]
    public enum LicenseTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"export")]
        Export = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"import")]
        Import = 2,

    }
    
    [System.Flags]
    public enum CustomsDocumentTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"972")]
        _972 = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"AHC")]
        AHC = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"ALC")]
        ALC = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"ATA")]
        ATA = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"ATR")]
        ATR = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"BEX")]
        BEX = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"CHA")]
        CHA = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"CHD")]
        CHD = 128,

        [System.Runtime.Serialization.EnumMember(Value = @"CHP")]
        CHP = 256,

        [System.Runtime.Serialization.EnumMember(Value = @"CIT")]
        CIT = 512,

        [System.Runtime.Serialization.EnumMember(Value = @"CIV")]
        CIV = 1024,

        [System.Runtime.Serialization.EnumMember(Value = @"CI2")]
        CI2 = 2048,

        [System.Runtime.Serialization.EnumMember(Value = @"COO")]
        COO = 4096,

        [System.Runtime.Serialization.EnumMember(Value = @"CPA")]
        CPA = 8192,

        [System.Runtime.Serialization.EnumMember(Value = @"CRL")]
        CRL = 16384,

        [System.Runtime.Serialization.EnumMember(Value = @"CSD")]
        CSD = 32768,

        [System.Runtime.Serialization.EnumMember(Value = @"DEX")]
        DEX = 65536,

        [System.Runtime.Serialization.EnumMember(Value = @"DGD")]
        DGD = 131072,

        [System.Runtime.Serialization.EnumMember(Value = @"DLI")]
        DLI = 262144,

        [System.Runtime.Serialization.EnumMember(Value = @"DOV")]
        DOV = 524288,

        [System.Runtime.Serialization.EnumMember(Value = @"ELP")]
        ELP = 1048576,

        [System.Runtime.Serialization.EnumMember(Value = @"EU1")]
        EU1 = 2097152,

        [System.Runtime.Serialization.EnumMember(Value = @"EU2")]
        EU2 = 4194304,

        [System.Runtime.Serialization.EnumMember(Value = @"EUS")]
        EUS = 8388608,

        [System.Runtime.Serialization.EnumMember(Value = @"EXL")]
        EXL = 16777216,

        [System.Runtime.Serialization.EnumMember(Value = @"FMA")]
        FMA = 33554432,

        [System.Runtime.Serialization.EnumMember(Value = @"HLC")]
        HLC = 67108864,

        [System.Runtime.Serialization.EnumMember(Value = @"HWB")]
        HWB = 134217728,

        [System.Runtime.Serialization.EnumMember(Value = @"INV")]
        INV = 268435456,

        [System.Runtime.Serialization.EnumMember(Value = @"IPA")]
        IPA = 536870912,

        [System.Runtime.Serialization.EnumMember(Value = @"JLC")]
        JLC = 1073741824,

        [System.Runtime.Serialization.EnumMember(Value = @"LIC")]
        LIC = -2147483648,

        [System.Runtime.Serialization.EnumMember(Value = @"LNP")]
        LNP = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"NID")]
        NID = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"PAS")]
        PAS = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"PFI")]
        PFI = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"PHY")]
        PHY = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"PLI")]
        PLI = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"POA")]
        POA = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"PCH")]
        PCH = 128,

        [System.Runtime.Serialization.EnumMember(Value = @"ROD")]
        ROD = 256,

        [System.Runtime.Serialization.EnumMember(Value = @"T2M")]
        T2M = 512,

        [System.Runtime.Serialization.EnumMember(Value = @"TAD")]
        TAD = 1024,

        [System.Runtime.Serialization.EnumMember(Value = @"TCS")]
        TCS = 2048,

        [System.Runtime.Serialization.EnumMember(Value = @"VET")]
        VET = 4096,

        [System.Runtime.Serialization.EnumMember(Value = @"VEX")]
        VEX = 8192,

    }
    
    [System.Flags]
    public enum CustomerReferenceTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"AFE")]
        AFE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"BRD")]
        BRD = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"DGC")]
        DGC = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"AAJ")]
        AAJ = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"INB")]
        INB = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"MAK")]
        MAK = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"ALX")]
        ALX = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"PAN")]
        PAN = 128,

        [System.Runtime.Serialization.EnumMember(Value = @"PON")]
        PON = 256,

        [System.Runtime.Serialization.EnumMember(Value = @"ABW")]
        ABW = 512,

        [System.Runtime.Serialization.EnumMember(Value = @"SE")]
        SE = 1024,

        [System.Runtime.Serialization.EnumMember(Value = @"SON")]
        SON = 2048,

        [System.Runtime.Serialization.EnumMember(Value = @"OID")]
        OID = 4096,

        [System.Runtime.Serialization.EnumMember(Value = @"DTC")]
        DTC = 8192,

        [System.Runtime.Serialization.EnumMember(Value = @"DTM")]
        DTM = 16384,

        [System.Runtime.Serialization.EnumMember(Value = @"DTQ")]
        DTQ = 32768,

        [System.Runtime.Serialization.EnumMember(Value = @"DTR")]
        DTR = 65536,

        [System.Runtime.Serialization.EnumMember(Value = @"ITR")]
        ITR = 131072,

        [System.Runtime.Serialization.EnumMember(Value = @"MID")]
        MID = 262144,

        [System.Runtime.Serialization.EnumMember(Value = @"OED")]
        OED = 524288,

        [System.Runtime.Serialization.EnumMember(Value = @"OET")]
        OET = 1048576,

        [System.Runtime.Serialization.EnumMember(Value = @"OOR")]
        OOR = 2097152,

        [System.Runtime.Serialization.EnumMember(Value = @"SME")]
        SME = 4194304,

        [System.Runtime.Serialization.EnumMember(Value = @"USM")]
        USM = 8388608,

        [System.Runtime.Serialization.EnumMember(Value = @"AAM")]
        AAM = 16777216,

        [System.Runtime.Serialization.EnumMember(Value = @"CFR")]
        CFR = 33554432,

        [System.Runtime.Serialization.EnumMember(Value = @"DOM")]
        DOM = 67108864,

        [System.Runtime.Serialization.EnumMember(Value = @"FOR")]
        FOR = 134217728,

        [System.Runtime.Serialization.EnumMember(Value = @"USG")]
        USG = 268435456,

        [System.Runtime.Serialization.EnumMember(Value = @"MAT")]
        MAT = 536870912,

        [System.Runtime.Serialization.EnumMember(Value = @"NLR")]
        NLR = 1073741824,

        [System.Runtime.Serialization.EnumMember(Value = @"DDS")]
        DDS = -2147483648,

    }
    
    [System.Flags]
    public enum CommodityCodeTypeCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"outbound")]
        Outbound = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"inbound")]
        Inbound = 2,

    }
    
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
}
