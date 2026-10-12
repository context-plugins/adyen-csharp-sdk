using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record KycUltimateParentCompanyCheckResult
{
    /// <summary>
    /// A list of the checks and their statuses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checks")]
    public IReadOnlyList<KycCheckStatusData>? Checks { get; init; }

    /// <summary>
    /// The code of the Ultimate Parent Company to which the check applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ultimateParentCompanyCode")]
    public string? UltimateParentCompanyCode { get; init; }
}
