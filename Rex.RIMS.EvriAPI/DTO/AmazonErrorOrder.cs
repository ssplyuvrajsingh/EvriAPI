using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class AmazonErrorOrder
{
    public string OriginalOrderId { get; set; } = null!;

    public DateTime LastDownloadOrUploadAttempt { get; set; }

    public DateTime? LastSentErrorEmail { get; set; }

    public string SubType { get; set; } = null!;
}
