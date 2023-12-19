using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class AutoReport
{
    public string AutoReportCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<AutoReportSchedule> AutoReportSchedules { get; set; } = new List<AutoReportSchedule>();
}
