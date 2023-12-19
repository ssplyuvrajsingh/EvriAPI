using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CustomerMessage
{
    public int CustomerMessageId { get; set; }

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? ReadDate { get; set; }

    public int ToCustomerId { get; set; }

    public string ToCustomerAccount { get; set; } = null!;

    public string FromUserId { get; set; } = null!;
}
