using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class LowStockAlertItem
{
    public int LowStockAlertItemId { get; set; }

    public int LowStockAlertId { get; set; }

    public string StockCode { get; set; } = null!;

    public string? Description { get; set; }

    public int CartonQuantity { get; set; }

    public int Physical { get; set; }

    public int Allocated { get; set; }

    public int Available { get; set; }

    public int MinimumOnlineQuantity { get; set; }

    public DateTime? DueDate { get; set; }

    public int? OnOrder { get; set; }
}
