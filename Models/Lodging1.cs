using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Lodging1
{
    /// <summary>
    /// The check-in date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkInDate")]
    public string? CheckInDate { get; init; }

    /// <summary>
    /// The total number of nights the room is booked for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfNights")]
    public int? NumberOfNights { get; init; }
}
