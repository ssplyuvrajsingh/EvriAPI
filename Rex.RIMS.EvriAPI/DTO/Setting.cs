using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Setting
{
    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
