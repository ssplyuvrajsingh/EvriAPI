using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Currency
{
    public int CurrencyId { get; set; }

    public string Shortname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? LongName { get; set; }

    public decimal ExchangeRate { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;

    public decimal RetailExchangeRate { get; set; }

    public string? FormatProvider { get; set; }

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();

    public virtual ICollection<ImportedOrder> ImportedOrders { get; set; } = new List<ImportedOrder>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
