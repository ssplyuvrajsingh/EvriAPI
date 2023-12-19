using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class UnpaidOrder
{
    public int OrderId { get; set; }

    public int Originator { get; set; }

    public int OriginatorUnitId { get; set; }

    public virtual Order Order { get; set; } = null!;
}
