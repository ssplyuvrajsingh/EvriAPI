using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class OrderLine
{
    public int OrderLineId { get; set; }

    public int Originator { get; set; }

    public int OriginatorUnitId { get; set; }

    public int OrderId { get; set; }

    public int OrderOriginator { get; set; }

    public int OrderOriginatorUnitId { get; set; }

    public short LineType { get; set; }

    public string StockCode { get; set; } = null!;

    public string? Description { get; set; }

    public int QuantityOrdered { get; set; }

    public int Qts { get; set; }

    public int? QuantitySupplied { get; set; }

    public bool Foc { get; set; }

    public decimal Price { get; set; }

    public short? Discount { get; set; }

    public bool UpdateStock { get; set; }

    public bool Pnprint { get; set; }

    public decimal Cos { get; set; }

    public short Vat { get; set; }

    public string? Unit { get; set; }

    public int? CustomerId { get; set; }

    public string? CustomerAccount { get; set; }

    public bool Bord { get; set; }

    public string ProdType { get; set; } = null!;

    public string? Binlocation { get; set; }

    public string SupplierCode { get; set; } = null!;

    public bool Migrated { get; set; }

    public string? Note { get; set; }

    public int? StockReturnId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public byte[] TimeStampId { get; set; } = null!;

    public bool IsReserved { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public bool IsInvoiced { get; set; }

    public string? Boxes { get; set; }

    public virtual Order Order { get; set; } = null!;
}
