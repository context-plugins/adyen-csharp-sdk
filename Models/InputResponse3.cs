using System.Text.Json.Serialization;

namespace Adyen.Models;

public record InputResponse3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputResult")]
    public OutputResult2? OutputResult { get; init; }

    [JsonPropertyName("InputResult")]
    public required InputResult InputResult { get; init; }
}
