using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class EBayStoreCategory
{
    public long StoreCategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string? FullPath { get; set; }

    public long? ParentId { get; set; }

    public DateTime? LastSynchronizedDate { get; set; }
}
