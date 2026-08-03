using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The results of the checks on the account holder.
/// </summary>
public record KyccheckResult2
{
    /// <summary>
    /// A list of the checks and their statuses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checks")]
    public IReadOnlyList<KyccheckStatusData>? Checks { get; init; }
}
