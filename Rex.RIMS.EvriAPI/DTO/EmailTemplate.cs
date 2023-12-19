using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class EmailTemplate
{
    public int EmailTemplateId { get; set; }

    public string FromName { get; set; } = null!;

    public string FromEmail { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[] TimeStampId { get; set; } = null!;

    public string? Bcc { get; set; }

    public string Title { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public int Sequence { get; set; }

    public int? OnlyLanguageId { get; set; }

    public string? Cc { get; set; }

    public virtual ICollection<EmailTemplateLanguage> EmailTemplateLanguages { get; set; } = new List<EmailTemplateLanguage>();
}
