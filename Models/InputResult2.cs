using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Contains the result and the content of the input.
/// </summary>
public record InputResult2
{
    [JsonPropertyName("Device")]
    public required Device4 Device { get; init; }

    [JsonPropertyName("InfoQualify")]
    public required InfoQualify2 InfoQualify { get; init; }

    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Input")]
    public Input? Input { get; init; }
}
