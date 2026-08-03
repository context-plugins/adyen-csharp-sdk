using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>ticket</b> (Edenred Brazil).
/// </summary>
public record TicketInfo2
{
    /// <summary>
    /// Ticket requestorId
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestorId")]
    public string? RequestorId { get; init; }
}
