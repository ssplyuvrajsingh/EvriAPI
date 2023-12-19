using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class PostageGroupPostcode
{
    public int PostageGroupPostcodeId { get; set; }

    public int PostageGroupId { get; set; }

    public string PostcodeRange { get; set; } = null!;

    public virtual PostageGroup PostageGroup { get; set; } = null!;
}
