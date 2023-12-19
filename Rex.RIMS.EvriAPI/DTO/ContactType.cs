using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class ContactType
{
    public int ContactTypeId { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<CustomerContact> CustomerContactEmail1ContactTypes { get; set; } = new List<CustomerContact>();

    public virtual ICollection<CustomerContact> CustomerContactEmail2ContactTypes { get; set; } = new List<CustomerContact>();

    public virtual ICollection<CustomerContact> CustomerContactPhone1ContactTypes { get; set; } = new List<CustomerContact>();

    public virtual ICollection<CustomerContact> CustomerContactPhone2ContactTypes { get; set; } = new List<CustomerContact>();

    public virtual ICollection<CustomerContact> CustomerContactPhone3ContactTypes { get; set; } = new List<CustomerContact>();
}
