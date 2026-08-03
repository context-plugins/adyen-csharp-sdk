using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record KyclegalArrangementCheckResult
{
    /// <summary>
    /// A list of the checks and their statuses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checks")]
    public IReadOnlyList<KyccheckStatusData>? Checks { get; init; }

    /// <summary>
    /// The unique ID of the legal arrangement to which the check applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementCode")]
    public string? LegalArrangementCode { get; init; }
}
