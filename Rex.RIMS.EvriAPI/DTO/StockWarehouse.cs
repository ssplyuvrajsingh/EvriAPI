using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockWarehouse
{
    public string StockCode { get; set; } = null!;

    public int CompanyId { get; set; }

    public string? Binlocation { get; set; }

    public string? WholesaleLocation { get; set; }

    public string? WholesaleLocationType { get; set; }

    public string? RetailLocation { get; set; }

    public string? RetailLocationType { get; set; }

    public int WarehouseStock { get; set; }

    public int BackOrderStock { get; set; }

    public int AllocatedStock { get; set; }

    public DateTime? LastSaleDate { get; set; }

    public DateTime? LastDeliveryDate { get; set; }

    public int? LastDeliveryStockAmount { get; set; }

    public int? SupplierId { get; set; }

    public string? SupplierCode2 { get; set; }

    public int SupplierLeadTime { get; set; }

    public DateTime? SupplierNextDeliveryDate { get; set; }

    public DateTime? SupplierLastReceivedStock { get; set; }

    public DateTime? SupplierLastPurchaseDate { get; set; }

    public DateTime? SupplierFirstDeliveryDate { get; set; }

    public int ReservedStock { get; set; }

    public bool LowStockAlert { get; set; }

    public int OriginalWarehouseStock { get; set; }

    public byte[] TimeStampId { get; set; } = null!;
}
