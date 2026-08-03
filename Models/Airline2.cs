using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Airline2
{
    /// <summary>
    /// Details about the flight legs for this ticket.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legs")]
    public IReadOnlyList<Leg1>? Legs { get; init; }

    /// <summary>
    /// The ticket's unique identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ticketNumber")]
    public string? TicketNumber { get; init; }
}
