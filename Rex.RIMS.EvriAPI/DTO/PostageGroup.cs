using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class PostageGroup
{
    public int PostageGroupId { get; set; }

    public string Name { get; set; } = null!;

    public string? PostageGroupType { get; set; }

    public bool? DisableOnlinePayment { get; set; }

    public bool? RemotePostCode { get; set; }

    public decimal? StartAmount { get; set; }

    public decimal? EndAmount { get; set; }

    public decimal? Carriage { get; set; }

    public decimal? AdditionalCarriage { get; set; }

    public decimal? CarriagePercent { get; set; }

    public virtual ICollection<PostageGroupPostcode> PostageGroupPostcodes { get; set; } = new List<PostageGroupPostcode>();

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
}
