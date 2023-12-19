using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class PendingRegistration
{
    public string CustomerAccount { get; set; } = null!;

    public string? RegCode { get; set; }

    public string? EmailId { get; set; }

    public DateTime? RegDate { get; set; }

    public virtual Customer CustomerAccountNavigation { get; set; } = null!;
}
