using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>ticket</b> (Edenred Brazil) details
/// </summary>
public record TicketResponseInfo2
{
    /// <summary>
    /// Ticket requestorId
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestorId")]
    public string? RequestorId { get; init; }
}
