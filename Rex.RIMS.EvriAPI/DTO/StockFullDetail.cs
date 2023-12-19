using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockFullDetail
{
    public string StockCode { get; set; } = null!;

    public string? NameEnglish { get; set; }

    public string? NameFrench { get; set; }

    public string? Namegerman { get; set; }

    public string? DescriptionEnglish { get; set; }

    public string? DescriptionFrench { get; set; }

    public string? DescriptionGerman { get; set; }

    public string SupplierCode { get; set; } = null!;

    public string Barcode { get; set; } = null!;

    public decimal SalePrice { get; set; }

    public int QuantityBreak { get; set; }

    public decimal QuantityBreakPrice { get; set; }

    public decimal? DiscountPrice { get; set; }

    public int? DiscountPriceBreakQuantity { get; set; }

    public int WarehouseStock { get; set; }

    public int BackOrderStock { get; set; }

    public int AllocatedStock { get; set; }

    public int? OnOrderStock { get; set; }

    public int MinimumSaleStockAmount { get; set; }

    public string Unit { get; set; } = null!;

    public bool Deleted { get; set; }

    public int ReservedStock { get; set; }

    public bool Discounted { get; set; }

    public bool Recommended { get; set; }

    public bool Hidden { get; set; }

    public bool PremiumProduct { get; set; }

    public bool LowStockAlert { get; set; }

    public string? CareInstructionsEnglish { get; set; }

    public string? CareInstructionsFrench { get; set; }

    public string? CareInstructionsGerman { get; set; }

    public string MaterialEnglish { get; set; } = null!;

    public string MaterialFrench { get; set; } = null!;

    public string MaterialGerman { get; set; } = null!;

    public int? MinimumOnlineQuantity { get; set; }

    public string? DotcomgiftshopEnglishUrl { get; set; }

    public string? DotcomgiftshopFrenchUrl { get; set; }

    public string? DotcomgiftshopGermanUrl { get; set; }

    public decimal? Width { get; set; }

    public decimal? Length { get; set; }

    public decimal? Height { get; set; }

    public decimal? Diameter { get; set; }

    public decimal? Weight { get; set; }

    public int Inner { get; set; }

    public int Carton { get; set; }

    public DateTime? NextDeliveryDate { get; set; }

    public bool TemporaryOutOfStock { get; set; }

    public DateTime? TemporaryOutOfStockDate { get; set; }

    public bool? RestrictExport { get; set; }

    public bool? RestrictUk { get; set; }

    public bool AllowDropShipped { get; set; }

    public bool? OutOfStock { get; set; }

    public bool? OutOfStockPermanent { get; set; }

    public decimal? RetailPrice { get; set; }

    public decimal? Rrp { get; set; }

    public int? CatalogId { get; set; }

    public string? RetailNameEnglish { get; set; }

    public string? RetailDescriptionEnglish { get; set; }
}
