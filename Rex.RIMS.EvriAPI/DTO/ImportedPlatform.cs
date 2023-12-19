using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class ImportedPlatform
{
    public int PlatformId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ImportedOrder> ImportedOrders { get; set; } = new List<ImportedOrder>();
}
