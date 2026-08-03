using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AcceptDisputeResponse
{
    [JsonPropertyName("disputeServiceResult")]
    public required DisputeServiceResult DisputeServiceResult { get; init; }
}
