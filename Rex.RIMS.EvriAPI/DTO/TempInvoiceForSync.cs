using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class TempInvoiceForSync
{
    public int Id { get; set; }

    public string InvoiceReference { get; set; } = null!;

    public DateTime? Synced { get; set; }
}
