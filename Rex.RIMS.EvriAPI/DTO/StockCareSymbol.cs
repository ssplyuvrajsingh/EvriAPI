using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockCareSymbol
{
    public string StockCode { get; set; } = null!;

    public string CareSymbolCode { get; set; } = null!;
}
