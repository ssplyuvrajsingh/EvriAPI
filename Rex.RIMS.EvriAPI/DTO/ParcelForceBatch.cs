using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class ParcelForceBatch
{
    public int ParcelForceBatchId { get; set; }

    public string BatchNumber { get; set; } = null!;

    public DateTime CollectionDate { get; set; }

    public virtual ICollection<ParcelForceOrder> ParcelForceOrders { get; set; } = new List<ParcelForceOrder>();
}
