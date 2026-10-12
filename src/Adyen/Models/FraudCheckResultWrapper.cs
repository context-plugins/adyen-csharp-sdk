using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record FraudCheckResultWrapper
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("FraudCheckResult")]
    public FraudCheckResult? FraudCheckResult { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
