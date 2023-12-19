using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockCareInstructionsTranslation
{
    public int CareInstructionsId { get; set; }

    public string StockCode { get; set; } = null!;

    public int LanguageId { get; set; }

    public string? RetailTranslation { get; set; }

    public string? TradeTranslation { get; set; }

    public virtual StringMessage Language { get; set; } = null!;
}
