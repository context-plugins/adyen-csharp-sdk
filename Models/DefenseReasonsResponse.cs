using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DefenseReasonsResponse
{
    /// <summary>
    /// The defense reasons that can be used to defend the dispute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defenseReasons")]
    public IReadOnlyList<DefenseReason>? DefenseReasons { get; init; }

    [JsonPropertyName("disputeServiceResult")]
    public required DisputeServiceResult DisputeServiceResult { get; init; }
}
