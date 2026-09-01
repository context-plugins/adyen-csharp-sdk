using System;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Information related to the POI System.
/// Returned if the response result is Success.
/// </summary>
public record PoiSystemData1
{
    /// <summary>
    /// Date and Time. In the response, the POI System gives its date and time to the Sale System.
    /// </summary>
    [JsonPropertyName("DateTime")]
    public required DateTimeOffset DateTime { get; init; }

    /// <summary>
    /// Information related to the software of the POI System which manages the Sale to POI protocol. In a session allows identifying the product features of a POI System.
    /// </summary>
    [JsonPropertyName("POISoftware")]
    public required PoiSoftware PoiSoftware { get; init; }

    /// <summary>
    /// Indicate the availability of the POI Terminal components. The data element is absent if the component is not part of the POI Terminal.
    /// State of a POI Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIStatus")]
    public PoiStatus? PoiStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
