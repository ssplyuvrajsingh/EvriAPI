using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Role
{
    public string Rolename { get; set; } = null!;

    public string ApplicationName { get; set; } = null!;

    public bool? IsSystemAdmin { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;
}
