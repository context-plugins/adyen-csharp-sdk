using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record Geolocation
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
