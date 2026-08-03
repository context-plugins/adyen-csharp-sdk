using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TopUpAmount
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fixed")]
    public Fixed? Fixed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target")]
    public Target5? Target { get; init; }
}
