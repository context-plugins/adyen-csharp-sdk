using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the Payment transaction processed by the POI System.
/// Content of the Payment Response message.
/// </summary>
public record PaymentResponse4
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    [JsonPropertyName("SaleData")]
    public required SaleData2 SaleData { get; init; }

    [JsonPropertyName("POIData")]
    public required Poidata2 Poidata { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentResult")]
    public PaymentResult1? PaymentResult { get; init; }

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
}
