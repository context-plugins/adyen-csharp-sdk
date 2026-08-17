using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AuthenticationResultResponse
{
    /// <summary>
    /// The result of the 3D Secure authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS1Result")]
    public ThreeDs1Result2? ThreeDs1Result { get; init; }

    /// <summary>
    /// The result of the 3D Secure 2 authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2Result")]
    public ThreeDs2Result? ThreeDs2Result { get; init; }
}
