using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CustomerOrigin
{
    public int CustomerOriginId { get; set; }

    public string Name { get; set; } = null!;

    public bool Hidden { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
