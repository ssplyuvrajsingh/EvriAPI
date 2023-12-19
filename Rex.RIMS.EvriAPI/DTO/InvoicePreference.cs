using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class InvoicePreference
{
    public int InvoicePreferenceId { get; set; }

    public string CustomerAccount { get; set; } = null!;

    public string EmailType { get; set; } = null!;
}
