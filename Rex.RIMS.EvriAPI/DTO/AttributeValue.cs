using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class AttributeValue
{
    public int AttributeValueId { get; set; }

    public int AttributeId { get; set; }

    public int TitleStringId { get; set; }

    public virtual Attribute Attribute { get; set; } = null!;

    public virtual StockStringMessage TitleString { get; set; } = null!;

    public virtual ICollection<Stock> StockCodes { get; set; } = new List<Stock>();
}
