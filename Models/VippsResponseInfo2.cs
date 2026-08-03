using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>vipps</b> details
/// </summary>
public record VippsResponseInfo2
{
    /// <summary>
    /// Vipps logo. Format: Base64-encoded string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo")]
    public string? Logo { get; init; }

    /// <summary>
    /// Vipps subscription cancel url (required in case of <see href="https://docs.adyen.com/online-payments/tokenization">recurring payments</see>)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriptionCancelUrl")]
    public string? SubscriptionCancelUrl { get; init; }
}
