using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information related to the result the output (display, print, input).
/// If DisplayOutput present in the request.
/// </summary>
public record OutputResult1
{
    [JsonPropertyName("Device")]
    public required Device3 Device { get; init; }

    [JsonPropertyName("InfoQualify")]
    public required InfoQualify3 InfoQualify { get; init; }

    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }
}
