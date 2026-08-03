using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Geographic location specified by geographic or UTM coordinates.
/// If data available.
/// </summary>
public record Geolocation1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("GeographicCoordinates")]
    public GeographicCoordinates? GeographicCoordinates { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("UTMCoordinates")]
    public Utmcoordinates? Utmcoordinates { get; init; }
}
