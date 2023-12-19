using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class AttributeValueView
{
    public int AttributeValueId { get; set; }

    public int AttributeId { get; set; }

    public int TitleStringId { get; set; }

    public string? EnglishTitle { get; set; }

    public string? FrenchTitle { get; set; }

    public string? GermanTitle { get; set; }

    public string? SpanishTitle { get; set; }
}
