using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Checks the wallet account score.
/// <para>
/// Supported operations: <b>equals</b>, <b>notEquals</b>, <b>greaterThanOrEqualTo</b>, <b>greaterThan</b>, <b>lessThanOrEqualTo</b>, <b>lessThan</b>.
/// </para>
/// </summary>
public record WalletProviderAccountScoreRestriction2
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public int? Value { get; init; }
}
