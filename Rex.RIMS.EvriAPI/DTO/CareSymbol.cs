using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CareSymbol
{
    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public int Sequence { get; set; }
}
