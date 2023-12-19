using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class LoginHistory
{
    public int LoginHistoryId { get; set; }

    public string AppName { get; set; } = null!;

    public string? CustomerAccount { get; set; }

    public DateTime LoginDate { get; set; }

    public string UserHostAddress { get; set; } = null!;

    public int? WebAccountId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool IsSuccess { get; set; }
}
