using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class BulletDescription
{
    public int Id { get; set; }

    public string StockCode { get; set; } = null!;

    public int LanguageId { get; set; }

    public int Sequence { get; set; }

    public string Text { get; set; } = null!;
}
