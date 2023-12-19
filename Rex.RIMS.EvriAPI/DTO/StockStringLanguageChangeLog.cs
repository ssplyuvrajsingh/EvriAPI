using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StockStringLanguageChangeLog
{
    public int Id { get; set; }

    public Guid UserId { get; set; }

    public DateTime ChangedDate { get; set; }

    public int StringId { get; set; }

    public int LanguageId { get; set; }

    public virtual Language Language { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
