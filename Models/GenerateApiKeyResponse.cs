using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GenerateApiKeyResponse
{
    /// <summary>
    /// The generated API key.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public required string ApiKey { get; init; }
}
