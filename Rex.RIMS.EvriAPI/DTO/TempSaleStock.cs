using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class TempSaleStock
{
    public string StockCode { get; set; } = null!;

    public decimal? RetailPrice { get; set; }

    public decimal? Rrp { get; set; }
}
