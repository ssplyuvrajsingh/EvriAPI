using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class ParcelForceParcel
{
    public int ParcelForceParcelId { get; set; }

    public int ImportedOrderId { get; set; }

    public int Sequence { get; set; }

    public string ParcelNumber { get; set; } = null!;

    public int ParcelWeight { get; set; }

    public virtual ParcelForceOrder ImportedOrder { get; set; } = null!;
}
