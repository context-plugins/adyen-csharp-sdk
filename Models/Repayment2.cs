using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details of the repayment configuration.
/// </summary>
public record Repayment2
{
    /// <summary>
    /// The repayment that is deducted daily from incoming net volume, in <see href="https://www.investopedia.com/terms/b/basispoint.asp">basis points</see>.
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
