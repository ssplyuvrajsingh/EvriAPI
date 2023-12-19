using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class WebAccountType
{
    public int WebAccountId { get; set; }

    public string DisplayName { get; set; } = null!;

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;
}
