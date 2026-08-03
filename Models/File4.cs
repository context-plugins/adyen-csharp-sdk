using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// For <c>eap</c> <b>tls</b>. The EAP intermediate certificate.
/// </summary>
public record File4
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
