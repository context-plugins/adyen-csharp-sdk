using System.Text.Json.Serialization;

namespace Adyen.Models;

public record FraudCheckResultWrapper
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("FraudCheckResult")]
    public FraudCheckResult? FraudCheckResult { get; init; }
}
