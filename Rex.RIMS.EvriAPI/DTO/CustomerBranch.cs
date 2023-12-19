using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CustomerBranch
{
    public int CustomerBranchId { get; set; }

    public int Originator { get; set; }

    public int? CustomerId { get; set; }

    public string CustomerAccount { get; set; } = null!;

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

    public string? Surname { get; set; }

    public string? Firstname { get; set; }

    public string? Title { get; set; }

    public string? AddressRef { get; set; }

    public short Discount { get; set; }

    public int CurrencyId { get; set; }

    public int CountryId { get; set; }

    public int SettlementDays { get; set; }

    public string? Terms { get; set; }

    public int CreditLimit { get; set; }

    public decimal Outstanding { get; set; }

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

    public bool Export { get; set; }

    public string? Vatnumber { get; set; }

    public bool TermsAgreed { get; set; }

    public string WantsCatalogue { get; set; } = null!;

    public int? CatalogAddressId { get; set; }

    public bool IsApproved { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;

    public bool RecommendedStockist { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public virtual Customer CustomerAccountNavigation { get; set; } = null!;
}
