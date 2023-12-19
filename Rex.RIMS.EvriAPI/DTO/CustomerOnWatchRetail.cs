using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CustomerOnWatchRetail
{
    public int CustomerOnWatchId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Postcode { get; set; }

    public int ImportedOrderId { get; set; }
}
