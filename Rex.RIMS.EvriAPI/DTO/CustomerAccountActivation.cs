using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CustomerAccountActivation
{
    public int Id { get; set; }

    public string CustomerAccount { get; set; } = null!;

    public bool IsEmailConfirmed { get; set; }

    public DateTime ConfirmedDate { get; set; }
}
