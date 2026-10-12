using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Checks if a user has recently made multiple transfers to the same counterparty.
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
/// Supported operations: <b>equals</b>.
/// </para>
/// </summary>
public record SameCounterpartyRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public bool? Value { get; init; }
}
