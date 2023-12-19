using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class SupplierAddress
{
    public int SupplierAddressId { get; set; }

    public string SupplierCode { get; set; } = null!;

    public string? Firstname { get; set; }

    public string? Surname { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public int? CountryId { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? Mobile { get; set; }

    public string? EmailAddress { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;

    public virtual Supplier SupplierCodeNavigation { get; set; } = null!;
}
