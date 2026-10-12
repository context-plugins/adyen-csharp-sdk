using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record SupplyDefenseDocumentResponse
{
    /// <summary>
    /// The result of the dispute service.
    /// </summary>
    [JsonPropertyName("disputeServiceResult")]
    public required DisputeServiceResult1 DisputeServiceResult { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
