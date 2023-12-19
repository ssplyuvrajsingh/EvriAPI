using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class RlapiPrinter
{
    public int PrinterId { get; set; }

    public string ComputerName { get; set; } = null!;

    public string PrinterName { get; set; } = null!;

    public string PrinterFriendlyName { get; set; } = null!;

    public bool IsEnabled { get; set; }
}
