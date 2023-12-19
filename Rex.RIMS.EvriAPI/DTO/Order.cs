using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Order
{
    public int OrderId { get; set; }

    public int Originator { get; set; }

    public int OriginatorUnitId { get; set; }

    public string? CustomerAccount { get; set; }

    public int? InvoiceAddressId { get; set; }

    public int? DeliveryAddressId { get; set; }

    public int? CustomerBranchId { get; set; }

    public int? CustomerBranchOriginator { get; set; }

    public short? Discount { get; set; }

    public string OrderType { get; set; } = null!;

    public string? CustomerReference { get; set; }

    public bool Delivery { get; set; }

    public string? DeliveryMethod { get; set; }

    public int InvoicePrints { get; set; }

    public int DeliveryPrints { get; set; }

    public DateTime OrderDate { get; set; }

    public string? Acstat { get; set; }

    public int? SettlementDays { get; set; }

    public string? Terms { get; set; }

    public decimal? OrderValue { get; set; }

    public decimal? ValueToSupply { get; set; }

    public decimal? Cost { get; set; }

    public string? PaymentMethod { get; set; }

    public string? DeliveryNumber { get; set; }

    public string PnWh { get; set; } = null!;

    public string? UserId { get; set; }

    public int ReceivedById { get; set; }

    public int NumberOfLines { get; set; }

    public bool Export { get; set; }

    public int CurrencyId { get; set; }

    public string? AckPrt { get; set; }

    public string? ConsignmentNumber { get; set; }

    public bool Migrated { get; set; }

    public bool? DeliveryAsap { get; set; }

    public DateTime? DeliveryWeekOf { get; set; }

    public Guid? PackingNotePrintedBy { get; set; }

    public DateTime? PackingNotePrintedDate { get; set; }

    public string? TheirReference { get; set; }

    public string? OrderComments { get; set; }

    public byte[]? TimeStampId { get; set; }

    public bool IsApproved { get; set; }

    public string? DeliveryWhen { get; set; }

    public int? OrderLinesCount { get; set; }

    public bool IsCardPayment { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public Guid? UpdatedBy { get; set; }

    public string ReserveLevel { get; set; } = null!;

    public DateTime? SentToPackingNoteScreenDate { get; set; }

    public string? OrderedBy { get; set; }

    public int? CcorderPayment { get; set; }

    public decimal ExchangeRate { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public bool IsRemote { get; set; }

    public bool IsNew { get; set; }

    public bool IsLocked { get; set; }

    public string Status { get; set; } = null!;

    public Guid? SentToPackingNoteScreenUserId { get; set; }

    public string? CustomerServiceInformation { get; set; }

    public string? RexLondonSyncNumber { get; set; }

    public Guid? PackedBy { get; set; }

    public DateTime? PackedDate { get; set; }

    public bool CrateManagerScanned { get; set; }

    public string? LockSource { get; set; }

    public Guid? LockedBy { get; set; }

    public DateTime? LockedOn { get; set; }

    public int? CartonQuantity { get; set; }

    public bool RequiresAttention { get; set; }

    public int CompanyId { get; set; }

    public int WarehouseCompanyId { get; set; }

    public decimal? OverrideVatrate { get; set; }

    public Guid? PickedBy { get; set; }

    public DateTime? PickedDate { get; set; }

    public bool IsExpress { get; set; }

    public virtual ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

    public virtual UnpaidOrder? UnpaidOrder { get; set; }
}
