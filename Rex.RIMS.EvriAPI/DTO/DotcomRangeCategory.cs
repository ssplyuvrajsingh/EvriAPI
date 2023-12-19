using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class DotcomRangeCategory
{
    public int Tid { get; set; }

    public int DotcomRangeId { get; set; }

    public virtual DotcomRange DotcomRange { get; set; } = null!;

    public virtual DotcomCategory TidNavigation { get; set; } = null!;
}
