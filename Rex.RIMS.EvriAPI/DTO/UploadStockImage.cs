using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class UploadStockImage
{
    public int Id { get; set; }

    public string StockCode { get; set; } = null!;

    public string ImageName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string Status { get; set; } = null!;

    public string? ErrorMessage { get; set; }
}
