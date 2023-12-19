using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class AccessControl
{
    public Guid AccessControlId { get; set; }

    public Guid ResourceId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? ApplicationName { get; set; }

    public virtual FormResource Resource { get; set; } = null!;
}
