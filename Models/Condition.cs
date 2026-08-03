using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Condition
{
    [JsonPropertyName("balanceType")]
    public required BalanceType BalanceType { get; init; }

    [JsonPropertyName("conditionType")]
    public required ConditionType ConditionType { get; init; }

    /// <summary>
    /// The value limit in the specified balance type and currency, in minor units.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; init; }
}
