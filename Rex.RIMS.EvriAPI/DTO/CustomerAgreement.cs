using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CustomerAgreement
{
    public int AgreementId { get; set; }

    public string CustomerAccount { get; set; } = null!;

    public DateTime AcceptedDate { get; set; }

    public virtual Agreement Agreement { get; set; } = null!;
}
