using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockImage
{
    public int StockImageId { get; set; }

    public string StockCode { get; set; } = null!;

    public string? Description { get; set; }

    public bool? IsPrimary { get; set; }

    public string ImageType { get; set; } = null!;

    public string ImageName { get; set; } = null!;

    public Guid XfsSynchronizationKeyId { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;

    public int? Width { get; set; }

    public int? Height { get; set; }
}
