using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TwintInfo
{
    /// <summary>
    /// Twint logo. Format: Base64-encoded string.
    /// </summary>
    [JsonPropertyName("logo")]
    public required string Logo { get; init; }
}
