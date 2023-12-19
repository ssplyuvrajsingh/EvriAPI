using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class AutoReportSchedule
{
    public int AutoReportScheduleId { get; set; }

    public string AutoReportCode { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string Scheduled { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? LastRun { get; set; }

    public virtual AutoReport AutoReportCodeNavigation { get; set; } = null!;

    public virtual ICollection<AutoReportLog> AutoReportLogs { get; set; } = new List<AutoReportLog>();
}
