using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockRetailStringMessage
{
    public int RecordId { get; set; }

    public string? StringCode { get; set; }

    public virtual ICollection<StockRetailStringLanguage> StockRetailStringLanguages { get; set; } = new List<StockRetailStringLanguage>();
}
