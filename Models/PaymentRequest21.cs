using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Payment Request message.
/// </summary>
public record PaymentRequest21
{
    [JsonPropertyName("SaleData")]
    public required SaleData2 SaleData { get; init; }

    [JsonPropertyName("PaymentTransaction")]
    public required PaymentTransaction PaymentTransaction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentData")]
    public PaymentData? PaymentData { get; init; }

    /// <summary>
    /// Data related to a Loyalty program or account.
    /// Loyalty cards used with the payment transaction and read by the Sale System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyData")]
    public IReadOnlyList<LoyaltyData>? LoyaltyData { get; init; }
}
