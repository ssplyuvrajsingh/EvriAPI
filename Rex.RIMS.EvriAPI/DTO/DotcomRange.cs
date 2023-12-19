using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class DotcomRange
{
    public int DotcomRangeId { get; set; }

    public int GroupId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DotcomRangeCategory> DotcomRangeCategories { get; set; } = new List<DotcomRangeCategory>();
}
