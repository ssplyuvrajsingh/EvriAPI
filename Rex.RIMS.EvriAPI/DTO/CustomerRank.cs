using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CustomerRank
{
    public int CustomerRankId { get; set; }

    public string CustomerAccount { get; set; } = null!;

    public int RankYear { get; set; }

    public int RankMonth { get; set; }

    public int FrequencyRank { get; set; }

    public int RecencyRank { get; set; }

    public int MonetaryRank { get; set; }

    public int? TotalRank { get; set; }

    public string RankChangeDirection { get; set; } = null!;
}
