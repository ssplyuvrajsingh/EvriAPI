using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockRetailStringLanguage
{
    public int StringId { get; set; }

    public int LanguageId { get; set; }

    public string StringText { get; set; } = null!;

    public DateTime LastTranslated { get; set; }

    public virtual StockRetailStringMessage Language { get; set; } = null!;
}
