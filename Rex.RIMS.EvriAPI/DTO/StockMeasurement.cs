using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockMeasurement
{
    public string StockCode { get; set; } = null!;

    public string SubType { get; set; } = null!;

    public decimal? Width { get; set; }

    public decimal? Length { get; set; }

    public decimal? Height { get; set; }

    public decimal? Diameter { get; set; }

    public decimal? Weight { get; set; }

    public int? StockAmount { get; set; }

    public decimal? PlasticPackagingWeight { get; set; }

    public decimal? ExemptPlasticPackagingWeight { get; set; }

    public decimal? RecycledPlasticPackagingWeight { get; set; }

    public decimal? MetalsPackagingWeight { get; set; }

    public decimal? GlassPackagingWeight { get; set; }

    public decimal? PaperPackagingWeight { get; set; }

    public decimal? WoodPackagingWeight { get; set; }
}
