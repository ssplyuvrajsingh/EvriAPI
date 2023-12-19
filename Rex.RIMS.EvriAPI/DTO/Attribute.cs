using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Attribute
{
    public int AttributeId { get; set; }

    public int TitleStringId { get; set; }

    public bool ShowInUmbraco { get; set; }

    public virtual ICollection<AttributeValue> AttributeValues { get; set; } = new List<AttributeValue>();

    public virtual StockStringMessage TitleString { get; set; } = null!;
}
