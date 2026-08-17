using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Condition
{
    /// <summary>
    /// Define the type of balance about which you want to get notified. Possible values:
    /// <list type="bullet">
    ///   <item><description><b>available</b>: the balance available for use.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>balance</b>: the sum of transactions that have already been settled.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>pending</b>: the sum of transactions that will be settled in the future.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>reserved</b>: the balance currently held in reserve.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("balanceType")]
    public required BalanceType BalanceType { get; init; }

    /// <summary>
    /// Define when you want to get notified about a balance change. Possible values:
    /// <list type="bullet">
    ///   <item><description><b>greaterThan</b>: the balance in the account(s) exceeds the specified <c>value</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>greaterThanOrEqual</b>: the balance in the account(s) reaches or exceeds the specified <c>value</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>lessThan</b>: the balance in the account(s) drops below the specified <c>value</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>lessThanOrEqual</b>: the balance in the account(s) reaches to drops below the specified <c>value</c>.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("conditionType")]
    public required ConditionType ConditionType { get; init; }

    /// <summary>
    /// The value limit in the specified balance type and currency, in minor units.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; init; }
}
