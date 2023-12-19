using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CustomerContact
{
    public int CustomerContactId { get; set; }

    public int Originator { get; set; }

    public string CustomerDepartment { get; set; } = null!;

    public string CustomerAccount { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Title { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Phone3 { get; set; }

    public string? Email1 { get; set; }

    public string? Email2 { get; set; }

    public int? Phone1ContactTypeId { get; set; }

    public int? Phone2ContactTypeId { get; set; }

    public int? Phone3ContactTypeId { get; set; }

    public int? Email1ContactTypeId { get; set; }

    public int? Email2ContactTypeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public byte[] TimeStampId { get; set; } = null!;

    public virtual Customer CustomerAccountNavigation { get; set; } = null!;

    public virtual ContactType? Email1ContactType { get; set; }

    public virtual ContactType? Email2ContactType { get; set; }

    public virtual ContactType? Phone1ContactType { get; set; }

    public virtual ContactType? Phone2ContactType { get; set; }

    public virtual ContactType? Phone3ContactType { get; set; }
}
