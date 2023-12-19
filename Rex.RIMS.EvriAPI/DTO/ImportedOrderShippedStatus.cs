using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class ImportedOrderShippedStatus
{
    public int ImportedOrderId { get; set; }

    public string OriginalOrderId { get; set; } = null!;

    public int PlatformId { get; set; }

    public string? CustomerAccount { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? ShippedDate { get; set; }

    public string? DeliveryCompany { get; set; }

    public string? TrackingNumber { get; set; }
}
