using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockView
{
    public string StockCode { get; set; } = null!;

    public string SupplierCode { get; set; } = null!;

    public string Barcode { get; set; } = null!;

    public decimal SalePrice { get; set; }

    public decimal MarketValue { get; set; }

    public decimal NetCost { get; set; }

    public decimal SterlingCost { get; set; }

    public decimal CostMultiplier { get; set; }

    public int QuantityBreak { get; set; }

    public decimal QuantityBreakPrice { get; set; }

    public int MinimumSaleStockAmount { get; set; }

    public int? MinimumOnlineQuantity { get; set; }

    public int UnitId { get; set; }

    public string? EecCommCode { get; set; }

    public string? AltCommCode { get; set; }

    public decimal EecUnitMass { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? LastModified { get; set; }

    public bool Migrated { get; set; }

    public bool Deleted { get; set; }

    public bool Discounted { get; set; }

    public bool? Ukonly { get; set; }

    public bool Recommended { get; set; }

    public bool Hidden { get; set; }

    public string? HiddenReason { get; set; }

    public byte[] TimeStampId { get; set; } = null!;

    public int? MaterialId { get; set; }

    public bool? ShowOnWebSite { get; set; }

    public decimal? DiscountPrice { get; set; }

    public int? DiscountPriceBreakQuantity { get; set; }

    public decimal? RetailPrice { get; set; }

    public decimal? RetailPriceEur { get; set; }

    public decimal? Rrp { get; set; }

    public decimal? AmazonPrice { get; set; }

    public bool? RetailHidden { get; set; }

    public string? RetailHiddenReason { get; set; }

    public bool? AmazonMerchantSupplied { get; set; }

    public decimal? SuggestedPrice { get; set; }

    public bool? RetailTemporaryOutOfStock { get; set; }

    public bool PremiumProduct { get; set; }

    public bool? RestrictExport { get; set; }

    public bool? RestrictUk { get; set; }

    public string? EBayTitle { get; set; }

    public string? EBayDescription { get; set; }

    public decimal? EBayPrice { get; set; }

    public bool? EBayHidden { get; set; }

    public string? EBayHiddenReason { get; set; }

    public bool? EBayFreeShipping { get; set; }

    public int? EBayMaxQuantity { get; set; }

    public bool? EBayIgnoreQuantityUpdate { get; set; }

    public bool? EBayAutoDetermineCategories { get; set; }

    public int? EBayPrimaryCategoryId { get; set; }

    public int? EBaySecondaryCategoryId { get; set; }

    public long? EBayStorePrimaryCategoryId { get; set; }

    public long? EBayStoreSecondaryCategoryId { get; set; }

    public int? ShortDescriptionId { get; set; }

    public int? ExtendedDescriptionId { get; set; }

    public int? RetailShortDescriptionId { get; set; }

    public int? RetailExtendedDescriptionId { get; set; }

    public int? DotcomgiftshopUrlId { get; set; }

    public int? CareInstructionsId { get; set; }

    public DateTime? FinalArtworkApproved { get; set; }

    public DateTime? ProductionSampleApproved { get; set; }

    public DateTime? DeliveryDateConfirmed { get; set; }

    public DateTime? ShippingDateConfirmed { get; set; }

    public DateTime? ReorderPlaced { get; set; }

    public DateTime? ReorderProductionSamplesApproved { get; set; }

    public DateTime? ReorderShippingDateConfirmed { get; set; }

    public DateTime? ReorderDeliveryDateConfirmed { get; set; }

    public DateTime? DotcomCatAdded { get; set; }

    public bool RemoveFromRoyalMail { get; set; }

    public bool RemoveFromUkmail { get; set; }

    public Guid XfsSynchronizationKeyId { get; set; }

    public string? Fsccertificate { get; set; }

    public bool IsDotcomgiftshop { get; set; }

    public bool IsRexLondon { get; set; }

    public bool TemporaryOutOfStock { get; set; }

    public DateTime? TemporaryOutOfStockDate { get; set; }

    public bool? IsUnpublished { get; set; }

    public int? FscdescriptionId { get; set; }

    public string? Fscclassification { get; set; }

    public bool AllowDropShipped { get; set; }

    public int? CountryId { get; set; }

    public bool UseSecondaryGtnforPurchaseOrder { get; set; }

    public int? DetailedProductMaterialsId { get; set; }

    public int? DetailedPackagingMaterialsId { get; set; }

    public decimal? ValueRelativeScore { get; set; }

    public decimal? UnitsRelativeScore { get; set; }

    public decimal? DistributionRelativeScore { get; set; }

    public decimal? TotalRelativeScore { get; set; }

    public string? Notes { get; set; }

    public string? CustomsDescription { get; set; }

    public bool UseSecondaryMeasurementForPurchaseOrder { get; set; }

    public string? SupplierCode2 { get; set; }

    public string? Binlocation { get; set; }

    public int WarehouseStock { get; set; }

    public int BackorderStock { get; set; }

    public int AllocatedStock { get; set; }

    public DateTime? LastSaleDate { get; set; }

    public DateTime? LastDeliveryDate { get; set; }

    public int? LastDeliveryStockAmount { get; set; }

    public int SupplierLeadTime { get; set; }

    public DateTime? SupplierNextDeliveryDate { get; set; }

    public DateTime? SupplierLastReceivedStock { get; set; }

    public DateTime? SupplierFirstDeliveryDate { get; set; }

    public int ReservedStock { get; set; }

    public int? SupplierId { get; set; }

    public DateTime? SupplierLastPurchaseDate { get; set; }

    public string? CashAndCarryLocation { get; set; }

    public string? RetailLocation { get; set; }

    public string? CashAndCarryLocationType { get; set; }

    public string? RetailLocationType { get; set; }

    public bool LowStockAlert { get; set; }

    public byte[] UkTimeStampId { get; set; } = null!;

    public string? EuSupplierCode2 { get; set; }

    public string? EuBinlocation { get; set; }

    public int? EuWarehouseStock { get; set; }

    public int? EuBackorderStock { get; set; }

    public int? EuAllocatedStock { get; set; }

    public DateTime? EuLastSaleDate { get; set; }

    public DateTime? EuLastDeliveryDate { get; set; }

    public int? EuLastDeliveryStockAmount { get; set; }

    public int? EuSupplierLeadTime { get; set; }

    public DateTime? EuSupplierNextDeliveryDate { get; set; }

    public DateTime? EuSupplierLastReceivedStock { get; set; }

    public DateTime? EuSupplierFirstDeliveryDate { get; set; }

    public int? EuReservedStock { get; set; }

    public int? EuSupplierId { get; set; }

    public DateTime? EuSupplierLastPurchaseDate { get; set; }

    public string? EuWholesaleLocation { get; set; }

    public string? EuRetailLocation { get; set; }

    public string? EuWholesaleLocationType { get; set; }

    public string? EuRetailLocationType { get; set; }

    public bool? EuLowStockAlert { get; set; }

    public byte[]? EuTimeStampId { get; set; }

    public decimal? ProductWidth { get; set; }

    public decimal? ProductLength { get; set; }

    public decimal? ProductHeight { get; set; }

    public decimal? ProductDiameter { get; set; }

    public decimal? ProductWeight { get; set; }

    public int? ProductStockAmount { get; set; }

    public decimal? ProductPlasticPackagingWeight { get; set; }

    public decimal? ProductExemptPlasticPackagingWeight { get; set; }

    public decimal? ProductRecycledPlasticPackagingWeight { get; set; }

    public decimal? ProductMetalsPackagingWeight { get; set; }

    public decimal? ProductGlassPackagingWeight { get; set; }

    public decimal? ProductPaperPackagingWeight { get; set; }

    public decimal? ProductWoodPackagingWeight { get; set; }

    public decimal? ShippingWidth { get; set; }

    public decimal? ShippingLength { get; set; }

    public decimal? ShippingHeight { get; set; }

    public decimal? ShippingDiameter { get; set; }

    public decimal? ShippingWeight { get; set; }

    public int? ShippingStockAmount { get; set; }

    public decimal? ShippingPlasticPackagingWeight { get; set; }

    public decimal? ShippingExemptPlasticPackagingWeight { get; set; }

    public decimal? ShippingRecycledPlasticPackagingWeight { get; set; }

    public decimal? ShippingMetalsPackagingWeight { get; set; }

    public decimal? ShippingGlassPackagingWeight { get; set; }

    public decimal? ShippingPaperPackagingWeight { get; set; }

    public decimal? ShippingWoodPackagingWeight { get; set; }

    public decimal? InnerWidth { get; set; }

    public decimal? InnerLength { get; set; }

    public decimal? InnerHeight { get; set; }

    public decimal? InnerDiameter { get; set; }

    public decimal? InnerWeight { get; set; }

    public int InnerStockAmount { get; set; }

    public decimal? InnerPlasticPackagingWeight { get; set; }

    public decimal? InnerExemptPlasticPackagingWeight { get; set; }

    public decimal? InnerRecycledPlasticPackagingWeight { get; set; }

    public decimal? InnerMetalsPackagingWeight { get; set; }

    public decimal? InnerGlassPackagingWeight { get; set; }

    public decimal? InnerPaperPackagingWeight { get; set; }

    public decimal? InnerWoodPackagingWeight { get; set; }

    public decimal? CartonWidth { get; set; }

    public decimal? CartonLength { get; set; }

    public decimal? CartonHeight { get; set; }

    public decimal? CartonDiameter { get; set; }

    public decimal? CartonWeight { get; set; }

    public int CartonStockAmount { get; set; }

    public decimal? CartonPlasticPackagingWeight { get; set; }

    public decimal? CartonExemptPlasticPackagingWeight { get; set; }

    public decimal? CartonRecycledPlasticPackagingWeight { get; set; }

    public decimal? CartonMetalsPackagingWeight { get; set; }

    public decimal? CartonGlassPackagingWeight { get; set; }

    public decimal? CartonPaperPackagingWeight { get; set; }

    public decimal? CartonWoodPackagingWeight { get; set; }

    public decimal? SubWidth { get; set; }

    public decimal? SubLength { get; set; }

    public decimal? SubHeight { get; set; }

    public decimal? SubDiameter { get; set; }

    public decimal? SubWeight { get; set; }

    public int SubStockAmount { get; set; }

    public decimal? SubPlasticPackagingWeight { get; set; }

    public decimal? SubExemptPlasticPackagingWeight { get; set; }

    public decimal? SubRecycledPlasticPackagingWeight { get; set; }

    public decimal? SubMetalsPackagingWeight { get; set; }

    public decimal? SubGlassPackagingWeight { get; set; }

    public decimal? SubPaperPackagingWeight { get; set; }

    public decimal? SubWoodPackagingWeight { get; set; }

    public decimal? InnerAdjustedWidth { get; set; }

    public decimal? InnerAdjustedLength { get; set; }

    public decimal? InnerAdjustedHeight { get; set; }

    public decimal? InnerAdjustedDiameter { get; set; }

    public decimal? InnerAdjustedWeight { get; set; }

    public int InnerAdjustedStockAmount { get; set; }

    public decimal? InnerAdjustedPlasticPackagingWeight { get; set; }

    public decimal? InnerAdjustedExemptPlasticPackagingWeight { get; set; }

    public decimal? InnerAdjustedRecycledPlasticPackagingWeight { get; set; }

    public decimal? InnerAdjustedMetalsPackagingWeight { get; set; }

    public decimal? InnerAdjustedGlassPackagingWeight { get; set; }

    public decimal? InnerAdjustedPaperPackagingWeight { get; set; }

    public decimal? InnerAdjustedWoodPackagingWeight { get; set; }

    public decimal? CartonAdjustedWidth { get; set; }

    public decimal? CartonAdjustedLength { get; set; }

    public decimal? CartonAdjustedHeight { get; set; }

    public decimal? CartonAdjustedDiameter { get; set; }

    public decimal? CartonAdjustedWeight { get; set; }

    public int CartonAdjustedStockAmount { get; set; }

    public decimal? CartonAdjustedPlasticPackagingWeight { get; set; }

    public decimal? CartonAdjustedExemptPlasticPackagingWeight { get; set; }

    public decimal? CartonAdjustedRecycledPlasticPackagingWeight { get; set; }

    public decimal? CartonAdjustedMetalsPackagingWeight { get; set; }

    public decimal? CartonAdjustedGlassPackagingWeight { get; set; }

    public decimal? CartonAdjustedPaperPackagingWeight { get; set; }

    public decimal? CartonAdjustedWoodPackagingWeight { get; set; }

    public decimal? SubAdjustedWidth { get; set; }

    public decimal? SubAdjustedLength { get; set; }

    public decimal? SubAdjustedHeight { get; set; }

    public decimal? SubAdjustedDiameter { get; set; }

    public decimal? SubAdjustedWeight { get; set; }

    public int SubAdjustedStockAmount { get; set; }

    public decimal? SubAdjustedPlasticPackagingWeight { get; set; }

    public decimal? SubAdjustedExemptPlasticPackagingWeight { get; set; }

    public decimal? SubAdjustedRecycledPlasticPackagingWeight { get; set; }

    public decimal? SubAdjustedMetalsPackagingWeight { get; set; }

    public decimal? SubAdjustedGlassPackagingWeight { get; set; }

    public decimal? SubAdjustedPaperPackagingWeight { get; set; }

    public decimal? SubAdjustedWoodPackagingWeight { get; set; }
}
