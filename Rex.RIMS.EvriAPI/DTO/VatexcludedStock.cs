using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class VatexcludedStock
{
    public string StockCode { get; set; } = null!;

    public int CompanyId { get; set; }
}
