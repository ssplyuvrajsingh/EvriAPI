using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class DotcomUploadStock
{
    public int DotcomUploadBatchId { get; set; }

    public int Tid { get; set; }

    public string StockCode { get; set; } = null!;

    public string ActionName { get; set; } = null!;

    public virtual DotcomUploadBatch DotcomUploadBatch { get; set; } = null!;
}
