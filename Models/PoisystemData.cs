using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PoisystemData
{
    /// <summary>
    /// Date and Time. In the response, the POI System gives its date and time to the Sale System.
    /// </summary>
    [JsonPropertyName("DateTime")]
    public required DateTimeOffset DateTime { get; init; }

    [JsonPropertyName("POISoftware")]
    public required Poisoftware1 Poisoftware { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIStatus")]
    public Poistatus2? Poistatus { get; init; }
}
