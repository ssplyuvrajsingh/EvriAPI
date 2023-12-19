using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class DotcomUploadBatch
{
    public int DotcomUploadBatchId { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual ICollection<DotcomUploadCategory> DotcomUploadCategories { get; set; } = new List<DotcomUploadCategory>();

    public virtual ICollection<DotcomUploadStock> DotcomUploadStocks { get; set; } = new List<DotcomUploadStock>();
}
