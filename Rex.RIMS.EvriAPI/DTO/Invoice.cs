using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Invoice
{
    public string Invoice1 { get; set; } = null!;

    public int? CustomerId { get; set; }

    public string? CustomerAccount { get; set; }

    public int? CustomerBranchId { get; set; }

    public int? CustomerBranchOriginator { get; set; }

    public string? OrderId { get; set; }

    public string InvoiceName { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public string? CustomerReference { get; set; }

    public string AccountType { get; set; } = null!;

    public string? Rep { get; set; }

    public bool Posted { get; set; }

    public decimal Goods { get; set; }

    public string Currency { get; set; } = null!;

    public decimal Goods1 { get; set; }

    public decimal? Goods2 { get; set; }

    public decimal? Goods3 { get; set; }

    public decimal? Vat { get; set; }

    public decimal Xstot1 { get; set; }

    public decimal? Xstot2 { get; set; }

    public decimal? Xstot3 { get; set; }

    public decimal? Cost { get; set; }

    public decimal? Paid { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public DateTime InvoiceDate { get; set; }

    public string? ReceivedBy { get; set; }

    public string? DeliveryMethod { get; set; }

    public decimal? SettlementDiscount { get; set; }

    public string UserId { get; set; } = null!;

    public string? ConsignmentNumber { get; set; }

    public bool Migrated { get; set; }

    public string? TheirReference { get; set; }

    public bool Settled { get; set; }

    public string? Deleted { get; set; }

    public bool IsCardPayment { get; set; }

    public DateTime? CardPaymentDate { get; set; }

    public Guid? CardPaymentBy { get; set; }

    public string? OrderComments { get; set; }

    public string? Eeccode { get; set; }

    public decimal Vatrate { get; set; }

    public int CurrencyId { get; set; }

    public decimal ExchangeRate { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;

    public string? PayerName { get; set; }

    public bool? IsOwnShip { get; set; }

    public bool Eechidden { get; set; }

    public bool ShowOnline { get; set; }

    public DateTime? EmailedToCustomerDate { get; set; }

    public bool IsOnlineRefund { get; set; }

    public int? CartonQuantity { get; set; }

    public Guid? PackedBy { get; set; }

    public DateTime? PackedDate { get; set; }

    public int CompanyId { get; set; }

    public int DeliveryCountryId { get; set; }

    public string? Vatnumber { get; set; }

    public virtual Currency CurrencyNavigation { get; set; } = null!;

    public virtual Customer? CustomerAccountNavigation { get; set; }

    public virtual ICollection<InvoiceLine> InvoiceLines { get; set; } = new List<InvoiceLine>();
}
