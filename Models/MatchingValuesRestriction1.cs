using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Checks if a user has recently made multiple transfers with the specified values.
/// <para>
/// To use this restriction, you must:
/// </para>
/// <list type="bullet">
///   <item><description>Set the rule <c>type</c> to <b>velocity</b>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>Specify a time <c>interval</c>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>Specify a number of <c>matchingTransactions</c>.</description></item>
/// </list>
/// <para>
/// Supported operation: <b>allMatch</b>.
/// </para>
/// <para>
/// Supported value inputs:
/// - <b>merchantId</b> and <b>acquirerId</b>
/// - <b>amount</b> and <b>currency</b>
/// - <b>merchantName</b>.
/// </para>
/// </summary>
public record MatchingValuesRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<Value3>? Value { get; init; }
}
