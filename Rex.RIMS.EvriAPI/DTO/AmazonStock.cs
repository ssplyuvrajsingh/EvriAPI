using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class AmazonStock
{
    public string StockCode { get; set; } = null!;

    public int SellableQuantity { get; set; }

    public int UnsellableQuantity { get; set; }

    public int SoldQuantity { get; set; }
}
