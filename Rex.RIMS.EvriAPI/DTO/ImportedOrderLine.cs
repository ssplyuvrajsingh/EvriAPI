using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class ImportedOrderLine
{
    public string? StockCode { get; set; }

    public string? Title { get; set; }

    public int? Quantity { get; set; }

    public decimal? TotalPrice { get; set; }

    public int ImportedOrderId { get; set; }

    public string? Option { get; set; }

    public decimal? Fees { get; set; }

    public decimal? ShippingPrice { get; set; }

    public string? OriginalOrderLineId { get; set; }

    public int ImportedOrderLineId { get; set; }

    public DateTime? PickingListPickedDate { get; set; }

    public int? OriginalQuantity { get; set; }

    public int? ParcelNumber { get; set; }

    public virtual ImportedOrder ImportedOrder { get; set; } = null!;
}
