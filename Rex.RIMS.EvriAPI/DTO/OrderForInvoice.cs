using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class OrderForInvoice
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public int OrderId { get; set; }

    public int OrderOriginator { get; set; }

    public int OrderOriginatorUnitId { get; set; }

    public decimal Vatrate { get; set; }

    public bool UseOrderDateAsInvoiceDate { get; set; }

    public string? PayerName { get; set; }

    public string Status { get; set; } = null!;

    public int Priority { get; set; }

    public bool IsCashAndCarry { get; set; }

    public bool HasDiscount { get; set; }

    public string? Invoice { get; set; }

    public string? ErrorMessage { get; set; }

    public int TryCount { get; set; }

    public bool Eechidden { get; set; }

    public bool EmailToCustomer { get; set; }

    public bool ShowOnline { get; set; }

    public bool SendToWebship { get; set; }
}
