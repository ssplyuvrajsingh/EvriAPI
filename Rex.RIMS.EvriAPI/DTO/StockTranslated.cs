using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockTranslated
{
    public string StockCode { get; set; } = null!;

    public int? TradeShortDescriptionId { get; set; }

    public int? TradeExtendedDescriptionId { get; set; }

    public int? DetailedProductMaterialsId { get; set; }

    public int? DetailedPackagingMaterialsId { get; set; }

    public int? RetailShortDescriptionId { get; set; }

    public int? RetailExtendedDescriptionId { get; set; }

    public int? DotcomgiftshopUrlId { get; set; }

    public string? TradeShortDescriptionEnglish { get; set; }

    public string? TradeShortDescriptionFrench { get; set; }

    public string? TradeShortDescriptionGerman { get; set; }

    public string? TradeShortDescriptionSpanish { get; set; }

    public string? TradeExtendedDescriptionEnglish { get; set; }

    public string? TradeExtendedDescriptionFrench { get; set; }

    public string? TradeExtendedDescriptionGerman { get; set; }

    public string? TradeExtendedDescriptionSpanish { get; set; }

    public string? RetailShortDescriptionEnglish { get; set; }

    public string? RetailShortDescriptionFrench { get; set; }

    public string? RetailShortDescriptionGerman { get; set; }

    public string? RetailShortDescriptionSpanish { get; set; }

    public string? RetailExtendedDescriptionEnglish { get; set; }

    public string? RetailExtendedDescriptionFrench { get; set; }

    public string? RetailExtendedDescriptionGerman { get; set; }

    public string? RetailExtendedDescriptionSpanish { get; set; }

    public string? DotcomgiftshopUrlEnglish { get; set; }

    public string? DotcomgiftshopUrlFrench { get; set; }

    public string? DotcomgiftshopUrlGerman { get; set; }

    public string? DotcomgiftshopUrlSpanish { get; set; }

    public string? DetailedProductMaterialsEnglish { get; set; }

    public string? DetailedProductMaterialsFrench { get; set; }

    public string? DetailedProductMaterialsGerman { get; set; }

    public string? DetailedProductMaterialsSpanish { get; set; }

    public string? DetailedPackagingMaterialsEnglish { get; set; }

    public string? DetailedPackagingMaterialsFrench { get; set; }

    public string? DetailedPackagingMaterialsGerman { get; set; }

    public string? DetailedPackagingMaterialsSpanish { get; set; }
}
