using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Language
{
    public int RecordId { get; set; }

    public bool? IsSupported { get; set; }

    public bool? IsRtl { get; set; }

    public int LangStringId { get; set; }

    public virtual ICollection<EmailTemplateLanguage> EmailTemplateLanguages { get; set; } = new List<EmailTemplateLanguage>();

    public virtual ICollection<ImportedOrder> ImportedOrders { get; set; } = new List<ImportedOrder>();

    public virtual ICollection<StockRetailStringLanguageChangeLog> StockRetailStringLanguageChangeLogs { get; set; } = new List<StockRetailStringLanguageChangeLog>();

    public virtual ICollection<StockStringLanguageChangeLog> StockStringLanguageChangeLogs { get; set; } = new List<StockStringLanguageChangeLog>();

    public virtual ICollection<StockStringLanguage> StockStringLanguages { get; set; } = new List<StockStringLanguage>();

    public virtual ICollection<StringLanguage> StringLanguages { get; set; } = new List<StringLanguage>();
}
