using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// In the message response, it contains the result of the output, if required in the message request.
/// Information related to the result the output (display, print, input).
/// </summary>
public record OutputResult
{
    [JsonPropertyName("Device")]
    public required Device3 Device { get; init; }

    [JsonPropertyName("InfoQualify")]
    public required InfoQualify3 InfoQualify { get; init; }

    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }
}
