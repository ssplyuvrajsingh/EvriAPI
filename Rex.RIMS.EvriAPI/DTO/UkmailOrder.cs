using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class UkmailOrder
{
    public int ImportedOrderId { get; set; }

    public int? UkmailBatchId { get; set; }

    public DateTime InsertedDate { get; set; }

    public string? ContactName { get; set; }

    public string? BusinessName { get; set; }

    public string Address1 { get; set; } = null!;

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string PostalTown { get; set; } = null!;

    public string? County { get; set; }

    public string Postcode { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telephone { get; set; }

    public string PreDeliveryNotification { get; set; } = null!;

    public string? CustomersRef { get; set; }

    public string? AlternativeRef { get; set; }

    public int Items { get; set; }

    public int? WeightInGrams { get; set; }

    public int ServiceKey { get; set; }

    public string? SpecialInstructions1 { get; set; }

    public string? SpecialInstructions2 { get; set; }

    public bool ConfirmationOfDelivery { get; set; }

    public string? ConfirmationEmail { get; set; }

    public string? ConfirmationTelephone { get; set; }

    public bool ExchangeOnDelivery { get; set; }

    public int ExtendedCover { get; set; }

    public bool SignatureOptional { get; set; }

    public string? SecureLocation1 { get; set; }

    public string? SecureLocation2 { get; set; }

    public bool Bookin { get; set; }

    public decimal? Codamount { get; set; }

    public bool LongLength { get; set; }

    public string? ConsignmentNumber { get; set; }

    public int? PacketLength { get; set; }

    public int? PacketWidth { get; set; }

    public int? PacketHeight { get; set; }

    public string? DeliveryMessage1 { get; set; }

    public string? DeliveryMessage2 { get; set; }

    public string DespatchType { get; set; } = null!;

    public virtual ImportedOrder ImportedOrder { get; set; } = null!;

    public virtual UkmailBatch? UkmailBatch { get; set; }
}
