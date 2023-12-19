using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class InvoiceLine
{
    public int InvoiceLineId { get; set; }

    public string Invoice { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public bool UpdateStock { get; set; }

    public string? StockCode { get; set; }

    public string? Description { get; set; }

    public string? Note { get; set; }

    public string CustomerAccount { get; set; } = null!;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal CostValue { get; set; }

    public decimal SalesValue { get; set; }

    public DateTime InvoiceDate { get; set; }

    public short Discount { get; set; }

    public string UserId { get; set; } = null!;

    public short Vat { get; set; }

    public int? StockReturnId { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;

    public virtual Invoice InvoiceNavigation { get; set; } = null!;
}
