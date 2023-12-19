using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class TotalOutstanding
{
    public int Year { get; set; }

    public int Month { get; set; }

    public decimal Outstanding { get; set; }

    public DateTime CreatedDate { get; set; }
}
