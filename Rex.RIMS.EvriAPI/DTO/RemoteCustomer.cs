using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class RemoteCustomer
{
    public string CustomerAccount { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
