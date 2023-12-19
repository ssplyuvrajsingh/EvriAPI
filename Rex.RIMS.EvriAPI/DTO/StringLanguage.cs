using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StringLanguage
{
    public int StringId { get; set; }

    public int LanguageId { get; set; }

    public string StringText { get; set; } = null!;

    public DateTime? TranslatedDate { get; set; }

    public virtual Language Language { get; set; } = null!;

    public virtual StringMessage String { get; set; } = null!;
}
