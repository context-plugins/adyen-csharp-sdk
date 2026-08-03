using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The number of transactions and the operation.
/// <para>
/// Supported operations: <b>equals</b>, <b>notEquals</b>, <b>greaterThanOrEqualTo</b>, <b>greaterThan</b>, <b>lessThanOrEqualTo</b>, <b>lessThan</b>.
/// </para>
/// </summary>
public record MatchingTransactionsRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    /// <summary>
    /// The number of transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public int? Value { get; init; }
}
