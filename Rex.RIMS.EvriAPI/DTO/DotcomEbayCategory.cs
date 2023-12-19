using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class DotcomEbayCategory
{
    public int Tid { get; set; }

    public int EBayCategoryId { get; set; }

    public long? StoreCategoryId { get; set; }

    public bool SecondaryOverride { get; set; }
}
