using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CheckResponse
{
    public string CustomerAccount { get; set; } = null!;

    public string? CountryCode { get; set; }

    public string CheckNumber { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string? CustomerAddress { get; set; }

    public string? OrderId { get; set; }

    public string? InvoiceNumber { get; set; }

    public DateTime CheckDate { get; set; }

    public Guid Id { get; set; }

    public string CheckType { get; set; } = null!;

    public string? CountryName { get; set; }

    public Guid? UserId { get; set; }

    public string Status { get; set; } = null!;
}
