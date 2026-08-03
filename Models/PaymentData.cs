using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentData
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentType")]
    public PaymentType1? PaymentType { get; init; }

    /// <summary>
    /// Indicates if the payment of the Sale transaction is split. Allows the POI to decline payment means that cannot accept split payment.
    /// </summary>
    [JsonPropertyName("SplitPaymentFlag")]
    public bool? SplitPaymentFlag { get; init; } = false;

    /// <summary>
    /// Requested validity date for the reservation. Allows a specific period for the reservation according to the need of the Merchant for the first reservation and the reservation updates as well.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RequestedValidityDate")]
    public DateTimeOffset? RequestedValidityDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionReference")]
    public CardAcquisitionReference? CardAcquisitionReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Instalment")]
    public Instalment? Instalment { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentInstrumentData")]
    public PaymentInstrumentData2? PaymentInstrumentData { get; init; }
}
