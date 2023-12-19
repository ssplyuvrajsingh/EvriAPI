using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class ImportedOrderLog
{
    public int ImportedOrderLogId { get; set; }

    public int ImportedOrderId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UserName { get; set; } = null!;

    public string? ParcelServiceProvider { get; set; }

    public string? OrderStatus { get; set; }

    public virtual ImportedOrder ImportedOrder { get; set; } = null!;
}
