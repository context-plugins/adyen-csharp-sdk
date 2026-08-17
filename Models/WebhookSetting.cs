using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record WebhookSetting
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see> of the balance.
    /// </summary>
    [JsonPropertyName("currency")]
    [MinLength(1)]
    public required string Currency { get; init; }

    /// <summary>
    /// The unique identifier of the webhook setting.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The status of the webhook setting. Possible values:
    /// <list type="bullet">
    ///   <item><description><b>active</b>: You receive a balance webhook if any of the conditions in this setting are met.</description></item>
    ///   <item><description><b>inactive</b>: You do not receive a balance webhook even if the conditions in this settings are met.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    /// <summary>
    /// The resource about whose balance change you want to get notified.
    /// </summary>
    [JsonPropertyName("target")]
    public required Target3 Target { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
