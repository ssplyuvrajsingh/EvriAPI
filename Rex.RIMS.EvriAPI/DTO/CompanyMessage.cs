using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CompanyMessage
{
    public int CompanyMessageId { get; set; }

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public string? ToUserId { get; set; }

    public string FromCustomerAccount { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? ReadDate { get; set; }
}
