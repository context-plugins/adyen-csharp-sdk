using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record Href
{
    /// <summary>
    /// The full URL for the redirection.
    /// </summary>
    [JsonPropertyName("href")]
    public required string HrefValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
