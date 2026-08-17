using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ThreeDs2ResultResponse
{
    /// <summary>
    /// The result of the 3D Secure 2 authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2Result")]
    public ThreeDs2Result? ThreeDs2Result { get; init; }
}
