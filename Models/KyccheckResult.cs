using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record KyccheckResult
{
    /// <summary>
    /// A list of the checks and their statuses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checks")]
    public IReadOnlyList<KyccheckStatusData>? Checks { get; init; }
}
