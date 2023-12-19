using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class UsersRlapi
{
    public int Id { get; set; }

    public string ClientId { get; set; } = null!;

    public string ClientSecret { get; set; } = null!;

    public string? ClientScopes { get; set; }

    public bool Enabled { get; set; }
}
