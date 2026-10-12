using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Risk scores provided by specific sources. The same operation applies to all scores.
/// <para>
/// Current sources available: <b>visa</b>, <b>mastercard</b>
/// </para>
/// <para>
/// Supported operations: <b>equals</b>, <b>notEquals</b>, <b>greaterThanOrEqualTo</b>, <b>greaterThan</b>, <b>lessThanOrEqualTo</b>, <b>lessThan</b>.
/// </para>
/// </summary>
public record RiskScoresRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public RiskScores? Value { get; init; }
}
