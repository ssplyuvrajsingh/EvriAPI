using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class BulkImportOperation
{
    public int Id { get; set; }

    public int OperationType { get; set; }

    public int OperationStatus { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string UserId { get; set; } = null!;

    public byte[]? OperationData { get; set; }

    public string? OperationDataType { get; set; }

    public string? Comment { get; set; }

    public string? ErrorDetails { get; set; }

    public bool NotifyUser { get; set; }

    public DateTime? NotificationDateRead { get; set; }

    public string? OperationDataParams { get; set; }
}
