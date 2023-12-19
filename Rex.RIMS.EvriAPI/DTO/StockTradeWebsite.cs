using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockTradeWebsite
{
    public string StockCode { get; set; } = null!;

    public bool ShowOnWebsite { get; set; }

    public decimal? DiscountPrice { get; set; }

    public int? DiscountPriceBreakQuantity { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;

    public bool? RestrictExport { get; set; }

    public bool RestrictUk { get; set; }
}
