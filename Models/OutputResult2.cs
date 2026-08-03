using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record OutputResult2
{
    [JsonPropertyName("Device")]
    public required Device3 Device { get; init; }

    [JsonPropertyName("InfoQualify")]
    public required InfoQualify3 InfoQualify { get; init; }

    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }
}
