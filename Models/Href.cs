using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Href
{
    /// <summary>
    /// The full URL for the redirection.
    /// </summary>
    [JsonPropertyName("href")]
    public required string HrefValue { get; init; }
}
