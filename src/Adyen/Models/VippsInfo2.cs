using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>vipps</b>.
/// </summary>
public record VippsInfo2
{
    /// <summary>
    /// Vipps logo. Format: Base64-encoded string.
    /// </summary>
    [JsonPropertyName("logo")]
    public required string Logo { get; init; }

    /// <summary>
    /// Vipps subscription cancel url (required in case of <see href="https://docs.adyen.com/online-payments/tokenization">recurring payments</see>)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriptionCancelUrl")]
    public string? SubscriptionCancelUrl { get; init; }
}
