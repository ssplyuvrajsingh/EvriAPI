using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class DotcomCategory
{
    public int Tid { get; set; }

    public string Name { get; set; } = null!;

    public int GroupId { get; set; }

    public bool? DotcomSpecial { get; set; }

    public bool PressAccess { get; set; }

    public virtual DotcomRangeCategory? DotcomRangeCategory { get; set; }
}
