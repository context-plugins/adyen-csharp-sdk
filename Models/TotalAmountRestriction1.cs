using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The total amount and the operation.
/// <para>
/// Supported operations: <b>equals</b>, <b>notEquals</b>, <b>greaterThanOrEqualTo</b>, <b>greaterThan</b>, <b>lessThanOrEqualTo</b>, <b>lessThan</b>.
/// </para>
/// </summary>
public record TotalAmountRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public Value7? Value { get; init; }
}
