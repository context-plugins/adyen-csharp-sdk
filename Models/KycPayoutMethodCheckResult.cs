using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record KycPayoutMethodCheckResult
{
    /// <summary>
    /// A list of the checks and their statuses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checks")]
    public IReadOnlyList<KycCheckStatusData>? Checks { get; init; }

    /// <summary>
    /// The unique ID of the payoput method to which the check applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutMethodCode")]
    public string? PayoutMethodCode { get; init; }
}
