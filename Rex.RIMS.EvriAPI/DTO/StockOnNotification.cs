using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockOnNotification
{
    public int Id { get; set; }

    public string Stockcode { get; set; } = null!;

    public string CustomerAccount { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string Url { get; set; } = null!;

    public bool IsEmailed { get; set; }

    public virtual Customer CustomerAccountNavigation { get; set; } = null!;

    public virtual Stock StockcodeNavigation { get; set; } = null!;
}
