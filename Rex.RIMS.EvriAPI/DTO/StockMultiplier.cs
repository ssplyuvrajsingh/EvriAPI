using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockMultiplier
{
    public string StockCode { get; set; } = null!;

    public int Multiple { get; set; }
}
