using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class OrderReceivedBy
{
    public int OrderReceivedById { get; set; }

    public bool Visable { get; set; }

    public string OrderReceivedBy1 { get; set; } = null!;

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;
}
