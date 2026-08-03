using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DefendDisputeResponse
{
    [JsonPropertyName("disputeServiceResult")]
    public required DisputeServiceResult DisputeServiceResult { get; init; }
}
