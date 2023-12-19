using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class RlapiPrinterDocument
{
    public int Id { get; set; }

    public int? ImportedOrderId { get; set; }

    public int PrinterId { get; set; }

    public string? DocumentName { get; set; }

    public byte[] DocumentData { get; set; } = null!;

    public bool IsPrinted { get; set; }

    public DateTime DateAdded { get; set; }

    public string? DatePrinted { get; set; }

    public string? DocumentFormat { get; set; }
}
