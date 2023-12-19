using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class EmailTemplateLanguage
{
    public int EmailTemplateId { get; set; }

    public int LanguageId { get; set; }

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public virtual EmailTemplate EmailTemplate { get; set; } = null!;

    public virtual Language Language { get; set; } = null!;
}
