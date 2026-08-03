using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Object with additional parameters for the 3D Secure authentication flow.
/// </summary>
public record ThreeDsrequestData2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("challengeWindowSize")]
    public ChallengeWindowSize? ChallengeWindowSize { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataOnly")]
    public DataOnly? DataOnly { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nativeThreeDS")]
    public NativeThreeDs? NativeThreeDs { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSVersion")]
    public ThreeDsversion? ThreeDsversion { get; init; }
}
