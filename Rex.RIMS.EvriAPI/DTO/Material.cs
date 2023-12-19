using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Material
{
    public int MaterialId { get; set; }

    public int? StringId { get; set; }

    public virtual ICollection<StockMaterialDetail> StockMaterialDetails { get; set; } = new List<StockMaterialDetail>();
}
