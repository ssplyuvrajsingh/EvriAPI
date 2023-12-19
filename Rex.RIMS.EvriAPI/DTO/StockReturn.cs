using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockReturn
{
    public int StockReturnId { get; set; }

    public string Reason { get; set; } = null!;

    public string? Description { get; set; }
}
