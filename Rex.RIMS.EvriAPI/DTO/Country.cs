using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Country
{
    public int CountryId { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public bool Eec { get; set; }

    public string? Eeccode { get; set; }

    public string? FormatProvider { get; set; }

    public string? DotcomCode { get; set; }

    public string? Crukcode { get; set; }

    public decimal? RetailPostage { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;

    public string? DpdcountryCode { get; set; }

    public string? UpscountryCode { get; set; }

    public int CurrencyId { get; set; }

    public int CallingCode { get; set; }

    public bool ExcludeDpdtrade { get; set; }

    public string DpdtermsOfDelivery { get; set; } = null!;

    public decimal? Vatrate { get; set; }

    public string? RemotePostcodes { get; set; }

    public virtual Currency Currency { get; set; } = null!;

    public virtual ICollection<UpsexcludedPostCode> UpsexcludedPostCodes { get; set; } = new List<UpsexcludedPostCode>();

    public virtual ICollection<PostageGroup> PostageGroups { get; set; } = new List<PostageGroup>();
}
