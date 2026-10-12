using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The total number of tokens that a card can have across different kinds of digital wallets on the user's phones, watches, or other wearables.
/// <para>
/// Supported operations: <b>equals</b>, <b>notEquals</b>, <b>greaterThanOrEqualTo</b>, <b>greaterThan</b>, <b>lessThanOrEqualTo</b>, <b>lessThan</b>.
/// </para>
/// </summary>
public record ActiveNetworkTokensRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    /// <summary>
    /// The number of tokens.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public int? Value { get; init; }
}
