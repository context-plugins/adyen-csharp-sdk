using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the Loyalty transaction processed by the POI System.
/// Content of the Loyalty Response message.
/// </summary>
public record LoyaltyResponse
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }

    /// <summary>
    /// Data related to the Sale System.
    /// </summary>
    [JsonPropertyName("SaleData")]
    public required SaleData1 SaleData { get; init; }

    /// <summary>
    /// Data related to the POI System.
    /// </summary>
    [JsonPropertyName("POIData")]
    public required PoiData1 PoiData { get; init; }

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
