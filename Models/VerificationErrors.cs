using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record VerificationErrors
{
    /// <summary>
    /// List of the verification errors.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("problems")]
    public IReadOnlyList<CapabilityProblem1>? Problems { get; init; }
}
