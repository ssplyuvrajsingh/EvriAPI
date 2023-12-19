using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class AmazonFbaFix
{
    public int FixId { get; set; }

    public string Invoice { get; set; } = null!;
}
