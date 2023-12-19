using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CategoryWithFullNameView
{
    public int? CategoryId { get; set; }

    public int? RootId { get; set; }

    public string? Name { get; set; }

    public string? FullName { get; set; }

    public string? ParentFullName { get; set; }
}
