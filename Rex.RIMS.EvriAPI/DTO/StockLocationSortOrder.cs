using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockLocationSortOrder
{
    public string Code { get; set; } = null!;

    public int Sequence { get; set; }

    public string SubType { get; set; } = null!;

    public int CompanyId { get; set; }
}
