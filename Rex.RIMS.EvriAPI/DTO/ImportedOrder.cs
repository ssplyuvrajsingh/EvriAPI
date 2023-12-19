using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class ImportedOrder
{
    public string OriginalOrderId { get; set; } = null!;

    public int? UserId { get; set; }

    public decimal? OrderTotal { get; set; }

    public string? Email { get; set; }

    public string? DeliveryFirstname { get; set; }

    public string? DeliverySurname { get; set; }

    public string? DeliveryPhone { get; set; }

    public string? DeliveryCompany { get; set; }

    public string? DeliveryAddress1 { get; set; }

    public string? DeliveryAddress2 { get; set; }

    public string? DeliveryAddress3 { get; set; }

    public string? DeliveryAddress4 { get; set; }

    public string? DeliveryCountry { get; set; }

    public string? BillingFirstname { get; set; }

    public string? BillingSurname { get; set; }

    public string? BillingPhone { get; set; }

    public string? BillingCompany { get; set; }

    public string? BillingAddress1 { get; set; }

    public string? BillingAddress2 { get; set; }

    public string? BillingAddress3 { get; set; }

    public string? BillingAddress4 { get; set; }

    public string? BillingCountry { get; set; }

    public string? PaymentMethod { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? DeliveryMethod { get; set; }

    public decimal? DeliveryRate { get; set; }

    public bool ForImport { get; set; }

    public DateTime? PrintedDate { get; set; }

    public int? ParcelCount { get; set; }

    public int PlatformId { get; set; }

    public bool IsEmailSent { get; set; }

    public Guid? PickingListPrintedBy { get; set; }

    public DateTime? PickingListPrintedDate { get; set; }

    public string? CustomerComment { get; set; }

    public string? OrderStatus { get; set; }

    public string? ParcelServiceProvider { get; set; }

    public bool IsAllocated { get; set; }

    public DateTime? UtcModifiedDate { get; set; }

    public Guid? PickerId { get; set; }

    public DateTime? PickerDate { get; set; }

    public Guid? PackerId { get; set; }

    public DateTime? PackerDate { get; set; }

    public bool IsPickingListUploaded { get; set; }

    public int ImportedOrderId { get; set; }

    public Guid? CarrierScannedId { get; set; }

    public DateTime? CarrierScannedDate { get; set; }

    public bool IsCanceled { get; set; }

    public int? LanguageId { get; set; }

    public int? CurrencyId { get; set; }

    public string? DeliveryUpslocationId { get; set; }

    public string? TrackingNumber { get; set; }

    public string? BatchNumber { get; set; }

    public int? CrateNumber { get; set; }

    public bool IsPreDespatched { get; set; }

    public string? AutoPrintErrorMessage { get; set; }

    public bool IsInconsistentDeliveryCountry { get; set; }

    public string? EmailError { get; set; }

    public DateTime? ManifestPrintedDate { get; set; }

    public string? ParcelServiceProviderOverride { get; set; }

    public DateTime? FirstDespatchDate { get; set; }

    public string? CustomerAccount { get; set; }

    public string? CustomerVat { get; set; }

    public bool HasBatteries { get; set; }

    public bool IsAmended { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? DpdtermsOfDelivery { get; set; }

    public string? CustomerEori { get; set; }

    public string? CouponCode { get; set; }

    public decimal? CouponDiscount { get; set; }

    public int CompanyId { get; set; }

    public bool NoPounds { get; set; }

    public int? UniqueStockCount { get; set; }

    public int? TotalQuantity { get; set; }

    public decimal? TotalWeight { get; set; }

    public DateTime? SentToRops { get; set; }

    public DateTime? PickingListCompletedDate { get; set; }

    public int? SequenceInRops { get; set; }

    public string? InvoiceReference { get; set; }

    public DateTime? PickerPackerAppPrintedDate { get; set; }

    public int? BatchInRops { get; set; }

    public bool NoLabelInRops { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual Dpdorder? Dpdorder { get; set; }

    public virtual ICollection<ImportedOrderLine> ImportedOrderLines { get; set; } = new List<ImportedOrderLine>();

    public virtual ICollection<ImportedOrderLog> ImportedOrderLogs { get; set; } = new List<ImportedOrderLog>();

    public virtual Language? Language { get; set; }

    public virtual User? Packer { get; set; }

    public virtual ParcelForceOrder? ParcelForceOrder { get; set; }

    public virtual User? Picker { get; set; }

    public virtual ImportedPlatform Platform { get; set; } = null!;

    public virtual RoyalMailOrder? RoyalMailOrder { get; set; }

    public virtual UkmailOrder? UkmailOrder { get; set; }
}
