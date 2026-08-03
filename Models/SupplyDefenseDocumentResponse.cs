using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SupplyDefenseDocumentResponse
{
    [JsonPropertyName("disputeServiceResult")]
    public required DisputeServiceResult DisputeServiceResult { get; init; }
}
