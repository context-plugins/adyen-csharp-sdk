using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

public record ReversalResponse4
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIData")]
    public Poidata2? Poidata { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OriginalPOITransaction")]
    public OriginalPoitransaction3? OriginalPoitransaction { get; init; }

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
}
