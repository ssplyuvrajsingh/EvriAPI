using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockMaterialDetail
{
    public string StockCode { get; set; } = null!;

    public int StockMaterialId { get; set; }

    public int DisplayOrder { get; set; }

    public virtual Stock StockCodeNavigation { get; set; } = null!;

    public virtual Material StockMaterial { get; set; } = null!;
}
