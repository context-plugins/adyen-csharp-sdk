using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Request sent to terminal to initiate payment.
/// It conveys Information related to the Payment transaction to process.
/// Content of the <c>PaymentRequest</c> message.
/// </summary>
public record PaymentRequest2
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
