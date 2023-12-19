using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class RemoteOrder
{
    public int OrderId { get; set; }

    public int Originator { get; set; }

    public int OriginatorUnitId { get; set; }

    public DateTime DateAdded { get; set; }
}
