using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class AutoReportLog
{
    public int AutoReportLogId { get; set; }

    public int AutoReportScheduleId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string ReportFileName { get; set; } = null!;

    public virtual AutoReportSchedule AutoReportSchedule { get; set; } = null!;
}
