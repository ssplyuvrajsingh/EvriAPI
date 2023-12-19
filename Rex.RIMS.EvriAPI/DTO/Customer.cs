using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Customer
{
    public int? CustomerId { get; set; }

    public string Account { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Shortname { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Telex { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public string? Postcode { get; set; }

    public string? Contact { get; set; }

    public string Surname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Title { get; set; }

    public string? AddressRef { get; set; }

    public short Discount { get; set; }

    public int CurrencyId { get; set; }

    public int CountryId { get; set; }

    public int SettlementDays { get; set; }

    public int CreditLimit { get; set; }

    public decimal Outstanding { get; set; }

    public decimal? OriginalBalance { get; set; }

    public string? AccountType { get; set; }

    public string? Other1 { get; set; }

    public string? Other2 { get; set; }

    public bool Stop { get; set; }

    public string? DeliveryMethod { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? LastOrdered { get; set; }

    public DateTime? LastCash { get; set; }

    public bool Migrated { get; set; }

    public string? Notes { get; set; }

    public bool Branches { get; set; }

    public bool Export { get; set; }

    public string? Vatnumber { get; set; }

    public bool TermsAgreed { get; set; }

    public string WantsCatalogue { get; set; } = null!;

    public int? CatalogAddressId { get; set; }

    public int WebAccountId { get; set; }

    public byte[] TimeStampId { get; set; } = null!;

    public DateTime? DeletedDate { get; set; }

    public DateTime DetailsLastUpdated { get; set; }

    public string? Other3 { get; set; }

    public string? SellerType { get; set; }

    public Guid? DeletedBy { get; set; }

    public string? HowFound { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public int? CustomerOriginId { get; set; }

    public string? AddressNote { get; set; }

    public decimal? InvoicePrintDiscount { get; set; }

    public bool? IsVatnumberValid { get; set; }

    public bool IsVatnumberApproved { get; set; }

    public string? RetailerType { get; set; }

    public string? WebAddress { get; set; }

    public bool IsOnlyOnlineRetailer { get; set; }

    public string? SellingOnWebsites { get; set; }

    public int? NoOfRetailPermises { get; set; }

    public string? TradePeriod { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public bool RecommendedStockist { get; set; }

    public bool TradeMarketingOptOut { get; set; }

    public bool HasAccessToLifestyleImages { get; set; }

    public DateTime? FirstOrderDate { get; set; }

    public int InvoiceCount { get; set; }

    public int? CustomerTermsId { get; set; }

    public int? BusinessStartYear { get; set; }

    public string? RegistrationNotes { get; set; }

    public string IncotermCode { get; set; } = null!;

    public bool Dapoverride { get; set; }

    public string? Eori { get; set; }

    public bool? IsEorivalid { get; set; }

    public int? CompanyId { get; set; }

    public string? SearchKeyword { get; set; }

    public string? SignupMethod { get; set; }

    public virtual ICollection<CustomerBranch> CustomerBranches { get; set; } = new List<CustomerBranch>();

    public virtual ICollection<CustomerContact> CustomerContacts { get; set; } = new List<CustomerContact>();

    public virtual CustomerOrigin? CustomerOrigin { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual PendingRegistration? PendingRegistration { get; set; }

    public virtual ICollection<StockOnNotification> StockOnNotifications { get; set; } = new List<StockOnNotification>();
}
