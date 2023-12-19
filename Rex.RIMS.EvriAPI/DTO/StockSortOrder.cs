using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockSortOrder
{
    public int Id { get; set; }

    public string StockCode { get; set; } = null!;

    public int CategoryId { get; set; }

    public int SortOrder { get; set; }
}
