using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class UkmailBatch
{
    public int UkmailBatchId { get; set; }

    public DateTime InsertedDate { get; set; }

    public string Username { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public bool ClosedForLunch { get; set; }

    public DateTime EarliestTime { get; set; }

    public DateTime LatestTime { get; set; }

    public DateTime RequestedCollectionDate { get; set; }

    public string? SpecialInstructions { get; set; }

    public string CollectionJobNumber { get; set; } = null!;

    public virtual ICollection<UkmailOrder> UkmailOrders { get; set; } = new List<UkmailOrder>();
}
