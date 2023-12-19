using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class OrderChangeLog
{
    public int Id { get; set; }

    public Guid UserId { get; set; }

    public int OrderId { get; set; }

    public int OrderOriginator { get; set; }

    public int OrderOriginatorUnitId { get; set; }

    public DateTime ChangedDate { get; set; }

    public string? Source { get; set; }

    public string? OrderStatus { get; set; }
}
