using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class AttributeView
{
    public int AttributeId { get; set; }

    public int TitleStringId { get; set; }

    public string? EnglishTitle { get; set; }

    public string? FrenchTitle { get; set; }

    public string? GermanTitle { get; set; }

    public string? SpanishTitle { get; set; }

    public bool ShowInUmbraco { get; set; }
}
