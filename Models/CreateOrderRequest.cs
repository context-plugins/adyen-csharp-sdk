using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CreateOrderRequest
{
    [JsonPropertyName("amount")]
    public required Amount16 Amount { get; init; }

    /// <summary>
    /// The date when the order should expire. If not provided, the default expiry duration is 1 day.
    /// <para>
    /// <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see> format: YYYY-MM-DDThh:mm:ss+TZD, for example, <b>2020-12-18T10:15:30+01:00</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiresAt")]
    public string? ExpiresAt { get; init; }

    /// <summary>
    /// The merchant account identifier, with which you want to process the order.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// A custom reference identifying the order.
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }
}
