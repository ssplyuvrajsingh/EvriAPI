using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Subscriber
{
    public string Account { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string? Email { get; set; }

    public string? Email2 { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? HowFound { get; set; }

    public bool? FullAccess { get; set; }

    public bool? Guest { get; set; }

    public DateTime? LastInvoiceDate { get; set; }

    public int? NumberOfInvoices { get; set; }

    public int? NumberOfOrders { get; set; }

    public bool OptedOut { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CountryName { get; set; }

    public string Language { get; set; } = null!;

    public string? SignupMethod { get; set; }

    public string? RetailerType { get; set; }

    public int? CompanyId { get; set; }
}
