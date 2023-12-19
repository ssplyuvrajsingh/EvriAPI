using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class SupplierCertificate
{
    public int SupplierCertificateId { get; set; }

    public string SupplierCode { get; set; } = null!;

    public string? FileNamePrefix { get; set; }

    public string FileName { get; set; } = null!;

    public DateTime UploadedDate { get; set; }
}
