using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the Payment transaction processed by the POI System.
/// Content of the Payment Response message.
/// </summary>
public record PaymentResponse4
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }

    /// <summary>
    /// Data related to the Sale System.
    /// Copy.
    /// </summary>
    [JsonPropertyName("SaleData")]
    public required SaleData6 SaleData { get; init; }

    /// <summary>
    /// Data related to the POI System.
    /// </summary>
    [JsonPropertyName("POIData")]
    public required PoiData1 PoiData { get; init; }

    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// If one data element is present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentResult")]
    public PaymentResult11? PaymentResult { get; init; }

    /// <summary>
    /// Data related to the result of a processed loyalty transaction.
    /// Loyalty cards used with the payment transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyResult")]
    public IReadOnlyList<LoyaltyResult>? LoyaltyResult { get; init; }

    /// <summary>
    /// Customer or Merchant payment receipt. If the payment receipts are printed by the Sale system and the POI or the Sale does not implement the Print exchange (Basic profile).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentReceipt")]
    public IReadOnlyList<PaymentReceipt>? PaymentReceipt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
