using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// For <c>authType</c> <b>wpa-eap</b> or <b>wpa2-eap</b>. The root certificate from the CA that signed the certificate of the RADIUS server that is part of your wireless network.
/// </summary>
public record File1
{
    /// <summary>
    /// The certificate content converted to a Base64-encoded string.
    /// </summary>
    [JsonPropertyName("data")]
    public required string Data { get; init; }

    /// <summary>
    /// The name of the certificate. Must be unique across Wi-Fi profiles.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
