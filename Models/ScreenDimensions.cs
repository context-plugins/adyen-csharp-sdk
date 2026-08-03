using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ScreenDimensions
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("height")]
    public int? Height { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("width")]
    public int? Width { get; init; }
}
