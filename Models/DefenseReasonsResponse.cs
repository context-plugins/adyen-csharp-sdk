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

    /// <summary>
    /// The result of the dispute service.
    /// </summary>
    [JsonPropertyName("disputeServiceResult")]
    public required DisputeServiceResult1 DisputeServiceResult { get; init; }
}
