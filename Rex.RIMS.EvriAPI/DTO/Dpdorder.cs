using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Dpdorder
{
    public int ImportedOrderId { get; set; }

    public string ServiceCode { get; set; } = null!;

    public string ParcelTrackingNo { get; set; } = null!;

    public int ParcelCount { get; set; }

    public string AccountCode { get; set; } = null!;

    public double Weight { get; set; }

    public string BarcodeContent { get; set; } = null!;

    public bool IsPreAdviceFile { get; set; }

    public int? DpdbatchId { get; set; }

    public string? DeliveryInstructions { get; set; }

    public int ParcelNumber { get; set; }

    public virtual Dpdbatch? Dpdbatch { get; set; }

    public virtual ImportedOrder ImportedOrder { get; set; } = null!;
}
