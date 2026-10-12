using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Request sent to terminal to initiate payment.
/// It conveys Information related to the Payment transaction to process.
/// Content of the <c>PaymentRequest</c> message.
/// </summary>
public record PaymentRequest2
{
    /// <summary>
    /// Data related to the Sale System.
    /// </summary>
    [JsonPropertyName("SaleData")]
    public required SaleData1 SaleData { get; init; }

    /// <summary>
    /// Data related to the payment and loyalty transaction.
    /// </summary>
    [JsonPropertyName("PaymentTransaction")]
    public required PaymentTransaction1 PaymentTransaction { get; init; }

    /// <summary>
    /// Data related to the payment transaction.
    /// If one data element is present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentData")]
    public PaymentData1? PaymentData { get; init; }

    /// <summary>
    /// Data related to a Loyalty program or account.
    /// Loyalty cards used with the payment transaction and read by the Sale System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyData")]
    public IReadOnlyList<LoyaltyData>? LoyaltyData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
