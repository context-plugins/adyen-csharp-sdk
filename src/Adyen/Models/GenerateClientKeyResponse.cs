using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GenerateClientKeyResponse
{
    /// <summary>
    /// Generated client key
    /// </summary>
    [JsonPropertyName("clientKey")]
    public required string ClientKey { get; init; }
}
