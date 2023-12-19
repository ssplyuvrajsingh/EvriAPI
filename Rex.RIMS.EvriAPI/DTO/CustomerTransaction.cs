using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CustomerTransaction
{
    public int CustomerTransactionId { get; set; }

    public int? CustomerId { get; set; }

    public string? CustomerAccount { get; set; }

    public DateTime Date { get; set; }

    public string Period { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Text { get; set; }

    public string UserPkid { get; set; } = null!;

    public string? Mandate { get; set; }

    public decimal Value1 { get; set; }

    public decimal? Value2 { get; set; }

    public decimal? Value3 { get; set; }

    public decimal Value4 { get; set; }

    public decimal? Value5 { get; set; }

    public decimal? Value6 { get; set; }

    public decimal Value4Ster { get; set; }

    public int? DeliveryCustomerBranchId { get; set; }

    public bool Migrated { get; set; }

    public decimal? SettledValue { get; set; }

    public DateTime? SettledDate { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;
}
