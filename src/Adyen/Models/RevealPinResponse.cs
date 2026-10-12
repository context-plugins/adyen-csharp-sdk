using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RevealPinResponse
{
    /// <summary>
    /// The encrypted <see href="https://www.pcisecuritystandards.org/glossary/pin-block">PIN block</see>.
    /// </summary>
    [JsonPropertyName("encryptedPinBlock")]
    public required string EncryptedPinBlock { get; init; }

    /// <summary>
    /// The 16-digit token that you need to extract the <c>encryptedPinBlock</c>.
    /// </summary>
    [JsonPropertyName("token")]
    public required string Token { get; init; }
}
