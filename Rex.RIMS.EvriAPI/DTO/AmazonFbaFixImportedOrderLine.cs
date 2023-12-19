using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class AmazonFbaFixImportedOrderLine
{
    public int FixId { get; set; }

    public int ImportedOrderLineId { get; set; }
}
