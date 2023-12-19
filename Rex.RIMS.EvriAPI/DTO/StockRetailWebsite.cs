using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockRetailWebsite
{
    public string StockCode { get; set; } = null!;

    public decimal? RetailPrice { get; set; }

    public decimal? Rrp { get; set; }

    public bool Hidden { get; set; }

    public int? CatalogId { get; set; }

    public Guid XfsSynchronizationKeyId { get; set; }

    public decimal? SuggestedPrice { get; set; }

    public int StockId { get; set; }

    public string? ProductUrl { get; set; }

    public string? ProductImageUrl { get; set; }

    public bool TemporaryOutOfStock { get; set; }

    public bool AmazonMerchantSupplied { get; set; }

    public bool AmazonInventorySynced { get; set; }

    public bool AmazonStockPriceSynced { get; set; }

    public decimal? AmazonPrice { get; set; }

    public string? EBayTitle { get; set; }

    public string? EBayDescription { get; set; }

    public decimal? EBayPrice { get; set; }

    public bool EBayHidden { get; set; }

    public bool EBayFreeShipping { get; set; }

    public int? EBayMaxQuantity { get; set; }

    public bool EBayIgnoreQuantityUpdate { get; set; }

    public string? HiddenReason { get; set; }

    public string? EBayHiddenReason { get; set; }

    public bool EBayAutoDetermineCategories { get; set; }

    public int? EBayPrimaryCategoryId { get; set; }

    public int? EBaySecondaryCategoryId { get; set; }

    public long? EBayStorePrimaryCategoryId { get; set; }

    public long? EBayStoreSecondaryCategoryId { get; set; }

    public bool Ukonly { get; set; }

    public int? ShortDescriptionId { get; set; }

    public int? ExtendedDescriptionId { get; set; }

    public int? CareInstructionsId { get; set; }

    public int? DotcomgiftshopUrlId { get; set; }

    public bool IsUnpublished { get; set; }

    public decimal? RetailPriceEur { get; set; }
}
