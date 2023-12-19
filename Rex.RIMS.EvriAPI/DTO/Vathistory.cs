using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Vathistory
{
    public int VathistoryId { get; set; }

    public DateTime StartDate { get; set; }

    public decimal Vatrate { get; set; }

    public int CompanyId { get; set; }
}
