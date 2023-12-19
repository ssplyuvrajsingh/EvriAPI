using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CcorderPayment
{
    public int OrderId { get; set; }

    public int Originator { get; set; }

    public int OriginatorUnitId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Town { get; set; }

    public string? County { get; set; }

    public string? Country { get; set; }

    public string? Postcode { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string Currency { get; set; } = null!;

    public string CustomerAccount { get; set; } = null!;

    public byte[]? TimeStampId { get; set; }

    public Guid? TlsSynchronizationKeyId { get; set; }

    public string Status { get; set; } = null!;

    public bool Callback { get; set; }

    public string? CcNumber { get; set; }

    public string? CcExpMm { get; set; }

    public string? CcExpYy { get; set; }

    public string? CcIssue { get; set; }

    public string? TranReference { get; set; }

    public DateTime? TranTime { get; set; }

    public string? TranResult { get; set; }

    public string? TranMessage { get; set; }

    public decimal? TranAmount { get; set; }

    public string? AutorisationCode { get; set; }

    public string OrderReference { get; set; } = null!;

    public decimal ValueSentToPayment { get; set; }

    public decimal? ValuePaid { get; set; }

    public DateTime PaymentDateRequest { get; set; }

    public DateTime? PaymentDateAnswer { get; set; }

    public string? Invoice { get; set; }

    public int CcorderPaymentId { get; set; }
}
