using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RiskScores
{
    /// <summary>
    /// Transaction risk score provided by Mastercard. Values provided by Mastercard range between 0 (lowest risk) to 998 (highest risk).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mastercard")]
    public int? Mastercard { get; init; }

    /// <summary>
    /// Transaction risk score provided by Visa. Values provided by Visa range between 01 (lowest risk) to 99 (highest risk).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visa")]
    public int? Visa { get; init; }
}
