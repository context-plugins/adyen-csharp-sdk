using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the repayment configuration of the grant.
/// </summary>
public record Repayment11
{
    /// <summary>
    /// The percentage of your user's incoming net volume that is deducted for repaying the grant. The percentage expressed in <see href="https://www.investopedia.com/terms/b/basispoint.asp">basis points</see>.
    /// </summary>
    [JsonPropertyName("basisPoints")]
    public required int BasisPoints { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("term")]
    public Term? Term { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threshold")]
    public ThresholdRepayment? Threshold { get; init; }
}
