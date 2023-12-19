using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class RoyalMailBatch
{
    public int RoyalMailBatchId { get; set; }

    public DateTime CollectionDate { get; set; }

    public string Number { get; set; } = null!;

    public string? Apiversion { get; set; }

    public virtual ICollection<RoyalMailOrder> RoyalMailOrders { get; set; } = new List<RoyalMailOrder>();
}
