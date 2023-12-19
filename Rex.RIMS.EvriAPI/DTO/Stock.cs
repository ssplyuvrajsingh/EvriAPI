using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Stock
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

    public int UnitId { get; set; }

    public string? EecCommCode { get; set; }

    public decimal EecUnitMass { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? LastModified { get; set; }

    public bool Migrated { get; set; }

    public bool Deleted { get; set; }

    public bool Discounted { get; set; }

    public bool Recommended { get; set; }

    public byte[] TimeStampId { get; set; } = null!;

    public bool Hidden { get; set; }

    public bool PremiumProduct { get; set; }

    public Guid XfsSynchronizationKeyId { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public string? HiddenReason { get; set; }

    public int? ShortDescriptionId { get; set; }

    public int? ExtendedDescriptionId { get; set; }

    public int? CareinstructionsId { get; set; }

    public int? MaterialId { get; set; }

    public int? MinimumOnlineQuantity { get; set; }

    public DateTime? FinalArtworkApproved { get; set; }

    public DateTime? ProductionSampleApproved { get; set; }

    public DateTime? ShippingDateConfirmed { get; set; }

    public DateTime? DeliveryDateConfirmed { get; set; }

    public DateTime? ReorderPlaced { get; set; }

    public DateTime? ReorderProductionSamplesApproved { get; set; }

    public DateTime? ReorderShippingDateConfirmed { get; set; }

    public DateTime? ReorderDeliveryDateConfirmed { get; set; }

    public DateTime? DotcomCatAdded { get; set; }

    public bool RemoveFromRoyalMail { get; set; }

    public bool RemoveFromUkmail { get; set; }

    public string? Fsccertificate { get; set; }

    public bool IsDotcomgiftshop { get; set; }

    public bool IsRexLondon { get; set; }

    public bool TemporaryOutOfStock { get; set; }

    public DateTime? TemporaryOutOfStockDate { get; set; }

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

    public DateTime? Scored { get; set; }

    public string? Notes { get; set; }

    public string? CustomsDescription { get; set; }

    public string? AltCommCode { get; set; }

    public bool UseSecondaryMeasurementForPurchaseOrder { get; set; }

    public virtual ICollection<DotcomStockCategory> DotcomStockCategories { get; set; } = new List<DotcomStockCategory>();

    public virtual Fscdescription? Fscdescription { get; set; }

    public virtual ICollection<StockMaterialDetail> StockMaterialDetails { get; set; } = new List<StockMaterialDetail>();

    public virtual ICollection<StockOnNotification> StockOnNotifications { get; set; } = new List<StockOnNotification>();

    public virtual ICollection<AttributeValue> AttributeValues { get; set; } = new List<AttributeValue>();

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
