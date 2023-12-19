using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockAmount
{
    public string StockCode { get; set; } = null!;

    public string? Name { get; set; }

    public bool Deleted { get; set; }

    public int CompanyId { get; set; }

    public int Warehouse { get; set; }

    public int Allocated { get; set; }

    public int BackOrder { get; set; }

    public int Reserved { get; set; }

    public int OnOrder { get; set; }

    public int? WarehouseCalculated { get; set; }

    public int AllocatedCalculated { get; set; }

    public int BackOrderCalculated { get; set; }

    public int? ReservedCalculated { get; set; }
}
