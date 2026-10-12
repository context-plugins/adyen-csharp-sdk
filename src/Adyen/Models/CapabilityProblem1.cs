using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CapabilityProblem1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public CapabilityProblemEntity1? Entity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationErrors")]
    public IReadOnlyList<VerificationError1>? VerificationErrors { get; init; }
}
