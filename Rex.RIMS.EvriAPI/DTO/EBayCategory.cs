using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class EBayCategory
{
    public int EBayCategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string? FullPath { get; set; }

    public int? ParentId { get; set; }

    public DateTime? LastSynchronizedDate { get; set; }
}
