using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TicketResponseInfo
{
    /// <summary>
    /// Ticket requestorId
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestorId")]
    public string? RequestorId { get; init; }
}
