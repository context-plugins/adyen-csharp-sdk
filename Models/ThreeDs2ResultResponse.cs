using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ThreeDs2ResultResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2Result")]
    public ThreeDs2Result2? ThreeDs2Result { get; init; }
}
