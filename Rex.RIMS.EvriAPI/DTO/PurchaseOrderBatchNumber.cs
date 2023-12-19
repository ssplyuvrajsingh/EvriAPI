using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class PurchaseOrderBatchNumber
{
    public string StockCode { get; set; } = null!;

    public string BatchNumber { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
