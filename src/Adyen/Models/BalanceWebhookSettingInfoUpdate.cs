using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record BalanceWebhookSettingInfoUpdate
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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    [MinLength(1)]
    public string? Currency { get; init; }

    /// <summary>
    /// The status of the webhook setting. Possible values:
    /// <list type="bullet">
    ///   <item><description><b>active</b>: You receive a balance webhook if any of the conditions in this setting are met.</description></item>
    ///   <item><description><b>inactive</b>: You do not receive a balance webhook even if the conditions in this settings are met.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status6? Status { get; init; }

    /// <summary>
    /// The type and ID of the resource about whose balance changes you want to be notified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target")]
    public TargetUpdate2? Target { get; init; }

    /// <summary>
    /// The type of the webhook you are configuring. Set to <b>balance</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type201? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
