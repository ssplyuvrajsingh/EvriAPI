using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class RoyalMailOrder
{
    public int ImportedOrderId { get; set; }

    public string ServiceCode { get; set; } = null!;

    public string TrackingNumber { get; set; } = null!;

    public int ParcelCount { get; set; }

    public int Weight { get; set; }

    public bool IsPreAdviceFile { get; set; }

    public int? RoyalMailBatchId { get; set; }

    public string? SafeplaceText { get; set; }

    public bool WithSignature { get; set; }

    public virtual ImportedOrder ImportedOrder { get; set; } = null!;

    public virtual RoyalMailBatch? RoyalMailBatch { get; set; }
}
