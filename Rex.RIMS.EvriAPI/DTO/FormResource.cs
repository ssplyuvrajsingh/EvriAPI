using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class FormResource
{
    public Guid Pkid { get; set; }

    public string FormName { get; set; } = null!;

    public virtual ICollection<AccessControl> AccessControls { get; set; } = new List<AccessControl>();
}
