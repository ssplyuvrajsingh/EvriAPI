using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class SupplierCertificateStock
{
    public int SupplierCertificateId { get; set; }

    public string StockCode { get; set; } = null!;
}
