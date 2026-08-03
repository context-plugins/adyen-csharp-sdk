using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Trigger
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public Schedule2? Schedule { get; init; }

    [JsonPropertyName("threshold")]
    public required Threshold2 Threshold { get; init; }
}
