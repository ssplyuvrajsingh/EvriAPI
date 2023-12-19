using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class UpsexcludedPostCode
{
    public int Id { get; set; }

    public int CountryId { get; set; }

    public string StartRange { get; set; } = null!;

    public string EndRange { get; set; } = null!;

    public virtual Country Country { get; set; } = null!;
}
