using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the Loyalty transaction processed by the POI System.
/// Content of the Loyalty Response message.
/// </summary>
public record LoyaltyResponse
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    [JsonPropertyName("SaleData")]
    public required SaleData2 SaleData { get; init; }

    [JsonPropertyName("POIData")]
    public required Poidata2 Poidata { get; init; }

    /// <summary>
    /// Data related to the result of a processed loyalty transaction.
    /// If loyalty account identified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyResult")]
    public IReadOnlyList<LoyaltyResult>? LoyaltyResult { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentReceipt")]
    public IReadOnlyList<PaymentReceipt>? PaymentReceipt { get; init; }
}
