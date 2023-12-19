using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockRequestList
{
    public string StockCode { get; set; } = null!;

    public string? Binlocation { get; set; }

    public string Barcode { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public int WarehouseStock { get; set; }

    public int OuterCartonStockAmount { get; set; }

    public Guid Rowguid { get; set; }
}
