using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockRequestListItem
{
    public string StockCode { get; set; } = null!;

    public int CartonsRequired { get; set; }
}
