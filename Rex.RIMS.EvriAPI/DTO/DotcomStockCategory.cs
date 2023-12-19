using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class DotcomStockCategory
{
    public string Stockcode { get; set; } = null!;

    public int Tid { get; set; }

    public virtual Stock StockcodeNavigation { get; set; } = null!;
}
