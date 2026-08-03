using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Input Request message.
/// </summary>
public record InputRequest2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayOutput")]
    public DisplayOutput3? DisplayOutput { get; init; }

    [JsonPropertyName("InputData")]
    public required InputData InputData { get; init; }
}
