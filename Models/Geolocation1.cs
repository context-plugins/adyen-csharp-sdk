using System.Text.Json.Serialization;
using Adyen.Core.Models;

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
    public UtmCoordinates? UtmCoordinates { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
