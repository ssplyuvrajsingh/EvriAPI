using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockReceived
{
    public int StockReceivedId { get; set; }

    public string StockCode { get; set; } = null!;

    public DateTime LastDeliveryDate { get; set; }

    public int? QuantityReceived { get; set; }
}
