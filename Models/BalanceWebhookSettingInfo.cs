using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record BalanceWebhookSettingInfo
{
    /// <summary>
    /// The array of conditions a balance change must meet for Adyen to send the webhook.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conditions")]
    [MinLength(0)]
    [MaxLength(20)]
    public IReadOnlyList<Condition>? Conditions { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see> of the balance.
    /// </summary>
    [JsonPropertyName("currency")]
    [MinLength(1)]
    public required string Currency { get; init; }

    [JsonPropertyName("status")]
    public required Status19 Status { get; init; }

    [JsonPropertyName("target")]
    public required Target Target { get; init; }

    /// <summary>
    /// The type of the webhook you are configuring. Set to <b>balance</b>.
    /// </summary>
    [JsonPropertyName("type")]
    public required Type20 Type { get; init; }
}
