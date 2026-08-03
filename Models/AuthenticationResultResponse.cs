using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AuthenticationResultResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS1Result")]
    public ThreeDs1Result? ThreeDs1Result { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2Result")]
    public ThreeDs2Result2? ThreeDs2Result { get; init; }
}
