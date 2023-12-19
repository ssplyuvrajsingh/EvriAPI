using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class OrderTransport
{
    public int OrderId { get; set; }

    public int OrderOriginator { get; set; }

    public int OrderOriginatorUnitId { get; set; }

    public int PurchaseOrderId { get; set; }

    public string Status { get; set; } = null!;
}
