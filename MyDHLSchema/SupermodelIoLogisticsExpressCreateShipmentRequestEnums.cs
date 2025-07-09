using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDHLSchema
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
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
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
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
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
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
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
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
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
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
}
