using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class PurchaseOrder
{
    public int PurchaseOrderId { get; set; }

    public string SupplierCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public string Contact { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string DeliveryName { get; set; } = null!;

    public string DeliveryAddress1 { get; set; } = null!;

    public string DeliveryAddress2 { get; set; } = null!;

    public string DeliveryAddress3 { get; set; } = null!;

    public string DeliveryAddress4 { get; set; } = null!;

    public int CurrencyId { get; set; }

    public string UserId { get; set; } = null!;

    public decimal OrderValue { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime LastUpdated { get; set; }

    public bool Migrated { get; set; }

    public bool IsPrinted { get; set; }

    public DateTime? DispatchedBy { get; set; }

    public string? Notes { get; set; }

    public bool IsDeleted { get; set; }

    public byte[] TimeStampId { get; set; } = null!;

    public DateTime? ShippedDate { get; set; }

    public Guid? ShippedBy { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public bool IsInDevelopment { get; set; }

    public string? TransportOrderId { get; set; }

    public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();

    public virtual Supplier SupplierCodeNavigation { get; set; } = null!;
}
