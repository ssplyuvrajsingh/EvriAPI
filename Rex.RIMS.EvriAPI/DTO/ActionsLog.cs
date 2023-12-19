using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class ActionsLog
{
    public int ActionLogId { get; set; }

    public string ActionText { get; set; } = null!;

    public string ActionType { get; set; } = null!;

    public DateTime ActionDate { get; set; }

    public string? Username { get; set; }
}
