using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockStringMessage
{
    public int RecordId { get; set; }

    public string? StringCode { get; set; }

    public virtual ICollection<AttributeValue> AttributeValues { get; set; } = new List<AttributeValue>();

    public virtual ICollection<Attribute> Attributes { get; set; } = new List<Attribute>();

    public virtual ICollection<StockStringLanguage> StockStringLanguages { get; set; } = new List<StockStringLanguage>();
}
