using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class OrderLineImported
{
    public int OrderLineId { get; set; }

    public int Originator { get; set; }

    public int OriginatorUnitId { get; set; }

    public int ImportedOrderLineId { get; set; }
}
