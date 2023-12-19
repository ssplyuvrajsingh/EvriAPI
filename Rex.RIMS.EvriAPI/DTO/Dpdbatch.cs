using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Dpdbatch
{
    public int DpdbatchId { get; set; }

    public DateTime CollectionDate { get; set; }

    public int Number { get; set; }

    public virtual ICollection<Dpdorder> Dpdorders { get; set; } = new List<Dpdorder>();
}
