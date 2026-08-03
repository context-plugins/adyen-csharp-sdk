using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CapabilityProblem
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public CapabilityProblemEntity? Entity { get; init; }

    /// <summary>
    /// Contains information about the verification error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationErrors")]
    public IReadOnlyList<VerificationError>? VerificationErrors { get; init; }
}
