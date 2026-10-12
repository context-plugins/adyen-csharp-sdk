using System.Text.Json.Serialization;

namespace Adyen.Models;

public record VippsInfo
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
