using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class XfsChangedRow
{
    public int XfsChangedRowsId { get; set; }

    public Guid XfsSynchronizationKeyId { get; set; }

    public string XfsTableName { get; set; } = null!;

    public string? XfsPrimaryKeys { get; set; }

    public string XfsAction { get; set; } = null!;

    public byte[] XfsVersionId { get; set; } = null!;
}
