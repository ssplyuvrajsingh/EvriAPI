using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class MailMessage
{
    public int Id { get; set; }

    public string FromEmail { get; set; } = null!;

    public string? ToEmail { get; set; }

    public string? CcEmail { get; set; }

    public string? BccEmail { get; set; }

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? ErrorMessage { get; set; }

    public DateTime UtcInsertedOn { get; set; }

    public DateTime? UtcUpdatedOn { get; set; }

    public string? AzureStorageAttachments { get; set; }
}
