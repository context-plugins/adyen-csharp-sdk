using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record KycCheckResult
{
    /// <summary>
    /// A list of the checks and their statuses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checks")]
    public IReadOnlyList<KycCheckStatusData>? Checks { get; init; }
}
