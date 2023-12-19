using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class ParcelForceOrder
{
    public int ImportedOrderId { get; set; }

    public string ConsignmentNumber { get; set; } = null!;

    public string ServiceCode { get; set; } = null!;

    public string? WeekendHandlingCode { get; set; }

    public string? AccountCode { get; set; }

    public string? SenderReference { get; set; }

    public string? CollectionId { get; set; }

    public string? ContractNumber { get; set; }

    public int? ConsignmentWeight { get; set; }

    public bool IsPrepaid { get; set; }

    public bool IsPreAdviceFile { get; set; }

    public int? ParcelForceBatchId { get; set; }

    public bool IsApi { get; set; }

    public DateTime? ShippingDate { get; set; }

    public virtual ImportedOrder ImportedOrder { get; set; } = null!;

    public virtual ParcelForceBatch? ParcelForceBatch { get; set; }

    public virtual ICollection<ParcelForceParcel> ParcelForceParcels { get; set; } = new List<ParcelForceParcel>();
}
