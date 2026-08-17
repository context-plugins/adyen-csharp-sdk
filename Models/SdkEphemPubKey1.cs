using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The <c>sdkEphemPubKey</c> value as received from the 3D Secure 2 SDK.
/// </summary>
public record SdkEphemPubKey1
{
    /// <summary>
    /// The <c>crv</c> value as received from the 3D Secure 2 SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("crv")]
    public string? Crv { get; init; }

    /// <summary>
    /// The <c>kty</c> value as received from the 3D Secure 2 SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kty")]
    public string? Kty { get; init; }

    /// <summary>
    /// The <c>x</c> value as received from the 3D Secure 2 SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("x")]
    public string? X { get; init; }

    /// <summary>
    /// The <c>y</c> value as received from the 3D Secure 2 SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("y")]
    public string? Y { get; init; }
}
