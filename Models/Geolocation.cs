using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Geolocation
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("GeographicCoordinates")]
    public GeographicCoordinates? GeographicCoordinates { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("UTMCoordinates")]
    public Utmcoordinates? Utmcoordinates { get; init; }
}
