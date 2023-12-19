using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Company
{
    public int CompanyId { get; set; }

    public string Name { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string Address3 { get; set; } = null!;

    public string Address4 { get; set; } = null!;

    public string Vatregistration { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public decimal Vat1 { get; set; }

    public int? ParentCompanyId { get; set; }

    public virtual ICollection<UserCompany> UserCompanies { get; set; } = new List<UserCompany>();
}
