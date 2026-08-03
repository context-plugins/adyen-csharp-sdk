using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GenerateHmacKeyResponse
{
    /// <summary>
    /// The HMAC key generated for this webhook.
    /// </summary>
    [JsonPropertyName("hmacKey")]
    public required string HmacKey { get; init; }
}
