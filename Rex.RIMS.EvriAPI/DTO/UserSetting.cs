using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class UserSetting
{
    public Guid UserId { get; set; }

    public string UserData { get; set; } = null!;
}
