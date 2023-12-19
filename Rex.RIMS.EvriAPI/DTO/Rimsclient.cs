using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Rimsclient
{
    public string MachineName { get; set; } = null!;

    public string Application { get; set; } = null!;

    public string? Ipaddress { get; set; }

    public Guid UserId { get; set; }

    public string Username { get; set; } = null!;

    public string InstalledVersion { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? LastUpdatedDate { get; set; }
}
