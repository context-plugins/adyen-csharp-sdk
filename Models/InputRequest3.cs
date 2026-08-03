using System.Text.Json.Serialization;

namespace Adyen.Models;

public record InputRequest3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayOutput")]
    public DisplayOutput3? DisplayOutput { get; init; }

    [JsonPropertyName("InputData")]
    public required InputData InputData { get; init; }
}
