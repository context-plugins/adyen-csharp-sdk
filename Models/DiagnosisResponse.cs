using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys the result of the requested diagnosis and a possible message to display on a logical device.
/// Content of the Diagnosis Response message.
/// </summary>
public record DiagnosisResponse
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIStatus")]
    public Poistatus2? Poistatus { get; init; }

    /// <summary>
    /// State of a Host.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("HostStatus")]
    public IReadOnlyList<HostStatus>? HostStatus { get; init; }
}
