using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class PurchaseOrderItem
{
    public int PurchaseOrderItemId { get; set; }

    public int PurchaseOrderId { get; set; }

    public string SupplierCode { get; set; } = null!;

    public short LineType { get; set; }

    public string? StockCode { get; set; }

    public int? UnitId { get; set; }

    public string? PartCode { get; set; }

    public string? Description { get; set; }

    public string? StockCategory { get; set; }

    public int Quantity { get; set; }

    public int Supplied { get; set; }

    public decimal Price { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? Barcode { get; set; }

    public string? Note { get; set; }

    public Guid? Guid { get; set; }

    public byte[] TimeStampId { get; set; } = null!;

    public Guid TlsSynchronizationKeyId { get; set; }

    public string? BatchNumber { get; set; }

    public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;
}
