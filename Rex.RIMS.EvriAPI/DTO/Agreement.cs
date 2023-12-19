using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Agreement
{
    public int AgreementId { get; set; }

    public DateTime AgreementDate { get; set; }

    public int? TitleStringId { get; set; }

    public int? AgreementHtmlStringId { get; set; }

    public virtual ICollection<CustomerAgreement> CustomerAgreements { get; set; } = new List<CustomerAgreement>();
}
