using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Diagnosis Response message.
/// </summary>
public record DiagnosisResponse2
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
