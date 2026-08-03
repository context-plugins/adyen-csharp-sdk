using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
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
    public IReadOnlyList<Condition?>? Conditions { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see> of the balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    [MinLength(1)]
    public string? Currency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status19? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target")]
    public TargetUpdate? Target { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type20? Type { get; init; }
}
