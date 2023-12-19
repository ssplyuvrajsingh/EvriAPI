using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class XmlfeedError
{
    public int XmlfeedErrorId { get; set; }

    public DateTime ErrorDate { get; set; }

    public string ErrorMessage { get; set; } = null!;

    public string? ErrorComments { get; set; }
}
