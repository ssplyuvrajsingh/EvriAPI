using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class StringMessage
{
    public int RecordId { get; set; }

    public string? StringCode { get; set; }

    public virtual ICollection<Category> CategoryIntroTextStrings { get; set; } = new List<Category>();

    public virtual ICollection<Category> CategoryNameStrings { get; set; } = new List<Category>();

    public virtual ICollection<StockCareInstructionsTranslation> StockCareInstructionsTranslations { get; set; } = new List<StockCareInstructionsTranslation>();

    public virtual ICollection<StringLanguage> StringLanguages { get; set; } = new List<StringLanguage>();
}
