using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CustomerOnWatchTrade
{
    public int CustomerOnWatchId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Postcode { get; set; }

    public string Account { get; set; } = null!;
}
