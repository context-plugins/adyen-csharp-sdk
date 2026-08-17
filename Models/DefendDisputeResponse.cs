using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DefendDisputeResponse
{
    /// <summary>
    /// The result of the dispute service.
    /// </summary>
    [JsonPropertyName("disputeServiceResult")]
    public required DisputeServiceResult1 DisputeServiceResult { get; init; }
}
