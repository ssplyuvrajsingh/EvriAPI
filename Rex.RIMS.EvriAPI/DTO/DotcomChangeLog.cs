using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class DotcomChangeLog
{
    public int DotcomChangeLogId { get; set; }

    public int Tid { get; set; }

    public int GroupId { get; set; }

    public string? Text { get; set; }

    public string ActionName { get; set; } = null!;

    public string? Flags { get; set; }
}
