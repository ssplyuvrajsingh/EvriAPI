using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class ImportedOrderForAllocate
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public int ImportedOrderId { get; set; }

    public string Status { get; set; } = null!;

    public string? ErrorMessage { get; set; }
}
