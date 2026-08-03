using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Repayment8
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
