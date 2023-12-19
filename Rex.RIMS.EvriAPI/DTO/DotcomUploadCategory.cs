using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class DotcomUploadCategory
{
    public int DotcomUploadBatchId { get; set; }

    public int Tid { get; set; }

    public string Name { get; set; } = null!;

    public int GroupId { get; set; }

    public bool IsDeleted { get; set; }

    public virtual DotcomUploadBatch DotcomUploadBatch { get; set; } = null!;
}
