using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Counter
{
    public Guid GuidId { get; set; }

    public string CounterType { get; set; } = null!;

    public int? Originator { get; set; }

    public int? OriginatorUnitId { get; set; }

    public long CounterValue { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;
}
