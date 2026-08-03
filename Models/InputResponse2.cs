using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Input Response message.
/// </summary>
public record InputResponse2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputResult")]
    public OutputResult2? OutputResult { get; init; }

    [JsonPropertyName("InputResult")]
    public required InputResult InputResult { get; init; }
}
