using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockStringLanguage
{
    public int StringId { get; set; }

    public int LanguageId { get; set; }

    public string StringText { get; set; } = null!;

    public DateTime LastTranslated { get; set; }

    public virtual Language Language { get; set; } = null!;

    public virtual StockStringMessage String { get; set; } = null!;
}
