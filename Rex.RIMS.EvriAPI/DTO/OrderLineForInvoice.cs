using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class OrderLineForInvoice
{
    public int Id { get; set; }

    public int OrderForInvoiceId { get; set; }

    public int OrderLineId { get; set; }

    public int Originator { get; set; }

    public int OriginatorUnitId { get; set; }

    public int QuantityToInvoice { get; set; }
}
