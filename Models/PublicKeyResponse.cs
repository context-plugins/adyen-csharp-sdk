using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PublicKeyResponse
{
    /// <summary>
    /// The public key you need for encrypting a symmetric session key.
    /// </summary>
    [JsonPropertyName("publicKey")]
    public required string PublicKey { get; init; }

    /// <summary>
    /// The expiry date of the public key.
    /// </summary>
    [JsonPropertyName("publicKeyExpiryDate")]
    public required string PublicKeyExpiryDate { get; init; }
}
