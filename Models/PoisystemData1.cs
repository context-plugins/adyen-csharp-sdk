using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Information related to the POI System.
/// Returned if the response result is Success.
/// </summary>
public record PoisystemData1
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
