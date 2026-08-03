using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DeleteDefenseDocumentResponse
{
    [JsonPropertyName("disputeServiceResult")]
    public required DisputeServiceResult DisputeServiceResult { get; init; }
}
