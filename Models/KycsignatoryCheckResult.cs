using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record KycsignatoryCheckResult
{
    /// <summary>
    /// A list of the checks and their statuses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checks")]
    public IReadOnlyList<KyccheckStatusData>? Checks { get; init; }

    /// <summary>
    /// The code of the signatory to which the check applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signatoryCode")]
    public string? SignatoryCode { get; init; }
}
