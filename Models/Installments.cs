using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Contains installment settings. For more information, refer to <see href="https://docs.adyen.com/payment-methods/cards/credit-card-installments">Installments</see>.
/// </summary>
public record Installments
{
    /// <summary>
    /// Defines the bonus percentage, refund percentage or if the transaction is Buy now Pay later.
    /// Used for <see href="https://docs.adyen.com/payment-methods/cards/credit-card-installments/#getting-paid-mexico">card installments in Mexico</see>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extra")]
    public int? Extra { get; init; }

    /// <summary>
    /// The installment plan, used for <see href="https://docs.adyen.com/payment-methods/cards/credit-card-installments#make-a-payment-japan">card installments in Japan</see>.
    /// and <see href="https://docs.adyen.com/payment-methods/cards/credit-card-installments/#getting-paid-mexico">Mexico</see>.
    /// By default, this is set to <b>regular</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plan")]
    public Plan? Plan { get; init; }

    /// <summary>
    /// Defines the number of installments.
    /// Usually, the maximum allowed number of installments is capped. For example, it may not be possible to split a payment in more than 24 installments. The acquirer sets this upper limit, so its value may vary.
    /// This value can be zero for Installments processed in Mexico.
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; init; }
}
