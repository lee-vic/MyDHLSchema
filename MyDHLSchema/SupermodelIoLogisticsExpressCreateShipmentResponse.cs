// 这是国际快递行业 DHL CreateShipment 的响应实体类，字段涵盖运单、包裹、费用、条码、地址等信息。
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MyDHLSchema
{
    /// <summary>
    /// DHL国际快递运单创建响应主实体
    /// </summary>
    public class SupermodelIoLogisticsExpressCreateShipmentResponse
    {
        /// <summary>
        /// 请求发送的目标URL
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 包裹的运单号（Shipment Identification Number）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shipmentTrackingNumber")]
        public string ShipmentTrackingNumber { get; set; } = default!;

        /// <summary>
        /// 如果申请了取件服务，可通过此URL取消取件
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("cancelPickupUrl")]
        public string CancelPickupUrl { get; set; } = default!;

        /// <summary>
        /// 可用于查询包裹物流轨迹的URL
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("trackingUrl")]
        public string TrackingUrl { get; set; } = default!;

        /// <summary>
        /// 如果申请了取件服务，此处返回取件确认号（Dispach Confirmation Number）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("dispatchConfirmationNumber")]
        public string DispatchConfirmationNumber { get; set; } = default!;

        /// <summary>
        /// 所有包裹的详细信息，如包裹识别码等
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("packages")]
        [System.ComponentModel.DataAnnotations.MaxLength(999)]
        public System.Collections.Generic.ICollection<Package> Packages { get; set; } = default!;

        /// <summary>
        /// 所有为该运单生成的单据，如运单标签、发票、收据等
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("documents")]
        public System.Collections.Generic.ICollection<ShipmentDocument> Documents { get; set; } = default!;

        /// <summary>
        /// 按需派送（ODD）服务的URL（如有申请）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("onDemandDeliveryURL")]
        public string OnDemandDeliveryURL { get; set; } = default!;

        /// <summary>
        /// 额外的运单相关信息（如在请求中指定）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shipmentDetails")]
        public System.Collections.Generic.ICollection<ShipmentDetails> ShipmentDetails { get; set; } = default!;

        /// <summary>
        /// 运单相关的费用信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shipmentCharges")]
        public System.Collections.Generic.ICollection<ShipmentCharge> ShipmentCharges { get; set; } = default!;

        /// <summary>
        /// 运单的条码信息（Base64编码）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("barcodeInfo")]
        public BarcodeInfo BarcodeInfo { get; set; } = default!;

        /// <summary>
        /// 预计送达日期相关信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("estimatedDeliveryDate")]
        public EstimatedDeliveryDateInfo EstimatedDeliveryDate { get; set; } = default!;

        /// <summary>
        /// 可能的警告信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public System.Collections.Generic.ICollection<string> Warnings { get; set; } = default!;

    }
    
    /// <summary>
    /// 包裹信息实体，包含包裹序号、识别码、体积重量等
    /// </summary>
    public class Package
    {
        /// <summary>
        /// 包裹序号
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("referenceNumber")]
        [System.ComponentModel.DataAnnotations.Range(1D, 999D)]
        public double ReferenceNumber { get; set; } = default!;

        /// <summary>
        /// 包裹识别码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("trackingNumber")]
        [System.ComponentModel.DataAnnotations.Required]
        public string TrackingNumber { get; set; } = default!;

        /// <summary>
        /// 可通过包裹识别码查询物流轨迹的URL
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("trackingUrl")]
        public string TrackingUrl { get; set; } = default!;

        /// <summary>
        /// 包裹的体积/尺寸重量
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("volumetricWeight")]
        public double VolumetricWeight { get; set; } = default!;

        /// <summary>
        /// 包裹二维码相关单据
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("documents")]
        public System.Collections.Generic.ICollection<PackageDocument> Documents { get; set; } = default!;

    }
    
    /// <summary>
    /// 运单相关单据实体，如标签、发票等
    /// </summary>
    public class ShipmentDocument
    {
        /// <summary>
        /// 单据图片格式，如PDF、JPG等
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("imageFormat")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ImageFormat { get; set; } = default!;

        /// <summary>
        /// 单据图片的Base64编码内容
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 单据类型，如发票、标签、收据等
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string TypeCode { get; set; } = default!;

        /// <summary>
        /// 包裹序号
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("packageReferenceNumber")]
        [System.ComponentModel.DataAnnotations.Range(1D, 999D)]
        public double PackageReferenceNumber { get; set; } = default!;

    }
    
    /// <summary>
    /// 运单详细信息，包括服务代码、计费、客户信息等
    /// </summary>
    public class ShipmentDetails
    {
        /// <summary>
        /// DHL特殊处理服务代码列表
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("serviceHandlingFeatureCodes")]
        public System.Collections.Generic.ICollection<string> ServiceHandlingFeatureCodes { get; set; } = default!;

        /// <summary>
        /// 根据请求中尺寸计算出的体积重量
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("volumetricWeight")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 999999999999D)]
        public double VolumetricWeight { get; set; } = default!;

        /// <summary>
        /// 运单应用的计费代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("billingCode")]
        public string BillingCode { get; set; } = default!;

        /// <summary>
        /// 运单内容代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("serviceContentCode")]
        public string ServiceContentCode { get; set; } = default!;

        /// <summary>
        /// 运单相关的客户信息（发货人、收件人等）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customerDetails")]
        public CustomerDetailsInfo CustomerDetails { get; set; } = default!;

        /// <summary>
        /// 始发服务区信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("originServiceArea")]
        public OriginServiceArea OriginServiceArea { get; set; } = default!;

        /// <summary>
        /// 目的服务区信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("destinationServiceArea")]
        public DestinationServiceArea DestinationServiceArea { get; set; } = default!;

        /// <summary>
        /// DHL路由代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("dhlRoutingCode")]
        public string DhlRoutingCode { get; set; } = default!;

        /// <summary>
        /// DHL路由数据ID
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("dhlRoutingDataId")]
        public string DhlRoutingDataId { get; set; } = default!;

        /// <summary>
        /// 送达日期代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("deliveryDateCode")]
        public string DeliveryDateCode { get; set; } = default!;

        /// <summary>
        /// 送达时间代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("deliveryTimeCode")]
        public string DeliveryTimeCode { get; set; } = default!;

        /// <summary>
        /// 产品简称
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("productShortName")]
        public string ProductShortName { get; set; } = default!;

        /// <summary>
        /// 增值服务列表
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("valueAddedServices")]
        [System.ComponentModel.DataAnnotations.MaxLength(99)]
        public System.Collections.Generic.ICollection<ValueAddedService> ValueAddedServices { get; set; } = default!;

        /// <summary>
        /// 取件相关信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pickupDetails")]
        public PickupDetails PickupDetails { get; set; } = default!;

    }
    
    /// <summary>
    /// 运单费用实体，包含币种、价格、服务明细等
    /// </summary>
    public class ShipmentCharge
    {
        /// <summary>
        /// 可能的取值：
        /// - 'BILLC'：计费币种
        /// - 'PULCL'：国家公开价格币种
        /// - 'BASEC'：基础币种
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("currencyType")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string CurrencyType { get; set; } = default!;

        /// <summary>
        /// 运单费用所用币种
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("priceCurrency")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PriceCurrency { get; set; } = default!;

        /// <summary>
        /// DHL产品和服务的价格金额
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public double Price { get; set; } = default!;

        /// <summary>
        /// 费用明细列表
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("serviceBreakdown")]
        public System.Collections.Generic.ICollection<ServiceBreakdown> ServiceBreakdown { get; set; } = default!;

    }
    
    /// <summary>
    /// 条码信息实体，包含运单号、服务区、路由等条码内容
    /// </summary>
    public class BarcodeInfo
    {
        /// <summary>
        /// 运单号条码（Base64编码）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shipmentIdentificationNumberBarcodeContent")]
        public string ShipmentIdentificationNumberBarcodeContent { get; set; } = default!;

        /// <summary>
        /// 始发/目的服务区代码及产品代码条码（Base64编码）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("originDestinationServiceTypeBarcodeContent")]
        public string OriginDestinationServiceTypeBarcodeContent { get; set; } = default!;

        /// <summary>
        /// DHL路由代码条码（Base64编码）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("routingBarcodeContent")]
        public string RoutingBarcodeContent { get; set; } = default!;

        /// <summary>
        /// 每个包裹的条码详情
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("trackingNumberBarcodes")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(999)]
        public System.Collections.Generic.ICollection<TrackingNumberBarcode> TrackingNumberBarcodes { get; set; } = default!;

    }
    
    /// <summary>
    /// 预计送达日期信息实体
    /// </summary>
    public class EstimatedDeliveryDateInfo
    {
        /// <summary>
        /// 预计送达日期
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("estimatedDeliveryDate")]
        public string EstimatedDeliveryDate { get; set; } = default!;

        /// <summary>
        /// 预计送达类型（EDD type）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("estimatedDeliveryType")]
        public string EstimatedDeliveryType { get; set; } = default!;

    }
    
    /// <summary>
    /// 包裹二维码相关单据实体
    /// </summary>
    public class PackageDocument
    {
        /// <summary>
        /// 单据图片格式，如PNG等
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("imageFormat")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ImageFormat { get; set; } = default!;

        /// <summary>
        /// 单据图片的Base64编码内容
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 二维码类型
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string TypeCode { get; set; } = default!;

    }
    
    /// <summary>
    /// 客户信息，包括发货人和收件人
    /// </summary>
    public class CustomerDetailsInfo
    {
        /// <summary>
        /// 发货人信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shipperDetails")]
        public ShipperDetails ShipperDetails { get; set; } = default!;

        /// <summary>
        /// 收件人信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("receiverDetails")]
        public ReceiverDetails ReceiverDetails { get; set; } = default!;

    }
    
    /// <summary>
    /// 发货人详细信息
    /// </summary>
    public class ShipperDetails
    {
        /// <summary>
        /// 发货人地址信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("postalAddress")]
        public SupermodelIoLogisticsExpressAddressCreateShipmentResponse PostalAddress { get; set; } = default!;

        /// <summary>
        /// 发货人联系方式
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("contactInformation")]
        public SupermodelIoLogisticsExpressContactCreateShipmentResponse ContactInformation { get; set; } = default!;

    }
    
    /// <summary>
    /// 始发服务区信息
    /// </summary>
    public class OriginServiceArea
    {
        /// <summary>
        /// 始发地设施代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("facilityCode")]
        public string FacilityCode { get; set; } = default!;

        /// <summary>
        /// 始发服务区代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("serviceAreaCode")]
        public string ServiceAreaCode { get; set; } = default!;

        /// <summary>
        /// 始发分拣代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("outboundSortCode")]
        public string OutboundSortCode { get; set; } = default!;

    }
    
    /// <summary>
    /// 目的服务区信息
    /// </summary>
    public class DestinationServiceArea
    {
        /// <summary>
        /// 目的地设施代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("facilityCode")]
        public string FacilityCode { get; set; } = default!;

        /// <summary>
        /// 目的服务区代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("serviceAreaCode")]
        public string ServiceAreaCode { get; set; } = default!;

        /// <summary>
        /// 目的分拣代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("inboundSortCode")]
        public string InboundSortCode { get; set; } = default!;

    }
    
    /// <summary>
    /// 增值服务信息
    /// </summary>
    public class ValueAddedService
    {
        /// <summary>
        /// 增值服务代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("serviceCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ServiceCode { get; set; } = default!;

        /// <summary>
        /// 增值服务描述
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

    }
    
    /// <summary>
    /// 取件相关详细信息
    /// </summary>
    public class PickupDetails
    {
        /// <summary>
        /// 取件截止时间（本地时间）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("localCutoffDateAndTime")]
        public string LocalCutoffDateAndTime { get; set; } = default!;

        /// <summary>
        /// 取件截止时间的GMT偏移
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("cutoffTimeOffset")]
        public string CutoffTimeOffset { get; set; } = default!;

        /// <summary>
        /// DHL最早可取件时间
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pickupEarliest")]
        public string PickupEarliest { get; set; } = default!;

        /// <summary>
        /// DHL最晚可取件时间
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pickupLatest")]
        public string PickupLatest { get; set; } = default!;

        /// <summary>
        /// 当天可转运的取件截止时间，超过此时间可能影响运输时效
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pickupCutoffSameDayOutboundProcessing")]
        public string PickupCutoffSameDayOutboundProcessing { get; set; } = default!;

        /// <summary>
        /// 运输天数
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("totalTransitDays")]
        public string TotalTransitDays { get; set; } = default!;

        /// <summary>
        /// 从指定城市或邮政区域取件到服务区的额外运输天数
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pickupAdditionalDays")]
        public string PickupAdditionalDays { get; set; } = default!;

        /// <summary>
        /// 到达服务区后送达指定城市或邮政区域的额外运输天数
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("deliveryAdditionalDays")]
        public string DeliveryAdditionalDays { get; set; } = default!;

        /// <summary>
        /// 取件星期几
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pickupDayOfWeek")]
        public string PickupDayOfWeek { get; set; } = default!;

        /// <summary>
        /// 送达星期几
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("deliveryDayOfWeek")]
        public string DeliveryDayOfWeek { get; set; } = default!;

    }
    
    /// <summary>
    /// 服务费用明细
    /// </summary>
    public class ServiceBreakdown
    {
        /// <summary>
        /// 服务名称
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 服务价格金额
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public double Price { get; set; } = default!;

        /// <summary>
        /// 服务类型代码
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("typeCode")]
        public string TypeCode { get; set; } = default!;

    }
    
    /// <summary>
    /// 包裹条码信息
    /// </summary>
    public class TrackingNumberBarcode
    {
        /// <summary>
        /// 包裹序号
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("referenceNumber")]
        [System.ComponentModel.DataAnnotations.Range(1D, 999D)]
        public double ReferenceNumber { get; set; } = default!;

        /// <summary>
        /// 包裹条码内容（Base64编码）
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("trackingNumberBarcodeContent")]
        public string TrackingNumberBarcodeContent { get; set; } = default!;

    }
    
    /// <summary>
    /// 收件人详细信息
    /// </summary>
    public class ReceiverDetails
    {
        /// <summary>
        /// 收件人地址信息
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("postalAddress")]
        public SupermodelIoLogisticsExpressAddressCreateShipmentResponse PostalAddress { get; set; } = default!;

        /// <summary>
        /// 收件人联系方式
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("contactInformation")]
        public SupermodelIoLogisticsExpressContactCreateShipmentResponse ContactInformation { get; set; } = default!;

    }
    
    /// <summary>
    /// 地址信息实体，包含邮编、城市、国家等
    /// </summary>
    public class SupermodelIoLogisticsExpressAddressCreateShipmentResponse
    {
        /// <summary>
        /// 邮政编码
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("postalCode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string PostalCode { get; set; } = default!;

        /// <summary>
        /// 城市名称
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("cityName")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string CityName { get; set; } = default!;

        /// <summary>
        /// 国家代码
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string CountryCode { get; set; } = default!;

        /// <summary>
        /// 省/州代码
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("provinceCode")]
        public string ProvinceCode { get; set; } = default!;

        /// <summary>
        /// 地址第一行
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("addressLine1")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string AddressLine1 { get; set; } = default!;

        /// <summary>
        /// 地址第二行
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("addressLine2")]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string AddressLine2 { get; set; } = default!;

        /// <summary>
        /// 地址第三行
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("addressLine3")]
        [System.ComponentModel.DataAnnotations.StringLength(45, MinimumLength = 1)]
        public string AddressLine3 { get; set; } = default!;

        /// <summary>
        /// 区县名称
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("cityDistrictName")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string CityDistrictName { get; set; } = default!;

        /// <summary>
        /// 省/州名称
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("provinceName")]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string ProvinceName { get; set; } = default!;

        /// <summary>
        /// 国家名称
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("countryName")]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string CountryName { get; set; } = default!;

    }
    
    /// <summary>
    /// 联系人信息实体，包含公司名、联系人姓名
    /// </summary>
    public class SupermodelIoLogisticsExpressContactCreateShipmentResponse
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("companyName")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength = 1)]
        public string CompanyName { get; set; } = default!;

        /// <summary>
        /// 联系人姓名
        /// </summary>
        /// 
        [System.Text.Json.Serialization.JsonPropertyName("fullName")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(255, MinimumLength = 1)]
        public string FullName { get; set; } = default!;

    }
}
