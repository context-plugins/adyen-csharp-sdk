using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the reversal processed by the POI System.
/// Content of the Reversal Response message.
/// </summary>
public record ReversalResponse
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }

    /// <summary>
    /// Data related to the POI System.
    /// If Result is Success.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIData")]
    public PoiData4? PoiData { get; init; }

    /// <summary>
    /// Identification of a previous POI transaction.
    /// In the Payment Request message, it allows using the card of a previous CardAcquisition or Payment request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OriginalPOITransaction")]
    public OriginalPoiTransaction? OriginalPoiTransaction { get; init; }

    /// <summary>
    /// Amount of the payment or loyalty to reverse.
    /// Copy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReversedAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? ReversedAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentReceipt")]
    public IReadOnlyList<PaymentReceipt>? PaymentReceipt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
