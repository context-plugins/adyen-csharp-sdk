using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
