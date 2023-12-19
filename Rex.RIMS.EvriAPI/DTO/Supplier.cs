using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Supplier
{
    public string SupplierCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? ShortName { get; set; }

    public int? TradingAddressId { get; set; }

    public int? AccountsAddressId { get; set; }

    public string ChequePayee { get; set; } = null!;

    public int CurrencyId { get; set; }

    public decimal Costmultiplier { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? LastOrderedDate { get; set; }

    public bool Migrated { get; set; }

    public byte[] TimeStampId { get; set; } = null!;

    public DateTime? DeletedDate { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<SupplierAddress> SupplierAddresses { get; set; } = new List<SupplierAddress>();
}
